using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
//static SurveyWebApp.ResultStatus;


namespace SurveyWebApp
{
    public partial class Login : System.Web.UI.Page
    {
        ResultStatus rs = new ResultStatus();
        string staffName;
        string staffPassword;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            staffName = email_txt.Text;
            staffPassword = password_txt.Text;

            int staff_id=-1;
            string staff_pass="";

            SqlConnection myConn;
            myConn = new SqlConnection();
            myConn.ConnectionString = AppConstant.DevConnectionString;
            myConn.Open();
            SqlCommand selectStaffID = new SqlCommand("SELECT staff_id,password FROM Staff where username = @username", myConn);
            selectStaffID.Parameters.AddWithValue("@username", staffName);
            SqlDataReader reader = selectStaffID.ExecuteReader();

            if (reader.Read())
            {
                staff_id = Convert.ToInt32(reader["staff_id"].ToString());
                staff_pass = Convert.ToString(reader["password"].ToString());

                myConn.Close();
            }

            if (staff_id != -1 && staff_pass == staffPassword)
            {
                Response.Redirect("StaffSearchForm.aspx");
            }
            else
            {
                reuslt_lbl.Text = "Username or password incorrect";
            }
        }

        protected void goBack_btn_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Home.aspx");
        }
    }
}