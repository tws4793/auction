using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using System.Data;

public partial class MyItems : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
        Title = "ABC Auction - My items";

        OleDbConnection Connec = (OleDbConnection)Session["Connection"];
        Verify.Update(Connec.ConnectionString);
        OleDbCommand dbCmd = new OleDbCommand("SELECT pid,category,pname,descb,qty,cond,day_start,duration,price_start,price_bid,buser FROM Products WHERE ( starter = \"" + (string)Session["Name"] + "\")", Connec);
        OleDbDataAdapter dbAdap = new OleDbDataAdapter(dbCmd);
        DataSet DS = new DataSet();
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
        DS.Tables[0].Columns[10].ColumnName = "Highest Bidder";


        GridView1.DataSource = DS.Tables[0];
        GridView1.DataBind();
    }
    protected void but_back_Click(object sender, EventArgs e)
    {
        Response.Redirect("Main.aspx");
    }
}