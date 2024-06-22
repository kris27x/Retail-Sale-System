<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 609px">
    <form id="form1" runat="server">
        <div style="height: 15px">
            <asp:Label ID="lblCustomerID" runat="server" Text="Customer ID" Width="85px"></asp:Label>
            <asp:TextBox ID="txtCustomerID" runat="server"></asp:TextBox>
        </div>
        <p>
            <asp:Label ID="lblName" runat="server" Text="Name" width="85px"></asp:Label>
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="lblEmail" runat="server" Text="Email" width="85px"></asp:Label>
        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="lblAddress" runat="server" Text="Address" width="85px"></asp:Label>
            <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="lblDateAdded" runat="server" Text="Date Added" width="85px"></asp:Label>
        <asp:TextBox ID="txtDateAdded" runat="server"></asp:TextBox>
        <p>
            <asp:CheckBox ID="chkReceiveMarketing" runat="server" Text="Receive Marketing" />
        </p>
        <asp:Label ID="lblError" runat="server"></asp:Label>
        <p>
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
            <asp:Button ID="BtnCancel" runat="server" Text="Cancel" OnClick="BtnCancel_Click" />
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" />
        </p>
    </form>
</body>
</html>
