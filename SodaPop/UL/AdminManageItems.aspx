<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AdminManageItems.aspx.cs" Inherits="SodaPop.UL.AdminManageItems" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
                  <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="content">
    <div>
    <h1>Manage User Accounts</h1>
        <!-- Accountm management  -->
        </div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" OnRowCommand="GridView1_RowCommand" DataSourceID="ObjectDataSource1">
        <Columns>
            <asp:CommandField ShowEditButton="True" />
            <asp:ButtonField CommandName="Delete" Text="Delete" />
            <asp:BoundField DataField="productID" HeaderText="productID" SortExpression="productID" />
            <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
            <asp:BoundField DataField="image" HeaderText="image" SortExpression="image" />
            <asp:BoundField DataField="price" HeaderText="price" SortExpression="price" />
            <asp:BoundField DataField="Description" HeaderText="Description" SortExpression="Description" />
        </Columns>
    </asp:GridView>
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="getAllProducts" TypeName="SodaPop.BL.ProductsBL" UpdateMethod="updateProduct">
        <UpdateParameters>
            <asp:Parameter Name="productID" Type="Int32" />
            <asp:Parameter Name="Name" Type="String" />
            <asp:Parameter Name="Brand" Type="String" />
            <asp:Parameter Name="imagefile" Type="String" />
            <asp:Parameter Name="price" Type="Decimal" />
            <asp:Parameter Name="Description" Type="String" />
        </UpdateParameters>
    </asp:ObjectDataSource>

            <br />
    <asp:Label ID="InsertNewLbl" runat="server" Text="Insert new Product"></asp:Label>
    <br />
    <asp:Label ID="productIDLbl" runat="server" Text="Product ID:  "></asp:Label>
    <asp:TextBox ID="ProductID" runat="server" ></asp:TextBox>
    <br />
    <asp:Label ID="nameLbl" runat="server" Text="Name:  "></asp:Label>
    <asp:TextBox ID="Name" runat="server" ></asp:TextBox>
    <asp:Label ID="productIDSwitch" runat="server" Text=""></asp:Label>
    <br />
    <asp:Label ID="brandLbl" runat="server" Text="Brand:  "></asp:Label>
    <asp:TextBox ID="Brand" runat="server" ></asp:TextBox>
    <br />
    <asp:Label ID="imageLbl" runat="server" Text="Image"></asp:Label>
    <asp:TextBox ID="image" runat="server" ></asp:TextBox>
    <br />
    <asp:Label ID="priceLbl" runat="server" Text="Price:  "></asp:Label>
    <asp:TextBox ID="Price" runat="server" ></asp:TextBox>
    <br />
    <asp:Label ID="DescriptionLbl" runat="server" Text="Description:  "></asp:Label>
    <asp:TextBox ID="ShortDescription" runat="server" ></asp:TextBox>
    <br />

    <br />
    <asp:Button ID="InsertButton" runat="server" Text="Insert" OnClick="InsertButton_Click" />


    </div>
</asp:Content>
