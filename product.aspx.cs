using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using System.Data;

public partial class product : System.Web.UI.Page
{
    private int PID;
    private OleDbDataAdapter dbAdap;
    private DataSet DS;

    protected void Page_Load(object sender, EventArgs e)
    {
        PID = (int)Session["ID"];

        OleDbConnection Connec = (OleDbConnection)Session["Connection"];
        OleDbCommand dbCmd = new OleDbCommand("SELECT * FROM Products WHERE ( pid =" + Convert.ToString(PID) + ")", Connec);
        dbAdap = new OleDbDataAdapter(dbCmd);
        DS = new DataSet();
        dbAdap.Fill(DS);

        lbl_starter.Text = Convert.ToString(DS.Tables[0].Rows[0][11]);
        lbl_name.Text = Convert.ToString(DS.Tables[0].Rows[0][2]);
        Title = "ABC Auction - Viewing: " + lbl_name.Text;
        lbl_des.Text = Convert.ToString(DS.Tables[0].Rows[0][3]);
        lbl_cond.Text = Convert.ToString(DS.Tables[0].Rows[0][5]);
        lbl_Qty.Text = Convert.ToString(DS.Tables[0].Rows[0][4]);
        lbl_start.Text = Convert.ToString(DS.Tables[0].Rows[0][6]);

        lbl_startbid.Text = String.Format("{0:c}", DS.Tables[0].Rows[0][8]);
        lbl_bid.Text = String.Format("{0:c}", DS.Tables[0].Rows[0][9]);
        lbl_bidder.Text = Convert.ToString(DS.Tables[0].Rows[0][10]);

        lbl_dur.Text = Convert.ToString(DS.Tables[0].Rows[0][7]) + " Days";

        System.DateTime End = Convert.ToDateTime(DS.Tables[0].Rows[0][6]);
        End = End.AddDays(Convert.ToInt32(DS.Tables[0].Rows[0][7]));

        lbl_end.Text = Convert.ToString(End);

        if (DateTime.Now > End)
        {
            txt_bid.Visible = false;
            but_bid.Visible = false;
            lbl_error.Text = "Auction Over";
        }
        else if ((Boolean)Session["LogStatus"] == false)
        {
            txt_bid.Visible = false;
            but_bid.Visible = false;
            lbl_error.Text = "Login Required to place bid!";
        }
        else if (Convert.ToString(DS.Tables[0].Rows[0][11]) == (string)Session["Name"])
        {
            txt_bid.Visible = false;
            but_bid.Visible = false;
            lbl_error.Text = "This is your item!";
        }
    }
    protected void btnBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("search_item.aspx");
    }
    protected void but_main_Click(object sender, EventArgs e)
    {
        Response.Redirect("main.aspx");
    }
    protected void but_bid_Click(object sender, EventArgs e)
    {

        OleDbConnection Connec = (OleDbConnection)Session["Connection"];

        double ubid = double.Parse(txt_bid.Text);
        double bid = Convert.ToDouble(DS.Tables[0].Rows[0][9]);
        double sbid = Convert.ToDouble(DS.Tables[0].Rows[0][8]);

        System.DateTime End = Convert.ToDateTime(DS.Tables[0].Rows[0][6]);
        End = End.AddDays(Convert.ToInt32(DS.Tables[0].Rows[0][7]));

        lbl_end.Text = Convert.ToString(End);

        if (DateTime.Now > End)
        {
            txt_bid.Visible = false;
            but_bid.Visible = false;
            lbl_error.Text = "Auction Over";
        }
        else
            
        {
            
            if (ubid > sbid && ubid > bid)
            {
                string highestbidder = Convert.ToString(DS.Tables[0].Rows[0][10]);
                string currentuser = (string)Session["Name"];

                if (highestbidder != currentuser)
                {
                    OleDbCommandBuilder dbCmdBuild = new OleDbCommandBuilder(dbAdap);

                    DS.Tables[0].Rows[0][9] = ubid;
                    DS.Tables[0].Rows[0][10] = (string)Session["Name"];

                    Connec.Open();
                    dbAdap.Update(DS);
                    DS.AcceptChanges();
                    Connec.Close();

                    txt_bid.Text = "";
                    lbl_error.Text = "Bid Placed!";

                    lbl_bid.Text = String.Format("{0:c}", ubid);
                    lbl_bidder.Text = (string)Session["Name"];
                }
                else
                {
                    txt_bid.Text = "";
                    lbl_error.Text = "Bid was not accepted: You are currently the highest bidder!";
                }
            }
            else
            {
                txt_bid.Text = "";
                lbl_error.Text = "Bid too low!";
            }
        }
    }
}