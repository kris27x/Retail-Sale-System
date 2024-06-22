<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    This is the staff data entry
    <form id="lblStaffID" runat="server">
        <div>
        </div>
        StaffID&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="textStaffID" runat="server"></asp:TextBox>
        <p id="lblStartDate">
            StartDate&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="textStartDate" runat="server"></asp:TextBox>
        </p>
        <p id="lblStaffFullName">
            StaffFullName&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="textStaffFullName" runat="server"></asp:TextBox>
        </p>
        <p id="lblStaffRole">
            StaffRole&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="textStaffRole" runat="server"></asp:TextBox>
        </p>
        <p id="lblCustomerID">
            CustomerID&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="textCustomerID" runat="server"></asp:TextBox>
        </p>
        <p id="lblAvailability">
            Availbility&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="textAvailability" runat="server"></asp:TextBox>
        </p>
        <br />
        <asp:Label ID="lblError" runat="server" Text="lblError"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnOK" runat="server" Text="OK" OnClick="btnOK_Click" />
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
    </form>
</body>
</html>
