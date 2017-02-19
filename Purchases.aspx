<%@ Page Title="" Language="C#" MasterPageFile="~/HeadSub.master" AutoEventWireup="true" CodeFile="Purchases.aspx.cs" Inherits="Purchases" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p style="font-size: xx-large">
    <strong>My Bids 
</p>
    <asp:Panel ID="panel_payment" runat="server" Height="139px" Visible="False">
        <table style="width:100%;">
            <tr>
                <td style="width: 162px">
                    Due Amount:</td>
                <strong>
                <td>
                    <asp:Label ID="lbl_bidamt" runat="server"></asp:Label>
                </td>
                <td>
                    &nbsp;</td>
                </strong>
            </tr>
            <tr>
                <td style="width: 162px">
                    Payment Method:<br />
                </td>
                <td>
                    <asp:RadioButtonList ID="rbl_method" runat="server">
                        <asp:ListItem>Master</asp:ListItem>
                        <asp:ListItem>Visa</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="width: 162px">
                    &nbsp;</td>
                <td>
                    <asp:Button ID="but_pay" runat="server" Text="Make Payment" 
                        onclick="but_pay_Click" />
                </td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
</strong>
    </asp:Panel>
    <asp:Panel ID="panel_paid" runat="server" Height="139px" Visible="False">
        <table style="width:100%;">
            <tr>
                <td style="width: 162px">
                    Transaction ID:</td>
                <td>
                    <strong>
                    <asp:Label ID="lbl_transID" runat="server"></asp:Label>
                    </strong>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="width: 162px">
                    Transaction Amount:</td>
                <strong>
                <td>
                    <asp:Label ID="lbl_paidamt" runat="server"></asp:Label>
                </td>
                <td>
                    &nbsp;</td>
                </strong>
            </tr>
            <tr>
                <td style="width: 162px">
                    Paid to:</td>
                <td>
                    <strong>
                    <asp:Label ID="lbl_seller" runat="server"></asp:Label>
                    </strong>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="width: 162px">
                    Payment Method:<br />
                </td>
                <td>
                    <strong>
                    <asp:Label ID="lbl_method" runat="server"></asp:Label>
                    </strong>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
</strong>
    </asp:Panel>
<asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" 
    Height="171px" Width="1002px" onrowcommand="GridView1_RowCommand1">
    <AlternatingRowStyle BackColor="White" />
    <Columns>
        <asp:ButtonField ButtonType="Button" Text="Payment Info" />
    </Columns>
    <EditRowStyle BackColor="#2461BF" />
    <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
    <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
    <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
    <RowStyle BackColor="#EFF3FB" />
    <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
</asp:GridView>
</strong>
<p style="font-size: xx-large">
    <strong>
    <asp:Button ID="but_back" runat="server" Height="31px" onclick="but_back_Click" 
        Text="Return to Main" />
    </strong>
</p>
</asp:Content>

