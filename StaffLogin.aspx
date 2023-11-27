<%@ Page Title="StaffLogin" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="StaffLogin.aspx.cs" Inherits="A7.StaffLogin" %>


<%@ Register TagPrefix="add" TagName="staffLogin" src="staffLogin.ascx"%> 

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <h2>Staff Login </h2>
        <add:staffLogin RunAt="server" />
    </main>

</asp:Content>