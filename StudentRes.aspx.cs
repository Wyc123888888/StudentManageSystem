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
    public partial class StudentRes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonStdSignUp_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-SB8H3D16\SQLEXPRESS;Initial Catalog=MainPage;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into StudentInfo" + "(StudentID,FirstName,LastName,Email,EnrollmentDate,Subject,UserName,Password)" +
                "values (@StudentID,@FirstName,@LastName,@Email,@EnrollmentDate,@Subject,@UserName,@Password)", con);
            cmd.Parameters.AddWithValue("@StudentID", TextBoxStdId.Text);
            cmd.Parameters.AddWithValue("@FirstName", TextBoxStdFN.Text);
            cmd.Parameters.AddWithValue("@LastName", TextBoxStdLN.Text);
            cmd.Parameters.AddWithValue("@Email", TextBoxEmail.Text);
            cmd.Parameters.AddWithValue("@EnrollmentDate", TextBoxStdED.Text);
            cmd.Parameters.AddWithValue("@Subject", TextBoxStdSubject.Text);
            cmd.Parameters.AddWithValue("@UserName", TextBoxStdUserN.Text);
            cmd.Parameters.AddWithValue("@Password", TextBoxStdPassword.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            Label1.Text = "You have registered successfully！";

        }

        protected void ButtonStdSignUpReturn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Main.aspx");
        }
    }
    }
