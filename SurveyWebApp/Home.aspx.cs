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
            SqlConnection myConn;
            myConn = new SqlConnection();
            myConn.ConnectionString = AppConstant.DevConnectionString;
            myConn.Open();

            /*SqlCommand selectAllQuestions= new SqlCommand("select * from Question",myConn);
            SqlDataReader questionReader = selectAllQuestions.ExecuteReader();

            DataTable questions = new DataTable();
            questions.Columns.Add("question_id", System.Type.GetType("System.String"));
            questions.Columns.Add("text", System.Type.GetType("System.String"));
            questions.Columns.Add("type", System.Type.GetType("System.String"));

            DataRow questionRow;
            while (questionReader.Read())
            {
                questionRow = questions.NewRow();

                questionRow["question_id"] = questionReader["question_id"].ToString();
                questionRow["text"] = questionReader["text"].ToString();
                questionRow["type"] = questionReader["type"].ToString();

                questions.Rows.Add(questionRow);//Add rows to the data table
            }

            question_grid.DataSource = questions;
            question_grid.DataBind(); //Present the data in the table

            myConn.Close();//Close connection with database*/
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