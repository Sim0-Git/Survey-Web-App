using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SurveyWebApp
{
    public partial class Master1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void next_btn2_Click(object sender, EventArgs e)
        {
            //Session["RespondentSession"] = next_btn2.Text;
            Response.Redirect("Respondent/RespondentRegisterForm.aspx");
        }

        public void Exit_btn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }
    }
}