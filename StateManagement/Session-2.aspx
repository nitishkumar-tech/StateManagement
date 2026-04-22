<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Session-2.aspx.cs" Inherits="StateManagement.Session_2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div>
            <h3>Session-2.aspx</h3>

            <table>
                <tr>
                    <td colspan="2">
                        Welcome <b>
                            <asp:Label ID="lblString" runat="server"></asp:Label>
                        </b>
                    </td>
                </tr>

                <tr>
                    <td>Your FirstName:</td>
                    <td>
                        <b>
                            <asp:Label ID="lblfName" runat="server"></asp:Label>
                        </b>
                    </td>
                </tr>

                <tr>
                    <td>Your LastName</td>
                    <td>
                        <b>
                            <asp:Label ID="lbllName" runat="server"></asp:Label>
                        </b>
                    </td>
                </tr>

                <tr>
                    <td></td>
                    <td></td>
                </tr>
            </table>

        </div>
        </div>
    </form>
</body>
</html>
