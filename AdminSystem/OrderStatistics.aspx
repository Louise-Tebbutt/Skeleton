<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderStatistics.aspx.cs" Inherits="OrderStatistics" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Order Statistics</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/bootstrap.bundle.min.js"></script>
    <style>
        body {
            background-color: #f8f9fa;
            font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
        }
        .container {
            max-width: 1200px;
            margin: 30px auto;
            padding: 20px;
        }
        .page-header {
            background: linear-gradient(135deg, #667eea 0%, #764ba2 100%);
            color: white;
            padding: 30px;
            border-radius: 10px;
            text-align: center;
            margin-bottom: 30px;
            box-shadow: 0 4px 15px rgba(0, 0, 0, 0.1);
        }
        .page-title {
            font-size: 2.2em;
            font-weight: 600;
            margin: 0;
        }
        .statistics-section {
            background-color: white;
            border-radius: 10px;
            padding: 25px;
            margin-bottom: 30px;
            box-shadow: 0 4px 6px rgba(0, 0, 0, 0.1);
        }
        .section-title {
            color: #495057;
            font-size: 1.4em;
            font-weight: 600;
            margin-bottom: 20px;
            padding-bottom: 10px;
            border-bottom: 3px solid #667eea;
            display: inline-block;
        }
        .gridview-container {
            overflow-x: auto;
            border-radius: 8px;
            box-shadow: 0 2px 4px rgba(0, 0, 0, 0.05);
        }
        .gridview-shipping {
            width: 100%;
            border-collapse: collapse;
            font-size: 0.95em;
        }
        .gridview-shipping th {
            background: linear-gradient(135deg, #003399 0%, #0056cc 100%) !important;
            color: #ffffff !important;
            padding: 12px 15px;
            text-align: left;
            font-weight: 600;
            border: none;
        }
        .gridview-shipping td {
            padding: 10px 15px;
            border-bottom: 1px solid #e9ecef;
        }
        .gridview-shipping tr:nth-child(even) {
            background-color: #f8f9fa;
        }
        .gridview-shipping tr:hover {
            background-color: #e3f2fd;
            transition: background-color 0.3s ease;
        }
        .gridview-date {
            width: 100%;
            border-collapse: collapse;
            font-size: 0.95em;
        }
        .gridview-date th {
            background: linear-gradient(135deg, #5D7B9D 0%, #4a6584 100%) !important;
            color: #ffffff !important;
            padding: 12px 15px;
            text-align: left;
            font-weight: 600;
            border: none;
        }
        .gridview-date td {
            padding: 10px 15px;
            border-bottom: 1px solid #e9ecef;
        }
        .gridview-date tr:nth-child(even) {
            background-color: #f7f6f3;
        }
        .gridview-date tr:hover {
            background-color: #fff3e0;
            transition: background-color 0.3s ease;
        }
        .back-button-container {
            text-align: center;
            margin-top: 30px;
        }
        .btn-back {
            background: linear-gradient(135deg, #28a745 0%, #20c997 100%);
            border: none;
            color: white;
            padding: 12px 30px;
            font-size: 1.1em;
            font-weight: 500;
            border-radius: 25px;
            transition: all 0.3s ease;
            box-shadow: 0 4px 15px rgba(40, 167, 69, 0.3);
        }
        .btn-back:hover {
            transform: translateY(-2px);
            box-shadow: 0 6px 20px rgba(40, 167, 69, 0.4);
            background: linear-gradient(135deg, #218838 0%, #1e7e34 100%);
        }
        .icon {
            margin-right: 8px;
        }
        .stats-grid {
            margin-bottom: 20px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <!-- Page Header -->
            <div class="page-header">
                <h1 class="page-title">📊 Order Statistics Dashboard</h1>
                <p class="mb-0" style="font-size: 1.1em; opacity: 0.9;">Comprehensive analysis of order data and trends</p>
            </div>
            
            <!-- Shipping Address Statistics -->
            <div class="statistics-section">
                <h2 class="section-title">📍 Orders Grouped by Shipping Address</h2>
                <div class="gridview-container">
                    <asp:GridView ID="GridViewGroupByShippingAddress" runat="server" 
                                  CssClass="gridview-shipping stats-grid"
                                  BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4">
                        <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
                        <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
                        <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
                        <RowStyle BackColor="White" ForeColor="#003399" />
                        <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                        <SortedAscendingCellStyle BackColor="#EDF6F6" />
                        <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
                        <SortedDescendingCellStyle BackColor="#D6DFDF" />
                        <SortedDescendingHeaderStyle BackColor="#002876" />
                    </asp:GridView>
                </div>
            </div>
            
            <!-- Order Date Statistics -->
            <div class="statistics-section">
                <h2 class="section-title">📅 Orders Grouped by Order Date</h2>
                <div class="gridview-container">
                    <asp:GridView ID="GridViewByOrderDate" runat="server" 
                                  CssClass="gridview-date stats-grid"
                                  CellPadding="4" ForeColor="#333333" GridLines="None">
                        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                        <EditRowStyle BackColor="#999999" />
                        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                        <SortedAscendingCellStyle BackColor="#E9E7E2" />
                        <SortedAscendingHeaderStyle BackColor="#506C8C" />
                        <SortedDescendingCellStyle BackColor="#FFFDF8" />
                        <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                    </asp:GridView>
                </div>
            </div>
            
            <!-- Navigation -->
            <div class="back-button-container">
                <asp:Button ID="btn_homepage" runat="server" OnClick="btn_homepage_Click" 
                          Text="🏠 Back to Homepage" CssClass="btn btn-back" />
            </div>
        </div>
    </form>
</body>
</html>