using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SurveyWebApp
{
    public partial class Question : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            title_lbl.Text = "Welcome " + (String)HttpContext.Current.Session["Username"];

            //Assume I have 5 questions to be displayed
            if(!IsPostBack)//For the first time
                question_lbl.Text = "This is question number: " + AppSession.getQuestionNumber();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if ((int)AppSession.getQuestionNumber() < 5)
            {
                AppSession.setQuestionNumber(AppSession.getQuestionNumber() + 1);
            }
            
            question_lbl.Text = "This is question number: " + AppSession.getQuestionNumber();
        }
    }
}