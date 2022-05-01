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
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Assign -1 value to the session as this value will be implemented at every page refreshing
            Session["questionID"] = -1;
            //Create and open connection with the database
            SqlConnection myConn;
            myConn = new SqlConnection();
            myConn.ConnectionString = AppConstant.DevConnectionString;
            myConn.Open();

            
        }

        protected void next_btn2_Click(object sender, EventArgs e)
        {
            //Redirect to the first question of the survey
            Response.Redirect("HomeMaster.aspx");
        }

        protected void Exit_btn_Click(object sender, EventArgs e)
        {
            //Redirect to the staff login form page
            Response.Redirect("Staff/Login.aspx");
        }

       
    }
}