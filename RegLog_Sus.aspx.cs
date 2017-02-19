using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Reg_Sus : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if ((Boolean)Session["LogStatus"] == true)
        {
            Title = "ABC Auction - successfully logged in as " + (String)Session["Name"];
            lab_text.Text = "has been sucessfully logged in!";
            lab_title.Text = "Login Successful!";
        }
        else
        {
            Title = "ABC Auction - successfully registered as " + (String)Session["Name"];
        }
        lab_name.Text = (String)Session["Name"];
    }
    protected void but_return_Click(object sender, EventArgs e)
    {
        Response.Redirect(Convert.ToString(Session["LogFrom"]));
    }
}