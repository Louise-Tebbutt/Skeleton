<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="IblGameId" runat="server" style="z-index: 1; left: 9px; top: 11px; position: absolute; width: 113px; bottom: 638px" Text="GameId"></asp:Label>
            <asp:TextBox ID="txtGameId" runat="server" style="z-index: 1; left: 165px; top: 13px; position: absolute"></asp:TextBox>
        </div>
        <asp:Label ID="IblGameTitle" runat="server" style="z-index: 1; left: 9px; top: 57px; position: absolute; height: 19px" Text="Game Title " width="113px"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged" style="z-index: 1; top: 55px; position: absolute; left: 165px"></asp:TextBox>
        <asp:Label ID="IblGameReleaseDate" runat="server" style="z-index: 1; left: 9px; top: 95px; position: absolute; height: 25px; bottom: 548px" Text="Release Date" width="113px"></asp:Label>
        <asp:TextBox ID="txtGameReleaseDate" runat="server" style="z-index: 1; left: 165px; top: 94px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtGamePrice" runat="server" style="z-index: 1; left: 165px; top: 135px; position: absolute"></asp:TextBox>
        <asp:Label ID="IblStockQty" runat="server" style="z-index: 1; left: 9px; top: 185px; position: absolute" Text="StockQty" width="113px"></asp:Label>
        <asp:TextBox ID="txtStockQty" runat="server" style="z-index: 1; left: 165px; top: 185px; position: absolute"></asp:TextBox>
        <asp:Label ID="IblGameRating" runat="server" style="z-index: 1; left: 9px; top: 231px; position: absolute" Text="Rating" width="113px"></asp:Label>
        <asp:TextBox ID="txtGameRating" runat="server" style="z-index: 1; left: 165px; top: 230px; position: absolute"></asp:TextBox>
        <asp:CheckBox ID="chkIsDigitial" runat="server" style="z-index: 1; left: 200px; top: 296px; position: absolute" Text="Digital" />
        <asp:Label ID="IblError" runat="server" style="z-index: 1; left: 13px; top: 328px; position: absolute"></asp:Label>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 14px; top: 413px; position: absolute" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 105px; top: 413px; position: absolute" Text="Cancel" />
        <asp:Label ID="IblGamePrice" runat="server" style="z-index: 1; left: 9px; top: 140px; position: absolute" Text="Game Price" width="113px"></asp:Label>
    </form>
</body>
</html>
