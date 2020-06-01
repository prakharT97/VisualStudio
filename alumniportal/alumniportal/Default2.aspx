<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

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
    <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
    
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    
    <asp:TextBox ID="TextBox1" runat="server" Width="162px"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Name is Required"></asp:RequiredFieldValidator>
    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Name should be letters only" ValidationExpression="^[A-Za-z]+$"></asp:RegularExpressionValidator>
    <br />
    <br />
    <asp:Label ID="Label2" runat="server" Text="Branch"></asp:Label>
    
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    
    <asp:TextBox ID="TextBox2" runat="server" Width="161px"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="Label3" runat="server" Text="Password"></asp:Label>
    
    &nbsp;&nbsp;&nbsp;&nbsp;
    
    <asp:TextBox ID="TextBox3" runat="server" TextMode="Password" Width="157px"></asp:TextBox>
    
    <asp:RequiredFieldValidator runat="server" ControlToValidate="TextBox3" ErrorMessage="Password is a req field"></asp:RequiredFieldValidator>
    
    <br />
    <br />
    <asp:Label ID="Label4" runat="server" Text="Company"></asp:Label>
    
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    
    <asp:TextBox ID="TextBox4" runat="server" Width="152px"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="Label5" runat="server" Text="Year"></asp:Label>
    
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    
    <asp:TextBox ID="TextBox5" runat="server" Width="150px"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox5" ErrorMessage="Year is required"></asp:RequiredFieldValidator>
    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="TextBox5" ErrorMessage="Year should contain digits only" ValidationExpression="^[0-9]{1,10}$"></asp:RegularExpressionValidator>
    <br />
    <br />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button1" runat="server" Text="Register" OnClick="Button1_Click" />
</asp:Content>

