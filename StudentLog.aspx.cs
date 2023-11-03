using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace StudentManagementSys
{
    public partial class StudentLog : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblErrorMessage.Visible = false;

        }

        protected void StdButtonLog_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=LAPTOP-SB8H3D16\SQLEXPRESS;Initial Catalog=MainPage;Integrated Security=True;"))
            {
                sqlCon.Open();
                string query = "select count(1) from StudentInfo where UserName=@UserName and Password=@Password";
                SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
                sqlCmd.Parameters.AddWithValue("@UserName",StdTextBoxUserName.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Password",StdTextBoxPassword.Text.Trim());
                int count = Convert.ToInt32(sqlCmd.ExecuteScalar());
                if (count ==1  ) 
                {
                    Session["UserName"] = StdTextBoxUserName.Text.Trim();
                    Response.Redirect("StudentInfo.aspx");

                }
                else { lblErrorMessage.Visible = true; }

            }
        }
    }
}