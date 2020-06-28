using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Web.Configuration;
public partial class index :System.Web.UI.Page
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
    public void datafun()
    {


        for (int i = 1; i<= 100; i++)
        {
            int A = random(11, 20);
            int B = random(1, 10);
            int C = random(2, 11);
            int D = random(8, 20);
data();
            query = "insert into dataset(v1)values('" + 'P' + A + "')";
            //query = "insert into dataset(v1,v2,v3,v4)values('" + 'P' + A + "','" + 'P' + B + "','" + 'P' + C + "','" + 'P' + D + "')";
cmd = new SqlCommand(query, con);
cmd.ExecuteNonQuery();
con.Close();

data();
            query = "insert into dataset(v1)values('" + 'P' + B + "')";
            //query = "insert into dataset(v1,v2,v3,v4)values('" + 'P' + A + "','" + 'P' + B + "','" + 'P' + C + "','" + 'P' + D + "')";
cmd = new SqlCommand(query, con);
cmd.ExecuteNonQuery();
con.Close();

data();
            query = "insert into dataset(v1)values('" + 'P' + C + "')";
            //query = "insert into dataset(v1,v2,v3,v4)values('" + 'P' + A + "','" + 'P' + B + "','" + 'P' + C + "','" + 'P' + D + "')";
cmd = new SqlCommand(query, con);
cmd.ExecuteNonQuery();
con.Close();

data();
            query = "insert into dataset(v1)values('" + 'P' + D + "')";
            //query = "insert into dataset(v1,v2,v3,v4)values('" + 'P' + A + "','" + 'P' + B + "','" + 'P' + C + "','" + 'P' + D + "')";
cmd = new SqlCommand(query, con);
cmd.ExecuteNonQuery();
con.Close();

        }


    }
    public void f1()
    {
        for (int i = 1; i<= 100; i++)
        {
            int A = random(1, 20);
            int B = random(1, 20);
            int C = random(1, 20);
            int D = random(1, 20);
data();
            query = "insert into dataset(v1)values('" + 'P' + A + "')";
            //query = "insert into dataset(v1,v2,v3,v4)values('" + 'P' + A + "','" + 'P' + B + "','" + 'P' + C + "','" + 'P' + D + "')";
cmd = new SqlCommand(query, con);
cmd.ExecuteNonQuery();
con.Close();
        }
    }
    public void f2()
    {
        for (int i = 1; i<= 100; i++)
        {
            int A = random(1, 20);
            int B = random(1, 20);
            int C = random(1, 20);
            int D = random(1, 20);
data();
            query = "insert into dataset(v1)values('" + 'P' + A + "')";
            //query = "insert into dataset(v1,v2,v3,v4)values('" + 'P' + A + "','" + 'P' + B + "','" + 'P' + C + "','" + 'P' + D + "')";
cmd = new SqlCommand(query, con);
cmd.ExecuteNonQuery();
con.Close();
        }
    }
    public void f3()
    {
        for (int i = 1; i<= 100; i++)
        {
            int A = random(1, 20);
            int B = random(1, 20);
            int C = random(1, 20);
            int D = random(1, 20);
data();
            query = "insert into dataset(v1)values('" + 'P' + A + "')";
            //query = "insert into dataset(v1,v2,v3,v4)values('" + 'P' + A + "','" + 'P' + B + "','" + 'P' + C + "','" + 'P' + D + "')";
cmd = new SqlCommand(query, con);
cmd.ExecuteNonQuery();
con.Close();
        }
    }
    public void f4()
    {
        for (int i = 1; i<= 1000; i++)
        {

data();
            query = "insert into dataset(v1)values('" + i + "')";
            //query = "insert into dataset(v1,v2,v3,v4)values('" + 'P' + A + "','" + 'P' + B + "','" + 'P' + C + "','" + 'P' + D + "')";
cmd = new SqlCommand(query, con);
cmd.ExecuteNonQuery();
con.Close();
        }
    }
    public int random(int min, int max)
    {
        Random random = new Random();
        return random.Next(min, max);
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
datafun();
data();
        query = "select count(v1) from dataset";
cmd = new SqlCommand(query, con);
SqlDataReaderrd = cmd.ExecuteReader();
        while (rd.Read())
        {
            Button1.Text = rd[0].ToString();
        }
rd.Close();
con.Close();
        //f1();
        //f2();
        //f3();
       // f4();
    }
}




