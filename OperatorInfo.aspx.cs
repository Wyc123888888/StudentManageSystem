using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace StudentManagementSys
{
    public partial class OperatorInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ButtonConStdClear.Enabled = false;
            ButtonConStdDelete.Enabled = false;
            ButtonConStdUpdate.Enabled = false;
            if (!IsPostBack)
            {
                clear();
            }
        }

        protected void ButtonConStdInsert_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=LAPTOP-SB8H3D16\\SQLEXPRESS;Initial Catalog=MainPage;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    string insertQuery = "INSERT INTO [dbo].[StudentInfo] " +
                        "([StudentID],[FirstName],[LastName],[Email],[EnrollmentDate],[Subject],[UserName],[Password]) " +
                        "VALUES (@StudentID, @FirstName, @LastName, @Email, @EnrollmentDate, @Subject, @UserName, @Password)";

                    using (SqlCommand cmd = new SqlCommand(insertQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@StudentID", TextBoxConStdID.Text);
                        cmd.Parameters.AddWithValue("@FirstName", TextBoxConStdFN.Text);
                        cmd.Parameters.AddWithValue("@LastName", TextBoxConStdLN.Text);
                        cmd.Parameters.AddWithValue("@Email", TextBoxConStdEMAIL.Text);
                        cmd.Parameters.AddWithValue("@EnrollmentDate", TextBoxConStdED.Text);
                        cmd.Parameters.AddWithValue("@Subject", TextBoxConStdSUB.Text);
                        cmd.Parameters.AddWithValue("@UserName", TextBoxConStdUN.Text);
                        cmd.Parameters.AddWithValue("@Password", TextBoxConStdP.Text);

                        con.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            Label1.Text = "Student Inserted successfully!";
                            ButtonConStdClear.Enabled = true;
                        }
                        else
                        {
                            Label1.Text = "Student Insertion failed.";
                        }
                    }
                }
                catch (Exception ex)
                {
                    Label1.Text = "An error occurred: " + ex.Message;
                }
            }
        }

        protected void ButtonConStdDelete_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=LAPTOP-SB8H3D16\\SQLEXPRESS;Initial Catalog=MainPage;Integrated Security=True";
            string query = "DELETE FROM [dbo].[StudentInfo] WHERE [StudentID] = @StudentID";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@StudentID", TextBoxConStdID.Text);

                    con.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    con.Close();

                    if (rowsAffected > 0)
                    {
                        Label1.Text = "Student Deleted successfully!";
                    }
                    else
                    {
                        Label1.Text = "No matching student record found.";
                    }
                }
            }

        }

        protected void ButtonConStdUpdate_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=LAPTOP-SB8H3D16\\SQLEXPRESS;Initial Catalog=MainPage;Integrated Security=True";

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    // Define your SQL query with parameters
                    string sqlQuery = "UPDATE [dbo].[StudentInfo] " +
                                     "SET [FirstName] = @FirstName, [LastName] = @LastName, [Email] = @Email, " +
                                     "[EnrollmentDate] = @EnrollmentDate, [Subject] = @Subject, [UserName] = @UserName, " +
                                     "[Password] = @Password " +
                                     "WHERE [StudentID] = @StudentID";

                    using (SqlCommand cmd = new SqlCommand(sqlQuery, con))
                    {
                        // Add parameters to the query
                        cmd.Parameters.AddWithValue("@FirstName", TextBoxConStdFN.Text);
                        cmd.Parameters.AddWithValue("@LastName", TextBoxConStdLN.Text);
                        cmd.Parameters.AddWithValue("@Email", TextBoxConStdEMAIL.Text);
                        cmd.Parameters.AddWithValue("@EnrollmentDate", TextBoxConStdED.Text);
                        cmd.Parameters.AddWithValue("@Subject", TextBoxConStdSUB.Text);
                        cmd.Parameters.AddWithValue("@UserName", TextBoxConStdUN.Text);
                        cmd.Parameters.AddWithValue("@Password", TextBoxConStdP.Text);
                        cmd.Parameters.AddWithValue("@StudentID", TextBoxConStdID.Text);

                        con.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            Label1.Text = "Student Updated successfully!";
                        }
                        else
                        {
                            Label1.Text = "No student was updated. Student not found.";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle the exception and display an error message
                Label1.Text = "An error occurred: " + ex.Message;
            }


        }

        void clear()
        {
            TextBoxConStdID.Text = string.Empty;
            TextBoxConStdFN.Text = TextBoxConStdLN.Text = TextBoxConStdEMAIL.Text = 
                TextBoxConStdED.Text = TextBoxConStdSUB.Text = TextBoxConStdUN.Text = TextBoxConStdP.Text = "";
            ButtonConStdDelete.Enabled = false;
            
        }

        //void GridFill()
        //{
        //    string connectionString = "Data Source=LAPTOP-SB8H3D16\\SQLEXPRESS;Initial Catalog=MainPage;Integrated Security=True";
        //    using (SqlConnection sqlCon = new SqlConnection(connectionString))
        //    {
        //        sqlCon.Open();
        //        SqlDataAdapter sqlDa = new SqlDataAdapter("", sqlCon);
        //    }
        //}

        protected void ButtonConStdClear_Click(object sender, EventArgs e)
        {
            clear();

        }

        protected void ButtonConStdShow_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=LAPTOP-SB8H3D16\\SQLEXPRESS;Initial Catalog=MainPage;Integrated Security=True";

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    // Define a SQL query to select all student records
                    string sqlQuery = "SELECT * FROM [dbo].[StudentInfo]";

                    using (SqlCommand cmd = new SqlCommand(sqlQuery, con))
                    {
                        con.Open();

                        // Create a SqlDataAdapter and DataSet to fetch and store the data
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataSet ds = new DataSet();

                        // Fill the DataSet with data from the SQL query
                        da.Fill(ds);

                        // Bind the DataSet to the GridView control
                        GridViewConStd.DataSource = ds;
                        GridViewConStd.DataBind();
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle the exception and display an error message
                Label1.Text = "An error occurred: " + ex.Message;
            }
        }

        protected void ButtonConStdSearch_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=LAPTOP-SB8H3D16\\SQLEXPRESS;Initial Catalog=MainPage;Integrated Security=True";

            try
            {
                // Define the SQL query to search for a student by Student ID
                string studentId = TextBoxConStdID.Text;
                string sqlQuery = "SELECT * FROM [dbo].[StudentInfo] WHERE [StudentID] = @StudentID";

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(sqlQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@StudentID", studentId);

                        con.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Student found, fill textboxes with the student's information
                                TextBoxConStdFN.Text = reader["FirstName"].ToString();
                                TextBoxConStdLN.Text = reader["LastName"].ToString();
                                TextBoxConStdEMAIL.Text = reader["Email"].ToString();
                                TextBoxConStdED.Text = reader["EnrollmentDate"].ToString();
                                TextBoxConStdSUB.Text = reader["Subject"].ToString();
                                TextBoxConStdUN.Text = reader["UserName"].ToString();
                                TextBoxConStdP.Text = reader["Password"].ToString();

                                // Enable the delete and update buttons
                                ButtonConStdDelete.Enabled = true;
                                ButtonConStdUpdate.Enabled = true;
                                ButtonConStdInsert.Enabled = false;
                                ButtonConStdClear.Enabled = true;
                            }
                            else
                            {
                                // Student not found, display a message or handle as needed
                                Label1.Text = "Student not found.";
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle the exception and display an error message
                Label1.Text = "An error occurred: " + ex.Message;
            }
        }
    }
}