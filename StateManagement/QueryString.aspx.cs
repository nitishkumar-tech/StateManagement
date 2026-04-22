using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagement
{
    public partial class QueryString : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string firstname = TextBox1.Text;
            string password = TextBox2.Text;
            Response.Redirect("~/QueryString-2.aspx?firstname=" + TextBox1.Text + "&password=" + TextBox2.Text);
        }
    }
}