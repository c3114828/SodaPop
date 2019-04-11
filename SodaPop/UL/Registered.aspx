<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Registered.aspx.cs" Inherits="SodaPop.UL.Registered" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
                <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" integrity="sha384-BVYiiSIFeK1dGmJRAkycuHAHRg32OmUcww7on3RYdg4Va+PmSTsz/K68vbdEjh4u" crossorigin="anonymous">

                <style type="text/css">
                    .auto-style1 {
                        height: 20px;
                    }
                </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="content">
        <table class="tableCentre1">
            <tr>
                <th colspan="3">
                    <h2>Thank you for registering for Soda Pop</h2>
                </th>
            </tr>
            <!-- First name textbox with validators -->
            <tr>
                <td class="auto-style1">
                    We've sent an email confirmation to this email.   
                </td>
                <td class="auto-style1">
                    <asp:Label ID="emailLbl" Text="Email" runat="server" />
                </td>
              
            </tr>
           
        </table>
        <br />
        <br />
    </div>

    </asp:Content>
