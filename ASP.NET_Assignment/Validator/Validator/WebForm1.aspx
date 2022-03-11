<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Validator.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 230px;
        }
        .auto-style2 {
            text-align: right;
            width: 160px;
        }
        .auto-style4 {
            width: 575px;
        }
        .auto-style5 {
            text-align: right;
            width: 160px;
            height: 32px;
        }
        .auto-style6 {
            width: 575px;
            height: 32px;
        }
        .auto-style7 {
            height: 32px;
        }
        .auto-style8 {
            margin-left: 160px;
        }
        .auto-style9 {
            text-align: right;
            width: 160px;
            height: 32px;
        }
        .auto-style10 {
            width: 575px;
            height: 32px;
        }
        .auto-style11 {
            width: 839px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server" class="auto-style11">
        <div class="auto-style8">
            Enter Your Details</div>
        <table class="auto-style1">
            <tr>
                <td class="auto-style9">Name</td>
                <td class="auto-style10">
                    <asp:TextBox ID="nm" runat="server"  Width="181px" Height="21px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" Display="None" runat="server" ControlToValidate="nm" ErrorMessage="Name is a required field" ForeColor="Red"></asp:RequiredFieldValidator>
                 
                </td>
            
            </tr>
            <tr>
                <td class="auto-style2">Family Name</td>
                <td class="auto-style4">
                    <asp:TextBox ID="fnm" runat="server"  Width="180px" Height="21px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" Display="None" runat="server" ControlToValidate="fnm" ErrorMessage="FullName is a required field" ForeColor="Red"></asp:RequiredFieldValidator>
                &nbsp;
                    <asp:CompareValidator ID="CompareValidator1" Display="None" runat="server" ControlToCompare="nm" ControlToValidate="fnm" ErrorMessage="Family Name must be different from Name" ForeColor="Red" Operator="NotEqual"></asp:CompareValidator>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">Address</td>
                <td class="auto-style4">
                    <asp:TextBox ID="adrs" runat="server" Width="180px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" Display="None" runat="server" ControlToValidate="adrs" ErrorMessage="Address is a required field" ForeColor="Red"></asp:RequiredFieldValidator>
                &nbsp;<asp:RegularExpressionValidator ID="RegularExpressionValidator5" Display="None" runat="server" ErrorMessage="Address field requires minimum 2 characters " ControlToValidate="adrs" ForeColor="Red" ValidationExpression="^[a-zA-Z-\s\{2,}]+$"></asp:RegularExpressionValidator>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5">City</td>
                <td class="auto-style4">
                    <asp:TextBox ID="ct" runat="server" Width="180px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" Display="None" runat="server" ControlToValidate="ct" ErrorMessage="City is a required field" ForeColor="Red"></asp:RequiredFieldValidator>
                &nbsp;
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator6" Display="None" runat="server" ErrorMessage="City field requires minimum 2 characters " ControlToValidate="ct" ForeColor="Red" ValidationExpression="^[a-zA-Z-\s\{2,}]+$"></asp:RegularExpressionValidator>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">Zip-Code</td>
                <td class="auto-style6">
                    <asp:TextBox ID="zpc" runat="server" Width="180px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" Display="None" runat="server" ControlToValidate="zpc" ErrorMessage="Zip-Code is a required field" ForeColor="Red"></asp:RequiredFieldValidator>
                &nbsp;
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator4" Display="None" runat="server" ErrorMessage="Zip-Code must be of 5 digits only" ControlToValidate="zpc" ForeColor="Red" ValidationExpression="\d{5}"></asp:RegularExpressionValidator>
                </td>
                <td class="auto-style7">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">Phone</td>
                <td class="auto-style4">
                    <asp:TextBox ID="phn" runat="server" Width="180px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" Display="None" runat="server" ControlToValidate="phn" ErrorMessage="Phone Number is a required field" ForeColor="Red"></asp:RequiredFieldValidator>
                &nbsp;<asp:RegularExpressionValidator ID="RegularExpressionValidator3" Display="None" runat="server" ErrorMessage="Phone number must be of 10 digits only" ControlToValidate="phn" ForeColor="Red" ValidationExpression="\d{10}"></asp:RegularExpressionValidator>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">Email</td>
                <td class="auto-style4">
                    <asp:TextBox ID="email" runat="server" Width="180px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator7" Display="None" runat="server" ControlToValidate="email" ErrorMessage="Email is a required field" ForeColor="Red"></asp:RequiredFieldValidator>&nbsp;
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" Display="None" runat="server" ErrorMessage="Enter a valid Email_id" ControlToValidate="email" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style4">
                    <p>Validation Summary</p>
                    <asp:ValidationSummary runat="server" ShowMessageBox="true" ShowSummary="true" />
                    <asp:Button ID="Button1" runat="server" Text="Check" />
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
