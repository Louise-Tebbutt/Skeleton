<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 493px">
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            <asp:Label ID="lblStaffId" runat="server" style="z-index: 1; left: 22px; top: 54px; position: absolute; bottom: 836px" Text="Staff Id" width="124px"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtStaffId" runat="server" style="z-index: 1; left: 192px; top: 54px; position: absolute"></asp:TextBox>
            <asp:Button ID="btnFind" runat="server" Height="23px" OnClick="btnFind_Click" style="margin-left: 196px; margin-bottom: 6px" Text="Find" Width="86px" />
        </p>
        <p>
            <asp:Label ID="lblStaffSalary" runat="server" style="z-index: 1; left: 22px; top: 296px; position: absolute" width="124px">Staff Salary</asp:Label>
            <asp:Label ID="lblStaffName" runat="server" style="z-index: 1; left: 22px; top: 104px; position: absolute; right: 1507px;" width="124px">Staff Name</asp:Label>
        </p>
        <p>
            <asp:Label ID="lblJoinDate" runat="server" style="z-index: 1; left: 22px; top: 153px; position: absolute" width="124px">Join date</asp:Label>
        </p>
        <p>
            <asp:CheckBox ID="chkMorePermissions" runat="server" style="z-index: 1; left: 192px; top: 345px; position: absolute" Text="More Permissions" />
        </p>
        <p>
            <asp:Label ID="lblStaffEmail" runat="server" style="z-index: 1; left: 22px; top: 205px; position: absolute" width="124px">Staff Email</asp:Label>
        </p>
        <p>
            <asp:Label ID="lblStaffPhonenumber" runat="server" style="z-index: 1; left: 22px; top: 251px; position: absolute">Staff Phone Number</asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:TextBox ID="txtJoinDate" runat="server" style="z-index: 1; left: 192px; top: 152px; position: absolute"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 22px; top: 386px; position: absolute" width="124px"></asp:Label>
        </p>
        <p>
            <asp:TextBox ID="txtStaffSalary" runat="server" style="z-index: 1; left: 192px; top: 295px; position: absolute"></asp:TextBox>
        </p>
        <p>
            <asp:TextBox ID="txtStaffEmail" runat="server" style="z-index: 1; left: 192px; top: 204px; position: absolute"></asp:TextBox>
        </p>
        <p>
            <asp:TextBox ID="txtStaffPhoneNumber" runat="server" style="z-index: 1; left: 192px; top: 250px; position: absolute"></asp:TextBox>
            <asp:Button ID="btnOk" runat="server" OnClick="btnOk_Click" style="z-index: 1; left: 68px; top: 435px; position: absolute" Text="Ok" />
        </p>
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 226px; top: 435px; position: absolute" Text="Cancel" />
        <p>
            <asp:TextBox ID="txtStaffName" runat="server" style="z-index: 1; left: 192px; top: 103px; position: absolute"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
