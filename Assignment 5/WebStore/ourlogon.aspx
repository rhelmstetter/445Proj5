<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ourlogon.aspx.cs" Inherits="ourlogon" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" Runat="Server">

    <h3>UserName</h3><br />
    <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>

<h3>Password</h3>
    <asp:TextBox TextMode="Password" ID="txtPassword" runat="server"></asp:TextBox>

    <asp:Button ID="btnLogon" runat="server" Text="Log In" OnClick="btnLogon_Click" />

<br />
<br />
<asp:Label ID="lblErro" runat="server" ForeColor="#990000" Text="Label" Visible="False"></asp:Label>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" Runat="Server">
</asp:Content>

