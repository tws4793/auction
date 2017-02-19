using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using System.Data;

public partial class HeadSub : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if ((Boolean)Session["LogStatus"] == true)
        {
            lab_name.Text = "Logged in as " + Session["Name"];
            but_log.Visible = false;
            but_reg.Visible = false;
            but_logout.Visible = true;
        }
        lab_time.Text = Convert.ToString(DateTime.Now);
    }
    protected void but_log_Click(object sender, EventArgs e)
    {
        Session["LogFrom"] = Request.Path;
        Response.Redirect("Login.aspx");
    }
    protected void but_reg_Click(object sender, EventArgs e)
    {
        Session["LogFrom"] = Request.Path;
        Response.Redirect("Register.aspx");
    }
    protected void but_logout_Click(object sender, EventArgs e)
    {
        lab_name.Text = "Login or Register";
        Session["LogStatus"] = false;
        Session["Name"] = "";
        but_log.Visible = true;
        but_reg.Visible = true;
        but_logout.Visible = false;
        Response.Redirect(Request.Path);
    }
}
