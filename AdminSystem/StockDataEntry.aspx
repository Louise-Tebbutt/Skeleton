<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Stock Data Entry</title>

    <!-- ✅ Add Bootstrap CSS -->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/css/bootstrap.min.css" rel="stylesheet" />
</head>
<body class="bg-light">
    <form id="form1" runat="server">
        <div class="container mt-5">
            <div class="card shadow">
                <div class="card-header text-center fw-bold">
                    Stock Data Entry
                </div>
                <div class="card-body">

                    <!-- Keep your exact layout but wrap in Bootstrap grid -->
                    <div class="mb-3">
                        <asp:Label ID="IblGameId" runat="server" Text="GameId" CssClass="form-label"></asp:Label>
                        <asp:TextBox ID="txtGameId" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>

                    <div class="mb-3">
                        <asp:Label ID="IblGameTitle" runat="server" Text="Game Title" CssClass="form-label"></asp:Label>
                        <asp:TextBox ID="txtGameTitle" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>

                    <div class="mb-3">
                        <asp:Label ID="IblGameReleaseDate" runat="server" Text="Release Date" CssClass="form-label"></asp:Label>
                        <asp:TextBox ID="txtGameReleaseDate" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>

                    <div class="mb-3">
                        <asp:Label ID="IblGamePrice" runat="server" Text="Game Price" CssClass="form-label"></asp:Label>
                        <asp:TextBox ID="txtGamePrice" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>

                    <div class="mb-3">
                        <asp:Label ID="IblStockQty" runat="server" Text="Stock Quantity" CssClass="form-label"></asp:Label>
                        <asp:TextBox ID="txtStockQty" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>

                    <div class="mb-3">
                        <asp:Label ID="IblGameRating" runat="server" Text="Game Rating" CssClass="form-label"></asp:Label>
                        <asp:TextBox ID="txtGameRating" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>

                    <div class="form-check mb-3">
                        <asp:CheckBox ID="chkIsDigital" runat="server" CssClass="form-check-input" />
                        <label class="form-check-label" for="chkIsDigital">Digital</label>
                    </div>

                    <asp:Label ID="lblError" runat="server" CssClass="text-danger mb-3 d-block"></asp:Label>

                    <div class="row mb-3">
                        <div class="col-md-3">
                            <asp:Button ID="btnOK" runat="server" Text="OK" OnClick="btnOK_Click" CssClass="btn btn-success w-100" BackColor="#99CCFF" />
                        </div>
                        <div class="col-md-3">
                            <asp:Button ID="btnCancel" runat="server" Text="Cancel" CssClass="btn btn-secondary w-100" OnClick="btnCancel_Click" BackColor="#99CCFF" />
                        </div>
                        <div class="col-md-3">
                            <asp:Button ID="btnFind" runat="server" Text="Find" OnClick="btnFind_Click" CssClass="btn btn-primary w-100" BackColor="#99CCFF" />
                        </div>
                        <div class="col-md-3">
                            <asp:Button ID="btnReturnToMM_Click" runat="server" OnClick="btnReturnToMM_Click_Click" Text="Return To Main Menu" CssClass="btn btn-info w-100" BackColor="#99CCFF" />
                        </div>
                    </div>

                </div>
            </div>
        </div>
    </form>

    <!-- ✅ Add Bootstrap JavaScript (optional but safe) -->
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/js/bootstrap.bundle.min.js"></script>
</body>
</html>
