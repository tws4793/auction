<%@ Page Title="" Language="C#" MasterPageFile="~/HeadSub.master" AutoEventWireup="true" CodeFile="product.aspx.cs" Inherits="product" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div>
        <asp:Label ID="lbl_name" runat="server" Font-Size="X-Large" 
            Text="Product Name"></asp:Label>
        <br />
        <br />
        <table style="width:100%;">
            <tr>
                <td class="attr" style="width: 180px">
                    By User&nbsp; :
                </td>
                <td>
                    <asp:Label ID="lbl_starter" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="attr" style="width: 180px; height: 23px;">
                    Description :
                </td>
                <td style="height: 23px">
                    <asp:Label ID="lbl_des" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="attr" style="width: 180px">
                    Condition :
                </td>
                <td>
                    <asp:Label ID="lbl_cond" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="attr" style="width: 180px">
                    Quantity :
                </td>
                <td>
                    <asp:Label ID="lbl_Qty" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="attr" style="width: 180px">
                    Start Time:</td>
                <td>
                    <asp:Label ID="lbl_start" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="attr" style="width: 180px">
                    Duration :</td>
                <td>
                    <asp:Label ID="lbl_dur" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="attr" style="width: 180px">
                    Auction End :
                </td>
                <td>
                    <asp:Label ID="lbl_end" runat="server"></asp:Label>
                    </td>
            </tr>
            <tr>
                <td class="attr" style="width: 180px">
                    Starting Bid :
                </td>
                <td>
                    <asp:Label ID="lbl_startbid" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="attr" style="width: 180px">
                    Current Bid :</td>
                <td>
                    <asp:Label ID="lbl_bid" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="attr" style="width: 180px">
                    Bid Amount :
                </td>
                <td>
                    <asp:TextBox ID="txt_bid" runat="server" Font-Size="Large"></asp:TextBox>
&nbsp;<asp:Button ID="but_bid" runat="server" Font-Size="Large" Text="Place Bid" 
                        onclick="but_bid_Click" />
                    <asp:Label ID="lbl_error" runat="server" Font-Bold="True" ForeColor="Red" 
                        Font-Size="Large"></asp:Label>
                    <br />
                    <asp:RequiredFieldValidator ID="rfvBidAmt" runat="server" 
                        ControlToValidate="txt_bid" ErrorMessage="Bid amount not entered!" 
                        Font-Bold="True" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="attr" style="width: 180px; height: 23px;">
                    Current Highest Bidder :
                </td>
                <td style="height: 23px">
                    <asp:Label ID="lbl_bidder" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
        <br />
        <asp:Button ID="btnBack" runat="server" Text="Back to Search" 
            CausesValidation="False" onclick="btnBack_Click" />
    &nbsp;&nbsp;&nbsp;
        <asp:Button ID="but_main" runat="server" Text="Back to Main" 
            CausesValidation="False" onclick="but_main_Click" />
    </div>
</asp:Content>

