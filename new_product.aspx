<%@ Page Title="" Language="C#" MasterPageFile="~/HeadSub.master" AutoEventWireup="true" CodeFile="new_product.aspx.cs" Inherits="new_product" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        <asp:Label ID="lblIntro" runat="server" 
            Text="Please add your new product below:"></asp:Label>
&nbsp;<asp:Label ID="lbl_DateTest" runat="server"></asp:Label>
    </p>
    <asp:Panel ID="pnlDetails" runat="server">
        <p>
            <table style="width:100%;">
                <tr>
                    <td 
                style="text-align: right; padding-right: 5px; width: 110px; vertical-align: top;">
                        Category:</td>
                    <td 
                style="vertical-align: top; text-align: left; width: 450px;">
                        <asp:Label ID="lbl_Category" runat="server" 
                    Visible="False"></asp:Label>
                        <asp:DropDownList ID="ddl_category" runat="server" Height="20px" Width="150px">
                        </asp:DropDownList>
                    </td>
                    <td style="vertical-align: top;">
                        <asp:RequiredFieldValidator ID="rfv_Category" runat="server" ControlToValidate="ddl_category" 
                    ErrorMessage="Choose the Category!" Font-Bold="True" ForeColor="Red"></asp:RequiredFieldValidator>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td 
                style="text-align: right; padding-right: 5px; width: 110px; vertical-align: top;">
                        Product Name:</td>
                    <td 
                style="vertical-align: top; text-align: left; width: 450px;">
                        <asp:Label ID="lbl_Name" runat="server" Visible="False"></asp:Label>
                        &nbsp;<asp:TextBox ID="tb_Name" runat="server" Width="300px"></asp:TextBox>
                    </td>
                    <td style="vertical-align: top;">
                        <asp:RequiredFieldValidator ID="rfv_Name" runat="server" 
                    ControlToValidate="tb_Name" ErrorMessage="Enter the product name!" 
                    Font-Bold="True" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td 
                style="text-align: right; padding-right: 5px; width: 110px; vertical-align: top;">
                        Quantity:</td>
                    <td 
                style="vertical-align: top; text-align: left; width: 450px;">
                        <asp:Label ID="lbl_Quantity" runat="server" 
                    Visible="False"></asp:Label>
                        <asp:TextBox ID="tb_Quantity" runat="server" Height="20px" Width="50px">1</asp:TextBox>
                    </td>
                    <td style="vertical-align: top;">
                        <asp:RequiredFieldValidator ID="rfv_Quantity" runat="server" ControlToValidate="tb_Quantity" 
                    ErrorMessage="Enter the quantity!" Font-Bold="True" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td 
                style="text-align: right; padding-right: 5px; width: 110px; vertical-align: top;">
                        Condition:</td>
                    <td 
                style="vertical-align: top; text-align: left; width: 450px;">
                        <asp:Label ID="lbl_Cond" runat="server" Visible="False"></asp:Label>
                        <asp:RadioButtonList ID="rb_Cond" runat="server" Height="20px" 
                            RepeatDirection="Horizontal">
                        </asp:RadioButtonList>
                    </td>
                    <td style="vertical-align: top;">
                        <asp:RequiredFieldValidator ID="rfv_Cond" runat="server" 
                    ControlToValidate="rb_cond" ErrorMessage="Choose the item condition!" 
                    Font-Bold="True" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td 
                style="text-align: right; padding-right: 5px; width: 110px; vertical-align: top;">
                        Duration (days):</td>
                    <td 
                style="vertical-align: top; text-align: left; width: 450px;">
                        <asp:Label ID="lbl_Duration" runat="server" 
                    Visible="False"></asp:Label>
                        &nbsp;<asp:TextBox ID="tb_Duration" runat="server" Height="20px" Width="50px"></asp:TextBox>
                    </td>
                    <td style="vertical-align: top;">
                        <asp:RequiredFieldValidator ID="rfv_Duration" runat="server" ControlToValidate="tb_Duration" 
                    ErrorMessage="Enter the duration!" Font-Bold="True" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td 
                style="text-align: right; padding-right: 5px; width: 110px; vertical-align: top;">
                        Starting price:</td>
                    <td 
                style="vertical-align: top; text-align: left; width: 450px;">
                        S$
                        <asp:TextBox ID="tb_StartPrice" runat="server" Height="20px" Width="100px"></asp:TextBox>
                        <asp:Label ID="lbl_StartPrice" runat="server" Visible="False"></asp:Label>
                    </td>
                    <td style="vertical-align: top;">
                        <asp:RequiredFieldValidator ID="rfv_StartPrice" runat="server" ControlToValidate="tb_StartPrice" 
                    ErrorMessage="Enter the starting price!" Font-Bold="True" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td 
                style="text-align: right; padding-right: 5px; width: 110px; vertical-align: top;">
                        Description:</td>
                    <td 
                style="vertical-align: top; text-align: left; width: 450px;">
                        &nbsp;<asp:Label ID="lbl_Description" runat="server" 
                    Visible="False"></asp:Label>
                        <asp:TextBox ID="tb_Description" runat="server" Height="50px" 
                            TextMode="MultiLine" Width="300px"></asp:TextBox>
                    </td>
                    <td style="vertical-align: top;">
                        <asp:RequiredFieldValidator ID="rfv_Description" runat="server" ControlToValidate="tb_Description" 
                    ErrorMessage="Enter the product description!" Font-Bold="True" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
            </table>
            <br />
            <asp:Button ID="btn_Submit" runat="server" 
        onclick="btn_Submit_Click" Text="Submit" />
            <asp:Button ID="btn_Confirm" runat="server" 
        onclick="btn_Confirm_Click" Text="Confirm" Visible="False" />
            &nbsp;<asp:Button ID="btn_Edit" runat="server" 
        onclick="btn_Edit_Click" Text="Edit Details" Visible="False" />
            &nbsp;<strong><asp:Button ID="but_back" runat="server" Height="31px" 
                onclick="but_back_Click" Text="Return to Main" />
            </strong>
        </p>
    </asp:Panel>
</asp:Content>

