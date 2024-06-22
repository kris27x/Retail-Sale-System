<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SupplierDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblSupplierId" runat="server" Text="Supplier ID" width="91px"></asp:Label>
        <asp:TextBox ID="txtSupplierId" runat="server"></asp:TextBox>
        <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" />
        <p>
            <asp:Label ID="lblProduct" runat="server" Text="Product" width="91px"></asp:Label>
            <asp:TextBox ID="txtSupplierProduct" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblFeedback" runat="server" Text="Feedback" width="91px"></asp:Label>
            <asp:TextBox ID="txtSupplierFeedback" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblPrice" runat="server" Text="Price" width="91px"></asp:Label>
            <asp:TextBox ID="txtSupplierPrice" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblDeliveryDate" runat="server" Text="Delivery Date"></asp:Label>
            <asp:TextBox ID="txtDeliveryDate" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblStock" runat="server" Text="In Stock"></asp:Label>
            <asp:TextBox ID="txtStock" runat="server"></asp:TextBox>
        </p>
            <asp:Label ID="lblError" runat="server"></asp:Label>
        <p>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
        </p>
    </form>
</body>
</html>
