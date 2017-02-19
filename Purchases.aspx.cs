using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using System.Data;

public partial class Purchases : System.Web.UI.Page
{
    private OleDbConnection Connec;
    private OleDbCommand dbCmd;
    private OleDbDataAdapter dbAdap;
    private DataSet DS;
    private int index;

    protected void Page_Load(object sender, EventArgs e)
    {
        Title = "ABC Auction - My Bids";

        Connec = (OleDbConnection)Session["Connection"];
        Verify.Update(Connec.ConnectionString);
        dbCmd = new OleDbCommand("SELECT pid,category,pname,descb,qty,cond,day_start,duration,price_start,price_bid,starter,Paid FROM Products WHERE ( buser = \"" + (string)Session["Name"] + "\")", Connec);
        dbAdap = new OleDbDataAdapter(dbCmd);
        DS = new DataSet();
        dbAdap.Fill(DS);

        DS.Tables[0].Columns[0].ColumnName = "ID";
        DS.Tables[0].Columns[1].ColumnName = "Category";
        DS.Tables[0].Columns[2].ColumnName = "Item Name";
        DS.Tables[0].Columns[3].ColumnName = "Description";
        DS.Tables[0].Columns[4].ColumnName = "QTY";
        DS.Tables[0].Columns[5].ColumnName = "Condition";
        DS.Tables[0].Columns[6].ColumnName = "Auction Start";
        DS.Tables[0].Columns[7].ColumnName = "Duration (days)";
        DS.Tables[0].Columns[8].ColumnName = "Starting Bid";
        DS.Tables[0].Columns[9].ColumnName = "Current Bid";
        DS.Tables[0].Columns[10].ColumnName = "By User";
        DS.Tables[0].Columns[11].ColumnName = "Paid";


        GridView1.DataSource = DS.Tables[0];
        GridView1.DataBind();
    }
    protected void but_back_Click(object sender, EventArgs e)
    {
        Response.Redirect("main.aspx");
    }
    protected void GridView1_RowCommand1(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "")
        {
            index = Convert.ToInt32(e.CommandArgument);
            if (Convert.ToString(DS.Tables[0].Rows[index][11]) != "Paid")
            {
                panel_payment.Visible = true;

                lbl_bidamt.Text = Convert.ToString(DS.Tables[0].Rows[index][8]);
                rbl_method.SelectedIndex = 0;
                
            }
            else
            {
                ShowPaid(Convert.ToString(DS.Tables[0].Rows[index][0]));
            }
        }
    }
    protected void but_pay_Click(object sender, EventArgs e)
    {
        string pid = Convert.ToString(DS.Tables[0].Rows[index][0]);
        OleDbCommand dbCmd2 = new OleDbCommand("SELECT * FROM Products WHERE ( pid = \"" + pid + "\")", Connec);
        OleDbDataAdapter dbAdap2 = new OleDbDataAdapter(dbCmd);
        DataSet DS2 = new DataSet();
        dbAdap2.Fill(DS2);

        OleDbCommandBuilder dbCmdBuild = new OleDbCommandBuilder(dbAdap);

        DataRow dr = DS2.Tables[0].NewRow();

        dr[0] = Convert.ToString(DS2.Tables[0].Rows.Count + 1);
        dr[1] = Convert.ToString(DS.Tables[0].Rows[index][0]);
        dr[2] = Convert.ToString(DS.Tables[0].Rows[index][10]);
        dr[3] = Session["Name"];
        dr[4] = rbl_method.SelectedValue;
        dr[5] = DS.Tables[0].Rows[index][8];

        DS2.Tables[0].Rows.Add(dr);
        Connec.Open();
        dbAdap.Update(DS2.Tables[0]);
        DS2.Tables[0].AcceptChanges();
        Connec.Close();

        panel_payment.Visible = false;
        ShowPaid(pid);
    }
    private void ShowPaid(string pid)
    {
        panel_paid.Visible = true;

        OleDbCommand dbCmd2 = new OleDbCommand("SELECT * FROM Products WHERE ( pid = \"" + pid + "\")", Connec);
        OleDbDataAdapter dbAdap2 = new OleDbDataAdapter(dbCmd);
        DataSet DS2 = new DataSet();
        dbAdap2.Fill(DS2);

        lbl_transID.Text = Convert.ToString(DS2.Tables[0].Rows[0][0]);
        lbl_paidamt.Text = Convert.ToString(DS2.Tables[0].Rows[0][5]);
        lbl_seller.Text = Convert.ToString(DS2.Tables[0].Rows[0][2]);
        lbl_method.Text = Convert.ToString(DS2.Tables[0].Rows[0][4]);
    }
}