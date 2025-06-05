<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrdersList.aspx.cs" Inherits="_1_List" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Orders List</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/bootstrap.bundle.min.js"></script>
    <style>
        body {
            background-color: #f8f9fa;
            font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
        }
        .container {
            max-width: 1000px;
            margin: 30px auto;
            padding: 20px;
        }
        .card {
            border: none;
            box-shadow: 0 4px 6px rgba(0, 0, 0, 0.1);
            border-radius: 10px;
        }
        .card-header {
            background: linear-gradient(135deg, #667eea 0%, #764ba2 100%);
            color: white;
            border-radius: 10px 10px 0 0 !important;
            text-align: center;
            font-weight: 600;
            font-size: 1.2em;
        }
        .orders-listbox {
            width: 100%;
            height: 400px;
            border: 2px solid #e9ecef;
            border-radius: 8px;
            font-family: 'Courier New', monospace;
            font-size: 0.9em;
            padding: 10px;
        }
        .btn-group-custom {
            display: flex;
            gap: 10px;
            justify-content: center;
            margin: 20px 0;
        }
        .btn-custom {
            padding: 8px 20px;
            border-radius: 6px;
            font-weight: 500;
            transition: all 0.3s ease;
        }
        .btn-add { background-color: #28a745; border-color: #28a745; }
        .btn-edit { background-color: #ffc107; border-color: #ffc107; color: #212529; }
        .btn-delete { background-color: #dc3545; border-color: #dc3545; }
        
        .btn-add:hover { background-color: #218838; }
        .btn-edit:hover { background-color: #e0a800; }
        .btn-delete:hover { background-color: #c82333; }
        
        .filter-section {
            background-color: #ffffff;
            padding: 20px;
            border-radius: 8px;
            margin: 20px 0;
            box-shadow: 0 2px 4px rgba(0, 0, 0, 0.05);
        }
        .filter-title {
            font-weight: 600;
            color: #495057;
            margin-bottom: 15px;
        }
        .filter-input {
            width: 100%;
            padding: 10px;
            border: 2px solid #e9ecef;
            border-radius: 6px;
            font-size: 0.95em;
            transition: border-color 0.3s ease;
        }
        .filter-input:focus {
            border-color: #667eea;
            outline: none;
            box-shadow: 0 0 0 0.2rem rgba(102, 126, 234, 0.25);
        }
        .filter-buttons {
            display: flex;
            gap: 15px;
            justify-content: center;
            margin-top: 15px;
        }
        .btn-filter { background-color: #667eea; border-color: #667eea; }
        .btn-clear { background-color: #6c757d; border-color: #6c757d; }
        .btn-stats { background-color: #17a2b8; border-color: #17a2b8; }
        
        .btn-filter:hover { background-color: #5a6fd8; }
        .btn-clear:hover { background-color: #5a6268; }
        .btn-stats:hover { background-color: #138496; }
        
        .error-label {
            background-color: #f8d7da;
            color: #721c24;
            padding: 10px 15px;
            border-radius: 6px;
            border: 1px solid #f5c6cb;
            margin-top: 20px;
            display: inline-block;
            font-weight: 500;
        }
        .error-label:empty {
            display: none;
        }
    </style>
</head>
<body>
    <form runat="server">
        <div class="container">
            <div class="card">
                <div class="card-header">
                    <h4 class="mb-0">Orders Management</h4>
                </div>
                <div class="card-body">
                    <!-- Orders List Section -->
                    <div class="row">
                        <div class="col-12">
                            <asp:ListBox ID="lstOrderList" runat="server" CssClass="orders-listbox"></asp:ListBox>
                        </div>
                    </div>
                    
                    <!-- Action Buttons -->
                    <div class="btn-group-custom">
                        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add Order" 
                                    CssClass="btn btn-custom btn-add text-white" />
                        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" Text="Edit Order" 
                                    CssClass="btn btn-custom btn-edit" />
                        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete Order" 
                                    CssClass="btn btn-custom btn-delete text-white" />
                    </div>
                    
                    <!-- Filter Section -->
                    <div class="filter-section">
                        <div class="filter-title">Filter Orders by Shipping Address</div>
                        <div class="row">
                            <div class="col-12">
                                <asp:TextBox ID="txtFilter" runat="server" CssClass="filter-input" 
                                           placeholder="Enter shipping address to filter..."></asp:TextBox>
                            </div>
                        </div>
                        
                        <div class="filter-buttons">
                            <asp:Button ID="btnApplyFilter_Click" runat="server" OnClick="btnApplyFilter_Click_Click" 
                                      Text="Apply Filter" CssClass="btn btn-custom btn-filter text-white" />
                            <asp:Button ID="btnClearFilter_Click" runat="server" OnClick="btnClearFilter_Click_Click" 
                                      Text="Clear Filter" CssClass="btn btn-custom btn-clear text-white" />
                            <asp:Button ID="btn_Statistics_Click" runat="server" Text="View Statistics" 
                                      OnClick="btn_Statistics_Click_Click" CssClass="btn btn-custom btn-stats text-white" />
                        </div>
                    </div>
                    
                    <!-- Error Display -->
                    <asp:Label ID="btn_lblError" runat="server" Text="[lblError]" CssClass="error-label"></asp:Label>
                </div>
            </div>
        </div>
    </form>
</body>
</html>