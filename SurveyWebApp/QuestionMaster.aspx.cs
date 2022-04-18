using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SurveyWebApp
{
    public partial class QuestionMaster : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string[] yesNo = { "Yes", "No" };
            string[] gender = { "Select", "Male", "Female" };
            string[] ageRange = { "Select", "18-25", "26-35", "36-45", "46+" };
            string[] state = { "Select", "NSW", "VIC", "SA", "NT", "WA" };
            string[] bank = { "Select", "NAB", "Commonwealth", "St.George", "ANZ" };
            string[] service = { "Select", "Mortgage" };
            string[] newspaper = { "Select", "The Daily Thelegraph", "Not interested" };
            string[] newsInterest = { "Property", "Sport", "Financial", "Entertainment", "Lifestyle", "Travel", "Politics" };
            string[] sport = { "Select", "AFL", "Football", "Cricket", "Racing", "Motorsport", "Basketball", "Tennis" };
            string[] travel = { "Select", "Australia", "Europe", "Pacific", "North America", "South Africa", "Asia", "Middle Est", "Africa" };

            if (!IsPostBack)
            {
                for (int i = 0; i <= 6; i++)//News interest list
                {
                    ListItem newsInterestItems = new ListItem();
                    newsInterestItems.Text = newsInterest[i];
                    newsInterestItems.Value = i.ToString();
                    checkBoxList.Items.Add(newsInterestItems);
                }
            }
        }
    }
}