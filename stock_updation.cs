using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Web.Configuration;
public partial class stockupdation :System.Web.UI.Page
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
    protected void dropproductid_SelectedIndexChanged(object sender, EventArgs e)
    {
data();
        query = "select name,stock from productdet where pid='" + dropproductid.SelectedItem.Text + "'";
cmd = new SqlCommand(query, con);
SqlDataReaderrd = cmd.ExecuteReader();
        while (rd.Read())
        {
lblprodname.Text = rd[0].ToString();
lblavailstock.Text = rd[1].ToString();

        }
rd.Close();
con.Close();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        int tot = Convert.ToInt32(lblavailstock.Text) + Convert.ToInt32(txtnoprod.Text);

data();
        query = "update productdet set stock=" + tot + " where pid='" + dropproductid.SelectedItem.Text + "'";
cmd = new SqlCommand(query, con);
cmd.ExecuteNonQuery();
con.Close();
MessageBox.Show("Stock Updated");
txtnoprod.Text = "";
    }
}
