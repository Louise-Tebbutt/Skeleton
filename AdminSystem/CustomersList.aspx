<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomersList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 570px;
        }
    </style>
</head>
<body style="height: 478px">
    <form id="form1" runat="server">
        <div style="height: 380px">

            <asp:ListBox ID="lstCustomerList" runat="server" Height="351px" Width="354px"></asp:ListBox>

        </div>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" Width="47px" />
        <asp:Button ID="bntEdit" runat="server" OnClick="bntEdit_Click" Text="Edit" Width="70px" />
        <asp:Button ID="bntDelete" runat="server" Text="Delete" OnClick="bntDelete_Click" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 23px; top: 540px; position: absolute" Text="lblError"></asp:Label>
        <asp:Label ID="lblEnterName" runat="server" style="z-index: 1; left: 23px; top: 450px; position: absolute" Text="Enter a Name"></asp:Label>
        <asp:TextBox ID="txtName" runat="server" style="z-index: 1; left: 180px; top: 450px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnApplyFilter" runat="server" style="z-index: 1; left: 23px; top: 480px; position: absolute" Text="Apply Filter" OnClick="btnApplyFilter_Click" />
        <asp:Button ID="btnEditFilter" runat="server" style="z-index: 1; left: 180px; top: 480px; position: absolute" Text="Clear Filter" OnClick="btnEditFilter_Click" />
        <asp:Button ID="btnSatisticsPage" runat="server" style="z-index: 1; left: 350px; top: 480px; position: absolute" Text="Statistics Page" OnClick="btnStatsPage" />
    </form>
</body>
</html>
