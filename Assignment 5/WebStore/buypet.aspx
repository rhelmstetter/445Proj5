<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="buypet.aspx.cs" Inherits="buypet" %>



<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" Runat="Server">
    <h2> Buy your Pet </h2>
    
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" Runat="Server">
    <table>
    <tr> 
        <td><asp:Image ID="imgPetPic" runat="server" Height="123px" Width="139px" />  </td>   
        <td>
            <h3> <asp:Label ID="lblAnimalInfo" runat="server" Text="Label"></asp:Label> </h3> </td>
    </tr>
</table>&nbsp;<center>
            <br />

            <br />
            <table>
                <tr>
                    <td><asp:Button ID="btnBuy" runat="server" Text="BUY YOUR PET!" OnClick="btnBuy_Click"></asp:Button></td>
                    <td><asp:Button ID="btnCancel" runat="server" Text="Back to listings" OnClick="btnCancel_Click"></asp:Button></td>
                </tr>
            </table>
        </center>
    </p>
</asp:Content>