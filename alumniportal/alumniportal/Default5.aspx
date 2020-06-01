<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" Theme="SkinFile1"  AutoEventWireup="true" CodeFile="Default5.aspx.cs" Inherits="Default5" %>

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
    <asp:Label ID="Label1" runat="server" Text="" SkinID="sk3"></asp:Label>
    <br />
    <br />
    <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" SkinID="sk2" AutoPostBack="true">
    <asp:ListItem>SkinFile1</asp:ListItem>
    <asp:ListItem>SkinFile2</asp:ListItem>
</asp:DropDownList>
    <br />
    <br />
    <asp:Image ID="Image1" runat="server" SkinID="sk4"/>
    
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
   
</asp:Content>

