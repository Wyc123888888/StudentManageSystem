<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentRes.aspx.cs" Inherits="StudentManagementSys.StudentRes" %>

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
                        <h2> Student Registeration Page</h2>
                    </td>
                </tr>
                <tr>
                    <td style="width:50%"><b>Student ID: </b></td>
                    <td>
                        <asp:TextBox ID="TextBoxStdId" runat="server" Height="31px" Width="308px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style="width:50%"><b>First Name: </b></td>
                    <td>
                        <asp:TextBox ID="TextBoxStdFN" runat="server" Height="29px" Width="308px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style="width:50%"><b>Last Name: </b></td>
                    <td>
                        <asp:TextBox ID="TextBoxStdLN" runat="server" Height="33px" Width="308px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style="width:50%"><b>Email: </b></td>
                    <td>
                        <asp:TextBox ID="TextBoxEmail" runat="server" Height="30px" Width="304px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style="width:50%"><b>Enrollment Date: </b></td>
                    <td>
                        <asp:TextBox ID="TextBoxStdED" runat="server" Height="38px" Width="304px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style="width:50%"><b>Subject: </b></td>
                    <td>
                        <asp:TextBox ID="TextBoxStdSubject" runat="server" Height="27px" Width="301px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style="width:50%"><b>UserName: </b></td>
                    <td>
                        <asp:TextBox ID="TextBoxStdUserN" runat="server" Height="37px" Width="302px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style="width:50%"><b>Password: </b></td>
                    <td>
                        <asp:TextBox ID="TextBoxStdPassword" runat="server" Height="34px" Width="302px" TextMode="Password"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="2" align="center" >

                        <asp:Button ID="ButtonStdSignUp" runat="server" Text="SignUp" OnClick="ButtonStdSignUp_Click" />

                        <asp:Button ID="ButtonStdSignUpReturn" runat="server" Text="Return" OnClick="ButtonStdSignUpReturn_Click" />

                    </td>

                </tr>
                <tr>
                    <td colspan="2" align="center">

                        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>

                    </td>
                </tr>
                

            </table>
            
        </div>
    </form>
</body>
</html>
