<%@ Page Title="" Language="C#" MasterPageFile="~/Header.master" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Register" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style2
        {
            width: 249px;
        }
        .style3
        {
            width: 220px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br />
    <table style="width: 69%; margin-right: 25px;">
    <tr>
        <td class="style3">
            Name*:</td>
        <td class="style2">
            <asp:TextBox ID="txt_name" runat="server" Width="300px"></asp:TextBox>
        </td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                ControlToValidate="txt_name" ErrorMessage="Name Required!"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="style3">
            User
            Name*:</td>
        <td class="style2">
            <asp:TextBox ID="txt_username" runat="server" Width="300px"></asp:TextBox>
        </td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" 
                ControlToValidate="txt_name" ErrorMessage="User Name Required!"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="style3">
            Password*:</td>
        <td class="style2">
            <asp:TextBox ID="txt_pass" runat="server" Width="300px" TextMode="Password"></asp:TextBox>
        </td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                ControlToValidate="txt_pass" ErrorMessage="Password Required!"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="style3">
            Email*:</td>
        <td class="style2">
            <asp:TextBox ID="txt_mail" runat="server" Width="300px"></asp:TextBox>
        </td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                ControlToValidate="txt_mail" ErrorMessage="Email Required!"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="style3">
            Address*:</td>
        <td class="style2">
            <asp:TextBox ID="txt_address" runat="server" Width="300px"></asp:TextBox>
        </td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                ControlToValidate="txt_address" ErrorMessage="Address Required!"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="style3">
            Country*:</td>
        <td class="style2">
            <asp:TextBox ID="txt_country" runat="server" Width="300px"></asp:TextBox>
        </td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
                ControlToValidate="txt_country" ErrorMessage="Country Required!"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="style3">
            Postal*:</td>
        <td class="style2">
            <asp:TextBox ID="txt_postal" runat="server" Width="300px"></asp:TextBox>
        </td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                ControlToValidate="txt_postal" ErrorMessage="Postal Code Required!"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="style3">
            About You:</td>
        <td class="style2">
            <asp:TextBox ID="txt_about" runat="server" Width="300px" Height="80px" 
                TextMode="MultiLine"></asp:TextBox>
        </td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style3">
            *Required Fields</td>
        <td class="style2">
            <asp:Label ID="lab_taken" runat="server" ForeColor="Red" 
                Text="ERROR: User name already in use" Visible="False"></asp:Label>
        </td>
        <td>
            <asp:Button ID="butReg" runat="server" Text="Register" Width="134px" 
                onclick="butReg_Click" />
        </td>
    </tr>
</table>
    <br />
<strong>
<asp:Button ID="but_back" runat="server" Height="31px" onclick="but_back_Click" 
    Text="Return to Main" />
</strong>
</asp:Content>

