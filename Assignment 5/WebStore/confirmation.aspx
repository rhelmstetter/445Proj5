<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="confirmation.aspx.cs" Inherits="confirmation" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" Runat="Server">
    <h1> CONGRATULATIONS </h1>
    <h3> On the purchase of your new feathery or furry friend!<br />
         You Bought:  <asp:Label ID="lblPetBough" runat="server" Text="Label"></asp:Label> </h3> <br />

         You are a hero to your pet! For luck here is your thought of the day: <asp:Label ID="lblFortune" runat="server" Text="Label"></asp:Label>  <br />



</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" Runat="Server">
    <h5>We are located at:</h5>
    
    <h4> <b>
    699 S. Mill Ave.
    Tempe, AZ 85281
    </b></h4>

    <center>
        <h5> Enter your address below to get direction<br />
            to our shelter to pick up your new friend</h5>
        <br />
        <b> <table>
            <tr>
                <td>Address:</td>
                <td> <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox> <br /></td> </tr>
            <tr>
                <td>City:</td>
                <td> <asp:TextBox ID="txtInputCity" runat="server"></asp:TextBox> <br /> </td></tr>
            <tr>
                <td>State:</td>
                <td> <asp:TextBox ID="txtInputState" runat="server"></asp:TextBox> </td></tr>
        </table> </b>
        <br />

        <asp:Button ID="btnGetDirections" runat="server" Text="Get Directions" OnClick="btnGetDirections_Click" />
        <br />
    

        <br />
        <br />
        <asp:GridView ID="gvDrivingDirections" runat="server" CellPadding="4" onrowdatabound="gvDrivingDirections_DataRowBound" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" />
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>
        <br />
        <asp:Label ID="lblDistance" runat="server" Text="Label" Visible="False"></asp:Label>
    

    <br />
        <asp:Label ID="lblTime" runat="server" Text="Label" Visible="False"></asp:Label>
        <br />
        <br />
    <br />

    </center>

</asp:Content>