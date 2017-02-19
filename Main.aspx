<%@ Page Title="" Language="C#" MasterPageFile="~/HeadSub.master" AutoEventWireup="true" CodeFile="Main.aspx.cs" Inherits="Main" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br />
<table style="width: 100%;">
    <tr>
        <td align="left" dir="ltr" style="width: 419px; height: 135px" valign="top">
    <asp:Button ID="but_search" runat="server" Text="Search for Item" 
    onclick="but_log_Click" Height="117px" Width="345px" 
    Font-Size="XX-Large" />
        </td>
        <td align="left" dir="ltr" style="height: 135px" valign="top">
    <asp:Button ID="but_uitem" runat="server" Text="View My Products" 
    onclick="but_uitem_Click" Height="117px" Width="345px" 
    Font-Size="XX-Large" Visible="False" />
        </td>
    </tr>
    <tr>
        <td style="width: 419px">
    <asp:Button ID="but_add" runat="server" Text="Add New Item" 
    onclick="but_add_Click" Height="117px" Width="345px" 
    Font-Size="XX-Large" />
        </td>
        <td>
    <asp:Button ID="but_pur" runat="server" Text="View My Bids" 
    onclick="but_pur_Click" Height="117px" Width="345px" 
    Font-Size="XX-Large" Visible="False" />
        </td>
    </tr>
    <tr>
        <td style="width: 419px">
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
</table>
</asp:Content>

