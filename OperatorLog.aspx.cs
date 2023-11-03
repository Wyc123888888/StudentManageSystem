using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StudentManagementSys
{
    public partial class OperatorLog : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblErrorMessage.Visible = false;
        }

        protected void OPButtonLog_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=LAPTOP-SB8H3D16\SQLEXPRESS;Initial Catalog=MainPage;Integrated Security=True;"))
            {
                sqlCon.Open();
                string query = "select count(1) from OperatorInformation where UserName=@UserName and Password=@Password";
                SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
                sqlCmd.Parameters.AddWithValue("@UserName", OPTextBoxUserName.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Password", OPTextBoxPassword.Text.Trim());
                int count = Convert.ToInt32(sqlCmd.ExecuteScalar());
                if (count == 1)
                {
                    Session["UserName"] = OPTextBoxUserName.Text.Trim();
                    Response.Redirect("OperatorInfo.aspx");

                }
                else { lblErrorMessage.Visible = true; }

            }
        }
    }
}