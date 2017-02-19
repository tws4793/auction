using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;

public partial class new_product : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if ((Boolean)Session["LogStatus"] == true)
        {
            pnlDetails.Visible = true;
            lblIntro.Text = "Please add your new product below";
            btn_Submit.Visible = true;
            btn_Confirm.Visible = false;
            btn_Edit.Visible = false;
            rfv_Quantity.ErrorMessage = "Enter the Quantity!";
            rfv_Duration.ErrorMessage = "Enter the Duration!";
            rfv_StartPrice.ErrorMessage = "Enter the Starting Price!";
        }
        else
        {
            pnlDetails.Visible = false;
            lblIntro.Text = "You are not logged in!\nPlease login to add a new product!";
        }

        if (!IsPostBack)
        {
            Title = "ABC Auction - New Product";

            
            OleDbConnection Connec = (OleDbConnection)Session["Connection"];

            OleDbCommand dbCmd = new OleDbCommand();
            dbCmd.CommandText = "Select Distinct [Category] FROM [Products]";
            dbCmd.Connection = Connec;
            OleDbDataAdapter dbAdap = new OleDbDataAdapter();
            dbAdap.SelectCommand = dbCmd;
            DataTable dt = new DataTable();
            dbAdap.Fill(dt);

            ddl_category.DataSource = dt;
            ddl_category.DataValueField = "Category";
            ddl_category.DataBind();

            dbCmd.CommandText = "Select Distinct [cond] FROM [Products]";
            dbAdap.SelectCommand = dbCmd;
            DataTable dt2 = new DataTable();
            dbAdap.Fill(dt2);

            rb_Cond.DataSource = dt2;
            rb_Cond.DataValueField = "cond";
            rb_Cond.DataBind();
            
        }
    }
    protected void btn_Submit_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            //To force user to enter as a number.
            //if(tb_Quantity.i
            btn_Submit.Visible = false;
            lblIntro.Text = "Please confirm your product details:";

            lbl_Category.Visible = true;
            lbl_Name.Visible = true;
            lbl_Quantity.Visible = true;
            lbl_Cond.Visible = true;
            lbl_Duration.Visible = true;
            lbl_StartPrice.Visible = true;
            lbl_Description.Visible = true;

            lbl_Category.Text = Convert.ToString(ddl_category.SelectedItem);
            lbl_Name.Text = tb_Name.Text;
            lbl_Quantity.Text = tb_Quantity.Text;
            lbl_Cond.Text = Convert.ToString(rb_Cond.SelectedItem);
            lbl_Duration.Text = tb_Duration.Text;
            lbl_StartPrice.Text = tb_StartPrice.Text;
            lbl_Description.Text = tb_Description.Text;

            ddl_category.Visible = false;
            tb_Name.Visible = false;
            tb_Quantity.Visible = false;
            rb_Cond.Visible = false;
            tb_Duration.Visible = false;
            tb_StartPrice.Visible = false;
            tb_Description.Visible = false;

            btn_Edit.Visible = true;
            btn_Confirm.Visible = true;
        }
    }
    protected void btn_Edit_Click(object sender, EventArgs e)
    {
        btn_Submit.Visible = true;
        lblIntro.Text = "Please add your new product below:";

        lbl_Category.Visible = false;
        lbl_Name.Visible = false;
        lbl_Quantity.Visible = false;
        lbl_Cond.Visible = false;
        lbl_Duration.Visible = false;
        lbl_StartPrice.Visible = false;
        lbl_Description.Visible = false;

        //ddl_category.SelectedItem = lbl_Category.Text;
        tb_Name.Text = lbl_Name.Text;
        tb_Quantity.Text = lbl_Quantity.Text;
        //Condition
        tb_Duration.Text = lbl_Duration.Text;
        tb_StartPrice.Text = lbl_StartPrice.Text;
        tb_Description.Text = lbl_Description.Text;

        ddl_category.Visible = true;
        tb_Name.Visible = true;
        tb_Quantity.Visible = true;
        rb_Cond.Visible = true;
        tb_Duration.Visible = true;
        tb_StartPrice.Visible = true;
        tb_Description.Visible = true;

        btn_Edit.Visible = false;
        btn_Confirm.Visible = false;
    }
    protected void btn_Confirm_Click(object sender, EventArgs e)
    {
        Session["New Product Name"] = (string)lbl_Name.Text;

        OleDbConnection Connec = (OleDbConnection)Session["Connection"];
        OleDbCommand dbCmd = new OleDbCommand("SELECT * FROM [Products]", Connec);
        OleDbDataAdapter dbAdap = new OleDbDataAdapter(dbCmd);
        DataSet DS = new DataSet();
        dbAdap.Fill(DS);

        OleDbCommandBuilder dbCmdBuild = new OleDbCommandBuilder(dbAdap);

        DataRow dr = DS.Tables[0].NewRow();

        dr[0] = DS.Tables[0].Rows.Count + 1;
        dr[1] = lbl_Category.Text;
        dr[2] = lbl_Name.Text;
        dr[3] = lbl_Description.Text;
        dr[4] = Convert.ToInt32(lbl_Quantity.Text);
        dr[5] = lbl_Cond.Text;
        dr[6] = DateTime.Now;
        dr[7] = Convert.ToInt32(lbl_Duration.Text);
        dr[8] = Convert.ToDouble(lbl_StartPrice.Text);
        dr[9] = 0;
        dr[11] = (string)Session["Name"];
         
        DS.Tables[0].Rows.Add(dr);
        Connec.Open();
        dbAdap.Update(DS);
        DS.AcceptChanges();
        Connec.Close();

        Response.Redirect("new_product_conf.aspx");

    }
    protected void but_back_Click(object sender, EventArgs e)
    {
        Response.Redirect("main.aspx");
    }
}