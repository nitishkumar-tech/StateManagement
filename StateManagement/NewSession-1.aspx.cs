using System;

namespace StateManagement  
{
    public partial class NewSession_1 : System.Web.UI.Page   
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["ClicksCount"] == null)
            {
                Session["ClicksCount"] = 0;
            }

            lblCount.Text = "Clicks count: " + Session["ClicksCount"].ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int count = (int)Session["ClicksCount"];
            count++;

            Session["ClicksCount"] = count;

            lblCount.Text = "Clicks count: " + Session["ClicksCount"].ToString();
        }
    }
}