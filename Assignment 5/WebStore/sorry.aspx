<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="sorry.aspx.cs" Inherits="sorry" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" Runat="Server">
<h2>Lost in cyperspace! </h2>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" Runat="Server">

    <center> <h3>
        <asp:Image ID="imgLostInfo" runat="server" Height="123px" Width="139px" ImageUrl="~/Images/SorryCat.jpg" /> <br /> <br />
        OH NO! I haz lost ur information on the pet you wanted to buy! <br />
        Pleaze go to <a href="Default.aspx"> This Page </a> to select ur pet again. <br />
        I iz sorry for the inconvenience... <br />
    </h3></center>



</asp:Content>

