using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;


namespace SurveyWebApp
{
    public partial class HomeMaster : System.Web.UI.Page
    {
        //Variables used to increment the question id and display a diffreent question type
        //and text from the database every time the user press next
        private static int ButtonClicks = -1;
        private static int id = 1;
        private static int questionID = -1;
        
        //Arrays that wills tore the question types, texts, and user answers
        string[] textArray;
        string[] typeArray;
        string[] answerTextArray;
        protected void Page_Load(object sender, EventArgs e)
        {
            //Retrieve the email entered by tthe user in the first screen
            Session["user_email"] = email_txtbox.Text;

            if (!IsPostBack)//If first time hide all the components
            {                
                text_box.Visible = false;
                dropdown_list.Visible = false;
                check_box_list.Visible = false;
                radio_button_list.Visible = false;
    
            }
            else//If it is post back, make the email field invisible
            {
                email_txtbox.Visible = false;
                RequiredFieldValidator_email.Visible = false;
                
            }
        }

        protected void next_btn2_Click(object sender, EventArgs e)
        {
            getFromDatabase();
        }

        //Method that select different types, text of each question and all the possible answers and display
        //them following the correspective types
        private void getFromDatabase()
        {
            
            SqlConnection myConn;
            myConn = new SqlConnection();
            myConn.ConnectionString = AppConstant.DevConnectionString;
            myConn.Open();

            SqlCommand selectText = new SqlCommand("select text from Question", myConn);
            SqlCommand selectType = new SqlCommand("select type from Question", myConn);
            SqlCommand selectAnswerText = new SqlCommand("select text from Answers where question_id = @id", myConn);
            selectAnswerText.Parameters.AddWithValue("@id", id);

            SqlDataAdapter dataAdapterText = new SqlDataAdapter();
            SqlDataAdapter dataAdapterType = new SqlDataAdapter();
            SqlDataAdapter dataAdapterAnswerText = new SqlDataAdapter();

            dataAdapterText.SelectCommand = selectText;
            dataAdapterType.SelectCommand = selectType;
            dataAdapterAnswerText.SelectCommand = selectAnswerText;

            DataSet dataSetText = new DataSet();
            DataSet dataSetType = new DataSet();
            DataSet dataSetAnswerText = new DataSet();

            dataAdapterText.Fill(dataSetText);
            dataAdapterType.Fill(dataSetType);
            dataAdapterAnswerText.Fill(dataSetAnswerText);

            textArray = new string[dataSetText.Tables[0].Rows.Count];
            typeArray = new string[dataSetType.Tables[0].Rows.Count];
            answerTextArray = new string[dataSetAnswerText.Tables[0].Rows.Count];


            //Keep incrementing the id of the question and the counter for the questions every time Next is pressed
            if (ViewState["ButtonClicks"] != null)
            {
                ButtonClicks = (int)ViewState["ButtonClicks"];
                id = (int)ViewState["id"];
            }
            ButtonClicks++;
            id++;
            ViewState["ButtonClicks"] = ButtonClicks;
            ViewState["id"] = id;

            //Loop to get question, type and answers from the datasets
            for (int counter = 0; counter < dataSetText.Tables[0].Rows.Count; counter++)
            {
                textArray[counter] = dataSetText.Tables[0].Rows[counter]["text"].ToString();
            }

            for (int counter = 0; counter < dataSetType.Tables[0].Rows.Count; counter++)
            {
                typeArray[counter] = dataSetType.Tables[0].Rows[counter]["type"].ToString();
            } 

            for (int counter = 0; counter < dataSetAnswerText.Tables[0].Rows.Count; counter++)
            {
                answerTextArray[counter] = dataSetAnswerText.Tables[0].Rows[counter]["text"].ToString();
            }

            //Call method that store user answers
            storeUserAnswers();

            //Check if the question id reached the end of the array, if yes we go to the summary page
            if (questionID == textArray.Length)
            {
                Response.Redirect("Summary.aspx");
            }

            //Clear all the fields in order to get a new input
            text_box.Text = "";
            dropdown_list.Items.Clear();
            check_box_list.Items.Clear();
            radio_button_list.Items.Clear();

            //Check for every question what is the type, and show the correspective component
            if (typeArray[ButtonClicks] == "text_box")
            {
                question_label.Text = textArray[ButtonClicks].ToString();
                dropdown_list.Visible = false;
                check_box_list.Visible = false;
                radio_button_list.Visible = false;
                text_box.Visible = true;

            }
            else if (typeArray[ButtonClicks] == "drop_list")
            {
                question_label.Text = textArray[ButtonClicks].ToString();
                dropdown_list.Items.Insert(0, new ListItem("Select", ""));
                foreach (object item in answerTextArray)
                {
                    dropdown_list.Items.Add(new ListItem(item.ToString(), item.ToString()));
                }

                text_box.Visible = false;
                check_box_list.Visible = false;
                radio_button_list.Visible = false;
                dropdown_list.Visible = true;
 
            }
            else if (typeArray[ButtonClicks] == "check_box")
            {
                question_label.Text = textArray[ButtonClicks].ToString();
                foreach (object item in answerTextArray)
                {
                    check_box_list.Items.Add(new ListItem(item.ToString(), item.ToString()));
                    
                }

                text_box.Visible = false;
                radio_button_list.Visible = false;
                dropdown_list.Visible = false;
                check_box_list.Visible = true;
            }
            else if (typeArray[ButtonClicks] == "radio_btn")
            {
                question_label.Text = textArray[ButtonClicks].ToString();
                foreach (object item in answerTextArray)
                {
                    radio_button_list.Items.Add(new ListItem(item.ToString(), item.ToString()));
                }

                text_box.Visible = false;
                dropdown_list.Visible = false;
                check_box_list.Visible = false;
                radio_button_list.Visible = true;

            }

            myConn.Close();
        }
        
        private void storeUserAnswers()
        {
            //Check if any component item is nulll
            if (radio_button_list.SelectedItem == null && check_box_list.SelectedItem == null && dropdown_list.SelectedItem == null && text_box.Text == null)
            {
                
            }
            else//if not check if the id is less then 1(meaning the array is not in range yet)
            {
                if(questionID > -1)
                {
                    //check all the questions 1 by one, when found the right one store the user choice
                    if (textArray[questionID] == "Select age range:")
                    {
                        Session["age"] = radio_button_list.SelectedItem.Text;
                    }
                    else if (textArray[questionID] == "Select gender:")
                    {
                        Session["gender"] = radio_button_list.SelectedItem.Text;
                    }
                    else if (textArray[questionID] == "News of interest:")
                    {
                        Session["news_interest"] = radio_button_list.SelectedItem.Text;
                    }
                    else if (textArray[questionID] == "Sport of interest:")
                    {
                        Session["sport_interest"] = radio_button_list.SelectedItem.Text;
                    }
                    else if (textArray[questionID] == "Destination:")
                    {
                        Session["travel"] = radio_button_list.SelectedItem.Text;
                    }
                    else if (textArray[questionID] == "Select fav color:")
                    {
                        Session["cl"] = radio_button_list.SelectedItem.Text;
                    }

                    else if (textArray[questionID] == "Select bank:")
                    {
                        Session["bank"] = check_box_list.SelectedItem.Text;
                    }
                    else if (textArray[questionID] == "Service used:")
                    {
                        Session["service"] = check_box_list.SelectedItem.Text;
                    }
                    else if (textArray[questionID] == "Favourite newspaper:")
                    {
                        Session["newspaper"] = check_box_list.SelectedItem.Text;
                    }

                    else if (textArray[questionID] == "Select state:")
                    {
                        Session["state"] = dropdown_list.SelectedItem.Text;
                    }

                    else if (textArray[questionID] == "Suburb:")
                    {
                        Session["suburb"] = text_box.Text;
                    }
                    else if (textArray[questionID] == "Post code:")
                    {
                        Session["postCode"] = text_box.Text;
                    }
                }
            }
            
            questionID++;

        }
       
        protected void Exit_btn_Click(object sender, EventArgs e)
        {
            //When this button is pressed, reset the initial statics variables and redirect the user to the home screen
            ButtonClicks = -1;
            id = 1;
            questionID = -1;
            Response.Redirect("/Home.aspx");
        }

    }
}