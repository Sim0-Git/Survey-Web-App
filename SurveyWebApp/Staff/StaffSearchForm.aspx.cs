using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;//Adds commands for reading and writing

namespace SurveyWebApp
{
    public partial class StaffSearchForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection myConn = new SqlConnection();
            myConn.ConnectionString = AppConstant.DevConnectionString;
            myConn.Open();


            string firstName = first_name_txt.Text;
            string secondName = second_name_txt.Text;
            string gender = gender_list.SelectedItem.Text;
            string age = age_list.SelectedItem.Text;
            string state = state_list.SelectedItem.Text;
            string suburb = suburb_txt.Text;
            string post_code = post_code_txt.Text;
            string email = email_txt.Text;
            string bank = bank_list.SelectedItem.Text;
            string service = service_list.SelectedItem.Text;
            string newspaper = newspaper_list.SelectedItem.Text;
            string interest = interest_list.SelectedItem.Text;
            string travel = travel_list.SelectedItem.Text;
            string sport = sport_list.SelectedItem.Text;

            //Result_lbl.Text = gender;

            SqlCommand selectAll = new SqlCommand("select * from User_Registration where name='" + firstName + "' or surname='" + secondName + "' or state='" + state + "' or gender='" + gender + "' or age_range='" + age + "' or suburb='" + suburb + "' or post_code='" + post_code + "' or bank='" + bank + "' or bank_service='" + service + "' or newspaper='" + newspaper + "' or news_interest='" + interest + "' or travel_destination='" + travel + "' or sport=' " + sport + "' or email='" + email + "'", myConn);

            SqlDataReader allUserReader = selectAll.ExecuteReader();

            DataTable users = new DataTable();
            users.Columns.Add("user_reg_id", System.Type.GetType("System.String"));
            users.Columns.Add("name", System.Type.GetType("System.String"));
            users.Columns.Add("surname", System.Type.GetType("System.String"));
            users.Columns.Add("phone", System.Type.GetType("System.String"));
            users.Columns.Add("dob", System.Type.GetType("System.String"));
            users.Columns.Add("email", System.Type.GetType("System.String"));
            users.Columns.Add("age_range", System.Type.GetType("System.String"));
            users.Columns.Add("gender", System.Type.GetType("System.String"));
            users.Columns.Add("state", System.Type.GetType("System.String"));
            users.Columns.Add("suburb", System.Type.GetType("System.String"));
            users.Columns.Add("post_code", System.Type.GetType("System.String"));
            users.Columns.Add("bank", System.Type.GetType("System.String"));
            users.Columns.Add("bank_service", System.Type.GetType("System.String"));
            users.Columns.Add("newspaper", System.Type.GetType("System.String"));
            users.Columns.Add("news_interest", System.Type.GetType("System.String"));
            users.Columns.Add("travel_destination", System.Type.GetType("System.String"));
            users.Columns.Add("sport", System.Type.GetType("System.String"));

            DataRow usersRow;
            while (allUserReader.Read())
            {
                //Display rows based on the database schema
                usersRow = users.NewRow();

                usersRow["user_reg_id"] = allUserReader["user_reg_id"].ToString();
                usersRow["name"] = allUserReader["name"].ToString();
                usersRow["surname"] = allUserReader["surname"].ToString();
                usersRow["phone"] = allUserReader["phone"].ToString();
                usersRow["dob"] = allUserReader["dob"].ToString();
                usersRow["email"] = allUserReader["email"].ToString();
                usersRow["age_range"] = allUserReader["age_range"].ToString();
                usersRow["gender"] = allUserReader["gender"].ToString();
                usersRow["state"] = allUserReader["state"].ToString();
                usersRow["suburb"] = allUserReader["suburb"].ToString();
                usersRow["post_code"] = allUserReader["post_code"].ToString();
                usersRow["bank"] = allUserReader["bank"].ToString();
                usersRow["bank_service"] = allUserReader["bank_service"].ToString();
                usersRow["newspaper"] = allUserReader["newspaper"].ToString();
                usersRow["news_interest"] = allUserReader["news_interest"].ToString();
                usersRow["travel_destination"] = allUserReader["travel_destination"].ToString();
                usersRow["sport"] = allUserReader["sport"].ToString();

                users.Rows.Add(usersRow);

                staff_search_grid.DataSource = users;
                staff_search_grid.DataBind(); //Present the data in the table

                //myConn.Close();//Close connection with database
            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            
            first_name_txt.Text = string.Empty;
            second_name_txt.Text = string.Empty;
            gender_list.SelectedIndex = -1;
            age_list.SelectedIndex = -1;
            state_list.SelectedIndex = -1;
            suburb_txt.Text = string.Empty;
            post_code_txt.Text = string.Empty;
            email_txt.Text = string.Empty;
            bank_list.SelectedIndex = -1;
            service_list.SelectedIndex = -1;
            newspaper_list.SelectedIndex = -1;
            interest_list.SelectedIndex = -1;
            travel_list.SelectedIndex = -1;
            sport_list.SelectedIndex = -1;
            staff_search_grid.DataBind();
            
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            first_name_txt.Text = "";
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            second_name_txt.Text = "";
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            email_txt.Text = "";
        }
    }
}