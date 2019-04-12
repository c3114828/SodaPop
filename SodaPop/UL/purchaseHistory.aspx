<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="purchaseHistory.aspx.cs" Inherits="SodaPop.Views.purchaseHistory" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <!-- reference to bootstrp -->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="content">
        <div class="text_container">
            <h1>Purchase History</h1>
        </div>
        <!--Purchase history page-->
        <asp:GridView ID="orderHistoryGrd" runat="server" GridLines="Horizontal" AutoGenerateColumns="False" CellPadding="4" AllowPaging="True" AllowSorting="True"  DataSourceID="SqlDataSource1" OnSelectedIndexChanged="orderHistoryGrd_SelectedIndexChanged1" >
            <Columns>
                <asp:CommandField ShowSelectButton="True" />
                <asp:BoundField HeaderText="Order ID.">
                    <ItemStyle CssClass="col-xs-2" />
                </asp:BoundField>
                <asp:BoundField HeaderText="Order Date" />
                <asp:BoundField HeaderText="Products" />
                <asp:BoundField HeaderText="Quantity" />
                <asp:BoundField HeaderText="Total Cost" />
                <asp:BoundField HeaderText="Postage" />
                
                <asp:ButtonField ButtonType="Button" Text="View Full Order" />
            </Columns>
        </asp:GridView>
        <!-- sets up a session variable to hold a placeholder for the connection string to use a craeted session -->
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" Connectionstring="<%$ ConnectionStrings:SodaPopConnectionString %>" selectcommand="SELECT * FROM [OrderId] WHERE ([OrderID] = @OrderID)">
                <selectparameters>
		<asp:sessionparameter name="OrderID" sessionfield="OrderID" type="Int32" />
	</selectparameters>
        </asp:SqlDataSource>
    </div>
</asp:Content>
