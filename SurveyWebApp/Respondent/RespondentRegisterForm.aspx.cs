using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using static SurveyWebApp.ResultStatus;

namespace SurveyWebApp
{
    
    public partial class RespondentRegisterForm : System.Web.UI.Page
    {
       //Variables used to get the user information from another screen
        ResultStatus rs = new ResultStatus();
        string userEmail;
        string userAge;
        string userGender;
        string userState;
        string userSuburb;
        string userPostCode;
        string userbank;
        string userService;
        string userNewspaper;
        string userNews;
        string userSport;
        string userTravel;

        string newUserEmail;
        protected void Page_Load(object sender, EventArgs e)
        {
            //Store all the values in variables
            userEmail = Session["email_reg"] as String;
            userAge = Session["age_reg"] as String;
            userGender = Session["gender_reg"] as String;
            userState = Session["state_reg"] as String;
            userSuburb = Session["suburb_reg"] as String;
            userPostCode = Session["post_code_reg"] as String;
            userbank = Session["bank_reg"] as String;
            userService = Session["service_reg"] as String;
            userNewspaper = Session["newspaper_reg"] as String;
            userNews = Session["news_interest_reg"] as String;
            userSport = Session["sport_reg"] as String;
            userTravel = Session["travel_reg"] as String;

            //Here is a workaround logic that take place due to the calendar button pressed
            //from the user that cause the page to refresh
            if (!IsPostBack)//If first time hide the overlapping email texfield
            {
                newEmail_txtbox.Enabled = false;
                RequiredFieldValidator_newEmail.Enabled = false;
                newEmail_txtbox.Style["visibility"] = "hidden";
                email_txtbox.Style["visibility"] = "visible";
                email_txtbox.Text = userEmail;
                ViewState["View"] = 2;
            }
            else
            //otherwise check if is the View is euqal to 0, 1 or 2
            {

                if ((int)ViewState["View"]==0)//If 0 keep the original email texfield visible
                {
                    email_txtbox.Enabled = false;
                    RequiredFieldValidator_email.Enabled = false;
                    RequiredFieldValidator_newEmail.Enabled = true;
                    newEmail_txtbox.Enabled = true;
                    newEmail_txtbox.Style["visibility"] = "visible";
                    email_txtbox.Style["visibility"] = "hidden";

                    newUserEmail = newEmail_txtbox.Text;
                }
                else if((int)ViewState["View"] == 2 || (int)ViewState["View"] == 1)//1 or 2 the overlapping email texfield invisible
                {
                    newEmail_txtbox.Enabled = false;
                    RequiredFieldValidator_newEmail.Enabled = false;
                    newEmail_txtbox.Style["visibility"] = "hidden";
                    email_txtbox.Style["visibility"] = "visible";
                    email_txtbox.Text = userEmail;

                    newEmail_txtbox.Text = userEmail;
                }

            }
            
        }

        protected void calendar_btn_Click(object sender, EventArgs e)
        {
            //If calendar is already visible , set it to invisible
            if (calendar.Visible == true)
            {
                calendar.Visible = false;
            }
            else//othervise set the calendar to visible
            {
                calendar.Visible = true;
                ViewState["View"] = 1;
            }
        }
        //Method that change the format of the date in order to insert it into the database
        protected void calendar_SelectionChanged(object sender, EventArgs e)
        {
            int day = calendar.SelectedDate.Day;
            int month = calendar.SelectedDate.Month;
            int year = calendar.SelectedDate.Year;

            String date = day + "/" + month + "/" + year;

            dob_txtbox.Text = date;
            calendar.Visible = false;
        }

        //Method that get the user id from the email
        private int GetRespondentRegistrationID(String stringEmail)
        {
            int respondent_registration_id = -1;

            SqlConnection myConn;
            myConn = new SqlConnection();
            myConn.ConnectionString = AppConstant.DevConnectionString;
            myConn.Open();
            SqlCommand selectRespondentRegistrationID = new SqlCommand("SELECT user_reg_id FROM User_Registration where email = @email", myConn);
            selectRespondentRegistrationID.Parameters.AddWithValue("@email",stringEmail);
            SqlDataReader reader = selectRespondentRegistrationID.ExecuteReader();

            if (reader.Read())//convert id into string
            {
                respondent_registration_id = Convert.ToInt32(reader["user_reg_id"].ToString());
                myConn.Close();
            }

            return respondent_registration_id;
            
        }

        //Method that check if the the user exist in the database, if id is -1 it means the user is already registered
        private ResultStatus RegisterRespondent(String stringEmail,String stringName, String stringSurname, String stringPhone, String stringDob)
        {

            int respondent_registration_id = GetRespondentRegistrationID(stringEmail);
            if(respondent_registration_id != -1)
            {
                Session["respondent_reg_id"] = respondent_registration_id;

                rs.ResultStatuscode = 2;
                rs.Message = "Email already in use, choose another one";
                email_txtbox.Text = "";

            }
            else//If not -1, so not registered yet, insert by query all user data into the database
            {
                SqlConnection myConn;
                myConn = new SqlConnection();
                myConn.ConnectionString = AppConstant.DevConnectionString;
                myConn.Open();
              
                String query = "insert into User_Registration (name,surname,phone,dob,email,age_range,gender,state,suburb,post_code,bank,bank_service,newspaper,news_interest,travel_destination,sport) values ('" + userAge + "','" + userbank + "','" + userAge + "','1988-09-23','" + userEmail + "','" + userAge + "','" + userGender + "','" + userState + "','" + userSuburb + "','" + userPostCode + "','" + userbank + "','" + userService + "','" + userNewspaper + "','" + userNews + "','" + userTravel + "','" + userSport + "')";

                //Fix date format for input into the database
                string[] dateTimeParts = stringDob.Split('/');
                int day = Convert.ToInt32(dateTimeParts[0]);
                int month = Convert.ToInt32(dateTimeParts[1]);
                int year = Convert.ToInt32(dateTimeParts[2]);
                DateTime dateTime = new DateTime(year, month, day);

                SqlCommand command = new SqlCommand(query, myConn);
                
                //Check if there is an error or if the registration is succesful
                int result = command.ExecuteNonQuery();
                //If result code is 3 there is an error in the registration, otherwise the registration will be successful
                if(result < 0) 
                {
                    rs.ResultStatuscode = 3;
                    rs.Message = "Error in registration";
                }
                else
                {
                    respondent_registration_id = GetRespondentRegistrationID(stringEmail);
                    Session["respondent_reg_id"] = respondent_registration_id;
                    rs.ResultStatuscode = 1;
                    rs.Message = "Registration succesful";
                    Response.Redirect("/FinalScreen.aspx");
                }
                myConn.Close();
            }
            return rs;
        }
        protected void submit_btn_Click(object sender, EventArgs e)
        {
            String stringName = name_txtbox.Text;
            String stringSurname = surname_txtbox.Text;
            String stringPhone = phone_txtbox.Text;
            String stringDob = dob_txtbox.Text;
            String stringEmail = email_txtbox.Text;

            //check if the email text box or the overlapping email text box are visible or not,
            //based on the result a different email text will passed in the method
            if (email_txtbox.Enabled == false)
            {
                rs = RegisterRespondent(newUserEmail, stringName, stringSurname, stringPhone, stringDob);
            }
            else
            {
                rs = RegisterRespondent(stringEmail, stringName, stringSurname, stringPhone, stringDob);
                //ResultStatus rs = RegisterRespondent(stringEmail, stringName, stringSurname, stringPhone, stringDob);
            }

            server_check.Text = rs.Message;

        }

        protected void skip_btn_Click(object sender, EventArgs e)
        {
            //Redirect the user to the last screen
            Response.Redirect("/FinalScreen.aspx");
        }
    }
}