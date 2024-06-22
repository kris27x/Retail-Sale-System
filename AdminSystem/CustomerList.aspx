<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 674px">
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstCustomerList" runat="server" Height="436px" Width="468px"></asp:ListBox>
        <p>
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" />
            <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" Text="Edit" />
            <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete" />
        </p>
        <p>
        <asp:Label ID="lblError" runat="server"></asp:Label>
        </p>
        <asp:Label ID="lblNameSearch" runat="server" Text="Enter a name: "></asp:Label>
        <asp:TextBox ID="txtNameSearch" runat="server" style="margin-top: 0px"></asp:TextBox>
        <p>
            <asp:Button ID="btnApply" runat="server" OnClick="btnApply_Click" Text="Apply" />
            <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" Text="Clear" />
        </p>
    </form>
</body>
</html>
