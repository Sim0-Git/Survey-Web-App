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

           //Sql command that select all the values from the database corresponding to each of the field
            SqlCommand selectAll = new SqlCommand("select * from User_Registration where name='" + firstName + "' or surname='" + secondName + "' or state='" + state + "' or gender='" + gender + "' or age_range='" + age + "' or suburb='" + suburb + "' or post_code='" + post_code + "' or bank='" + bank + "' or bank_service='" + service + "' or newspaper='" + newspaper + "' or news_interest='" + interest + "' or travel_destination='" + travel + "' or sport=' " + sport + "' or email='" + email + "'", myConn);

            SqlDataReader allUserReader = selectAll.ExecuteReader();
            //Creeate a table
            DataTable users = new DataTable();
            users.Columns.Add("ID", System.Type.GetType("System.String"));
            users.Columns.Add("Name", System.Type.GetType("System.String"));
            users.Columns.Add("Surname", System.Type.GetType("System.String"));
            users.Columns.Add("Phone", System.Type.GetType("System.String"));
            users.Columns.Add("DOB", System.Type.GetType("System.String"));
            users.Columns.Add("Email", System.Type.GetType("System.String"));
            users.Columns.Add("Age range", System.Type.GetType("System.String"));
            users.Columns.Add("Gender", System.Type.GetType("System.String"));
            users.Columns.Add("State", System.Type.GetType("System.String"));
            users.Columns.Add("Suburb", System.Type.GetType("System.String"));
            users.Columns.Add("Post code", System.Type.GetType("System.String"));
            users.Columns.Add("Bank", System.Type.GetType("System.String"));
            users.Columns.Add("Service", System.Type.GetType("System.String"));
            users.Columns.Add("Newspaper", System.Type.GetType("System.String"));
            users.Columns.Add("Interests", System.Type.GetType("System.String"));
            users.Columns.Add("Travel", System.Type.GetType("System.String"));
            users.Columns.Add("Sport", System.Type.GetType("System.String"));

            //Loop every row present in the databse
            DataRow usersRow;
            while (allUserReader.Read())
            {
                //Display rows based on the database schema
                usersRow = users.NewRow();

                usersRow["ID"] = allUserReader["user_reg_id"].ToString();
                usersRow["Name"] = allUserReader["name"].ToString();
                usersRow["Surname"] = allUserReader["surname"].ToString();
                usersRow["Phone"] = allUserReader["phone"].ToString();
                usersRow["DOB"] = allUserReader["dob"].ToString();
                usersRow["Email"] = allUserReader["email"].ToString();
                usersRow["Age range"] = allUserReader["age_range"].ToString();
                usersRow["Gender"] = allUserReader["gender"].ToString();
                usersRow["State"] = allUserReader["state"].ToString();
                usersRow["Suburb"] = allUserReader["suburb"].ToString();
                usersRow["Post code"] = allUserReader["post_code"].ToString();
                usersRow["Bank"] = allUserReader["bank"].ToString();
                usersRow["Service"] = allUserReader["bank_service"].ToString();
                usersRow["Newspaper"] = allUserReader["newspaper"].ToString();
                usersRow["Interests"] = allUserReader["news_interest"].ToString();
                usersRow["Travel"] = allUserReader["travel_destination"].ToString();
                usersRow["Sport"] = allUserReader["sport"].ToString();

                users.Rows.Add(usersRow);
                //pass the data to the table and display the results
                staff_search_grid.DataSource = users;
                staff_search_grid.DataBind(); //Present the data in the table
            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //reset all the fields
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

        //Methods used for single reset of certain fields present in the research page
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