using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Main : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Title = "ABC Auction - Main";

        try
        {
            Boolean test = (Boolean)Session["LogStatus"];
        }
        catch
        {
            Boolean log = false;
            Session["LogStatus"] = log;
        }

        if ((Boolean)Session["LogStatus"] == true)
        {
            but_uitem.Visible = true;
            but_pur.Visible = true;
        }
    }
    protected void but_log_Click(object sender, EventArgs e)
    {
        Response.Redirect("search_item.aspx");
    }
    protected void but_add_Click(object sender, EventArgs e)
    {
        Response.Redirect("new_product.aspx");
    }
    protected void but_uitem_Click(object sender, EventArgs e)
    {
        Response.Redirect("MyItems.aspx");
    }
    protected void but_pur_Click(object sender, EventArgs e)
    {
        Response.Redirect("Purchases.aspx");
    }
}