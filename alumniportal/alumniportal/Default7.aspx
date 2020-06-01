<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default7.aspx.cs" Inherits="Default7" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <asp:Label ID="mainl" runat="server" Text="ALUMNI PORTAL" Font-Italic="true" Font-Bold="true"></asp:Label>

    <br />
    <br />
    <asp:HyperLink ID="HyperLink1" runat="server">Register</asp:HyperLink>
        <asp:HyperLink ID="HyperLink2" runat="server">Signin</asp:HyperLink>
    <asp:HyperLink ID="HyperLink3" runat="server">Admin Signin</asp:HyperLink>
    <br />
    <br />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:GridView ID="GridView3" runat="server">
</asp:GridView>
    <br />
<asp:GridView ID="GridView4" runat="server" OnSelectedIndexChanged="GridView4_SelectedIndexChanged">
</asp:GridView>
    <br />
<asp:GridView ID="GridView5" runat="server">
</asp:GridView>
    <br />
<asp:GridView ID="GridView6" runat="server">
</asp:GridView>
    <br />
    <br />
<asp:DropDownList ID="DropDownList3" runat="server">
</asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="FilterByYear" />
    <br />
    <br />
<asp:DropDownList ID="DropDownList2" runat="server">
</asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="FilterByCompany" />
    <br />
    <br />
<asp:DropDownList ID="DropDownList1" runat="server">
</asp:DropDownList>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button2" runat="server" Text="FilterByBranch" OnClick="Button2_Click" />
    
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    

    
    

</asp:Content>

