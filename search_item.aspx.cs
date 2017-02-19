using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using System.Data;

public partial class search_item : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Title = "ABC Auction - Search";

            OleDbConnection Connec = (OleDbConnection)Session["Connection"];
            OleDbCommand dbCmd = new OleDbCommand();
            dbCmd.CommandText = "Select Distinct [Category] FROM [Products]";
            dbCmd.Connection = Connec;
            OleDbDataAdapter dbAdap = new OleDbDataAdapter();
            dbAdap.SelectCommand = dbCmd;
            DataTable dt = new DataTable();
            dbAdap.Fill(dt);

            ddl_cat.DataSource = dt;
            ddl_cat.DataValueField = "Category";
            ddl_cat.DataBind();

            dbCmd.CommandText = "Select Distinct [cond] FROM [Products]";
            dbAdap.SelectCommand = dbCmd;
            DataTable dt2 = new DataTable();
            dbAdap.Fill(dt2);

            ddl_condi.DataSource = dt2;
            ddl_condi.DataValueField = "cond";
            ddl_condi.DataBind();
        }
    }
    protected void but_search_Click(object sender, EventArgs e)
    {
        String sql = "";
        if (cb_cat.Checked == true || cb_condi.Checked == true || cb_name.Checked == true || cb_status.Checked == true)
        {
            String sql_add = "";
            if (cb_cat.Checked == true)
            {
                sql_add = " category = \"" + ddl_cat.SelectedValue + "\"";
            }
            if (cb_condi.Checked == true)
            {
                if (cb_cat.Checked == true) sql_add += " AND";
                sql_add += " cond = \"" + ddl_condi.SelectedValue + "\"";
            }
            if (cb_name.Checked == true)
            {
                if (cb_cat.Checked == true || cb_condi.Checked == true) sql_add += " AND";
                sql_add += " pname LIKE \"%" + txt_name.Text + "%\"";
            }
            if (cb_status.Checked == true)
            {
                if (cb_cat.Checked == true || cb_condi.Checked == true || cb_name.Checked == true) sql_add += " AND";
                sql_add += " Status = \"" + "Ongoing" + "\"";
            }
            sql = "SELECT * FROM Products WHERE (" + sql_add + " )";
        }
        else sql = "SELECT * FROM Products";

        test.Text = sql;

        OleDbConnection Connec = (OleDbConnection)Session["Connection"];

        Verify.Update(Connec.ConnectionString);
        
        OleDbCommand dbCmd = new OleDbCommand();
        dbCmd.CommandText = sql;
        dbCmd.Connection = Connec;
        OleDbDataAdapter dbAdap = new OleDbDataAdapter();
        dbAdap.SelectCommand = dbCmd;
        DataSet DS = new DataSet();
        Session["DataSet"] = DS;
        dbAdap.Fill(DS);
        DataTable dt = new DataTable();
        dt = DS.Tables[0];

        dt.Columns[0].ColumnName = "ID";
        dt.Columns[1].ColumnName = "Category";
        dt.Columns[2].ColumnName = "Item Name";
        dt.Columns[3].ColumnName = "Description";
        dt.Columns[4].ColumnName = "QTY";
        dt.Columns[5].ColumnName = "Condition";
        dt.Columns[6].ColumnName = "Auction Start";
        dt.Columns[7].ColumnName = "Duration (days)";
        dt.Columns[8].ColumnName = "Starting Bid";
        dt.Columns[9].ColumnName = "Current Bid";
        dt.Columns[10].ColumnName = "Highest Bidder";
        dt.Columns[11].ColumnName = "By User";

        GridView1.DataSource = dt;
        GridView1.DataBind();

        int[] HideRow = new int[] { 0, 1, 3, 4, 5, 8, 10 };

        foreach (int i in HideRow)
        {
            GridView1.HeaderRow.Cells[i + 1].Visible = false;
            foreach (GridViewRow gvrt in GridView1.Rows)
            {
                gvrt.Cells[i + 1].Visible = false;
                // Because the first column has a button, therefore add 1.
            }
        }
    }

    protected void GridView1_RowCommand1(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "")
        {
            int index = Convert.ToInt32(e.CommandArgument);

            DataSet DS = (DataSet)Session["DataSet"];
            Session["ID"] = Convert.ToInt32(DS.Tables[0].Rows[index][0]);

            Response.Redirect("product.aspx");
        }
    }
    protected void but_back_Click(object sender, EventArgs e)
    {
        Response.Redirect("main.aspx");
    }
}