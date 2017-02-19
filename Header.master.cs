using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using System.Data;

public partial class Header : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            OleDbConnection Connec = new OleDbConnection();
            Connec.ConnectionString = AccessDataSource1.ConnectionString;
            Session["Connection"] = Connec;
            try
            {
                Boolean test = (Boolean)Session["LogStatus"];
            }
            catch
            {
                Boolean log = false;
                Session["LogStatus"] = log;
                
            }
        }
    }
}
