using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SurveyWebApp
{
    public class AppSession
    {
        public static int getQuestionNumber()
        {
            if (HttpContext.Current.Session["QuestionNumber"] == null)
                HttpContext.Current.Session["QuestionNumber"] = 1;

            return (int)HttpContext.Current.Session["QuestionNumber"];
        }
        public static void setQuestionNumber(int _number)
        {
            HttpContext.Current.Session["QuestionNumer"] = _number;
        }
    }
}