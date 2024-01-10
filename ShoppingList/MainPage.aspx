<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainPage.aspx.cs" Inherits="ShoppingList.MainPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Name: <asp:TextBox ID="TBName" runat="server"></asp:TextBox>
            Description: <asp:TextBox ID="TBDesc" runat="server"></asp:TextBox>
            <br />
            <hr />
            <asp:GridView ID="GVShopList" runat="server">
            </asp:GridView>
            <hr />
            <hr />
            ID: <asp:TextBox ID="TBID" runat="server"></asp:TextBox> <asp:Label ID="Label3" runat="server" Text="For delete and search function"></asp:Label>
            <br />
            <asp:Button ID="btnInsert" runat="server" Text="Insert" OnClick="btnInsert_Click" />
            <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" />           
            <asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click" />
            <asp:Button ID="btnDisplay" runat="server" Text="Display" OnClick="btnDisplay_Click" />
            <asp:Button ID="btnTotal" runat="server" Text="Total" OnClick="btnTotal_Click" />
            <asp:Label ID="lblTotal" runat="server"></asp:Label>

        </div>
    </form>
</body>
</html>
