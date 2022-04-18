using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SurveyWebApp
{
    public partial class HomeMaster : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["user_email"] = email_txtbox.Text;
        }
       
    }
}