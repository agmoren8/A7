<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="addStaff.ascx.cs" Inherits="A7.addStaff" %>

<p>
    <asp:Label ID="Label1" runat="server" Text="Enter the following information in order to add a staff member:"></asp:Label>
</p>

<p>
    <asp:Label ID="Label2" runat="server" Text="Username:"></asp:Label>
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
</p>

<p>
    <asp:Label ID="Label3" runat="server" Text="Password:"></asp:Label>
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
</p>

<p>
    <asp:Button ID="Button1" runat="server" Text="add Account" OnClick="Button1_Click" />
    <asp:Label ID="Label4" runat="server" Text="..."></asp:Label>
</p>