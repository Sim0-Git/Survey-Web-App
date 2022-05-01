using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SurveyWebApp
{
    public partial class FinalScreen : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //Redirect to the Home screen
        protected void Unnamed2_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Home.aspx");
        }
    }
}