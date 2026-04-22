using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagement
{
    public partial class Cookie_1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //cookie creation and add seconds to expire
            //HttpCookie ucookie = new HttpCookie("UserId");
            //ucookie.Value = txtUsername.Text;
            //ucookie.Value = txtPassword.Text;
            //ucookie.Expires.AddSeconds(60);
            //Response.Cookies.Add(ucookie);
            //Response.Redirect("CookieData.aspx");

            HttpCookie usercookie = new HttpCookie("userInfo");
            usercookie["Username"] =textusername.Text;
            usercookie["Password"] = textpassword.Text;

            usercookie.Expires = DateTime.Now.AddMinutes(1);

            Response.Cookies.Add(usercookie);

            // usercookie.Expires.AddMinutes(1);

            Response.Redirect("Cookie-2.aspx");
        }
    }
}