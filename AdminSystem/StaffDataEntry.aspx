<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 267px">
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            <asp:Label ID="lblStaffId" runat="server" style="z-index: 1; left: 13px; top: 17px; position: absolute; bottom: 830px" Text="Staff Id" width="124px"></asp:Label>
        </p>
        <p>
            <asp:TextBox ID="txtStaffId" runat="server" height="22" style="z-index: 1; left: 158px; position: absolute; bottom: 828px"></asp:TextBox>
            <asp:Label ID="lblStaffSalary" runat="server" style="z-index: 1; left: 13px; top: 204px; position: absolute" width="124px">Staff Salary</asp:Label>
            <asp:Label ID="lblStaffName" runat="server" style="z-index: 1; left: 13px; top: 53px; position: absolute" width="124px">Staff Name</asp:Label>
        </p>
        <p>
            <asp:Label ID="lblJoinDate" runat="server" style="z-index: 1; left: 13px; top: 91px; position: absolute" width="124px">Join date</asp:Label>
            <asp:TextBox ID="txtStaffName" runat="server" style="z-index: 1; left: 158px; top: 52px; position: absolute"></asp:TextBox>
        </p>
        <p>
            <asp:CheckBox ID="chkMorePermissions" runat="server" style="z-index: 1; left: 158px; top: 243px; position: absolute" Text="More Permissions" />
        </p>
        <p>
            <asp:Label ID="lblStaffEmail" runat="server" style="z-index: 1; left: 13px; top: 128px; position: absolute" width="124px">Staff Email</asp:Label>
        </p>
        <p>
            <asp:Label ID="lblStaffPhonenumber" runat="server" style="z-index: 1; left: 13px; top: 166px; position: absolute">Staff Phone Number</asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:TextBox ID="txtJoinDate" runat="server" style="z-index: 1; left: 158px; top: 90px; position: absolute"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 13px; top: 292px; position: absolute" width="124px"></asp:Label>
        </p>
        <p>
            <asp:TextBox ID="txtStaffSalary" runat="server" style="z-index: 1; left: 158px; top: 203px; position: absolute"></asp:TextBox>
        </p>
        <p>
            <asp:TextBox ID="txtStaffEmail" runat="server" style="z-index: 1; left: 158px; top: 127px; position: absolute"></asp:TextBox>
        </p>
        <p>
            <asp:TextBox ID="txtStaffPhoneNumber" runat="server" style="z-index: 1; left: 158px; top: 165px; position: absolute"></asp:TextBox>
            <asp:Button ID="btnOk" runat="server" OnClick="btnOk_Click" style="z-index: 1; left: 59px; top: 321px; position: absolute" Text="Ok" />
        </p>
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 192px; top: 323px; position: absolute" Text="Cancel" />
    </form>
</body>
</html>
