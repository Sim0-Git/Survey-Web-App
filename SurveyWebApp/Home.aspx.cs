using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SurveyWebApp
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void next_btn2_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomeMaster.aspx");
        }

        protected void Exit_btn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Staff/Login.aspx");
        }
    }
}