<%@ Page Title="" Language="C#" MasterPageFile="~/Header.master" AutoEventWireup="true" CodeFile="new_product_conf.aspx.cs" Inherits="new_product_conf" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style2
        {
            font-size: large;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        <br />
        <table align="center" style="width:100%;">
            <tr>
                <td style="text-align: center">
                    <strong><span class="style2">Success!</span></strong><br />
                    Your new product,<br />
                    <asp:Label ID="lbl_Name" runat="server"></asp:Label>
                    <br />
                    has been added successfully!</td>
            </tr>
            <tr>
                <td style="text-align: center">
                    <br />
                <asp:Button ID="but_return" runat="server" onclick="but_return_Click" 
                    Text="Return to Main" Width="147px" />
                    <br />
                </td>
            </tr>
        </table>
    </p>
</asp:Content>

