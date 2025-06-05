<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrdersDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Order Data Entry</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/bootstrap.bundle.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
    <style>
        body {
            background-color: #f8f9fa;
            font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
        }
        .container {
            max-width: 800px;
            margin: 30px auto;
            padding: 20px;
        }
        .page-header {
            background: linear-gradient(135deg, #667eea 0%, #764ba2 100%);
            color: white;
            padding: 25px;
            border-radius: 10px;
            text-align: center;
            margin-bottom: 30px;
            box-shadow: 0 4px 15px rgba(0, 0, 0, 0.1);
        }
        .page-title {
            font-size: 1.8em;
            font-weight: 600;
            margin: 0;
        }
        .form-card {
            background-color: white;
            border-radius: 10px;
            padding: 30px;
            box-shadow: 0 4px 6px rgba(0, 0, 0, 0.1);
        }
        .form-group {
            margin-bottom: 20px;
            display: flex;
            align-items: center;
            gap: 15px;
        }
        .form-label {
            font-weight: 600;
            color: #495057;
            min-width: 140px;
            text-align: left;
            font-size: 0.95em;
        }
        .form-input {
            flex: 1;
            padding: 10px 12px;
            border: 2px solid #e9ecef;
            border-radius: 6px;
            font-size: 0.95em;
            transition: border-color 0.3s ease;
            max-width: 300px;
        }
        .form-input:focus {
            border-color: #667eea;
            outline: none;
            box-shadow: 0 0 0 0.2rem rgba(102, 126, 234, 0.25);
        }
        .search-section {
            background-color: #f8f9fa;
            padding: 20px;
            border-radius: 8px;
            margin-bottom: 25px;
            border-left: 4px solid #667eea;
        }
        .search-title {
            font-weight: 600;
            color: #495057;
            margin-bottom: 15px;
            font-size: 1.1em;
        }
        .btn-find {
            background-color: #667eea;
            border-color: #667eea;
            color: white;
            padding: 8px 20px;
            border-radius: 6px;
            font-weight: 500;
            transition: all 0.3s ease;
        }
        .btn-find:hover {
            background-color: #5a6fd8;
            border-color: #5a6fd8;
            color: white;
        }
        .checkbox-group {
            margin: 25px 0;
            padding: 15px;
            background-color: #f8f9fa;
            border-radius: 6px;
            border-left: 4px solid #28a745;
        }
        .checkbox-custom {
            font-weight: 500;
            color: #495057;
        }
        .action-buttons {
            display: flex;
            gap: 15px;
            justify-content: center;
            margin-top: 30px;
            padding-top: 20px;
            border-top: 2px solid #e9ecef;
        }
        .btn-ok {
            background-color: #28a745;
            border-color: #28a745;
            color: white;
            padding: 12px 30px;
            border-radius: 6px;
            font-weight: 500;
            transition: all 0.3s ease;
        }
        .btn-ok:hover {
            background-color: #218838;
            border-color: #218838;
            color: white;
        }
        .btn-cancel {
            background-color: #6c757d;
            border-color: #6c757d;
            color: white;
            padding: 12px 30px;
            border-radius: 6px;
            font-weight: 500;
            transition: all 0.3s ease;
        }
        .btn-cancel:hover {
            background-color: #5a6268;
            border-color: #5a6268;
            color: white;
        }
        .error-display {
            background-color: #f8d7da;
            color: #721c24;
            padding: 12px 15px;
            border-radius: 6px;
            border: 1px solid #f5c6cb;
            margin-top: 20px;
            font-weight: 500;
            text-align: center;
        }
        .error-display:empty {
            display: none;
        }
        .form-section {
            border-bottom: 1px solid #e9ecef;
            padding-bottom: 20px;
            margin-bottom: 20px;
        }
        .form-section:last-child {
            border-bottom: none;
            margin-bottom: 0;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <!-- Page Header -->
            <div class="page-header">
                <h1 class="page-title">📝 Order Data Entry</h1>
                <p class="mb-0" style="font-size: 1.0em; opacity: 0.9;">Create and manage order information</p>
            </div>
            
            <!-- Form Card -->
            <div class="form-card">
                <!-- Search Section -->
                <div class="search-section">
                    <div class="search-title">🔍 Order Search</div>
                    <div class="form-group">
                        <asp:Label ID="Label1" runat="server" Text="Order ID" CssClass="form-label"></asp:Label>
                        <asp:TextBox ID="txtOrderId" runat="server" CssClass="form-input"></asp:TextBox>
                        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Find" CssClass="btn btn-find" />
                    </div>
                </div>
                
                <!-- Order Information Section -->
                <div class="form-section">
                    <div class="form-group">
                        <asp:Label ID="Label2" runat="server" Text="Customer ID" CssClass="form-label"></asp:Label>
                        <asp:TextBox ID="txtCustomerId" runat="server" CssClass="form-input"></asp:TextBox>
                    </div>
                    
                    <div class="form-group">
                        <asp:Label ID="Label3" runat="server" Text="Order Date" CssClass="form-label"></asp:Label>
                        <asp:TextBox ID="txtOrderDate" runat="server" CssClass="form-input"></asp:TextBox>
                    </div>
                    
                    <div class="form-group">
                        <asp:Label ID="Label4" runat="server" Text="Total Amount" CssClass="form-label"></asp:Label>
                        <asp:TextBox ID="txtTotalAmount" runat="server" CssClass="form-input"></asp:TextBox>
                    </div>
                    
                    <div class="form-group">
                        <asp:Label ID="Label5" runat="server" Text="Payment Status" CssClass="form-label"></asp:Label>
                        <asp:TextBox ID="txtPaymentStatus" runat="server" CssClass="form-input"></asp:TextBox>
                    </div>
                    
                    <div class="form-group">
                        <asp:Label ID="Label6" runat="server" Text="Shipping Address" CssClass="form-label"></asp:Label>
                        <asp:TextBox ID="txtShippingAddress" runat="server" CssClass="form-input"></asp:TextBox>
                    </div>
                    
                    <div class="form-group">
                        <asp:Label ID="Label7" runat="server" Text="Staff ID" CssClass="form-label"></asp:Label>
                        <asp:TextBox ID="txtStaffId" runat="server" CssClass="form-input"></asp:TextBox>
                    </div>
                </div>
                
                <!-- Status Section -->
                <div class="checkbox-group">
                    <asp:CheckBox ID="chkActive" runat="server" Text="Active Order" CssClass="checkbox-custom" />
                </div>
                
                <!-- Action Buttons -->
                <div class="action-buttons">
                    <asp:Button ID="Button1" runat="server" Text="OK" OnClick="Button1_Click" CssClass="btn btn-ok" />
                    <asp:Button ID="Button2" runat="server" Text="Cancel" CssClass="btn btn-cancel" />
                </div>
                
                <!-- Error Display -->
                <asp:Label ID="lblError" runat="server" Text="[lblError]" CssClass="error-display"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btn_Mainmenu" runat="server" OnClick="btn_Mainmenu_Click" Text="Return to Main Menu" />
            </div>
        </div>
    </form>
</body>
</html>