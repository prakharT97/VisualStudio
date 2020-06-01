using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

public partial class Default7 : System.Web.UI.Page
{
   
    protected void Page_Load(object sender, EventArgs e)
    {
        HyperLink1.NavigateUrl = "Default2.aspx";
        HyperLink2.NavigateUrl = "Default4.aspx";
        HyperLink3.NavigateUrl = "Default6.aspx";
        
        if (!IsPostBack)
        {
            DropDownList1.Items.Add("CSE");
            DropDownList1.Items.Add("CCE");
            DropDownList1.Items.Add("IT");
            DropDownList2.Items.Add("IBM");
            DropDownList2.Items.Add("Phillips");
            DropDownList2.Items.Add("TCS");
            DropDownList3.Items.Add("2008");
            DropDownList3.Items.Add("2009");
            DropDownList3.Items.Add("2010");
            DropDownList3.Items.Add("2011");
            DropDownList3.Items.Add("2012");
            DropDownList3.Items.Add("2013");
            DropDownList3.Items.Add("2014");
            DropDownList3.Items.Add("2015");
            DropDownList3.Items.Add("2016");
            DropDownList3.Items.Add("2017");
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=tempdb;Integrated Security=True;
Pooling=False";
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from stud", con);
                SqlDataReader reader;
                reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("Column1");
                dt.Columns.Add("Column2");
                dt.Columns.Add("Column3");
                dt.Columns.Add("Column4");
                dt.Columns.Add("Column5");
                dt.Columns.Add("Column6");
                while (reader.Read())
                {
                    
                    DataRow dr = dt.NewRow();
                    dr["Column1"] = reader["student_name"].ToString();
                    dr["Column2"] = reader["branch"].ToString();
                    dr["Column3"] = reader["password"].ToString();
                    dr["Column4"] = reader["company"].ToString();
                    dr["Column5"] = reader["year"].ToString();
                    dr["Column6"] = reader["survey"].ToString();
                    dt.Rows.Add(dr);
                   
                    //string[] row1 = new string[] {reader["student_name"].ToString(), reader["branch"].ToString(),
                    //    reader["password"].ToString() };
                    
                }
                GridView4.DataSource = dt;
                GridView4.DataBind();
            }
            catch(Exception ex)
            {

            }
            finally
            {
                con.Close();
            }
        }
    }

    protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection();
        con.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=tempdb;Integrated Security=True;
Pooling=False";
        try
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from stud where branch=@branch", con);
            cmd.Parameters.AddWithValue(@"branch", DropDownList1.SelectedItem.Text);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Column1");
            dt.Columns.Add("Column2");
            dt.Columns.Add("Column3");
            dt.Columns.Add("Column4");
            dt.Columns.Add("Column5");
            dt.Columns.Add("Column6");
            while (reader.Read())
            {

                DataRow dr = dt.NewRow();
                dr["Column1"] = reader["student_name"].ToString();
                dr["Column2"] = reader["branch"].ToString();
                dr["Column3"] = reader["password"].ToString();
                dr["Column4"] = reader["company"].ToString();
                dr["Column5"] = reader["year"].ToString();
                dr["Column6"] = reader["survey"].ToString();
                dt.Rows.Add(dr);

                //string[] row1 = new string[] {reader["student_name"].ToString(), reader["branch"].ToString(),
                //    reader["password"].ToString() };

            }
            GridView3.DataSource = dt;
            GridView3.DataBind();
        }
        catch (Exception ex)
        {

        }
        finally
        {
            con.Close();
        }
    }


    protected void Button3_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection();
        con.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=tempdb;Integrated Security=True;
Pooling=False";
        try
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from stud where company=@cmpny", con);
            cmd.Parameters.AddWithValue(@"cmpny", DropDownList2.SelectedItem.Text);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Column1");
            dt.Columns.Add("Column2");
            dt.Columns.Add("Column3");
            dt.Columns.Add("Column4");
            dt.Columns.Add("Column5");
            dt.Columns.Add("Column6");
            while (reader.Read())
            {

                DataRow dr = dt.NewRow();
                dr["Column1"] = reader["student_name"].ToString();
                dr["Column2"] = reader["branch"].ToString();
                dr["Column3"] = reader["password"].ToString();
                dr["Column4"] = reader["company"].ToString();
                dr["Column5"] = reader["year"].ToString();
                dr["Column6"] = reader["survey"].ToString();
                dt.Rows.Add(dr);

                //string[] row1 = new string[] {reader["student_name"].ToString(), reader["branch"].ToString(),
                //    reader["password"].ToString() };

            }
            GridView3.DataSource = dt;
            GridView3.DataBind();
        }
        catch (Exception ex)
        {

        }
        finally
        {
            con.Close();
        }
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection();
        con.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=tempdb;Integrated Security=True;
Pooling=False";
        try
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from stud where year=@year", con);
            cmd.Parameters.AddWithValue(@"year", DropDownList3.SelectedItem.Text);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Column1");
            dt.Columns.Add("Column2");
            dt.Columns.Add("Column3");
            dt.Columns.Add("Column4");
            dt.Columns.Add("Column5");
            dt.Columns.Add("Column6");
            while (reader.Read())
            {

                DataRow dr = dt.NewRow();
                dr["Column1"] = reader["student_name"].ToString();
                dr["Column2"] = reader["branch"].ToString();
                dr["Column3"] = reader["password"].ToString();
                dr["Column4"] = reader["company"].ToString();
                dr["Column5"] = reader["year"].ToString();
                dr["Column6"] = reader["survey"].ToString();
                dt.Rows.Add(dr);

                //string[] row1 = new string[] {reader["student_name"].ToString(), reader["branch"].ToString(),
                //    reader["password"].ToString() };

            }
            GridView3.DataSource = dt;
            GridView3.DataBind();
        }
        catch (Exception ex)
        {

        }
        finally
        {
            con.Close();
        }
    }

    protected void GridView4_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}