using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default5 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        HyperLink1.NavigateUrl = "Default2.aspx";
        HyperLink2.NavigateUrl = "Default4.aspx";
        HyperLink3.NavigateUrl = "Default6.aspx";
        Image1.Attributes.Add("width", "500");
        Image1.Attributes.Add("height", "200");
        HttpCookie c = Request.Cookies["Names"];
        
            
           string lab = c["Names1"];
        
        Label1.Text = "WELCOME " + lab;

        if (!IsPostBack) {

            if (Session["Theme"] != null) {

                DropDownList1.Items.FindByText(Session["Theme"].ToString()).Selected = true; 

            }

        }
    }

    protected void Page_PreInit(object semder, EventArgs e) {

        if (Session["Theme"] != null) {

            Page.Theme = Session["Theme"].ToString();
        }
    }


    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        Session["Theme"] = DropDownList1.SelectedValue;
        Server.Transfer(Request.FilePath);
    }
}