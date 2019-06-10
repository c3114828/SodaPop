<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AdminLogin.aspx.cs" Inherits="SodaPop.UL.AdminLogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
          <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="content">
        <table class="tableCentre1">
            <tr>
                <th colspan="3">
                    <h2>SodaPop Admin Login</h2>
                </th>
            </tr>
            
            <tr>
                <td class="auto-style1">
                    Email:
                </td>
                <td class="auto-style1">
                    <asp:Textbox ID="emailTxtBx" runat="server"/>
                    <asp:RequiredFieldValidator ErrorMessage="Required" ForeColor="Red" ControlToValidate="emailTxtBx"
                        runat="server" />
                </td>
              
            </tr>
            
          
            <tr>
                <td class="auto-style1">
                      Password:
                </td>
                <td class="auto-style1">
                    <asp:TextBox ID="passwordTxtBx" TextMode="Password" runat="server" />
                    <asp:RequiredFieldValidator ErrorMessage="Required" ForeColor="Red" ControlToValidate="passwordTxtBx"
                        runat="server" />
                </td>
              
            </tr>
            <tr>
               <td>
                  <asp:HyperLink ID="RegisterLbl" NavigateUrl="~/UL/Forgot.aspx" Text="Forgot Login Credentials" runat="server" Font-Size="Smaller" />
                </td>

                 <td>
                     <asp:Button ID="logInBtn" runat="server" OnClick="logInBtn_Click1" Text="Log In" />
               </td>
            </tr>
           
           
        </table>
        <br />
        <br />
    </div>
</asp:Content>
