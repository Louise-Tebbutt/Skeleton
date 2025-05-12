<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrdersDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
  <form id="form1" runat="server">
        <div>
            THIS IS AN ORDER PAGE
        </div>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 21px; top: 42px; position: absolute" Text="OrderId"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" style="z-index: 1; left: 144px; top: 70px; position: absolute"></asp:TextBox>
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 21px; top: 76px; position: absolute" Text="CustomerId"></asp:Label>
        <p>
            <asp:TextBox ID="TextBox2" runat="server" style="z-index: 1; left: 142px; top: 38px; position: absolute"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:TextBox ID="TextBox3" runat="server"  style="z-index: 1; left: 144px; top: 101px; position: absolute"></asp:TextBox>
            <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 19px; top: 106px; position: absolute" Text="Order Date"></asp:Label>
            <asp:Label ID="Label4" runat="server" style="z-index: 1; left: 19px; top: 142px; position: absolute" Text="Total Amount"></asp:Label>
        </p>
        <p>
            <asp:TextBox ID="TextBox5" runat="server" style="z-index: 1; left: 148px; top: 175px; position: absolute"></asp:TextBox>
        </p>
        <p>
            <asp:TextBox ID="TextBox4" runat="server" style="z-index: 1; left: 146px; top: 136px; position: absolute"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label5" runat="server" style="z-index: 1; left: 20px; top: 176px; position: absolute" Text="Payment Status"></asp:Label>
        </p>
        <asp:Label ID="Label6" runat="server" style="z-index: 1; left: 19px; top: 215px; position: absolute" Text="Shipping Address"></asp:Label>
        <asp:TextBox ID="TextBox6" runat="server" style="z-index: 1; left: 147px; top: 213px; position: absolute"></asp:TextBox>
        <asp:Label ID="Label7" runat="server" style="z-index: 1; left: 25px; top: 255px; position: absolute" Text="StaffId"></asp:Label>
        <asp:TextBox ID="TextBox7" runat="server" style="z-index: 1; left: 146px; top: 254px; position: absolute"></asp:TextBox>
        <p>
            <asp:CheckBox ID="CheckBox1" runat="server" style="z-index: 1; left: 166px; top: 302px; position: absolute" Text="Active" />
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" style="z-index: 1; left: 57px; top: 334px; position: absolute" Text="OK" OnClick="Button1_Click" />
        </p>
        <asp:Button ID="Button2" runat="server" style="z-index: 1; left: 163px; top: 335px; position: absolute" Text="Cancel" />
        <asp:Label ID="IblError" runat="server" style="z-index: 1; left: 20px; top: 310px; position: absolute"></asp:Label>
    </form>
</body>
</html>
