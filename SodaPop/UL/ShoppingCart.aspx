<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="ShoppingCart.aspx.cs" Inherits="SodaPop.UL.ShoppingCart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
        <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <!-- Shopping cart grid view -->
    <div Class="content">
          
                 <asp:GridView ID="CartLst" runat="server" AutoGenerateColumns="False" GridLines="Horizontal" CellPadding="2"
                    ItemType="UL.Products" SelectMethod="GetShoppingCartItems" onrowcommand="CartList_RowCommand">
                <%-- set the content of each rows of the gridview (the list of data we need for each cart items) --%>
                <Columns>
                    <asp:BoundField DataField="ProductID" HeaderText="ID"/>
                    <asp:ImageField DataImageUrlField="ProductImage" HeaderText="image" ControlStyle-Width="100px" ControlStyle-Height = "100px"/>
                    <asp:BoundField DataField="ProductName" HeaderText="Product name"/>
                    <asp:BoundField DataField="ProductPrice" HeaderText="Price"/>
                    <asp:BoundField DataField="ProductBrand" HeaderText="brand"/>
                    <asp:BoundField DataField="ProductDescription" HeaderText="description"/>
                    <asp:ButtonField buttontype="Button" Text="remove" commandname="Remove"/>
                </Columns>
                </asp:GridView>

                <!-- button to go to payment with total amount written-->
                <div style="text-align: center; margin-top: 20px;"><asp:Button ID="paymentBtn" runat="server" /></div>
           

    </div>
</asp:Content>
