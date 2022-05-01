<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="SurveyWebApp.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Master1.css" rel="stylesheet" />
    <link href="Home.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server" class="form1">
        <div class="header_container">
            <div style="display: flex; align-items: center;">
                <asp:Image ID="LogoImage" runat="server" ImageUrl="~/Images/rocket_login.png" CssClass="LogoImage" />
                <asp:Label ID="Logo_lbl" runat="server" Text="Market Survey" CssClass="Logo_lbl" />
            </div>
            <div>
                <asp:Button ID="Exit_btn" runat="server" Text="Staff login >" CssClass="login_btn" OnClick="Exit_btn_Click" />
            </div>
        </div>
            
        <div class="containerHome">
            <asp:Label ID="Label1" runat="server" Text="Welcome to the survey page" CssClass="label1"></asp:Label>
            <asp:Label ID="Label2" runat="server" Text="In order to complete the survey you will be asked some questions,<br/>please take your time to answer." CssClass="label2"></asp:Label>
            <asp:Label ID="Label3" runat="server" Text="Click the button &quot;Start&quot; to begin the survey" CssClass="label3"></asp:Label>
            <div class="btn_container">
                <asp:Button ID="next_btn2" Text="Start" runat="server" CssClass="start_btn" OnClick="next_btn2_Click" />
            </div>
        </div>
    </form>
    <div class="footer_container">
        <asp:Label ID="copyright_lbl" runat="server" Text="Copyright @Market Survey 2022" CssClass="copyright_lbl"></asp:Label>
    </div>
</body>
</html>
