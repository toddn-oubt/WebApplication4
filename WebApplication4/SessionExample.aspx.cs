using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication4
{
    public partial class SessionExample : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Name"] != null)
            {
                Response.Redirect("SessionExampleSubmit.aspx");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session.Add("Name", TextBox1.Text);
            Response.Redirect("SessionExampleSubmit.aspx");
        }
    }
}