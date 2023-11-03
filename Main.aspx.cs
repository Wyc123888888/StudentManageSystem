using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StudentManagementSys
{
    public partial class Main : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonStd_Click(object sender, EventArgs e)
        {
            Response.Redirect("StudentLog.aspx");
        }

        protected void ButtonOperator_Click(object sender, EventArgs e)
        {
            Response.Redirect("OperatorLog.aspx");
        }

        protected void ButtonStdRes_Clik(object sender, EventArgs e)
        {
            Response.Redirect("StudentRes.aspx");
        }

        protected void ButtonOpertorRes_Click(object sender, EventArgs e)
        {
            Response.Redirect("OpertorRes.aspx");
        }
    }
}