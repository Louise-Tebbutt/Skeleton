<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffStatistics.aspx.cs" Inherits="StaffStatistics" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblTitle" runat="server" Font-Bold="True" Font-Size="XX-Large" Text="Statistics Page"></asp:Label>
            <br />
        </div>
        <br />
        <asp:Label ID="lblJoinDate" runat="server" Text="Staff List - Grouped by JoinDate"></asp:Label>
        <br />
        <asp:GridView ID="GridViewStGroupByJoinDate" runat="server">
        </asp:GridView>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="lblStaffSalary" runat="server" Text="Staff List - Grouped by Staff Salary"></asp:Label>
        </p>
        <asp:GridView ID="GridViewStGroupByStaffSalary" runat="server">
        </asp:GridView>
        <p>
            <asp:Button ID="btnBack" runat="server" OnClick="btnBack_Click" style="margin-left: 0px" Text="Back to previous page" />
        </p>
    </form>
</body>
</html>
