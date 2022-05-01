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
    public partial class Summary : System.Web.UI.Page
    {
        //Variables used to store all the information and answers coming from the Home master
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
        protected void Page_Load(object sender, EventArgs e)
        {
            //Assign all the values to the variables
            userEmail = Session["user_email"] as String;
            userAge = Session["age"] as String;
            userGender = Session["gender"] as String;
            userState = Session["state"] as String;
            userSuburb = Session["suburb"] as String;
            userPostCode = Session["postCode"] as String;
            userbank = Session["bank"] as String;
            userService = Session["service"] as String;
            userNewspaper = Session["newspaper"] as String;
            userNews = Session["news_interest"] as String;
            userSport = Session["sport_interest"] as String;
            userTravel = Session["travel"] as String; 
            
            user_email.Text = userEmail;

            age_lbl.Text = userAge;
            gender_lbl.Text = userGender;
            state_lbl.Text = userState;
            suburb_lbl.Text = userSuburb;
            postCode_lbl.Text = userPostCode;
            bank_lbl.Text = userbank;
            service_lbl.Text = userService;
            newspaper_lbl.Text = userNewspaper;
            news_interest_lbl.Text = userNews;
            sport_interest_lbl.Text = userSport;
            travel_lbl.Text = userTravel;
        }

        protected void Exit_btn_Click(object sender, EventArgs e)
        {
            //Redirect the user to the Home screen
            Response.Redirect("/Home.aspx");
        }

        protected void finish_btn_Click(object sender, EventArgs e)
        {
            //Store all the values in Session and redirect the user to the registration form
            Session["email_reg"] = userEmail;
            Session["age_reg"] = userAge;
            Session["gender_reg"] = userGender;
            Session["state_reg"] = userState;
            Session["suburb_reg"] = userSuburb;
            Session["post_code_reg"] = userPostCode;
            Session["bank_reg"] = userbank;
            Session["service_reg"] = userService;
            Session["newspaper_reg"] = userNewspaper;
            Session["news_interest_reg"] = userNews;
            Session["sport_reg"] = userSport;
            Session["travel_reg"] = userTravel;

            Response.Redirect("Respondent/RespondentRegisterForm.aspx");
        }
    }
}