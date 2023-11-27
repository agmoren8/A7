<%@ Page Title="MemberPage" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MemberPage.aspx.cs" Inherits="A7.MemberPage" %>
<%@ Register TagPrefix="game" TagName="blackJack" src="blackJack.ascx"%> 

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <h2>Welcome to the Member Page</h2>
        <p>
            <game:blackJack RunAt="server" />
        </p>
    </main>

</asp:Content>

