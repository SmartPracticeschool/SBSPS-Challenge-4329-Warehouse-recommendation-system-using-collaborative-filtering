using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Web.Configuration;
public partial class cleardb :System.Web.UI.Page
{
SqlConnection con;
SqlCommandcmd;
    string query;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    public void data()
    {
        string connstring = WebConfigurationManager.ConnectionStrings["connect"].ConnectionString;
        con = new SqlConnection(connstring);
con.Open();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
data();
        query = "delete from billdetails";
cmd = new SqlCommand(query, con);
cmd.ExecuteNonQuery();
con.Close();

data();
        query = "delete from tempbill";
cmd = new SqlCommand(query, con);
cmd.ExecuteNonQuery();
con.Close();

data();
        query = "delete from tmprcm";
cmd = new SqlCommand(query, con);
cmd.ExecuteNonQuery();
con.Close();

data();
        query = "delete from updataset";
cmd = new SqlCommand(query, con);
cmd.ExecuteNonQuery();
con.Close();

data();
        query = "update recommendation set P1=0,P2=0,P3=0,P4=0,P5=0,P6=0,P7=0,P8=0,P9=0,P10=0";
cmd = new SqlCommand(query, con);
cmd.ExecuteNonQuery();
con.Close();

data();
        query = "update recommendation set P11=0,P12=0,P13=0,P14=0,P15=0,P16=0,P17=0,P18=0,P19=0,P20=0";
cmd = new SqlCommand(query, con);
cmd.ExecuteNonQuery();
con.Close();

MessageBox.Show("Database Cleared Successfully");
    }
}
