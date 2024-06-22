<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblOrderID" runat="server" Text="Order number" width="198px"></asp:Label>
        <asp:TextBox ID="txtOrderID" runat="server" style="margin-left: 27px" width="206px"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnFind" runat="server" OnClick="lblFind_Click" Text="Find" />
&nbsp;<p>
            <asp:Label ID="lblPhoneNumber" runat="server" Text="Add Phone Number" width="198px"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtPhoneNumber" runat="server" width="206px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblItemQuantity" runat="server" Text="Number of Item(s)" width="198px"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtItemQuantity" runat="server" width="206px"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:CheckBox ID="chkDelivered" runat="server" Text="Delivery?" width="198px" />
        </p>
        <p>
            <asp:Label ID="lblDeliveryTime" runat="server" Text="Time for the delivery" width="198px"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtDeliveryTime" runat="server" width="206px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblDeliveryAddress" runat="server" Text="Address to drop off" width="198px"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtDeliveryAddress" runat="server" width="206px"></asp:TextBox>
        </p>
        <p>
&nbsp;
            <asp:Label ID="lblNotes" runat="server" Text="Any Instruction. (please specify)." width="198px"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtNotes" runat="server" width="206px" style="margin-top: 0px"></asp:TextBox>
        </p>
        <p>
&nbsp;&nbsp;&nbsp;
            </p>
        <asp:Label ID="lblError" runat="server" width="198px"></asp:Label>
        <p>
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" width="86px" />
            <asp:Button ID="btnCancel" runat="server" style="margin-left: 28px" Text="Cancel" width="86px" OnClick="btnCancel_Click" />
        </p>
    </form>
</body>
</html>
