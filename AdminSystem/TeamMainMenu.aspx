<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TeamMainMenu.aspx.cs" Inherits="TeamMainMenu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        .centerTitle {
            margin: auto;
            width: 10%;
            text-align: center;
        }
        .center {
            margin: auto;
            width: 50%;
        }

    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="centerTitle">
            <p>
            <asp:Label ID="lblTitle" runat="server" Text="Main Menu" style="font-weight: 700; font-size: x-large"></asp:Label>
            </p>
            <p>
                &nbsp;</p>
        </div>

        <div class="center">

            <asp:Button ID="btnCustomer" runat="server" OnClick="btnCustomer_Click" Text="Customers" Width="120px" style="margin-left: 280px;" />
            <asp:Button ID="btnOrder" runat="server" OnClick="btnOrder_Click" Text="Orders" Width="120px" style="margin-left: 20px;" />
            <asp:Button ID="btnStaff" runat="server" OnClick="btnStaff_Click" Text="Staff" Width="120px" style="margin-left: 20px;" />
            <asp:Button ID="btnStock" runat="server" OnClick="btnStock_Click" Text="Stock" Width="120px" style="margin-left: 20px;" />

        </div>
    </form>
</body>
</html>
