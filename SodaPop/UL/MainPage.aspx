<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="MainPage.aspx.cs" Inherits="SodaPop.UL.Default2Main" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
            <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="content">
        <div class="text_container">
            <h1> Welcome to the SodaPop webpage!</h1>
        </div>
        <div class="text_container_2col">
            <p>
                SodaPop, is the place to get all your fizz cravings fixed. We have a large variety to choose from and only the best<br /><br />
             
                
                <a href="Products.aspx">Cola</a><br />
                <asp:ImageButton ID="colaImgButton" runat="server" ImageUrl="~/Img/soda-bottle.png" Height="76px" BorderColor="Black" BorderStyle="Solid"  AlternateText="Generic Soda Bottle icon" Width="87px" OnClientClick="colaImageButton_Click"  />
                <br /><br />
                <a href="Products.aspx">Lemonade</a><br />
                 <asp:ImageButton ID="lemonadeImgButton" runat="server" ImageUrl="~/Img/soda-bottle.png" Height="76px" BorderColor="Black" BorderStyle="Solid"  AlternateText="Generic Soda Bottle icon" Width="87px" />





            
            </p>
        </div>
        <div class="text_container_2col">
            <h3>
               <asp:hyperlink ID="SignUpID" Text="Sign Up" NavigateUrl="~/UL/Registration.aspx" runat="server" /> Now to create an account and start shopping
            </h3>
            <p>
               Simply click the <asp:hyperlink ID="LogInId" Text="Log In" NavigateUrl="~/UL/Registration.aspx" runat="server" /> link up the top right hand side OR If you're already a user <asp:hyperlink ID="signInID" Text="Sign in" NavigateUrl="~/UL/Login.aspx" runat="server" /> and use your account.
                <br />
                <br />
                Feel Free to browse the store to see what SodaPop Offers
            </p>
        </div>

    </div>


</asp:Content>
