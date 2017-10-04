using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication4
{
    public partial class SessionExampleSubmit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Name"] != null)
            {
                Label1.Text = String.Format("Welcome, {0}", Session["Name"]);
            }
            else
            {
                Response.Redirect("SessionExample.aspx");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session.Remove("Name");
            Response.Redirect("SessionExample.aspx");
        }
    }
}