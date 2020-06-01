<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

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
    
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    
</asp:Content>

