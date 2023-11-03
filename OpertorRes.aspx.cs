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
    public partial class OpertorRes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonOpResReturn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Main.aspx");
        }

        protected void ButtonOpRes_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-SB8H3D16\SQLEXPRESS;Initial Catalog=MainPage;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into OperatorInformation" + "(OperatorID,FirstName,LastName,Email,UserName,Password)" +
                "values (@OperatorID,@FirstName,@LastName,@Email,@UserName,@Password)", con);
            cmd.Parameters.AddWithValue("@OperatorID", TextBoxOPID.Text);
            cmd.Parameters.AddWithValue("@FirstName", TextBoxOPFN.Text);
            cmd.Parameters.AddWithValue("@LastName", TextBoxOPLN.Text);
            cmd.Parameters.AddWithValue("@Email", TextBoxOPEMAIL.Text);
            cmd.Parameters.AddWithValue("@UserName", TextBoxOPUN.Text);
            cmd.Parameters.AddWithValue("@Password", TextBoxOPPASS.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            Label1.Text = "You have registered successfully！";
        }
    }
}