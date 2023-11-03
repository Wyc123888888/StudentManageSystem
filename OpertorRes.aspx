<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OpertorRes.aspx.cs" Inherits="StudentManagementSys.OpertorRes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    </head>
<body>
    <form id="form1" runat="server">
        <div>
            
            <table align="center" style="width: 700px; height: 600px; background-color: #5f98f3">
                <tr>
                    <td colspan="2" align="center">
                        <h2>Operator Registration Page</h2>

                    </td>
                    
                </tr>
                <tr>
                    <td style="width:50%">Operator ID:</td>
                    <td>
                        <asp:TextBox ID="TextBoxOPID" runat="server" Height="30px" Width="263px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style="width:50%">First Name: </td>
                    <td>
                        <asp:TextBox ID="TextBoxOPFN" runat="server" Height="30px" Width="263px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style="width:50%">Last Name: </td>
                    <td>
                        <asp:TextBox ID="TextBoxOPLN" runat="server" Height="30px" Width="263px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style="width:50%">Email: </td>
                    <td>
                        <asp:TextBox ID="TextBoxOPEMAIL" runat="server" Height="30px" Width="263px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style="width:50%">UserName:</td>
                    <td>
                        <asp:TextBox ID="TextBoxOPUN" runat="server" Height="30px" Width="263px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style="width:50%">Password: </td>
                    <td>
                        <asp:TextBox ID="TextBoxOPPASS" runat="server" Height="30px" Width="263px" TextMode="Password"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="2" align="center">
                        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td align="center">
                        <asp:Button ID="ButtonOpRes" runat="server" Text="SignUp" OnClick="ButtonOpRes_Click" />
                    </td>
                    <td align="center">
                        <asp:Button ID="ButtonOpResReturn" runat="server" Text="Return" OnClick="ButtonOpResReturn_Click" />
                    </td>
                </tr>
            </table>
            
        </div>
    </form>
</body>
</html>
