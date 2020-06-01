using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

public partial class Default3 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        HyperLink1.NavigateUrl = "Default2.aspx";
        HyperLink2.NavigateUrl = "Default4.aspx";
        HyperLink3.NavigateUrl = "Default6.aspx";
        string lab = Request.QueryString["val"];
        Label1.Text = "Rating for " + lab;
        SqlConnection con = new SqlConnection();
        con.ConnectionString = @"Data Source=(localdb)\MSSQLlocalDB;Initial Catalog=tempdb;Integrated Security=True";
        try
        {
            con.Open();
            
            
            
           


        }
        catch (Exception ex) { }
        finally { con.Close(); }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection();
        con.ConnectionString = @"Data Source=(localdb)\MSSQLlocalDB;Initial Catalog=tempdb;Integrated Security=True";
        try
        {
            con.Open();
            

            if (TextBox1.Text.Equals("go"))
            {
                SqlCommand command = new SqlCommand("SELECT ratings from autorate WHERE ratings=@x", con);
                command.Parameters.AddWithValue(@"x", "good");
               
                SqlDataReader reader;
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    TextBox1.Text = reader["ratings"].ToString();
                }
            }
            else if (TextBox1.Text.Equals("ba"))
            {
                SqlCommand command = new SqlCommand("SELECT ratings from autorate WHERE ratings=@x", con);
                command.Parameters.AddWithValue(@"x", "bad");
                SqlDataReader reader;
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    TextBox1.Text = reader["ratings"].ToString();
                }
            }
            else if (TextBox1.Text.Equals("ex"))
            {
                SqlCommand command = new SqlCommand("SELECT ratings from autorate WHERE ratings=@x", con);
                command.Parameters.AddWithValue(@"x", "excellent");
                SqlDataReader reader;
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    TextBox1.Text = reader["ratings"].ToString();
                }
            }
            else if (TextBox1.Text.Equals("av"))
            {
                SqlCommand command = new SqlCommand("SELECT ratings from autorate WHERE ratings=@x", con);
                command.Parameters.AddWithValue(@"x", "average");
                SqlDataReader reader;
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    TextBox1.Text = reader["ratings"].ToString();
                }
            }



        }
        catch (Exception ex) { }
        finally { con.Close(); }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string lab = Request.QueryString["val"];
        Console.WriteLine(lab);
        SqlConnection con = new SqlConnection();
        con.ConnectionString = @"Data Source=(localdb)\MSSQLlocalDB;Initial Catalog=tempdb;Integrated Security=True";
        try
        {
            con.Open();
            SqlCommand command = new SqlCommand("update stud set survey=@p where student_name=@q", con);
            command.Parameters.AddWithValue(@"p", TextBox1.Text.ToString());
            command.Parameters.AddWithValue(@"q", lab);
            command.ExecuteNonQuery();
        }
        catch (Exception ex) { }
        finally { con.Close(); }
        Response.Redirect("Default2.aspx");
       
    }
}