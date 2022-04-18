<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Main1.aspx.cs" Inherits="SurveyWebApp.Main1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label_name" runat="server" Text="Your name:"></asp:Label>
            <asp:TextBox ID="TextBox_name" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
            <br />
            <br />
            <asp:Label ID="Label_result" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
