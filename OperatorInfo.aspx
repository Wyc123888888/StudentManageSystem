<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OperatorInfo.aspx.cs" Inherits="StudentManagementSys.OperatorInfo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 265px;
        }
        .auto-style2 {
            width: 17%;
        }
    </style>
    </head>
<body>
    <form id="form1" runat="server">
        <div>
            
            
            <table align="center" style="background-color: #00FFFF; width: 700px; height: 700px">
                <tr>
                    <td colspan="2" align="center">
                        <h2>Operator Controll Page</h2>
                    </td>
                    
                </tr>
                <tr>
                    <td style="width:50%">Student ID: </td>
                    <td class="auto-style1">
                        <asp:TextBox ID="TextBoxConStdID" runat="server" Height="34px" Width="292px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style="width:50%">First Name: </td>
                    <td class="auto-style1">
                        <asp:TextBox ID="TextBoxConStdFN" runat="server" Height="34px" Width="292px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style="width:50%">Last Name: </td>
                    <td class="auto-style1">
                        <asp:TextBox ID="TextBoxConStdLN" runat="server" Height="34px" Width="292px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style="width:50%">Email: </td>
                    <td class="auto-style1">
                        <asp:TextBox ID="TextBoxConStdEMAIL" runat="server" Height="34px" Width="292px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style="width:50%">Enrollment Date: </td>
                    <td class="auto-style1">
                        <asp:TextBox ID="TextBoxConStdED" runat="server" Height="34px" Width="292px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style="width:50%">Subject: </td>
                    <td class="auto-style1">
                        <asp:TextBox ID="TextBoxConStdSUB" runat="server" Height="34px" Width="292px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style="width:50%">UserName: </td>
                    <td class="auto-style1">
                        <asp:TextBox ID="TextBoxConStdUN" runat="server" Height="34px" Width="292px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style="width:50%">Password: </td>
                    <td class="auto-style1">
                        <asp:TextBox ID="TextBoxConStdP" runat="server" Height="34px" Width="292px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="2" align="center">

                        <asp:GridView ID="GridViewConStd" runat="server"></asp:GridView>

                    </td>
                </tr>
                <tr>
                    <td style="width:50%" align="center">
                        <asp:Button ID="ButtonConStdInsert" runat="server" Text="Insert" OnClick="ButtonConStdInsert_Click" />
                    </td>
                    <td style="width:50%" align="center">
                        <asp:Button ID="ButtonConStdDelete" runat="server" Text="Delete" OnClick="ButtonConStdDelete_Click" />
                    </td>
                </tr>
                <tr>
                     <td style="width:50%" align="center">
                        <asp:Button ID="ButtonConStdUpdate" runat="server" Text="Update" OnClick="ButtonConStdUpdate_Click"  />
                    </td >
                    <td style="width:50%" align="center">

                        <asp:Button ID="ButtonConStdClear" runat="server" Text="Clear" OnClick="ButtonConStdClear_Click" />

                    </td>
                </tr>
                <tr>
                    <td tyle="width:50%" align="center">
                        <asp:Button ID="ButtonConStdShow" runat="server" Text="Show" OnClick="ButtonConStdShow_Click" />
                    </td>
                    <td tyle="width:50%" align="center">
                        <asp:Button ID="ButtonConStdSearch" runat="server" Text="Search" OnClick="ButtonConStdSearch_Click" />
                    </td>
                </tr>
                <tr >
                    <td colspan="2" align="center"><asp:Label ID="Label1" runat="server" Text=""></asp:Label></td>
                </tr>
            </table>
            
            
        </div>
    </form>
</body>
</html>
