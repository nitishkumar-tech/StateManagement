using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagement
{
    public partial class NewSession_2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int CurrentUserCount = (int)Application["userCount"];
            lblUserCount.Text = "Current User Count: " + CurrentUserCount.ToString();
        }
    }
}