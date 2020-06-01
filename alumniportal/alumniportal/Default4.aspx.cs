using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

public partial class Default4 : System.Web.UI.Page
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
        HttpCookie mycookie = new HttpCookie("Names");
        
        con.ConnectionString = @"Data Source=(localdb)\MSSQLlocalDB;Initial Catalog=tempdb;Integrated Security=True";
        try
        {
            
            con.Open();
            SqlCommand command = new SqlCommand("SELECT * from stud where student_name=@x AND password=@y", con);
            SqlCommand command2 = new SqlCommand("insert into stud_details(student_name,branch) values(@p,@q)", con);
            command.Parameters.AddWithValue(@"x", TextBox1.Text);
            command.Parameters.AddWithValue(@"y", TextBox2.Text);
            command2.Parameters.AddWithValue(@"p", TextBox1.Text.ToString());
            command2.Parameters.AddWithValue(@"q", TextBox2.Text.ToString());
           
            if (command.ExecuteScalar()!=null)
            {

                
                mycookie["Names1"] = TextBox1.Text;
                Response.Cookies.Add(mycookie);
                //command2.ExecuteNonQuery();

                Response.Redirect("Default5.aspx");
           }
            else {
                Label3.Text = "Invalid user";
            }

        }
        catch (Exception ex) { }
        finally { con.Close(); }
    }
}