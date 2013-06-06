<%@ Page Language="C#" AutoEventWireup="true" CodeFile="getEmployees.aspx.cs" Inherits="getEmployees" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <p style="text-align: center">
            <a href="Default.aspx">Home</a> | <a href="addEmployees.aspx">Create</a> | <a href="getEmployees.aspx">Read</a>
            | <a href="updateEmployees.aspx">Update</a> | <a href="deleteEmployees.aspx">Delete</a>
        </p>

        <asp:Button ID="btnExample" runat="server" Text="Example" OnClick="btnExample_Click" />
        &nbsp;
        <asp:Button ID="btnEmployee" runat="server" Text="Employee" OnClick="btnEmployee_Click" />
        &nbsp;
        <asp:Button ID="btnCustomer" runat="server" Text="Customer" OnClick="btnCustomer_Click" />
        &nbsp;
        <asp:Button ID="btnWorkOrder" runat="server" Text="Work Order" OnClick="btnWorkOrder_Click" />


    </div>
    </form>
</body>
</html>
