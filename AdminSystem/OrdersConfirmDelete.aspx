<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrdersConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <p>
        <br />
    </p>
    <p style="margin-left: 120px">
        Are you sure you want to delete this record?</p>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btn_yes" runat="server" OnClick="btn_yes_Click" Text="Yes" />
            <asp:Button ID="btn_No" runat="server" OnClick="btn_No_Click" Text="No" />
        </div>
    </form>
</body>
</html>
