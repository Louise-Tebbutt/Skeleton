<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomersDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 229px">
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblCustomer" runat="server" style="z-index: 1; left: 18px; top: 52px; position: absolute" Text="Customer ID"></asp:Label>
        <asp:TextBox ID="txtCustomer" runat="server" style="z-index: 1; left: 148px; top: 52px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblEmail" runat="server" style="z-index: 1; left: 18px; top: 72px; position: absolute" Text="Email"></asp:Label>
        <asp:TextBox ID="txtEmail" runat="server" style="z-index: 1; left: 148px; top: 72px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblDateOfBirth" runat="server" style="z-index: 1; left: 18px; top: 92px; position: absolute" Text="Date Of Birth"></asp:Label>
        <asp:TextBox ID="txtDateOfBirth" runat="server" style="z-index: 1; left: 148px; top: 92px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblFullName" runat="server" style="z-index: 1; left: 18px; top: 112px; position: absolute" Text="Full Name"></asp:Label>
        <asp:TextBox ID="txtFullName" runat="server" style="z-index: 1; left: 148px; top: 112px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblAddress" runat="server" style="z-index: 1; left: 18px; top: 132px; position: absolute" Text="Address"></asp:Label>
        <asp:TextBox ID="txtAddress" runat="server" style="z-index: 1; left: 148px; top: 132px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblPhoneNumber" runat="server" style="z-index: 1; left: 18px; top: 152px; position: absolute" Text="Phone Number"></asp:Label>
        <asp:TextBox ID="txtPhoneNumber" runat="server" style="z-index: 1; left: 148px; top: 152px; position: absolute"></asp:TextBox>
        <asp:CheckBox ID="cbActive" runat="server" Text="Active" Style="position: absolute; top: 172px; left: 148px;" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 18px; top: 200px; position: absolute" Text="lblError"></asp:Label>
        <asp:Button ID="btnOK" runat="server" Text="OK" Style="position: absolute; top: 230px; left: 18px;" OnClick="btnOK_Click"/>
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" Style="position: absolute; top: 230px; left: 70px;"/>
        <p>
        <asp:Button ID="btnFind" runat="server" Text="Find" Style="position: absolute; top: 49px; left: 300px; height: 27px;" OnClick="btnFind_Click"/>
        </p>
    </form>
</body>
</html>
