<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Member.aspx.cs" Inherits="A7.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main aria-labelledby="title">
        <h2>Member Page</h2>

        <p>
            <asp:Label ID="Label1" runat="server" Text="The member page includes:"></asp:Label>
        </p>

        <p>
            <asp:Label ID="Label2" runat="server" Text="1. A black jack game simulation"></asp:Label>
        </p>

        <p>
            <asp:Label ID="Label3" runat="server" Text="2. ..."></asp:Label>
        </p>
        <nav >
    <div >

        <div >
            <ul class="navbar-nav flex-grow-1">
                <li class="nav-item"><a class="LinkButton" runat="server" href="~/memberSignup">Signup</a></li>
                <li class="nav-item"><a class="LinkButton" runat="server" href="~/memberLogin">Login</a></li>
            </ul>
        </div>
    </div>
</nav>
    </main>



</asp:Content>
