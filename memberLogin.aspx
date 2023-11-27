<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="memberLogin.aspx.cs" Inherits="A7.memberLogin" %>
<%@ Register TagPrefix="user" TagName="LoginControl" src="LoginControl.ascx"%> 

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main aria-labelledby="title">
        <h2>Member Login</h2>
        <user:LoginControl RunAt="server" />

    </main>



</asp:Content>
