using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using System.Data;

public partial class Register : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void butReg_Click(object sender, EventArgs e)
    {

        lab_taken.Visible = false;
        if (Page.IsValid)
        {
            OleDbConnection Connec = (OleDbConnection)Session["Connection"];
            OleDbCommand dbCmd = new OleDbCommand();
            dbCmd.CommandText = "Select * From [Users] Where (username = \"" + txt_username.Text + "\")";
            dbCmd.Connection = Connec;
            OleDbDataAdapter dbAdap = new OleDbDataAdapter();
            dbAdap.SelectCommand = dbCmd;
            DataTable dt = new DataTable();
            dbAdap.Fill(dt);

            if (dt.Rows.Count == 0)
            {
                OleDbCommandBuilder dbCmdBuild = new OleDbCommandBuilder(dbAdap);

                dbCmd.CommandText = "Select * From [Users]";
                dbAdap.SelectCommand = dbCmd;
                dbAdap.Fill(dt);

                DataRow dr = dt.NewRow();

                dr[0] = Convert.ToString(dt.Rows.Count + 1);
                dr[1] = txt_username.Text;
                dr[8] = txt_name.Text;
                dr[2] = txt_pass.Text;
                dr[3] = txt_mail.Text;
                dr[4] = txt_about.Text;
                dr[5] = txt_address.Text;
                dr[6] = txt_country.Text;
                dr[7] = txt_postal.Text;

                dt.Rows.Add(dr);
                Connec.Open();
                dbAdap.Update(dt);
                dt.AcceptChanges();
                Connec.Close();

                Session["Name"] = txt_username.Text;
                Response.Redirect("RegLog_Sus.aspx");
            }
            else
            {
                lab_taken.Visible = true;
            }
        }
    }
    protected void but_back_Click(object sender, EventArgs e)
    {
        Response.Redirect("main.aspx");
    }
}