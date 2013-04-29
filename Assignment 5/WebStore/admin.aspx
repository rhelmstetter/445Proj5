<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="admin.aspx.cs" Inherits="admin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" Runat="Server">
    <p><center style="margin-left: 40px">
    
        List of available pets<br />
&nbsp;<asp:ListBox ID="petBox" runat="server" Height="179px" Width="374px" ViewStateMode="Enabled"></asp:ListBox>
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Delete Pet" Width="145px" />
        <br />
        <br />
        Add a new pet to be listed:<br />
        <br />
        Type
        <asp:RadioButtonList ID="typeRadio" runat="server" Height="18px" RepeatDirection="Horizontal" Width="330px">
            <asp:ListItem>Dog</asp:ListItem>
            <asp:ListItem>Bird</asp:ListItem>
            <asp:ListItem>Cat</asp:ListItem>
        </asp:RadioButtonList>
        Breed (Dog and Cat Only):<br />
        <asp:TextBox ID="breedBox" runat="server" Width="260px"></asp:TextBox>
        <br />
        Type (Bird Only):<br />
        <asp:TextBox ID="typeBox" runat="server" Width="261px"></asp:TextBox>
        <br />
        Color (Dog and Cat Only):<br />
        <asp:TextBox ID="colorBox" runat="server" Width="261px"></asp:TextBox>
        <br />
        Weight (Bird Only):<br />
        <asp:TextBox ID="weightBox" runat="server" Width="262px"></asp:TextBox>
        <br />
        ID:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="idBox" runat="server" Width="141px"></asp:TextBox>
        <br />
        Age:&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="ageBox" runat="server" Width="141px"></asp:TextBox>
        <br />
        Price:&nbsp;&nbsp;
        <asp:TextBox ID="priceBox" runat="server" Width="141px"></asp:TextBox>
        <br />
        Descr:&nbsp;
        <asp:TextBox ID="descBox" runat="server" TextMode="MultiLine" Width="485px"></asp:TextBox>
        <br />
&nbsp;
        <asp:Button ID="Button2" runat="server" Text="Add Pet" Width="132px" OnClick="Button2_Click" />
        <br />
        <br />
        <br />
        
    </center></p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
</asp:Content>

