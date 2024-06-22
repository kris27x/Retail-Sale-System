<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div id="ItemNo">
            <asp:Label ID="lblItemNo" runat="server" Text="Item No"></asp:Label>
            <asp:TextBox ID="txtItemNo" runat="server"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnFind" runat="server" OnClick="Button1_Click" Text="Find" />
            <br />
            <br />
        </div>
        <asp:Label ID="lblItemDescription" runat="server" Text="Item Description"></asp:Label>
        <p>
            <asp:TextBox ID="txtItemDescription" runat="server" Height="88px" Width="435px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblItemQuantity" runat="server" Text="Item Quantity"></asp:Label>
            <asp:TextBox ID="txtItemQuantity" runat="server" OnTextChanged="TextBox2_TextChanged" Width="94px"></asp:TextBox>
        </p>
        <asp:Label ID="lblDateAdded" runat="server" Text="Date Added"></asp:Label>
        <asp:TextBox ID="txtDateAdded" runat="server" Width="115px"></asp:TextBox>
        <p>
            <asp:Label ID="lblPrice" runat="server" Text="Price"></asp:Label>
            <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:CheckBox ID="ChkAvailable" runat="server" Text="Available" />
        </p>
        <asp:Label ID="lblError" runat="server"></asp:Label>
        <p>
            <asp:Button ID="BtnOK" runat="server" OnClick="BtnOK_Click" Text="OK" />
            <asp:Button ID="BtnCancel" runat="server" OnClick="BtnCancel_Click" Text="Cancel" Width="62px" />
        </p>
    </form>
</body>
</html>
