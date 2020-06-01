using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        HyperLink1.NavigateUrl = "Default2.aspx";
        HyperLink2.NavigateUrl = "Default4.aspx";
        HyperLink3.NavigateUrl = "Default6.aspx";
    }
}