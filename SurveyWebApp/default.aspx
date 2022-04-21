<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="SurveyWebApp._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Users" runat="server" Text="Unregistered Users" Font-Bold="True" Font-Names="Arial" Font-Size="Large" ForeColor="#006699"></asp:Label>
            <br />
            <br />
            <asp:GridView ID="GridView1" runat="server" BorderColor="#0033CC" BorderStyle="Double" CellPadding="5" CellSpacing="5" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
            </asp:GridView>
            <br />
            <asp:Label ID="Staff" runat="server" Text="Staff" Font-Bold="True" Font-Names="Arial" Font-Size="Large" ForeColor="#006699"></asp:Label>
            <br />
            <br />
            <asp:GridView ID="GridView2" runat="server">
            </asp:GridView>
            <br />
            <br />
        </div>
    </form>
</body>
</html>
