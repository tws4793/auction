<%@ Page Title="" Language="C#" MasterPageFile="~/Header.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style2
        {
            width: 73px;
        }
        .style3
        {
            width: 197px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        <table style="width: 65%;">
            <tr>
                <td class="style2">
                    Login</td>
                <td class="style3">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style2">
                    Username:</td>
                <td class="style3">
                    <asp:TextBox ID="txtUser" runat="server" Width="210px"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                        ControlToValidate="txtUser" ErrorMessage="Please Enter User Name"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    Password:</td>
                <td>
                    <asp:TextBox ID="txtPass" runat="server" Width="210px" TextMode="Password"></asp:TextBox>
                </td>
                &nbsp;<td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                        ControlToValidate="txtPass" ErrorMessage="Please Enter Password"></asp:RequiredFieldValidator>
                </td>
            </tr>
            &nbsp;<tr>
                <td class="style2">
                    &nbsp;</td>
                <td style="text-align: right">
                    <asp:Button ID="btnLogin" runat="server" onclick="Button1_Click" Text="Login" 
                        style="text-align: right" Width="72px" />
                    &nbsp;</td>
                <td>
    <asp:Label ID="lblIncorrect" runat="server" Font-Bold="False" ForeColor="Red" 
        Text="The username or password you have entered is wrong!" Visible="False"></asp:Label>
                </td>
            </tr>
        </table>
    </p>
    </asp:Content>

