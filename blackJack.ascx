<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="blackJack.ascx.cs" Inherits="A7.blackJack" %>


<h1>BlackJack game</h1>
<p>
    <asp:Label ID="Label8" runat="server" Text="Click Play to start a new game"></asp:Label>

</p>

<p>
    <asp:Button ID="Button1" runat="server" Text="Play" OnClick="Button1_Click" />

</p>

<p>
    <asp:Label ID="Label9" runat="server" Text="Dealer Cards:"></asp:Label>
    <asp:Label ID="Label10" runat="server" Text="Cards.."></asp:Label>
</p>
             
<p>
    <asp:Label ID="Label11" runat="server" Text="Player Cards:"></asp:Label>
    <asp:Label ID="Label12" runat="server" Text="Cards.."></asp:Label>
</p>

<p>
    <asp:Button ID="Button2" runat="server" Text="Hit" OnClick="Button2_Click" />
    <asp:Button ID="Button4" runat="server" Text="Stand" OnClick="Button4_Click" />
    <asp:Label ID="Label13" runat="server" Text="Outcome"></asp:Label>
    <asp:Label ID="Label14" runat="server" Text="..."></asp:Label>
</p>