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
        protected void Page_Load(object sender, EventArgs e)
        {
            var userEmail = Session["user_email"] as String;
            email_txtbox.Text = userEmail;
        }

        protected void calendar_btn_Click(object sender, EventArgs e)
        {
            if (calendar.Visible == true)
            {
                calendar.Visible = false;
            }
            else
            {
                calendar.Visible = true;
            }
            
        }

        protected void calendar_SelectionChanged(object sender, EventArgs e)
        {
            int day = calendar.SelectedDate.Day;
            int month = calendar.SelectedDate.Month;
            int year = calendar.SelectedDate.Year;

            String date = day + "/" + month + "/" + year;

            dob_txtbox.Text = date;
            calendar.Visible = false;
        }


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

            if (reader.Read())
            {
                respondent_registration_id = Convert.ToInt32(reader["user_reg_id"].ToString());
                //respondent_registration_id = -1;
                myConn.Close();
            }

            return respondent_registration_id;
            
        }
        private ResultStatus RegisterRespondent(String strinEmail,String stringName, String stringSurname, String stringPhone, String stringDob)
        {
            ResultStatus rs = new ResultStatus();

            int respondent_registration_id = GetRespondentRegistrationID(strinEmail);
            if(respondent_registration_id != -1)
            {
                Session["respondent_reg_id"] = respondent_registration_id;

                rs.ResultStatuscode = 2;
                rs.Message = "Email already in use, choose another one";
            }
            else
            {
                SqlConnection myConn;
                myConn = new SqlConnection();
                myConn.ConnectionString = AppConstant.DevConnectionString;
                myConn.Open();
                String query = "INSERT INTO User_Registration (name,surname,phone,dob,email) VALUES (@name,@surname,@phone,@dob,@email)";

                //Fix date format for input into the database
                string[] dateTimeParts = stringDob.Split('/');
                int day = Convert.ToInt32(dateTimeParts[0]);
                int month = Convert.ToInt32(dateTimeParts[1]);
                int year = Convert.ToInt32(dateTimeParts[2]);
                DateTime dateTime = new DateTime(year, month, day);

                SqlCommand command = new SqlCommand(query, myConn);
                
                command.Parameters.AddWithValue("@name", stringName);
                command.Parameters.AddWithValue("@surname", stringSurname);
                command.Parameters.AddWithValue("@phone", stringPhone);
                command.Parameters.AddWithValue("@dob", dateTime);
                command.Parameters.AddWithValue("@email", strinEmail);

                int result = command.ExecuteNonQuery();
                if(result < 0)
                {
                    rs.ResultStatuscode = 3;
                    rs.Message = "Error in registration";
                }
                else
                {
                    respondent_registration_id = GetRespondentRegistrationID(strinEmail);
                    Session["respondent_reg_id"] = respondent_registration_id;
                    rs.ResultStatuscode = 1;
                    rs.Message = "Registration succesful";
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

            ResultStatus rs = RegisterRespondent(stringEmail,stringName, stringSurname, stringPhone, stringDob);
            Label5.Text = rs.Message;

        }
    }
}