<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewSession-1.aspx.cs" Inherits="StateManagement.NewSession_1" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Session Example</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:Label ID="Label1" runat="server" Text="Click Button"></asp:Label>
            <br /><br />

            <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
            <br /><br />

            <asp:Label ID="lblCount" runat="server"></asp:Label>

        </div>
    </form>
</body>
</html>