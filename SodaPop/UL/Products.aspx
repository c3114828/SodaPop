<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Products.aspx.cs" Inherits="SodaPop.UL.Products" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
            <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="content">
  
<%--      <asp:GridView ID="SearchResult" runat="server" AutoGenerateColumns="False" GridLines="Horizontal" CellPadding="4"
        ItemType="UL.Product" SelectMethod="SodaPop" onrowcommand="SearchResult_RowCommand">
        <Columns>
            <asp:ImageField DataImageUrlField="imagePath" HeaderText="image" ControlStyle-Width="100px" ControlStyle-Height = "100px"/>
            <asp:BoundField DataField="ProductName" HeaderText="Product Name"/>
            <asp:BoundField DataField="ProductQuantity" HeaderText="Quantity"/>
            <asp:BoundField DataField="ProductPrice" HeaderText="price"/>
            <asp:BoundField DataField="ProductBrand" HeaderText="Brand"/>
            <asp:BoundField DataField="description" HeaderText="description"/>
            <asp:ButtonField buttontype="Button" Text="Add to cart" commandname="AddToCart"/>
        </Columns>
    </asp:GridView>--%>

         <asp:Panel ID="SearchBox" runat="server" DefaultButton="btn_search">
        <div>
            <h3> Search for products</h3>
            <!-- https://www.w3schools.com/howto/howto_css_searchbar.asp Reference to Seach bar-->
            <div class="input-group col-md-3">
        <asp:TextBox ID="searchBar" runat="server" class="form-control" placeholder="Enter Soda"></asp:TextBox>
        <div class="input-group-btn"> 
            <asp:LinkButton ID="btn_search" runat="server" CssClass="btn btn-default" OnClick="searchbutton_Click"> 
                 <span class="glyphicon glyphicon-search"></span>
            </asp:LinkButton>
        </div>
        </div>
      </div>
    </asp:Panel>
    <!-- https://bootsnipp.com/snippets/featured/ecommerce-product-display  used to create shaded box around the products-->
    <div>
        <h3> Please select a product </h3>
        <p class="text"> Select Image to view more Information</p> 
        <asp:Label ID="errorlbl" CssClass="h5" runat="server"></asp:Label><br />
        <asp:Button ID="btn_show" runat="server" CssClass="btn btn-danger" Text="Show All Products" OnClick="btn_showAll" BackColor="#0066FF" />
    </div>
    <!-- Repeater For DB-->
    <asp:repeater id="repeater1" runat="server" onitemcommand="repeater1_itemcommand1" ValidateRequestMode="Disabled">
        <itemtemplate>
            <div class="col-md-2 column box">
                <asp:imagebutton id="img" runat="server" class="img-responsive img img-thumbnail center-block" imageurl='<%#Eval("image") %>' commandname="showdetails" commandargument='<%#Eval("productid") %>'/>
                <div><asp:label id="name" runat="server" text='<%#Eval("name") %>'/></div>
                <div><div class="pull-right"><asp:button id="button" runat="server" cssclass="btn btn-default" text="add to cart" commandname="add" commandargument='<%#Eval("productid") %>'/></div><div class="text-danger"><asp:label id="pri" runat="server" text='<%#Eval("price") %>'/></div></div>
            </div>
        </itemtemplate>
    </asp:repeater>
    <div>
    </div>

    </div>
</asp:Content>
