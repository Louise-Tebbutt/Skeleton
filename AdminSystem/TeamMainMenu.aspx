<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TeamMainMenu.aspx.cs" Inherits="TeamMainMenu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        .centerTitle {
            margin: auto;
            width: 16%;
            text-align: center;
        }
        .center {
            margin: auto;
            width: 65%;
        }

    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="centerTitle">
            <p>
            <asp:Label ID="lblTitle" runat="server" Text="Main Menu" style="font-weight: 800; font-size: xx-large" BackColor="#A95658"></asp:Label>
            </p>
        </div>

        <div class="center">

            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

            <asp:Button ID="btnCustomer" runat="server" OnClick="btnCustomer_Click" Text="Customers" Width="120px" style="margin-left: 20px;" BackColor="#66FFFF" ForeColor="Black" />
            <asp:Button ID="btnOrder" runat="server" OnClick="btnOrder_Click" Text="Orders" Width="120px" style="margin-left: 20px;" BackColor="#66FFFF" />
            <asp:Button ID="btnStaff" runat="server" OnClick="btnStaff_Click" Text="Staff" Width="120px" style="margin-left: 20px;" BackColor="#66FFFF" />
            <asp:Button ID="btnStock" runat="server" OnClick="btnStock_Click" Text="Stock" Width="120px" style="margin-left: 20px;" BackColor="#66FFFF" />

        </div>
    </form>
</body>
</html>
