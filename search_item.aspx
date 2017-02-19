<%@ Page Title="" Language="C#" MasterPageFile="~/HeadSub.master" AutoEventWireup="true" CodeFile="search_item.aspx.cs" Inherits="search_item" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p style="font-size: x-large">
    Item Search </p>
<p style="font-size: x-large">
    <table style="width: 59%; margin-top: 0px;">
        <tr>
            <td bgcolor="#FFFFCC" 
                style="font-size: medium; width: 32px; text-align: center; height: 26px;">
                <asp:CheckBox ID="cb_cat" runat="server" Text="*" />
            </td>
            <td style="font-size: medium; width: 66px; text-align: right; height: 26px;" 
                bgcolor="#FFFFCC">
                Category : </td>
            <td style="width: 170px; height: 26px;">
                <asp:DropDownList ID="ddl_cat" runat="server" Height="26px" Width="282px">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td bgcolor="#FFFFCC" 
                style="font-size: medium; width: 32px; text-align: center; height: 26px;">
                <asp:CheckBox ID="cb_condi" runat="server" Text="*" />
            </td>
            <td style="width: 66px; font-size: medium; height: 26px; text-align: right;" 
                bgcolor="#FFFFCC">
                Condition : </td>
            <td style="width: 170px; height: 26px;">
                <asp:DropDownList ID="ddl_condi" runat="server" Height="26px" Width="282px" 
                    style="margin-left: 0px">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td bgcolor="#FFFFCC" 
                style="font-size: medium; width: 32px; text-align: center; height: 26px;">
                <asp:CheckBox ID="cb_name" runat="server" Text="*" />
            </td>
            <td style="width: 66px; font-size: medium; height: 26px; text-align: right;" 
                bgcolor="#FFFFCC">
                Name:</td>
            <td style="width: 170px; height: 26px;">
                <asp:TextBox ID="txt_name" runat="server" Height="26px" Width="326px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="font-size: medium; width: 32px; text-align: center">
                &nbsp;</td>
            <td style="width: 66px; font-size: medium">
                &nbsp;</td>
            <td style="font-size: medium; width: 170px">
                <asp:CheckBox ID="cb_status" runat="server" Text="Show Only Ongoing Autions" 
                    Font-Bold="False" Width="300px" Checked="True" />
            </td>
        </tr>
        <tr>
            <td style="font-size: medium; width: 32px; text-align: center">
                &nbsp;</td>
            <td style="width: 66px; font-size: medium">
                &nbsp;</td>
            <td style="font-size: medium; width: 170px">
                &nbsp;<asp:Button ID="but_search" runat="server" onclick="but_search_Click" 
                    Text="Search" Width="89px" />
            </td>
        </tr>
    </table>
</p>
                *Check checkbox to select search criterion&nbsp;&nbsp;
                <asp:Label ID="test" runat="server"></asp:Label>
                <br />
                <br />
<asp:GridView ID="GridView1" runat="server" CellPadding="4" 
    EnableModelValidation="True" ForeColor="#333333" GridLines="None" 
    Height="171px" Width="1002px" onrowcommand="GridView1_RowCommand1">
    <AlternatingRowStyle BackColor="White" />
    <Columns>
        <asp:ButtonField ButtonType="Button" Text="Go to Item" />
    </Columns>
    <EditRowStyle BackColor="#2461BF" />
    <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
    <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
    <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
    <RowStyle BackColor="#EFF3FB" />
    <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
</asp:GridView>
<br />
<strong>
<asp:Button ID="but_back" runat="server" Height="31px" onclick="but_back_Click" 
    Text="Return to Main" />
</strong>
<br />
</asp:Content>

