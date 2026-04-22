<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cookie-1.aspx.cs" Inherits="StateManagement.Cookie_1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <table>
     
     <tr>
         <td>
             <asp:Label ID="Labelusername" runat="server" Text="Username"></asp:Label>
         </td>
         <td>
             <asp:TextBox ID="textusername" runat="server"></asp:TextBox>
         </td>
     </tr>

     <tr>
         <td>
             <asp:Label ID="Labelpassword" runat="server" Text="Password:"></asp:Label>
         </td>
         <td>
             <asp:TextBox ID="textpassword" runat="server" ></asp:TextBox>
         </td>
     </tr>
     <tr>
         <td></td>
         <td>
             <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
         </td>
     </tr>

 </table>
        </div>
    </form>
</body>
</html>
