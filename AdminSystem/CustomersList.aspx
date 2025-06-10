<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomersList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 409px">
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstCustomerList" runat="server" Height="324px" OnSelectedIndexChanged="lstCustomerList_SelectedIndexChanged" Width="502px"></asp:ListBox>
        </div>
    </form>
</body>
</html>
