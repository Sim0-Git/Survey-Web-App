using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SurveyWebApp
{
    public partial class Main1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                HttpContext.Current.Session["UserName"] = TextBox_name.Text;
            }
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            /*Label_result.Text = (String)HttpContext.Current.Session["Username"];*/
            Response.Redirect("QUestion.aspx");
        }
    }
}