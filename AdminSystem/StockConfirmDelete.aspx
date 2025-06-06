<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Confirm Delete</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/css/bootstrap.min.css" rel="stylesheet" />
</head>
<body class="bg-light">
    <form id="form1" runat="server">
        <div class="container mt-5">
            <div class="card shadow-sm">
                <div class="card-body text-center">
                    <h5 class="card-title text-danger mb-4">
                        <asp:Label ID="lblConfirm" runat="server" Text="Are you sure you want to delete this record?"></asp:Label>
                    </h5>
                    <div class="d-flex justify-content-center gap-3">
                        <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" Text="Yes" CssClass="btn btn-danger" />
                        <asp:Button ID="btnNo" runat="server" OnClick="btnNo_Click" Text="No" CssClass="btn btn-secondary" />
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
