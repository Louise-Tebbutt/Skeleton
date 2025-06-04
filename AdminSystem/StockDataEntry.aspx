<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Stock Data Entry</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="IblGameId" runat="server" Text="GameId" style="position:absolute; top:10px; left:10px;"></asp:Label>
            <asp:TextBox ID="txtGameId" runat="server" style="position:absolute; top:10px; left:150px;"></asp:TextBox>

            <asp:Label ID="IblGameTitle" runat="server" Text="Game Title" style="position:absolute; top:50px; left:10px;"></asp:Label>
            <asp:TextBox ID="txtGameTitle" runat="server" style="position:absolute; top:50px; left:150px;"></asp:TextBox>

            <asp:Label ID="IblGameReleaseDate" runat="server" Text="Release Date" style="position:absolute; top:90px; left:10px;"></asp:Label>
            <asp:TextBox ID="txtGameReleaseDate" runat="server" style="position:absolute; top:90px; left:150px;"></asp:TextBox>

            <asp:Label ID="IblGamePrice" runat="server" Text="Game Price" style="position:absolute; top:130px; left:10px;"></asp:Label>
            <asp:TextBox ID="txtGamePrice" runat="server" style="position:absolute; top:130px; left:150px;"></asp:TextBox>

            <asp:Label ID="IblStockQty" runat="server" Text="Stock Quantity" style="position:absolute; top:170px; left:10px;"></asp:Label>
            <asp:TextBox ID="txtStockQty" runat="server" style="position:absolute; top:170px; left:150px;"></asp:TextBox>

            <asp:Label ID="IblGameRating" runat="server" Text="Game Rating" style="position:absolute; top:210px; left:10px;"></asp:Label>
            <asp:TextBox ID="txtGameRating" runat="server" style="position:absolute; top:210px; left:150px;"></asp:TextBox>

            <asp:CheckBox ID="chkIsDigital" runat="server" Text="Digital" style="position:absolute; top:250px; left:150px;"></asp:CheckBox>

            <asp:Button ID="btnOK" runat="server" Text="OK" OnClick="btnOK_Click" style="position:absolute; top:300px; left:10px;" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" style="position:absolute; top:300px; left:100px;" OnClick="btnCancel_Click" />
            <asp:Button ID="btnFind" runat="server" Text="Find" OnClick="btnFind_Click" style="position:absolute; top:300px; left:200px;" />
            <asp:Label ID="lblError" runat="server" style="position:absolute; top:346px; left:10px;"></asp:Label>
        </div>
    </form>
</body>
</html>
