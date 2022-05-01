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
            <asp:Label Text="Username" runat="server" CssClass="label_txt"/>
            <asp:TextBox ID="email_txt" runat="server" placeholder="Enter username" class="text_box"/>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator_email" runat="server" ErrorMessage="Username required" ControlToValidate="email_txt" ForeColor="#FF0066" Font-Size="10pt"></asp:RequiredFieldValidator><br />
            <asp:Label Text="Password" runat="server" CssClass="label_txt" />
            <asp:TextBox ID="password_txt" runat="server" placeholder="Enter password" class="text_box" TextMode="Password"/>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator_password" runat="server" ErrorMessage="Password required" ControlToValidate="password_txt" ForeColor="#FF0066" Font-Size="10pt"></asp:RequiredFieldValidator>

            <asp:Button ID="Button1" runat="server" CssClass="login_btn" Text="Sign in" OnClick="Button1_Click" />
            <asp:Button ID="goBack_btn" runat="server" CssClass="goBack_btn" Text="Go back" OnClick="goBack_btn_Click"/>
            <asp:Label ID="reuslt_lbl" runat="server" CssClass="reuslt_lbl"></asp:Label>
        </form>   

    </div>
</body>
</html>
