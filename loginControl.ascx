<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="loginControl.ascx.cs" Inherits="A7.WebUserControl1" %>


<table id="MyTable" cellpadding="4" RunAt="server">
    
  	<tr> <td>User Name:</td>
         	<td><asp:TextBox ID="MyUserName" RunAt="server" />
		</td>
	</tr>
         <tr>	<td>Password:</td> 
               	<td><asp:TextBox ID="MyPassword" TextMode="password" RunAt="server" />  
		</td>
  	</tr>
  	<tr> <td></td> <td>
          <asp:LinkButton Text="Log In" runat="server" OnClick="Unnamed1_Click" /></td> </tr>

    <tr> <td></td> <td>
        <asp:Label ID="Label1" runat="server" Text="..."></asp:Label></td> </tr>
    
</table>