﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 463px; width: 776px">
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblCheck" runat="server" Text="Are you sure you want to delete this record?"></asp:Label>
        <p style="height: 156px">
            <asp:Button ID="btnYes" runat="server" Text="Yes" />
            <asp:Button ID="btnNo" runat="server" Text="No" />
        </p>
    </form>
</body>
</html>
