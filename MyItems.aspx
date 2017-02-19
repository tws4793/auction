<%@ Page Title="" Language="C#" MasterPageFile="~/HeadSub.master" AutoEventWireup="true" CodeFile="MyItems.aspx.cs" Inherits="MyItems" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p style="font-size: xx-large">
        <strong>My Items </strong>
    </p>
    <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" 
    Height="171px" Width="1002px">
        <AlternatingRowStyle BackColor="White" />
        <EditRowStyle BackColor="#2461BF" />
        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#EFF3FB" />
        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
    </asp:GridView>
    <p style="font-size: xx-large">
        <strong>
        <asp:Button ID="but_back" runat="server" Height="31px" onclick="but_back_Click" 
        Text="Return to Main" />
        </strong>
    </p>
</asp:Content>

