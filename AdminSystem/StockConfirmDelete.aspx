<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="IblGameId" runat="server" style="z-index: 1; top: 15px; position: absolute; width: 48px; right: 1562px" Text="GameId"></asp:Label>
            <asp:TextBox ID="txtGameId" runat="server" style="z-index: 1; left: 229px; top: 12px; position: absolute; width: 189px"></asp:TextBox>
        </div>
        <asp:Label ID="IblGameTitle" runat="server" style="z-index: 1; left: 10px; top: 34px; position: absolute; width: 76px; right: 1535px" Text="Game Title"></asp:Label>
        <p>
            <asp:TextBox ID="txtGameTitleId" runat="server" style="z-index: 1; left: 229px; top: 35px; position: absolute; width: 189px"></asp:TextBox>
            <asp:Label ID="IblGameReleaseDate" runat="server" style="z-index: 1; left: 13px; top: 52px; position: absolute" Text="Game Release Date"></asp:Label>
            <asp:TextBox ID="txtGameReleaseDate" runat="server" style="z-index: 1; left: 229px; top: 59px; position: absolute; width: 188px"></asp:TextBox>
        </p>
    </form>
</body>
</html>
