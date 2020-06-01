using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

public partial class Default6 : System.Web.UI.Page
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
            SqlCommand command = new SqlCommand("SELECT * from adtab where adname=@x AND adpass=@y", con);
            command.Parameters.AddWithValue(@"x", TextBox1.Text.ToString());
            command.Parameters.AddWithValue(@"y", TextBox2.Text.ToString());
            if (command.ExecuteScalar() != null)
            {
                Response.Redirect("Default7.aspx");
            }
            else {
                Label3.Text = "Invalid credentials";
            }
        }
        catch (Exception ex) { }
        finally { con.Close(); }
    }
}