<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Main.aspx.cs" Inherits="StudentManagementSys.Main" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 305px; width: 1426px">
    <form id="form1" runat="server">
        <div>
            <table style="margin:auto; border:5px solid white">
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="Welcome To  Student Management System Please Select Your Identifcation:"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="ButtonStd" runat="server" Text="Student" OnClick="ButtonStd_Click" /></td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="ButtonOperator" runat="server" Text="Operator" OnClick="ButtonOperator_Click" />

                    </td>
                </tr>
                <tr>
                    
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="New To Our System? Sign Up Now！"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="ButtonStdRes" runat="server" Text="StudentSignUp" OnClick="ButtonStdRes_Clik" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="ButtonOpertorRes" runat="server" Text="OpertorSignUp" OnClick="ButtonOpertorRes_Click" />
                    </td>
                </tr>
            </table>
                        
        </div>
        
    </form>
</body>
</html>
