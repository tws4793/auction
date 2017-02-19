using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Title = "ABC Auction - Login";

        OleDbConnection Connec = (OleDbConnection)Session["Connection"];
    }

    protected void Button1_Click(object sender, EventArgs e)
    {

        if (Page.IsValid)
        {
            OleDbConnection Connec = (OleDbConnection)Session["Connection"];

            OleDbCommand dbCmd = new OleDbCommand();
            dbCmd.CommandText = "Select * From [Users] Where (username = \"" + txtUser.Text + "\")";
            dbCmd.Connection = Connec;
            OleDbDataAdapter dbAdap = new OleDbDataAdapter();
            dbAdap.SelectCommand = dbCmd;
            DataTable dt = new DataTable();
            dbAdap.Fill(dt);

            if (dt.Rows.Count > 0 && txtPass.Text == Convert.ToString(dt.Rows[0].ItemArray[2]) && txtUser.Text.ToUpper() == Convert.ToString(dt.Rows[0].ItemArray[1]).ToUpper())
            {
                Session["Name"] = dt.Rows[0].ItemArray[1];
                Boolean log = true;
                Session["LogStatus"] = log;
                Response.Redirect("RegLog_Sus.aspx");
            }
            else lblIncorrect.Visible = true;
        }
    }
}