using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class new_product_conf : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Title = "New Product: " + (string)Session["New Product Name"];
        lbl_Name.Text = (string)Session["New Product Name"];
    }
    protected void but_return_Click(object sender, EventArgs e)
    {
        Response.Redirect("Main.aspx");
    }
}