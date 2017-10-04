using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication4
{
    public partial class Form1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            NameValueCollection nv = Request.Form;

            string text1Field = nv["TextBox1"];
            string text2Field = nv["TextBox2"];

            Response.Write("TextBox1: " + text1Field + "<br />");
            Response.Write("TextBox2: " + text2Field + "<br />");
        }
    }
}