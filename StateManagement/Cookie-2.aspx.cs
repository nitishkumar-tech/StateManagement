using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagement
{
    public partial class Cookie_2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie ucookie=Request.Cookies["userInfo"];
            if (ucookie!=null)
            {
                lblfName.Text = ucookie["Username"];
                lbllName.Text = ucookie["Password"];
            }
        }
    }
}