<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstStockList" runat="server" Height="295px" Width="353px"></asp:ListBox>
        </div>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" />
    &nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" Text="Edit" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="height: 26px" Text="Delete " />
&nbsp;<p>
            &nbsp;</p>
        <asp:Label runat="server" Text="Enter a Game Title"></asp:Label>
&nbsp;&nbsp;
        <asp:TextBox ID="txtFilter" runat="server"></asp:TextBox>
        <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnApplyFilter" runat="server" OnClick="btnApplyFilter_Click" Text="Apply Filter" />
&nbsp;
            <asp:Button ID="btnClearFilter" runat="server" OnClick="btnClearFilter_Click" Text="Clear Filter" />
        &nbsp;&nbsp;
            <asp:Button ID="BtnStatistics" runat="server" OnClick="BtnStatistics_Click" Text="Statistics Page " />
        </p>
        <p>
            <asp:Label ID="lblError" runat="server" ForeColor="Red"></asp:Label>
        </p>
    </form>
</body>
</html>
