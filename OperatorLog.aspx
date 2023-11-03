<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OperatorLog.aspx.cs" Inherits="StudentManagementSys.OperatorLog" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
     body{
         background-color:wheat;
     }
</style>
</head>
<body>
    <form id="form1" runat="server">
        <div>

             <table style="margin:auto; border:5px solid white">
    <tr>
        <td>
            <asp:Label ID="Label3" runat="server" Text="Operator User: "></asp:Label></td>
    </tr>
     <tr>
         <td>
             <asp:Label ID="Label1" runat="server" Text="User Name: "></asp:Label>
         </td>
     </tr>
     <tr>
         <td>
             <asp:TextBox ID="OPTextBoxUserName" runat="server"></asp:TextBox>
         </td>
     </tr>
     <tr>
         <td>
             <asp:Label ID="Label2" runat="server" Text="Password: "></asp:Label>

         </td>
     </tr>
     <tr>
         <td>
             <asp:TextBox ID="OPTextBoxPassword" runat="server" TextMode ="Password"></asp:TextBox>
         </td>
     </tr>
     <tr>
         <td>
             <asp:Button ID="OPButtonLog" runat="server" Text="Login" OnClick="OPButtonLog_Click" />
         </td>
     </tr>
     <tr>
         <td>
             <asp:Label ID="lblErrorMessage" runat="server" Text="Incorrect username or password!" ForeColor="Red"></asp:Label></td>
     </tr>
 </table>
        </div>
    </form>
</body>
</html>
