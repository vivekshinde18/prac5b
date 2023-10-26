<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Pract5b1" %>
<!DOCTYPE html>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<title></title></head>
<body>
<form id="form1" runat="server">
<div style="height: 393px">
Username:<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
<br /><br/>
Password:<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
<br /><br/>
<asp:Button ID="Button4" runat="server" Text="submit"
onclick="Button4_Click" />
&nbsp;&nbsp;
<asp:Button ID="Button5" runat="server" Text="restore"
onclick="Button5_Click" />
<asp:HiddenField ID="HiddenField1" runat="server" />
<asp:Label ID="Label1" runat="server"></asp:Label><br/>
<asp:Label ID="Label2" runat="server" ></asp:Label><br/>
<asp:Button ID="Button1" runat="server" Text="ViewState"
onclick="Button1_Click" /><br/><br/>
<asp:Button ID="Button2" runat="server" Text="HiddenField"
onclick="Button2_Click" />
<br /><br />
<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br /><br /><br />
<asp:Button ID="Button3" runat="server" Text="Cookies"
onclick="Button3_Click" />
</div>
</form>
</body>
</html>
