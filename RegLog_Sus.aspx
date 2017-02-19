<%@ Page Title="" Language="C#" MasterPageFile="~/Header.master" AutoEventWireup="true" CodeFile="RegLog_Sus.aspx.cs" Inherits="Reg_Sus" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style2
        {
            height: 49px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width:100%;">
        <tr>
            <td style="text-align: center">
                <asp:Label ID="lab_title" runat="server" Font-Bold="True" Font-Size="Large" 
                    style="text-align: center" Text="Registration Successful!"></asp:Label>
                <br />
                <asp:Label ID="lab_name" runat="server" Font-Bold="False" Font-Size="Medium" 
                    style="text-align: center"></asp:Label>
&nbsp;<asp:Label ID="lab_text" runat="server" Font-Bold="False" Font-Size="Medium" 
                    style="text-align: center" Text="has been sucessfully registed!"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style2" style="text-align: center">
                <asp:Button ID="but_return" runat="server" onclick="but_return_Click" 
                    Text="Return to Previous Page" Width="171px" />
            </td>
        </tr>
    </table>
</asp:Content>

