<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="admin.aspx.cs" Inherits="admin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" Runat="Server">
    <p><center style="margin-left: 40px">
    
        List of available pets<br />
&nbsp;<asp:ListBox ID="ListBox1" runat="server" Height="179px" Width="374px"></asp:ListBox>
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" Text="Delete Pet" Width="145px" />
        <br />
        <br />
        Add a new pet to be listed:<br />
        <br />
        Type
        <asp:RadioButtonList ID="RadioButtonList1" runat="server" Height="18px" RepeatDirection="Horizontal" Width="330px">
            <asp:ListItem>Dog</asp:ListItem>
            <asp:ListItem>Bird</asp:ListItem>
            <asp:ListItem>Cat</asp:ListItem>
        </asp:RadioButtonList>
        Breed (Dog and Cat Only):<br />
        <asp:TextBox ID="TextBox1" runat="server" Width="260px"></asp:TextBox>
        <br />
        Type (Bird Only):<br />
        <asp:TextBox ID="TextBox3" runat="server" Width="261px"></asp:TextBox>
        <br />
        Color (Cat and Bird Only):<br />
        <asp:TextBox ID="TextBox2" runat="server" Width="261px"></asp:TextBox>
        <br />
        <br />
        Age:&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        <br />
        Price:&nbsp;&nbsp;
        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        <br />
        Descr:&nbsp;
        <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
        <br />
&nbsp;
        <asp:Button ID="Button2" runat="server" Text="Add Pet" Width="132px" />
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

