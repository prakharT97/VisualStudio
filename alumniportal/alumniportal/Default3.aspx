<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default3.aspx.cs" Inherits="Default3" %>

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
    <asp:Label ID="Label1" runat="server" Text="Rating"></asp:Label>
    
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>

    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

    <asp:Button ID="Button2" runat="server" Text="AutoFill" OnClick="Button2_Click" />

    <br />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    
</asp:Content>

