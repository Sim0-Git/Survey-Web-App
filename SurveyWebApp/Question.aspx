<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Question.aspx.cs" Inherits="SurveyWebApp.Question" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="title_lbl" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            <asp:Label ID="question_lbl" runat="server" Text=""></asp:Label>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Next" OnClick="Button1_Click" style="height: 35px" />
        </div>
    </form>
</body>
</html>
