<%@ Page Title="RumbleFish Online Store for Dead Animals!!!" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
                <h1><%: Title %>Buy your Pets Online.</h1>
            </hgroup>
            
        </div>
    </section>
</asp:Content>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <h3>We have Dogs, Cats, and Birds for sale. To purchase one, please login.</h3>
    <ol class="round">
        <li class="one">
            <h5>Dogs</h5>
           
        </li>
        <li class="two">
            <h5>Cats</h5>
            
        </li>
        <li class="three">
            <h5>Birds</h5>

        </li>
    </ol>
</asp:Content>