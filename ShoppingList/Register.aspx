<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="ShoppingList.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 417px">
    <form id="form1" runat="server">
        <h3>Register</h3>
        <br />
        <asp:Label ID="lbl_Usn" runat="server" Text="Username:"></asp:Label>
        <asp:TextBox ID="TBUsername" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
        ErrorMessage="Username cannot be empty!" ForeColor="Red" ControlToValidate="TBUsername">
        </asp:RequiredFieldValidator><br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Full name:"></asp:Label>
        <asp:TextBox ID="TBFN" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Password:"></asp:Label>
        <asp:TextBox ID="TBPsw" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label1" runat="server" Text="Confirm password:"></asp:Label>
        <asp:TextBox ID="TBCPsw" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Confirm" />
    </form>
</body>
</html>