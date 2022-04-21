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
        private static int ButtonClicks = -1;
        private static int id = 1;
        RadioButtonList radioBtn;

        string[] textArray;
        string[] typeArray;
        string[] answerTextArray;
        protected void Page_Load(object sender, EventArgs e)
        {
            //Session["user_email"] = email_txtbox.Text;

            if (!IsPostBack)
            {
                //getFromDatabase();
                
            }
            else
            {
                //getFromDatabase();
                
            }

        }

        protected void next_btn2_Click(object sender, EventArgs e)
        {
            //Session["RespondentSession"] = next_btn2.Text;
            //Response.Redirect("Respondent/RespondentRegisterForm.aspx");

            
            getFromDatabase();


            /*string strControlType = ViewState["ControlType"].ToString();
            if (strControlType.Equals("radio_button_id"))
            {
                RadioButtonList radioBtnList = (RadioButtonList)placeHolder.FindControl(strControlType);
                foreach (ListItem item in radioBtnList.Items)
                {
                    if (item.Selected)
                    {
                        option_selected_lbl.Text = item.Text;
                    }
                }

            }*/

        }

        private void getFromDatabase()
        {
            placeHolder.Controls.Clear();

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
            if (ButtonClicks < textArray.Length - 1)
            {
                if (ViewState["ButtonClicks"] != null)
                {
                    ButtonClicks = (int)ViewState["ButtonClicks"];
                    id = (int)ViewState["id"];
                }
                ButtonClicks++;
                id++;
                ViewState["ButtonClicks"] = ButtonClicks;
                ViewState["id"] = id;
            }
            else
            {
                Response.Redirect("Summary.aspx");
            }

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


            checkQuestionsTypeAndDisplayAnswers();

        }
        /*protected void Button1_Click(object sender, EventArgs e)
        {
            option_selected_lbl.Text = "Button clicked";

            

            *//*string strControlType = ViewState["ControlType"].ToString();
            if (strControlType.Equals("radio_button_id"))
            {
                RadioButtonList radioBtnList = (RadioButtonList)placeHolder.FindControl(strControlType);
                foreach (ListItem item in radioBtnList.Items)
                {
                    if (item.Selected)
                    {
                        option_selected_lbl.Text = item.Text;
                    }
                }
            }else if (strControlType.Equals("check_box_id"))
            {
                CheckBoxList checkBoxList = (CheckBoxList)placeHolder.FindControl(strControlType);
                foreach (ListItem item in checkBoxList.Items)
                {
                    if (item.Selected)
                    {
                        option_selected_lbl.Text +=", " + item.Text;
                    }
                }
            }
            else if (strControlType.Equals("drop_list_id"))
            {
                DropDownList dropList = (DropDownList)placeHolder.FindControl(strControlType);
                foreach (ListItem item in dropList.Items)
                {
                    if (item.Selected)
                    {
                        option_selected_lbl.Text += ", " + item.Text;
                    }
                }
            }
            else if (strControlType.Equals("text_box_id"))
            {
                TextBox textBox = (TextBox)placeHolder.FindControl(strControlType);
                option_selected_lbl.Text = textBox.Text;
            }*//*
        }*/
        private void checkQuestionsTypeAndDisplayAnswers()
        {
            //Check type of question and assign answers
            if (typeArray[ButtonClicks].ToString() == "text_box")
            {
                question_label.Text = textArray[ButtonClicks].ToString();
                TextBox textBox = new TextBox();
                textBox.ID = "text_box_id";
                placeHolder.Controls.Add(textBox);

                RequiredFieldValidator req = new RequiredFieldValidator();
                req.ID = "req_id";
                req.SetFocusOnError = true;
                req.ErrorMessage = "Required";
                req.ForeColor = System.Drawing.Color.Crimson;
                req.Font.Bold = true;
                req.Display = ValidatorDisplay.Dynamic;
                req.ControlToValidate = "text_box_id";
                placeHolder.Controls.Add(req);

                ViewState["ControlType"] = textBox.Text;

                //option_selected_lbl.Text = "Textbox displayed";
                option_selected_lbl.Text = textBox.Text;

            }
            else if (typeArray[ButtonClicks] == "drop_list")
            {
                question_label.Text = textArray[ButtonClicks].ToString();
                DropDownList dropList = new DropDownList();
                for (int i = 0; i < answerTextArray.Length; i++)
                {
                    dropList.Items.Add(new ListItem(answerTextArray[i]));
                }
                placeHolder.Controls.Add(dropList);

                option_selected_lbl.Text = "Droplist displayed";
            }
            else if (typeArray[ButtonClicks] == "check_box")
            {
                question_label.Text = textArray[ButtonClicks].ToString();
                CheckBoxList checkBoxList = new CheckBoxList();
                checkBoxList.ForeColor = System.Drawing.Color.White;
                for (int i = 0; i < answerTextArray.Length; i++)
                {
                    checkBoxList.Items.Add(new ListItem(answerTextArray[i]));
                }
                placeHolder.Controls.Add(checkBoxList);
                option_selected_lbl.Text = "Checbox displayed";
            }
            else if (typeArray[ButtonClicks].ToString() == "radio_btn")
            {

                question_label.Text = textArray[ButtonClicks].ToString();
                /* RadioButtonList */
                radioBtn = new RadioButtonList();
                radioBtn.ForeColor = System.Drawing.Color.White;
                for (int i = 0; i < answerTextArray.Length; i++)
                {
                    radioBtn.Items.Add(new ListItem(answerTextArray[i], "RadioButton"));
                }
                radioBtn.ID = "radio_button_id";

                placeHolder.Controls.Add(radioBtn);

                RequiredFieldValidator req = new RequiredFieldValidator();
                req.ID = "req_id";
                req.SetFocusOnError = true;
                req.ForeColor = System.Drawing.Color.White;
                req.Font.Bold = true;
                req.ErrorMessage = "Required";
                req.Display = ValidatorDisplay.Dynamic;
                req.ControlToValidate = "radio_button_id";
                placeHolder.Controls.Add(req);

                ViewState["ControlType"] = radioBtn.ID;


                //option_selected_lbl.Text = "Radio button displayed";
                //option_selected_lbl.Text = radioBtn.SelectedValue.ToString();
                //option_selected_lbl.Text = radioBtn.ID.ToString();
            }
        }

        
    }
}