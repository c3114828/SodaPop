<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="SodaPop.UL.Registration" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
   
    <style type="text/css">
        .auto-style1 {
            height: 22px;
        }
    </style>
        <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" integrity="sha384-BVYiiSIFeK1dGmJRAkycuHAHRg32OmUcww7on3RYdg4Va+PmSTsz/K68vbdEjh4u" crossorigin="anonymous">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.1/jquery.min.js"></script>
    <script type="text/javascript">
        <!-- JQuery Script used to duplicate addresses if same -->
        $(document).ready(function() {
            $('input:checkbox[id*=sameAddressChBx]').change(function() {
                if ($(this).is(':checked')) {
                    $('input:text[id*=streetNumberBillTxtBx]').val($('input:text[id*=streetNumberTxtBx]').val());
                    $('input:text[id*=streetNameBillTxtBx]').val($('input:text[id*=streetNameTxtBx]').val());
                    $('input:text[id*=cityBillTxtBx]').val($('input:text[id*=cityTxtBx]').val());
                    $('input:text[id*=stateBillTxtBx]').val($('input:text[id*=stateTxtBx]').val());
                    $('input:text[id*=postcodeBillTxtBx]').val($('input:text[id*=postcodeTxtBx]').val());
                }
                else {
                    $('input:text[id*=streetNumberBillTxtBx]').val('');
                    $('input:text[id*=streetNameBillTxtBx]').val('');
                    $('input:text[id*=cityBillTxtBx]').val('');
                    $('input:text[id*=stateBillTxtBx]').val('');
                    $('input:text[id*=postcodeBillTxtBx]').val('');
                }
            });
        });
    </script>

    <div class="content">
        <table class="tableCentre1">
            <tr>
                <th colspan="3">
                    <h2>Registration</h2>
                </th>
            </tr>
            <!-- First name textbox with validators -->
            <tr>
                <td class="auto-style1">
                    First Name:
                </td>
                <td class="auto-style1">
                    <asp:TextBox ID="firstNameTxtBx" runat="server" />
                </td>
                <td class="auto-style1">
                    <asp:RequiredFieldValidator ErrorMessage="Required" ForeColor="Red" ControlToValidate="firstNameTxtBx"
                        runat="server" />
                </td>
            </tr>
            <!-- Last name textbox with validators -->
            <tr>
                <td>
                    Last Name:
                </td>
                <td>
                    <asp:TextBox ID="lastNameTxtBX" runat="server" />
                </td>
                <td>
                    <asp:RequiredFieldValidator ErrorMessage="Required" ForeColor="Red" ControlToValidate="lastNameTxtBX"
                          runat="server" />
                </td>
            </tr>
            <tr>
                <td colspan="3"></td>
            </tr>
            <tr>
                <td colspan="3"><hr /></td>
            </tr>
            <tr>
                <td colspan="3"></td>
            </tr>
            <tr>
                <th colspan="3">
                    Residential Address
                </th>
            </tr>
            <!-- Residential street number textbox with validators -->
            <tr>
                <td>
                    Street Number:
                </td>
                <td>
                    <asp:TextBox ID="streetNumberTxtBx" runat="server" />
                </td>
                <td>
                    <asp:RequiredFieldValidator ErrorMessage="Required" ForeColor="Red" ControlToValidate="streetNumberTxtBx"
                        runat="server" />
                </td>
            </tr>
            <!-- Residential street name textbox with validators -->
            <tr>
                <td>
                    Street Name:
                </td>
                <td>
                    <asp:TextBox ID="streetNameTxtBx" runat="server" />
                </td>
                <td>
                    <asp:RequiredFieldValidator ErrorMessage="Required" ForeColor="Red" ControlToValidate="streetNameTxtBx"
                        runat="server" />
                </td>
            </tr>
            <!-- Residential city textbox with validators -->
            <tr>
                <td>
                    City:
                </td>
                <td>
                    <asp:TextBox ID="cityTxtBx" runat="server" />
                </td>
                <td>
                    <asp:RequiredFieldValidator ErrorMessage="Required" ForeColor="Red" ControlToValidate="cityTxtBx"
                        runat="server" />
                </td>
            </tr>
            <!-- Residential state textbox with validators -->
            <tr>
                <td>
                    State:
                </td>
                <td>
                    <asp:TextBox ID="stateTxtBx" runat="server" />
                </td>
                <td>
                    <asp:RequiredFieldValidator ErrorMessage="Required" ForeColor="Red" ControlToValidate="stateTxtBx"
                        runat="server" />
                </td>
            </tr>
            <!-- Residential postcode textbox with validators -->
            <tr>
                <td>
                    Post Code:
                </td>
                <td>
                    <asp:TextBox ID="postcodeTxtBx" runat="server" />
                </td>
                <td>
                    <asp:RequiredFieldValidator ErrorMessage="Required" ForeColor="Red" ControlToValidate="postcodeTxtBx"
                        runat="server" />
                </td>
            </tr>
            <!-- Same address checkbox used to duplicate residential address to billing address if checked -->
            <tr>
                <td>
                    Use same Address?
                </td>
                <td>
                    <asp:CheckBox ID="sameAddressChBx" runat="server" />
                </td>
            </tr>
            <tr>
                <th colspan="3">
                    Billing Address
                </th>
            </tr>
            <!-- Billing street number textbox with validators -->
            <tr>
                <td>
                    Street Number:
                </td>
                <td>
                    <asp:TextBox ID="streetNumberBillTxtBx" runat="server" />
                </td>
                <td>
                    <asp:RequiredFieldValidator ErrorMessage="Required" ForeColor="Red" ControlToValidate="streetNumberBillTxtBx"
                        runat="server" />
                </td>
            </tr>
            <!-- Billing street name textbox with validators -->
            <tr>
                <td>
                    Street Name:
                </td>
                <td>
                    <asp:TextBox ID="streetNameBillTxtBx" runat="server" />
                </td>
                <td>
                    <asp:RequiredFieldValidator ErrorMessage="Required" ForeColor="Red" ControlToValidate="streetNameBillTxtBx"
                        runat="server" />
                </td>
            </tr>
            <!-- Billing city textbox with validators -->
            <tr>
                <td>
                    City:
                </td>
                <td>
                    <asp:TextBox ID="cityBillTxtBx" runat="server" />
                </td>
                <td>
                    <asp:RequiredFieldValidator ErrorMessage="Required" ForeColor="Red" ControlToValidate="cityBillTxtBx"
                        runat="server" />
                </td>
            </tr>
            <!-- Billing state textbox with validators -->
            <tr>
                <td>
                    State:
                </td>
                <td>
                    <asp:TextBox ID="stateBillTxtBx" runat="server" />
                </td>
                <td>
                    <asp:RequiredFieldValidator ErrorMessage="Required" ForeColor="Red" ControlToValidate="stateBillTxtBx"
                        runat="server" />
                </td>
            </tr>
            <!-- Billing postcode textbox with validators -->
            <tr>
                <td>
                    Post Code:
                </td>
                <td>
                    <asp:TextBox ID="postcodeBillTxtBx" runat="server" />
                </td>
                <td>
                    <asp:RequiredFieldValidator ErrorMessage="Required" ForeColor="Red" ControlToValidate="postcodeBillTxtBx"
                        runat="server" />
                </td>
            </tr>
            <tr>
                <td colspan="3"></td>
            </tr>
            <tr>
                <td colspan="3"><hr /></td>
            </tr>
            <tr>
                <td colspan="3"></td>
            </tr>
            <!-- Password textbox with validators -->
            <tr>
                <td>
                    Password
                </td>
                <td>
                    <asp:TextBox ID="passwordTxtBx" runat="server" TextMode="Password" />
                </td>
                <td>
                    <asp:RequiredFieldValidator ErrorMessage="Required" ForeColor="Red" ControlToValidate="passwordTxtBx"
                        runat="server" />
                </td>
            </tr>
            <!-- Confirm password textbox with validators -->
            <tr>
                <td>
                    Confirm Password
                </td>
                <td>
                    <asp:TextBox ID="confirmPasswordTxtBx" runat="server" TextMode="Password" />
                </td>
                <td>
                    <asp:CompareValidator ErrorMessage="Passwords do not match." ForeColor="Red" ControlToCompare="passwordTxtBx"
                        ControlToValidate="confirmPasswordTxtBx" runat="server" />
                </td>
            </tr>
            <!-- Email address textbox with validators -->
            <tr>
                <td>
                    Email
                </td>
                <td>
                    <asp:TextBox ID="emailTxtBx" runat="server" />
                </td>
                <td>
                    <asp:RequiredFieldValidator ErrorMessage="Required" Display="Dynamic" ForeColor="Red"
                        ControlToValidate="emailTxtBx" runat="server" />
                    <asp:RegularExpressionValidator runat="server" Display="Dynamic" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
                        ControlToValidate="emailTxtBx" ForeColor="Red" ErrorMessage="Invalid email address." />
                </td>
            </tr>
            <tr>
                <td>
                </td>
                <!-- Submit button runs RegisterUser method when clicked -->
                <td>
                    
                    <asp:Button ID="registerBtn1" runat="server" OnClick="Button1_Click" Text="Register" />
                </td>
                <td>
                </td>
            </tr>
        </table>
        <br />
        <br />
    </div>
</asp:Content>
