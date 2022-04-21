<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="SurveyWebApp.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Login.css" rel="stylesheet" />
</head>
<body>
    <div class="login_box">
        <asp:Image ID="Login_Image" runat="server" CssClass ="login_icon" ImageUrl="~/Images/rocket_login.png"/>
        <asp:Label ID="Label1" runat="server" Text="Welcome" class="h1"></asp:Label>
        <form id="form" runat="server">
            <asp:Label Text="Email" runat="server" CssClass="label_txt"/>
            <asp:TextBox runat="server" placeholder="Enter email" class="text_box" TextMode="Email"/>
            <asp:Label Text="Password" runat="server" CssClass="label_txt" />
            <asp:TextBox runat="server" placeholder="Enter password" class="text_box" TextMode="Password"/>
            <asp:Button ID="Button1" runat="server" CssClass="login_btn" Text="Sign in" OnClick="Button1_Click" />
        </form>   
    </div>
</body>
</html>
