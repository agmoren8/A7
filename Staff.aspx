<%@ Page Title="Staff" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Staff.aspx.cs" Inherits="A7.Contact" %>

<%@ Register TagPrefix="add" TagName="addStaff" src="addStaff.ascx"%> 

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <h2>Welcome to the Staff Page </h2>
        <add:addStaff RunAt="server" />
    </main>

</asp:Content>