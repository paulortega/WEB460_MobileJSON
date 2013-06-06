<%@ Page Language="C#" AutoEventWireup="true" CodeFile="updateEmployees.aspx.cs" Inherits="updateEmployees" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <p style="text-align: center">
            <a href="Default.aspx">Home</a> | <a href="addEmployees.aspx">Create</a> | <a href="getEmployees.aspx">Read</a>
            | <a href="updateEmployees.aspx">Update</a> | <a href="deleteEmployees.aspx">Delete</a>
        </p>
        <br />
        <asp:Label ID="lblMessage" runat="server" Text="Label" Visible="false"></asp:Label>
    </div>
    </form>
</body>
</html>
