using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using System.Data;


public static class Verify
{
    public static void Update(string ConnectionString)
    {
        OleDbConnection Connec = new OleDbConnection();
        Connec.ConnectionString = ConnectionString;
        OleDbCommand dbCmd = new OleDbCommand("SELECT * FROM Products WHERE ( Status = \"" + "Ongoing" + "\")", Connec);
        OleDbDataAdapter dbAdap = new OleDbDataAdapter(dbCmd);
        DataSet DS = new DataSet();
        dbAdap.Fill(DS);

        OleDbCommandBuilder dbCmdBuild = new OleDbCommandBuilder(dbAdap);

        int c = DS.Tables[0].Rows.Count;

        for (int i = 0; i < c; i++)
        {

            System.DateTime End = Convert.ToDateTime(DS.Tables[0].Rows[i][6]);
            End = End.AddDays(Convert.ToInt32(DS.Tables[0].Rows[i][7]));


            if (DateTime.Now > End)
            {
                DS.Tables[0].Rows[i][12] = "Expired";
            }
            else
                DS.Tables[0].Rows[i][12] = "Ongoing";
        }

        Connec.Open();
        dbAdap.Update(DS);
        DS.AcceptChanges();
        Connec.Close();
    }
}