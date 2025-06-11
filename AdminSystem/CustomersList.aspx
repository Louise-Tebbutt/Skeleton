<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomersList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 497px;
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
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 18px; top: 450px; position: absolute" Text="lblError"></asp:Label>
        <asp:Button ID="bntDelete" runat="server" Text="Delete" OnClick="bntDelete_Click" />
    </form>
</body>
</html>
