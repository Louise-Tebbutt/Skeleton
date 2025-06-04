<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrdersList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form runat="server">
        <div>
            <asp:ListBox ID="lstOrderList" runat="server" Height="469px" Width="354px"></asp:ListBox>
        </div>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" />
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" Text="Edit" />
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete " />
        <br />
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Enter Shipping Address
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnApplyFilter_Click" runat="server" OnClick="btnApplyFilter_Click_Click" Text="Apply Filter" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnClearFilter_Click" runat="server" OnClick="btnClearFilter_Click_Click" Text="Clear Filter" />
        <br />
        <br />
        <br />
        <br />
        <p>
            <asp:Label ID="btn_lblError" runat="server" Text="[lblError]"></asp:Label>
        </p>
    </form>
    <p>
&nbsp;</p>
</body>
</html>
