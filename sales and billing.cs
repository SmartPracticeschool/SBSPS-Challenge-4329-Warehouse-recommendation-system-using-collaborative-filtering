using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Collections;
public partial class salesandbilling :System.Web.UI.Page
{
SqlConnection con;
SqlCommandcmd;
    string query;
ArrayListprod_name = new ArrayList();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
lblbillno.Text = "BNO" + randomnumber(000, 999);
data();
            query = "select MAX(cid) from updataset";
cmd = new SqlCommand(query, con);
SqlDataReaderrd = cmd.ExecuteReader();
            while (rd.Read())
            {
lblcusid.Text = (Convert.ToInt32(rd[0]) + 1).ToString();
            }
rd.Close();
con.Close();
data();
            query = "delete from tempbill";
cmd = new SqlCommand(query, con);
cmd.ExecuteNonQuery();
con.Close();
            GridView1.DataBind();
        }
    }
    public void data()
    {
        string connstring = WebConfigurationManager.ConnectionStrings["connect"].ConnectionString;
        con = new SqlConnection(connstring);
con.Open();
    }
    private int randomnumber(int min, int max)
    {
        Random random = new Random();
        return random.Next(min, max);
    }
    protected void dropproductid_SelectedIndexChanged(object sender, EventArgs e)
    {
data();
        query = "select name,rackno,stock,price from productdet where pid='" + dropproductid.SelectedItem.Text + "'";
cmd = new SqlCommand(query, con);
SqlDataReaderrd = cmd.ExecuteReader();
        while (rd.Read())
        {
lblprodname.Text = rd[0].ToString();
lblrack.Text = rd[1].ToString();
lblavailstock.Text = rd[2].ToString();
lblprice.Text = rd[3].ToString();
        }
rd.Close();
con.Close();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
data();
        query = "select top(3) " + dropproductid.SelectedItem.Text + ",pname from recommendation order by " + dropproductid.SelectedItem.Text + " DESC";
cmd = new SqlCommand(query, con);
SqlDataReaderrd = cmd.ExecuteReader();
        while (rd.Read())
        {
prod_name.Add(rd[1].ToString());
        }
rd.Close();
con.Close();
        if (prod_name.Count == 3)
        {
data();
            query = "select name from productdet where pid='" + prod_name[0].ToString() + "'";
cmd = new SqlCommand(query, con);
SqlDataReaderdr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lblr1.Text = dr[0].ToString();
            }
dr.Close();
con.Close();

data();
            query = "select name from productdet where pid='" + prod_name[1].ToString() + "'";
cmd = new SqlCommand(query, con);
SqlDataReader dr1 = cmd.ExecuteReader();
            while (dr1.Read())
            {
                lblr2.Text = dr1[0].ToString();
            }
            dr1.Close();
con.Close();

data();
            query = "select name from productdet where pid='" + prod_name[2].ToString() + "'";
cmd = new SqlCommand(query, con);
SqlDataReader dr2 = cmd.ExecuteReader();
            while (dr2.Read())
            {
                lblr3.Text = dr2[0].ToString();
            }
            dr2.Close();
con.Close();

            //lblr1.Text = prod_name[0].ToString();
            //lblr2.Text = prod_name[1].ToString();
            //lblr3.Text = prod_name[2].ToString();
        }
        else if(prod_name.Count == 2)
        {
            lblr1.Text = prod_name[0].ToString();
            lblr2.Text = prod_name[1].ToString();
        }
        else if(prod_name.Count == 1)
        {
            lblr1.Text = prod_name[0].ToString();
        }


    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        if ((Convert.ToInt32(lblavailstock.Text)) > 0)
        {
            Button5.Enabled = true;
data();
            query = "insert into tempbill(pid,pname,price,cusid)values('" + dropproductid.SelectedItem.Text + "','" + lblprodname.Text + "','" + lblprice.Text + "','" + lblcusid.Text + "')";
cmd = new SqlCommand(query, con);
cmd.ExecuteNonQuery();
con.Close();

data();
            query = "select sum(price) from tempbill";
cmd = new SqlCommand(query, con);
SqlDataReaderrd = cmd.ExecuteReader();
            while (rd.Read())
            {
lbltotal.Text = rd[0].ToString();
            }
rd.Close();
con.Close();

            GridView1.DataBind();
        }
        else
        {
MessageBox.Show("Insufficient Stock");
            Button5.Enabled = false;
        }
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        int id = Convert.ToInt32(GridView1.SelectedRow.Cells[0].Text.ToString());
data();
        query = "delete from tempbill where Id=" + id + "";
cmd = new SqlCommand(query, con);
cmd.ExecuteNonQuery();
con.Close();
data();
        query = "select sum(price) from tempbill";
cmd = new SqlCommand(query, con);
SqlDataReaderrd = cmd.ExecuteReader();
        while (rd.Read())
        {
lbltotal.Text = rd[0].ToString();
        }
rd.Close();
con.Close();
        GridView1.DataBind();
    }
    protected void Button5_Click(object sender, EventArgs e)
    {
data();
        query = "select * from tempbill";
cmd = new SqlCommand(query, con);
SqlDataReaderrd = cmd.ExecuteReader();
        while (rd.Read())
        {
data();
            query = "insert into billdetails(billno,cusid,phno,pid,pname,price,ordate,ortime)values('" + lblbillno.Text + "','" + rd[4].ToString() + "','" + txtphoneno.Text + "','" + rd[1].ToString() + "','" + rd[2].ToString() + "'," + rd[3] + ",'" + System.DateTime.Today.ToShortDateString() + "','" + System.DateTime.Now.ToShortTimeString() + "')";
cmd = new SqlCommand(query, con);
cmd.ExecuteNonQuery();
con.Close();

data();
            query = "update productdet set stock=stock-1 where pid='" + rd[1] + "'";
cmd = new SqlCommand(query, con);
cmd.ExecuteNonQuery();
con.Close();


        }
rd.Close();
con.Close();

data();
        query = "insert into updataset(cid)values(" + lblcusid.Text + ")";
cmd = new SqlCommand(query, con);
cmd.ExecuteNonQuery();
con.Close();

        for (int i = 0; i<GridView1.Rows.Count; i++)
        {
            string q = "pur" + (i + 1);
data();
            query = "update updataset set " + q + " = '" + GridView1.Rows[i].Cells[1].Text.ToString() + "' where cid=" + lblcusid.Text + "";
cmd = new SqlCommand(query, con);
cmd.ExecuteNonQuery();
con.Close();
        }


MessageBox.Show("Items Purchased Successfully");
Response.Redirect("salesandbilling.aspx");
    }
}
