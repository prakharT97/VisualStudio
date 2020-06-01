using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        HyperLink1.NavigateUrl = "Default2.aspx";
        HyperLink2.NavigateUrl = "Default4.aspx";
        HyperLink3.NavigateUrl = "Default6.aspx";
        SqlConnection con = new SqlConnection();
        con.ConnectionString = @"Data Source=(localdb)\MSSQLlocalDB;Initial Catalog=tempdb;Integrated Security=True";
        try
        {
            con.Open();
            
        }
        catch (Exception ex) { }
        finally { con.Close(); }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection();
        
        con.ConnectionString = @"Data Source=(localdb)\MSSQLlocalDB;Initial Catalog=tempdb;Integrated Security=True";
        try
        {
            con.Open();
            SqlCommand command = new SqlCommand("insert into stud(student_name,branch,password,company,year) values (@x,@y,@z,@p,@q)", con);
            command.Parameters.AddWithValue(@"x", TextBox1.Text.ToString());
            command.Parameters.AddWithValue(@"y", TextBox2.Text.ToString());
            command.Parameters.AddWithValue(@"z", TextBox3.Text.ToString());
            command.Parameters.AddWithValue(@"p", TextBox4.Text.ToString());
            command.Parameters.AddWithValue(@"q", TextBox5.Text.ToString());

            command.ExecuteNonQuery();
            SqlDataReader reader;
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                
            }
            
        }
        catch (Exception ex) { }
        finally { con.Close(); }
        string url1 = "Default3.aspx?";
        url1 += "val=" + TextBox1.Text;
        Response.Redirect(url1);
    }

}
