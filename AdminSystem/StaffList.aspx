<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstStaffList" runat="server" Height="262px" Width="300px"></asp:ListBox>
        <p>
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" Width="100px" />
            <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" Text="Edit" Width="100px" />
            <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete" Width="100px" />
        </p>
        <p>
            <asp:Label ID="lblFilter" runat="server" Text="Enter a Staff Name:" style="margin-left: 90px;"></asp:Label>
        </p>
        <p>
            <asp:TextBox ID="txtFilter" runat="server" Height="20px" style="margin-left: 70px; margin-top: 12px" Width="160px" ></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="btnApply" runat="server" OnClick="btnApply_Click" Text="Apply Filter" Width="150px" />
            <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" Text="Clear Filter" Width="150px" />
        </p>
        <p>
            <asp:Button ID="btnStatPage" runat="server" Text="Statistics Page" Width="150px" OnClick="btnStatPage_Click" />
            <asp:Button ID="btnReturnMainMenu" runat="server" Text="Main Menu" Width="150px" OnClick="btnReturnMainMenu_Click" />
        </p>
        <p>
        <asp:Label ID="lblError" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>
