using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;//Adds commands for reading and writing
using System.Configuration;

namespace SurveyWebApp
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Creating a Sql connection
            SqlConnection myConn;
            myConn = new SqlConnection();

            //Targeting the connection
            String targetConnection = ConfigurationManager.ConnectionStrings["CurrentConnection"].ConnectionString;
            if (targetConnection.Equals("dev"))
            {
                myConn.ConnectionString = AppConstant.DevConnectionString;
            }
            else if (targetConnection.Equals("test"))
            {
                myConn.ConnectionString = AppConstant.TestConnectionString;
            }
            else if (targetConnection.Equals("prod"))
            {
                myConn.ConnectionString = AppConstant.ProductionConnectionString;
            }
            else
                throw new Exception();


            myConn.Open();//Open connection with database

           
            //Create sql statement
            SqlCommand selectAllUnregisteredUsers;

            string userInput = "NSW";string postCode = "2065";string sport = null;//Tryng to select from strings
            if (sport == null)//If the a search field is empty!
            {
                selectAllUnregisteredUsers = new SqlCommand("SELECT * FROM UnregisteredUsers INNER JOIN Sport ON UnregisteredUsers.sport_id=Sport.Sport_id WHERE State= '" + userInput + "' AND PostCode='" + postCode + "' OR sport_name='" + sport + "' ", myConn);
                //Create reader commands
                SqlDataReader allUnregisteredUserReader;

                //Execute readers
                allUnregisteredUserReader = selectAllUnregisteredUsers.ExecuteReader();


                //Create tables and add columns
                DataTable unregistered_Users = new DataTable(); //Excel sheet like
                unregistered_Users.Columns.Add("Un_User_ID", System.Type.GetType("System.String"));
                unregistered_Users.Columns.Add("Gender", System.Type.GetType("System.String"));
                unregistered_Users.Columns.Add("Age_range", System.Type.GetType("System.String"));
                unregistered_Users.Columns.Add("State", System.Type.GetType("System.String"));
                unregistered_Users.Columns.Add("Suburb", System.Type.GetType("System.String"));
                unregistered_Users.Columns.Add("PostCode", System.Type.GetType("System.String"));
                unregistered_Users.Columns.Add("Email", System.Type.GetType("System.String"));
                unregistered_Users.Columns.Add("Bank", System.Type.GetType("System.String"));
                unregistered_Users.Columns.Add("Newspaper", System.Type.GetType("System.String"));
                unregistered_Users.Columns.Add("sport_id", System.Type.GetType("System.String"));
                unregistered_Users.Columns.Add("sport_name", System.Type.GetType("System.String"));

                DataRow unregisteredUsersRow;
                while (allUnregisteredUserReader.Read())
                {
                    //Display rows based on the database schema
                    unregisteredUsersRow = unregistered_Users.NewRow();

                    unregisteredUsersRow["Un_User_ID"] = allUnregisteredUserReader["Un_User_ID"].ToString();
                    unregisteredUsersRow["Gender"] = allUnregisteredUserReader["Gender"].ToString();
                    unregisteredUsersRow["Age_range"] = allUnregisteredUserReader["Age_range"].ToString();
                    unregisteredUsersRow["State"] = allUnregisteredUserReader["State"].ToString();
                    unregisteredUsersRow["Suburb"] = allUnregisteredUserReader["Suburb"].ToString();
                    unregisteredUsersRow["PostCode"] = allUnregisteredUserReader["PostCode"].ToString();
                    unregisteredUsersRow["Email"] = allUnregisteredUserReader["Email"].ToString();
                    unregisteredUsersRow["Bank"] = allUnregisteredUserReader["Bank"].ToString();
                    unregisteredUsersRow["Newspaper"] = allUnregisteredUserReader["Newspaper"].ToString();
                    unregisteredUsersRow["sport_id"] = allUnregisteredUserReader["sport_id"].ToString();
                    unregisteredUsersRow["sport_name"] = allUnregisteredUserReader["sport_name"].ToString();

                    unregistered_Users.Rows.Add(unregisteredUsersRow);//Add rows to the data table
                }

                GridView1.DataSource = unregistered_Users;
                GridView1.DataBind(); //Present the data in the table

                myConn.Close();//Close connection with database
            }
            else
            {
                selectAllUnregisteredUsers = new SqlCommand("SELECT * FROM UnregisteredUsers INNER JOIN Sport ON UnregisteredUsers.sport_id=Sport.Sport_id WHERE State= '" + userInput + "' AND PostCode='" + postCode + "' AND sport_name='" + sport + "' ", myConn);
                //Create reader commands
                SqlDataReader allUnregisteredUserReader;

                //Execute readers
                allUnregisteredUserReader = selectAllUnregisteredUsers.ExecuteReader();


                //Create tables and add columns
                DataTable unregistered_Users = new DataTable(); //Excel sheet like
                unregistered_Users.Columns.Add("Un_User_ID", System.Type.GetType("System.String"));
                unregistered_Users.Columns.Add("Gender", System.Type.GetType("System.String"));
                unregistered_Users.Columns.Add("Age_range", System.Type.GetType("System.String"));
                unregistered_Users.Columns.Add("State", System.Type.GetType("System.String"));
                unregistered_Users.Columns.Add("Suburb", System.Type.GetType("System.String"));
                unregistered_Users.Columns.Add("PostCode", System.Type.GetType("System.String"));
                unregistered_Users.Columns.Add("Email", System.Type.GetType("System.String"));
                unregistered_Users.Columns.Add("Bank", System.Type.GetType("System.String"));
                unregistered_Users.Columns.Add("Newspaper", System.Type.GetType("System.String"));
                unregistered_Users.Columns.Add("sport_id", System.Type.GetType("System.String"));
                unregistered_Users.Columns.Add("sport_name", System.Type.GetType("System.String"));

                DataRow unregisteredUsersRow;
                while (allUnregisteredUserReader.Read())
                {
                    //Display rows based on the database schema
                    unregisteredUsersRow = unregistered_Users.NewRow();

                    unregisteredUsersRow["Un_User_ID"] = allUnregisteredUserReader["Un_User_ID"].ToString();
                    unregisteredUsersRow["Gender"] = allUnregisteredUserReader["Gender"].ToString();
                    unregisteredUsersRow["Age_range"] = allUnregisteredUserReader["Age_range"].ToString();
                    unregisteredUsersRow["State"] = allUnregisteredUserReader["State"].ToString();
                    unregisteredUsersRow["Suburb"] = allUnregisteredUserReader["Suburb"].ToString();
                    unregisteredUsersRow["PostCode"] = allUnregisteredUserReader["PostCode"].ToString();
                    unregisteredUsersRow["Email"] = allUnregisteredUserReader["Email"].ToString();
                    unregisteredUsersRow["Bank"] = allUnregisteredUserReader["Bank"].ToString();
                    unregisteredUsersRow["Newspaper"] = allUnregisteredUserReader["Newspaper"].ToString();
                    unregisteredUsersRow["sport_id"] = allUnregisteredUserReader["sport_id"].ToString();
                    unregisteredUsersRow["sport_name"] = allUnregisteredUserReader["sport_name"].ToString();

                    unregistered_Users.Rows.Add(unregisteredUsersRow);//Add rows to the data table
                }

                GridView1.DataSource = unregistered_Users;
                GridView1.DataBind(); //Present the data in the table

                myConn.Close();//Close connection with database
            }
            //Assign sql query to the command
            /*selectAllUnregisteredUsers = new SqlCommand("SELECT * FROM UnregisteredUsers INNER JOIN Sport ON UnregisteredUsers.sport_id=Sport.Sport_id WHERE State= '" + userInput + "' AND PostCode='" + postCode + "' AND sport_name='" + sport + "' ", myConn);*/
            myConn.Close();

            myConn.Open();
            SqlCommand selectAllStaff;
            selectAllStaff = new SqlCommand("SELECT * FROM Staff", myConn);
            SqlDataReader allStaff;
            allStaff = selectAllStaff.ExecuteReader();

            DataTable staff = new DataTable();
            staff.Columns.Add("Staff_ID", System.Type.GetType("System.String"));
            staff.Columns.Add("Username", System.Type.GetType("System.String"));
            staff.Columns.Add("Password", System.Type.GetType("System.String"));

            DataRow staffRow;
            while (allStaff.Read())
            {
                staffRow = staff.NewRow();
                staffRow["Staff_ID"] = allStaff["Staff_ID"].ToString();
                staffRow["Username"] = allStaff["Username"].ToString();
                staffRow["Password"] = allStaff["Password"].ToString();

                staff.Rows.Add(staffRow);
            }

            GridView2.DataSource = staff;
            GridView2.DataBind();

            myConn.Close();

        }
    }
}