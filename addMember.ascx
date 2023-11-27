<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="addMember.ascx.cs" Inherits="A7.addMember" %>



<p>
    <asp:Label ID="Label3" runat="server" Text="Enter the following information in order to make an account:"></asp:Label>
</p>

<p>
    <asp:Label ID="Label2" runat="server" Text="Username:"></asp:Label>
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
</p>

<p>
    <asp:Label ID="Label5" runat="server" Text="Password:"></asp:Label>
    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
</p>

<p>
    <asp:Button ID="Button1" runat="server" Text="add Account" OnClick="Button1_Click" />
    <asp:Label ID="Label4" runat="server" Text="..."></asp:Label>
</p>