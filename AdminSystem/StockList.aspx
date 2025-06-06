<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Stock List</title>
    <!-- Add Bootstrap CSS -->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/css/bootstrap.min.css" rel="stylesheet" />
</head>
<body class="bg-light">
    <form id="form1" runat="server">
        <div class="container mt-5">
            <h2 class="mb-4 text-center">Stock List</h2>

            <div class="mb-3">
                <asp:ListBox ID="lstStockList" runat="server" CssClass="form-select" Height="295px" Width="100%"></asp:ListBox>
            </div>

            <div class="d-flex flex-wrap gap-2 mb-4">
                <asp:Button ID="btnAdd" runat="server" CssClass="btn btn-primary" Text="Add" OnClick="btnAdd_Click" />
                <asp:Button ID="btnEdit" runat="server" CssClass="btn btn-warning" Text="Edit" OnClick="btnEdit_Click" />
                <asp:Button ID="btnDelete" runat="server" CssClass="btn btn-danger" Text="Delete" OnClick="btnDelete_Click" />
            </div>

            <div class="row mb-3">
                <div class="col-md-4">
                    <asp:Label runat="server" Text="Enter a Game Title" CssClass="form-label"></asp:Label>
                    <asp:TextBox ID="txtFilter" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>

            <div class="d-flex flex-wrap gap-2 mb-3">
                <asp:Button ID="btnApplyFilter" runat="server" CssClass="btn btn-info text-white" Text="Apply Filter" OnClick="btnApplyFilter_Click" />
                <asp:Button ID="btnClearFilter" runat="server" CssClass="btn btn-secondary" Text="Clear Filter" OnClick="btnClearFilter_Click" />
                <asp:Button ID="BtnStatistics" runat="server" CssClass="btn btn-dark" Text="Statistics Page" OnClick="BtnStatistics_Click" />
                <asp:Button ID="btnReturnToMM_Click" runat="server" CssClass="btn btn-outline-primary" Text="Return To Main Menu" OnClick="btnReturnToMM_Click_Click" />
            </div>

            <asp:Label ID="lblError" runat="server" ForeColor="Red" CssClass="fw-bold"></asp:Label>
        </div>
    </form>
</body>
</html>
