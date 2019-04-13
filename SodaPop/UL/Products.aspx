<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Products.aspx.cs" Inherits="SodaPop.UL.Products" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
            <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="content">
        <!-- just few comments for now -->
      <asp:GridView ID="SearchResult" runat="server" AutoGenerateColumns="False" GridLines="Horizontal" CellPadding="4"
        ItemType="UL.Clothes" SelectMethod="GetMensClothes" onrowcommand="SearchResult_RowCommand">
    <%-- set the content of each rows of the gridview (the list of data we need for each product) --%>
     <%-- Code for gridview sourced from - https://docs.microsoft.com/en-us/aspnet/web-forms/overview/getting-started/getting-started-with-aspnet-45-web-forms/shopping-cart --%>
        <Columns>
            <asp:ImageField DataImageUrlField="imagePath" HeaderText="image" ControlStyle-Width="100px" ControlStyle-Height = "100px"/>
            <asp:BoundField DataField="ProductName" HeaderText="Product Name"/>
            <asp:BoundField DataField="ProductQuantity" HeaderText="Quantity"/>
            <asp:BoundField DataField="ProductPrice" HeaderText="price"/>
            <asp:BoundField DataField="ProductBrand" HeaderText="Brand"/>
            <asp:BoundField DataField="description" HeaderText="description"/>
            <asp:ButtonField buttontype="Button" Text="Add to cart" commandname="AddToCart"/>
        </Columns>
    </asp:GridView>
    </div>
</asp:Content>
