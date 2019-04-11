<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="MyAccountPage.aspx.cs" Inherits="SodaPop.UL.MyAccountPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
            <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" integrity="sha384-BVYiiSIFeK1dGmJRAkycuHAHRg32OmUcww7on3RYdg4Va+PmSTsz/K68vbdEjh4u" crossorigin="anonymous">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="content">
        <table class="tableCentre1">
           
        <tr>
            <th colspan="3">
                <h2>Welcome to your account <asp:Label ID="emailLbl" runat="server" Text="email"></asp:Label></h2>
            </th>
        </tr>
            <tr>
                <td>
                    Account Details

                </td>
                <td>
                    <asp:HyperLink NavigateUrl="account.aspx" Text="View" runat="server" />
                </td>
            </tr>
            
            <tr>
                <td>
                    Purchases History
                </td>
                <td>
                    <asp:HyperLink NavigateUrl="#" Text="View" runat="server" />
                </td>
            </tr>
            <tr>
                <td>
                    Wishlist
                </td>
                <td>
                   <asp:HyperLink NavigateUrl="#" Text="View" runat="server" />
                </td>
            </tr>
            <tr>
                <td>
                    Payment Methods
                </td>
                <td>
                    <asp:HyperLink NavigateUrl="#" Text="View" runat="server" />

                </td>
            </tr>
            <tr>
                <td>
                    Shipping Address
                </td>
                <td>
                    <asp:HyperLink NavigateUrl="#" Text="View" runat="server" />
                </td>
            </tr>


        </table>
    </div>
    
</asp:Content>
