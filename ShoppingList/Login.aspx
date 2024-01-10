<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ShoppingList.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
           <div>
        <h4>Login</h4>
        <asp:Label ID="label_error" runat="server" Text=""></asp:Label><br />
<br />
<br />  
        <asp:Label ID="lbl_Usn" runat="server" Text="Username:"></asp:Label>
        <asp:TextBox ID="TBUsername" runat="server"></asp:TextBox>
<br />
<br />
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
        ErrorMessage="Username cannot be empty!" ForeColor="Red" ControlToValidate="TBUsername">
        </asp:RequiredFieldValidator><br />
    
        <asp:Label ID="lbl_Psw" runat="server" Text="Password:"></asp:Label>
        <asp:TextBox ID="TBPassword" runat="server" TextMode="Password"></asp:TextBox>
<br />
<br />
        <asp:Button ID="Blogin" runat="server" Text="Login" OnClick="BLogin" />
    </div>
    </form>
</body>
</html>
