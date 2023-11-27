<%@ Page Title="memberSignUp" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="memberSignUp.aspx.cs" Inherits="A7.memberSignUp" %>

<%@ Register TagPrefix="add" TagName="addMember" src="addMember.ascx"%> 

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <h2>Member Sign Up </h2>
        <add:addMember RunAt="server" />
    </main>

</asp:Content>