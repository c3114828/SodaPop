<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AdmingAccountManagement.aspx.cs" Inherits="SodaPop.UL.AdmingAccountManagement" %>
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
            <asp:BoundField DataField="userId" HeaderText="userId" SortExpression="userId" />
            <asp:BoundField DataField="email" HeaderText="email" SortExpression="email" />
            <asp:BoundField DataField="userPassword" HeaderText="userPassword" SortExpression="userPassword" />
            <asp:BoundField DataField="firstName" HeaderText="firstName" SortExpression="firstName" />
            <asp:BoundField DataField="lastName" HeaderText="lastName" SortExpression="lastName" />
            <asp:BoundField DataField="phoneNumber" HeaderText="phoneNumber" SortExpression="phoneNumber" />
            <asp:BoundField DataField="userAddress" HeaderText="userAddress" SortExpression="userAddress" />
        </Columns>
    </asp:GridView>

  
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="getUserDetails" TypeName="SodaPop.BL.UserAcount" UpdateMethod="updateUserAccount">
        <UpdateParameters>
            <asp:Parameter Name="userId" Type="Int32" />
            <asp:Parameter Name="Email" Type="String" />
            <asp:Parameter Name="userPassword" Type="String" />
            <asp:Parameter Name="FirstName" Type="String" />
            <asp:Parameter Name="LastName" Type="String" />
            <asp:Parameter Name="PhoneNumber" Type="Int32" />
            <asp:Parameter Name="userAddress" Type="String" />
        </UpdateParameters>
    </asp:ObjectDataSource>

    <br />
    <asp:Label ID="CreateNewUserLbl" runat="server" Text="Create New User Account"></asp:Label>
    <br />
     <asp:Label ID="userIDLbl" runat="server" Text="UserID:  "></asp:Label>
    <asp:TextBox ID="UserIDTxtBx" runat="server" ></asp:TextBox>
    <br />
    <asp:Label ID="emailLbl" runat="server" Text="Email:  "></asp:Label>
    <asp:TextBox ID="EmailTxtBx" runat="server" ></asp:TextBox>
    <br />
    <asp:Label ID="passwordLbl" runat="server" Text="Password:  "></asp:Label>
    <asp:TextBox ID="PasswordTxtBx" runat="server" ></asp:TextBox>
    <br />
    <asp:Label ID="fNameLbl" runat="server" Text="First Name:  "></asp:Label>
    <asp:TextBox ID="FirstNameTxtBx" runat="server" ></asp:TextBox>
    <br />
    <asp:Label ID="lNameLbl" runat="server" Text="Last Name:  "></asp:Label>
    <asp:TextBox ID="LastNameTxtBx" runat="server" ></asp:TextBox>
    <br />
    <asp:Label ID="PhoNoLbl" runat="server" Text="Phone Number:  "></asp:Label>
    <asp:TextBox ID="PhoneNumberTxtBx" runat="server" ></asp:TextBox>
    <br />
    <asp:Label ID="AddressLbl" runat="server" Text="Address:  "></asp:Label>
    <asp:TextBox ID="AddressTxtBx" runat="server" ></asp:TextBox>
    <br />
    
    <asp:Button ID="InsertButton" runat="server" Text="Create" OnClick="InsertButton_Click" />
    </div>
</asp:Content>
