using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Drawing;
using System.Web.Configuration;
using System.Collections;
using System.Windows.Forms;
public partial class bill :System.Web.UI.Page
{
SqlConnection con;
SqlCommandcmd;
    string query;
ArrayListcid = new ArrayList();
ArrayListprod_name = new ArrayList();
    protected void Page_Load(object sender, EventArgs e)
    {
         for (int k = 0; k <GridView1.Rows.Count; k++)
        {
            if (GridView1.Rows[k].Cells[1].Text != "0")
            {
                GridView1.Rows[k].Cells[1].ForeColor = Color.Red;
            }
            if (GridView1.Rows[k].Cells[2].Text != "0")
            {
                GridView1.Rows[k].Cells[2].ForeColor = Color.Red;
            }
            if (GridView1.Rows[k].Cells[3].Text != "0")
            {
                GridView1.Rows[k].Cells[3].ForeColor = Color.Red;
            }
            if (GridView1.Rows[k].Cells[4].Text != "0")
            {
                GridView1.Rows[k].Cells[4].ForeColor = Color.Red;
            }
            if (GridView1.Rows[k].Cells[5].Text != "0")
            {
                GridView1.Rows[k].Cells[5].ForeColor = Color.Red;
            }
            if (GridView1.Rows[k].Cells[6].Text != "0")
            {
                GridView1.Rows[k].Cells[6].ForeColor = Color.Red;
            }
            if (GridView1.Rows[k].Cells[7].Text != "0")
            {
                GridView1.Rows[k].Cells[7].ForeColor = Color.Red;
            }
            if (GridView1.Rows[k].Cells[8].Text != "0")
            {
                GridView1.Rows[k].Cells[8].ForeColor = Color.Red;
            }
            if (GridView1.Rows[k].Cells[9].Text != "0")
            {
                GridView1.Rows[k].Cells[9].ForeColor = Color.Red;
            }
            if (GridView1.Rows[k].Cells[10].Text != "0")
            {
                GridView1.Rows[k].Cells[10].ForeColor = Color.Red;
            }

            if (GridView1.Rows[k].Cells[11].Text != "0")
            {
                GridView1.Rows[k].Cells[11].ForeColor = Color.Red;
            }
            if (GridView1.Rows[k].Cells[12].Text != "0")
            {
                GridView1.Rows[k].Cells[12].ForeColor = Color.Red;
            }
            if (GridView1.Rows[k].Cells[13].Text != "0")
            {
                GridView1.Rows[k].Cells[13].ForeColor = Color.Red;
            }
            if (GridView1.Rows[k].Cells[14].Text != "0")
            {
                GridView1.Rows[k].Cells[14].ForeColor = Color.Red;
            }
            if (GridView1.Rows[k].Cells[15].Text != "0")
            {
                GridView1.Rows[k].Cells[15].ForeColor = Color.Red;
            }
            if (GridView1.Rows[k].Cells[16].Text != "0")
            {
                GridView1.Rows[k].Cells[16].ForeColor = Color.Red;
            }
            if (GridView1.Rows[k].Cells[17].Text != "0")
            {
                GridView1.Rows[k].Cells[17].ForeColor = Color.Red;
            }
            if (GridView1.Rows[k].Cells[18].Text != "0")
            {
                GridView1.Rows[k].Cells[18].ForeColor = Color.Red;
            }
            if (GridView1.Rows[k].Cells[19].Text != "0")
            {
                GridView1.Rows[k].Cells[19].ForeColor = Color.Red;
            }
            if (GridView1.Rows[k].Cells[20].Text != "0")
            {
                GridView1.Rows[k].Cells[20].ForeColor = Color.Red;
            }
        }
    }
    public void data()
    {
        string connstring = WebConfigurationManager.ConnectionStrings["connect"].ConnectionString;
        con = new SqlConnection(connstring);
con.Open();
    }
    public void colorchange()
    {
        if (DropDownList1.SelectedItem.Text == "P1")
        {
            lblp1.BackColor = Color.Green;
            lblp1.Text = "P1 Done";
        }
        else if (DropDownList1.SelectedItem.Text == "P2")
        {
            lblp2.BackColor = Color.Green;
            lblp2.Text = "P2 Done";
        }
        else if (DropDownList1.SelectedItem.Text == "P3")
        {
            lblp3.BackColor = Color.Green;
            lblp3.Text = "P3 Done";
        }
        else if (DropDownList1.SelectedItem.Text == "P4")
        {
            lblp4.BackColor = Color.Green;
            lblp4.Text = "P4 Done";
        }
        else if (DropDownList1.SelectedItem.Text == "P5")
        {
            lblp5.BackColor = Color.Green;
            lblp5.Text = "P5 Done";
        }
        else if (DropDownList1.SelectedItem.Text == "P6")
        {
            lblp6.BackColor = Color.Green;
            lblp6.Text = "P6 Done";
        }
        else if (DropDownList1.SelectedItem.Text == "P7")
        {
            lblp7.BackColor = Color.Green;
            lblp7.Text = "P7 Done";
        }
        else if (DropDownList1.SelectedItem.Text == "P8")
        {
            lblp8.BackColor = Color.Green;
            lblp8.Text = "P8 Done";
        }
        else if (DropDownList1.SelectedItem.Text == "P9")
        {
            lblp9.BackColor = Color.Green;
            lblp9.Text = "P9 Done";
        }
        else if (DropDownList1.SelectedItem.Text == "P10")
        {
            lblp10.BackColor = Color.Green;
            lblp10.Text = "P10 Done";
        }
        if (DropDownList1.SelectedItem.Text == "P11")
        {
            lbl11.BackColor = Color.Green;
            lbl11.Text = "P11 Done";
        }
        else if (DropDownList1.SelectedItem.Text == "P12")
        {
            lbl12.BackColor = Color.Green;
            lbl12.Text = "P12 Done";
        }
        else if (DropDownList1.SelectedItem.Text == "P13")
        {
            lbl13.BackColor = Color.Green;
            lbl13.Text = "P13 Done";
        }
        else if (DropDownList1.SelectedItem.Text == "P14")
        {
            lbl14.BackColor = Color.Green;
            lbl14.Text = "P14 Done";
        }
        else if (DropDownList1.SelectedItem.Text == "P15")
        {
            lbl15.BackColor = Color.Green;
            lbl15.Text = "P15 Done";
        }
        else if (DropDownList1.SelectedItem.Text == "P16")
        {
            lbl16.BackColor = Color.Green;
            lbl16.Text = "P16 Done";
        }
        else if (DropDownList1.SelectedItem.Text == "P17")
        {
            lbl17.BackColor = Color.Green;
            lbl17.Text = "P17 Done";
        }
        else if (DropDownList1.SelectedItem.Text == "P18")
        {
            lbl18.BackColor = Color.Green;
            lbl18.Text = "P18 Done";
        }
        else if (DropDownList1.SelectedItem.Text == "P19")
        {
            lbl19.BackColor = Color.Green;
            lbl19.Text = "P19 Done";
        }
        else if (DropDownList1.SelectedItem.Text == "P20")
        {
            lbl20.BackColor = Color.Green;
            lbl20.Text = "P20 Done";
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
colorchange();
data();
        query = "delete from tmprcm";
cmd = new SqlCommand(query, con);
cmd.ExecuteNonQuery();
con.Close();

updaterow();

data();
        query = "select * from updataset where pur1='" + DropDownList1.SelectedItem.Text + "' or pur2='" + DropDownList1.SelectedItem.Text + "' or pur3='" + DropDownList1.SelectedItem.Text + "' or pur4='" + DropDownList1.SelectedItem.Text + "' or pur5='" + DropDownList1.SelectedItem.Text + "' or pur6='" + DropDownList1.SelectedItem.Text + "' or pur7='" + DropDownList1.SelectedItem.Text + "' or pur8='" + DropDownList1.SelectedItem.Text + "' or pur9='" + DropDownList1.SelectedItem.Text + "' or pur10='" + DropDownList1.SelectedItem.Text + "'";
cmd = new SqlCommand(query, con);
SqlDataReaderrd = cmd.ExecuteReader();
        while (rd.Read())
        {
data();
            query = "insert into tmprcm(pur1,pur2,pur3,pur4,pur5,pur6,pur7,pur8,pur9,pur10,cid)values('" + rd[0] + "','" + rd[1] + "','" + rd[2] + "','" + rd[3] + "','" + rd[4] + "','" + rd[5] + "','" + rd[6] + "','" + rd[7] + "','" + rd[8] + "','" + rd[9] + "','" + rd[10] + "')";
cmd = new SqlCommand(query, con);
cmd.ExecuteNonQuery();
con.Close();
cid.Add(rd[10]);
        }
rd.Close();
con.Close();

        for (int i = 0; i<cid.Count; i++)
        {
data();
            query = "select * from tmprcm where cid='" + cid[i] + "'";
cmd = new SqlCommand(query, con);
SqlDataReaderdr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (((dr[0].ToString()) == DropDownList1.SelectedItem.Text))
                {
                }
                else
                {
prod_name.Add(dr[0]);
                }
                if (((dr[1].ToString()) == DropDownList1.SelectedItem.Text))
                {
                }
                else
                {
prod_name.Add(dr[1]);
                }
                if (((dr[2].ToString()) == DropDownList1.SelectedItem.Text))
                {
                }
                else
                {
prod_name.Add(dr[2]);
                }
                if (((dr[3].ToString()) == DropDownList1.SelectedItem.Text))
                {
                }
                else
                {
prod_name.Add(dr[3]);
                }
                if (((dr[4].ToString()) == DropDownList1.SelectedItem.Text))
                {
                }
                else
                {
prod_name.Add(dr[4]);
                }
                if (((dr[5].ToString()) == "") || ((dr[5].ToString()) == DropDownList1.SelectedItem.Text))
                {
                }
                else
                {
prod_name.Add(dr[5]);
                }
                if (((dr[6].ToString()) == "") || ((dr[6].ToString()) == DropDownList1.SelectedItem.Text))
                {
                }
                else
                {
prod_name.Add(dr[6]);
                }
                if (((dr[7].ToString()) == "") || ((dr[7].ToString()) == DropDownList1.SelectedItem.Text))
                {
                }
                else
                {
prod_name.Add(dr[7]);
                }
                if (((dr[8].ToString()) == "") || ((dr[8].ToString()) == DropDownList1.SelectedItem.Text))
                {
                }
                else
                {
prod_name.Add(dr[8]);
                }
                if (((dr[9].ToString()) == "") || ((dr[9].ToString()) == DropDownList1.SelectedItem.Text))
                {
                }
                else
                {
prod_name.Add(dr[9]);
                }




            }
dr.Close();
con.Close();


            for (int j = 0; j <prod_name.Count; j++)
            {
                if (DropDownList1.SelectedItem.Text == "P1")
                {
data();
                    query = "update recommendation set P1=P1+1 where pname='" + prod_name[j] + "'";
cmd = new SqlCommand(query, con);
cmd.ExecuteNonQuery();
con.Close();
                }
                if (DropDownList1.SelectedItem.Text == "P2")
                {
data();
                    query = "update recommendation set P2=P2+1 where pname='" + prod_name[j] + "'";
cmd = new SqlCommand(query, con);
cmd.ExecuteNonQuery();
con.Close();
                }
                if (DropDownList1.SelectedItem.Text == "P3")
                {
data();
                    query = "update recommendation set P3=P3+1 where pname='" + prod_name[j] + "'";
cmd = new SqlCommand(query, con);
cmd.ExecuteNonQuery();
con.Close();
                }
                if (DropDownList1.SelectedItem.Text == "P4")
                {
data();
                    query = "update recommendation set P4=P4+1 where pname='" + prod_name[j] + "'";
cmd = new SqlCommand(query, con);
cmd.ExecuteNonQuery();
con.Close();
                }
                if (DropDownList1.SelectedItem.Text == "P5")
                {
data();
                    query = "update recommendation set P5=P5+1 where pname='" + prod_name[j] + "'";
cmd = new SqlCommand(query, con);
cmd.ExecuteNonQuery();
con.Close();
                }
                if (DropDownList1.SelectedItem.Text == "P6")
                {
data();
                    query = "update recommendation set P6=P6+1 where pname='" + prod_name[j] + "'";
cmd = new SqlCommand(query, con);
cmd.ExecuteNonQuery();
con.Close();
                }
                if (DropDownList1.SelectedItem.Text == "P7")
                {
data();
                    query = "update recommendation set P7=P7+1 where pname='" + prod_name[j] + "'";
cmd = new SqlCommand(query, con);
cmd.ExecuteNonQuery();
con.Close();
                }
                if (DropDownList1.SelectedItem.Text == "P8")
                {
data();
                    query = "update recommendation set P8=P8+1 where pname='" + prod_name[j] + "'";
cmd = new SqlCommand(query, con);
cmd.ExecuteNonQuery();
con.Close();
                }
                if (DropDownList1.SelectedItem.Text == "P9")
                {
data();
                    query = "update recommendation set P9=P9+1 where pname='" + prod_name[j] + "'";
cmd = new SqlCommand(query, con);
cmd.ExecuteNonQuery();
con.Close();
                }
                if (DropDownList1.SelectedItem.Text == "P10")
                {
data();
                    query = "update recommendation set P10=P10+1 where pname='" + prod_name[j] + "'";
cmd = new SqlCommand(query, con);
cmd.ExecuteNonQuery();
con.Close();
                }
                if (DropDownList1.SelectedItem.Text == "P11")
                {
data();
                    query = "update recommendation set P11=P11+1 where pname='" + prod_name[j] + "'";
cmd = new SqlCommand(query, con);
cmd.ExecuteNonQuery();
con.Close();
                }
                if (DropDownList1.SelectedItem.Text == "P12")
                {
data();
                    query = "update recommendation set P12=P12+1 where pname='" + prod_name[j] + "'";
cmd = new SqlCommand(query, con);
cmd.ExecuteNonQuery();
con.Close();
                }
                if (DropDownList1.SelectedItem.Text == "P13")
                {
data();
                    query = "update recommendation set P13=P13+1 where pname='" + prod_name[j] + "'";
cmd = new SqlCommand(query, con);
cmd.ExecuteNonQuery();
con.Close();
                }
                if (DropDownList1.SelectedItem.Text == "P14")
                {
data();
                    query = "update recommendation set P14=P14+1 where pname='" + prod_name[j] + "'";
cmd = new SqlCommand(query, con);
cmd.ExecuteNonQuery();
con.Close();
                }
                if (DropDownList1.SelectedItem.Text == "P15")
                {
data();
                    query = "update recommendation set P15=P15+1 where pname='" + prod_name[j] + "'";
cmd = new SqlCommand(query, con);
cmd.ExecuteNonQuery();
con.Close();
                }
                if (DropDownList1.SelectedItem.Text == "P16")
                {
data();
                    query = "update recommendation set P16=P16+1 where pname='" + prod_name[j] + "'";
cmd = new SqlCommand(query, con);
cmd.ExecuteNonQuery();
con.Close();
                }
                if (DropDownList1.SelectedItem.Text == "P17")
                {
data();
                    query = "update recommendation set P17=P17+1 where pname='" + prod_name[j] + "'";
cmd = new SqlCommand(query, con);
cmd.ExecuteNonQuery();
con.Close();
                }
                if (DropDownList1.SelectedItem.Text == "P18")
                {
data();
                    query = "update recommendation set P18=P18+1 where pname='" + prod_name[j] + "'";
cmd = new SqlCommand(query, con);
cmd.ExecuteNonQuery();
con.Close();
                }
                if (DropDownList1.SelectedItem.Text == "P19")
                {
data();
                    query = "update recommendation set P19=P19+1 where pname='" + prod_name[j] + "'";
cmd = new SqlCommand(query, con);
cmd.ExecuteNonQuery();
con.Close();
                }
                if (DropDownList1.SelectedItem.Text == "P20")
                {
data();
                    query = "update recommendation set P20=P20+1 where pname='" + prod_name[j] + "'";
cmd = new SqlCommand(query, con);
cmd.ExecuteNonQuery();
con.Close();
                }

            }

prod_name.Clear();

        }
grd();
       // GridView1.DataBind();

        if ((lbl11.BackColor == Color.Green) && (lbl12.BackColor == Color.Green) && (lbl13.BackColor == Color.Green) && (lbl14.BackColor == Color.Green) && (lbl15.BackColor == Color.Green) && (lbl16.BackColor == Color.Green) &&(lbl17.BackColor == Color.Green) && (lbl18.BackColor == Color.Green) && (lbl19.BackColor == Color.Green) && (lbl20.BackColor == Color.Green))
        {


            if ((lblp1.BackColor == Color.Green) && (lblp2.BackColor == Color.Green) && (lblp3.BackColor == Color.Green) && (lblp4.BackColor == Color.Green) && (lblp5.BackColor == Color.Green) && (lblp6.BackColor == Color.Green) && (lblp7.BackColor == Color.Green) && (lblp8.BackColor == Color.Green) && (lblp9.BackColor == Color.Green) && (lblp10.BackColor == Color.Green))
            {
                GridView1.Visible = true;
            }
            else
            {
                GridView1.Visible = false;
               // MessageBox.Show("Process All Products to view Recommendation!!!");
            }
        }
        else
        {
            GridView1.Visible = false;
            //MessageBox.Show("Process All Products to view Recommendation!!!");
        }
    }
    public void updaterow()
    {
        if (DropDownList1.SelectedItem.Text == "P1")
        {
data();
            query = "update recommendation set P1=0";
cmd = new SqlCommand(query, con);
cmd.ExecuteNonQuery();
con.Close();
        }
        if (DropDownList1.SelectedItem.Text == "P2")
        {
data();
            query = "update recommendation set P2=0";
cmd = new SqlCommand(query, con);
cmd.ExecuteNonQuery();
con.Close();
        }
        if (DropDownList1.SelectedItem.Text == "P3")
        {
data();
            query = "update recommendation set P3=0";
cmd = new SqlCommand(query, con);
cmd.ExecuteNonQuery();
con.Close();
        }
        if (DropDownList1.SelectedItem.Text == "P4")
        {
data();
            query = "update recommendation set P4=0";
cmd = new SqlCommand(query, con);
cmd.ExecuteNonQuery();
con.Close();
        }
        if (DropDownList1.SelectedItem.Text == "P5")
        {
data();
            query = "update recommendation set P5=0";
cmd = new SqlCommand(query, con);
cmd.ExecuteNonQuery();
con.Close();
        }
        if (DropDownList1.SelectedItem.Text == "P6")
        {
data();
            query = "update recommendation set P6=0";
cmd = new SqlCommand(query, con);
cmd.ExecuteNonQuery();
con.Close();
        }
        if (DropDownList1.SelectedItem.Text == "P7")
        {
data();
            query = "update recommendation set P7=0";
cmd = new SqlCommand(query, con);
cmd.ExecuteNonQuery();
con.Close();
        }
        if (DropDownList1.SelectedItem.Text == "P8")
        {
data();
            query = "update recommendation set P8=0";
cmd = new SqlCommand(query, con);
cmd.ExecuteNonQuery();
con.Close();
        }
        if (DropDownList1.SelectedItem.Text == "P9")
        {
data();
            query = "update recommendation set P9=0";
cmd = new SqlCommand(query, con);
cmd.ExecuteNonQuery();
con.Close();
        }
        if (DropDownList1.SelectedItem.Text == "P10")
        {
data();
            query = "update recommendation set P10=0";
cmd = new SqlCommand(query, con);
cmd.ExecuteNonQuery();
con.Close();
        }
        if (DropDownList1.SelectedItem.Text == "P11")
        {
data();
            query = "update recommendation set P11=0";
cmd = new SqlCommand(query, con);
cmd.ExecuteNonQuery();
con.Close();
        }
        if (DropDownList1.SelectedItem.Text == "P12")
        {
data();
            query = "update recommendation set P12=0";
cmd = new SqlCommand(query, con);
cmd.ExecuteNonQuery();
con.Close();
        }
        if (DropDownList1.SelectedItem.Text == "P13")
        {
data();
            query = "update recommendation set P13=0";
cmd = new SqlCommand(query, con);
cmd.ExecuteNonQuery();
con.Close();
        }
        if (DropDownList1.SelectedItem.Text == "P14")
        {
data();
            query = "update recommendation set P14=0";
cmd = new SqlCommand(query, con);
cmd.ExecuteNonQuery();
con.Close();
        }
        if (DropDownList1.SelectedItem.Text == "P15")
        {
data();
            query = "update recommendation set P15=0";
cmd = new SqlCommand(query, con);
cmd.ExecuteNonQuery();
con.Close();
        }
        if (DropDownList1.SelectedItem.Text == "P16")
        {
data();
            query = "update recommendation set P16=0";
cmd = new SqlCommand(query, con);
cmd.ExecuteNonQuery();
con.Close();
        }
        if (DropDownList1.SelectedItem.Text == "P17")
        {
data();
            query = "update recommendation set P17=0";
cmd = new SqlCommand(query, con);
cmd.ExecuteNonQuery();
con.Close();
        }
        if (DropDownList1.SelectedItem.Text == "P18")
        {
data();
            query = "update recommendation set P18=0";
cmd = new SqlCommand(query, con);
cmd.ExecuteNonQuery();
con.Close();
        }
        if (DropDownList1.SelectedItem.Text == "P19")
        {
data();
            query = "update recommendation set P19=0";
cmd = new SqlCommand(query, con);
cmd.ExecuteNonQuery();
con.Close();
        }
        if (DropDownList1.SelectedItem.Text == "P20")
        {
data();
            query = "update recommendation set P20=0";
cmd = new SqlCommand(query, con);
cmd.ExecuteNonQuery();
con.Close();
        }

    }
    public void grd()
    {
        GridView1.DataBind();
        for (int k = 0; k <GridView1.Rows.Count; k++)
        {
            if (GridView1.Rows[k].Cells[1].Text != "0")
            {
                GridView1.Rows[k].Cells[1].ForeColor = Color.Red;
            }
            if (GridView1.Rows[k].Cells[2].Text != "0")
            {
                GridView1.Rows[k].Cells[2].ForeColor = Color.Red;
            }
            if (GridView1.Rows[k].Cells[3].Text != "0")
            {
                GridView1.Rows[k].Cells[3].ForeColor = Color.Red;
            }
            if (GridView1.Rows[k].Cells[4].Text != "0")
            {
                GridView1.Rows[k].Cells[4].ForeColor = Color.Red;
            }
            if (GridView1.Rows[k].Cells[5].Text != "0")
            {
                GridView1.Rows[k].Cells[5].ForeColor = Color.Red;
            }
            if (GridView1.Rows[k].Cells[6].Text != "0")
            {
                GridView1.Rows[k].Cells[6].ForeColor = Color.Red;
            }
            if (GridView1.Rows[k].Cells[7].Text != "0")
            {
                GridView1.Rows[k].Cells[7].ForeColor = Color.Red;
            }
            if (GridView1.Rows[k].Cells[8].Text != "0")
            {
                GridView1.Rows[k].Cells[8].ForeColor = Color.Red;
            }
            if (GridView1.Rows[k].Cells[9].Text != "0")
            {
                GridView1.Rows[k].Cells[9].ForeColor = Color.Red;
            }
            if (GridView1.Rows[k].Cells[10].Text != "0")
            {
                GridView1.Rows[k].Cells[10].ForeColor = Color.Red;
            }
            if (GridView1.Rows[k].Cells[11].Text != "0")
            {
                GridView1.Rows[k].Cells[11].ForeColor = Color.Red;
            }
            if (GridView1.Rows[k].Cells[12].Text != "0")
            {
                GridView1.Rows[k].Cells[12].ForeColor = Color.Red;
            }
            if (GridView1.Rows[k].Cells[13].Text != "0")
            {
                GridView1.Rows[k].Cells[13].ForeColor = Color.Red;
            }
            if (GridView1.Rows[k].Cells[14].Text != "0")
            {
                GridView1.Rows[k].Cells[14].ForeColor = Color.Red;
            }
            if (GridView1.Rows[k].Cells[15].Text != "0")
            {
                GridView1.Rows[k].Cells[15].ForeColor = Color.Red;
            }
            if (GridView1.Rows[k].Cells[16].Text != "0")
            {
                GridView1.Rows[k].Cells[16].ForeColor = Color.Red;
            }
            if (GridView1.Rows[k].Cells[17].Text != "0")
            {
                GridView1.Rows[k].Cells[17].ForeColor = Color.Red;
            }
            if (GridView1.Rows[k].Cells[18].Text != "0")
            {
                GridView1.Rows[k].Cells[18].ForeColor = Color.Red;
            }
            if (GridView1.Rows[k].Cells[19].Text != "0")
            {
                GridView1.Rows[k].Cells[19].ForeColor = Color.Red;
            }
            if (GridView1.Rows[k].Cells[20].Text != "0")
            {
                GridView1.Rows[k].Cells[20].ForeColor = Color.Red;
            }
        }
    }


}
