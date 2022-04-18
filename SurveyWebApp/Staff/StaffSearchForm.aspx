<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StaffSearchForm.aspx.cs" Inherits="SurveyWebApp.StaffSearchForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="StaffSearchForm.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="main_container">
            <asp:Label ID="Label1" runat="server" Text="Search by criteria:" CssClass="Label1"></asp:Label>
            <div class="search_form_container">
                <div class="column">
                    <div class="row">
                        <asp:Label ID="Label3" runat="server" Text="First name:" CssClass="label"></asp:Label>
                        <asp:TextBox ID="TextBox1" runat="server" CssClass="text_field"></asp:TextBox>
                        <asp:Button ID="Button3" runat="server" Text="X" CssClass="cancel_button" />
                    </div>
                    <div class="row">
                        <asp:Label ID="Label4" runat="server" Text="Second name:" CssClass="label"></asp:Label>
                        <asp:TextBox ID="TextBox2" runat="server" CssClass="text_field"></asp:TextBox>
                        <asp:Button ID="Button4" runat="server" Text="X" CssClass="cancel_button" />
                    </div>
                    <div class="row">
                        <asp:Label ID="Label5" runat="server" Text="Gender:" CssClass="label"></asp:Label>
                        <asp:TextBox ID="TextBox3" runat="server" CssClass="text_field"></asp:TextBox>
                         <asp:Button ID="Button7" runat="server" Text="X" CssClass="cancel_button_empty" />
                    </div>
                    <div class="row">
                        <asp:Label ID="Label6" runat="server" Text="Age range:" CssClass="label"></asp:Label>
                        <asp:TextBox ID="TextBox4" runat="server" CssClass="text_field"></asp:TextBox>
                         <asp:Button ID="Button8" runat="server" Text="X" CssClass="cancel_button_empty" />
                    </div>
                </div>
                <div class="column">
                    <div class="row">
                        <asp:Label ID="Label7" runat="server" Text="State:" CssClass="label"></asp:Label>
                        <asp:TextBox ID="TextBox5" runat="server" CssClass="text_field_middle"></asp:TextBox>
                         <asp:Button ID="Button9" runat="server" Text="X" CssClass="cancel_button_empty" />
                    </div>
                    <div class="row">
                        <asp:Label ID="Label8" runat="server" Text="Suburb:" CssClass="label"></asp:Label>
                        <asp:TextBox ID="TextBox6" runat="server" CssClass="text_field_middle"></asp:TextBox>
                         <asp:Button ID="Button10" runat="server" Text="X" CssClass="cancel_button_empty" />
                    </div>
                    <div class="row">
                        <asp:Label ID="Label9" runat="server" Text="Post code:" CssClass="label"></asp:Label>
                        <asp:TextBox ID="TextBox7" runat="server" CssClass="text_field_middle"></asp:TextBox>
                        <asp:Button ID="Button5" runat="server" Text="X" CssClass="cancel_button_empty" />
                    </div>
                </div>
                <div class="column">
                    <div class="row">
                        <asp:Label ID="Label10" runat="server" Text="Email:" CssClass="label"></asp:Label>
                        <asp:TextBox ID="TextBox8" runat="server" CssClass="text_field_middle"></asp:TextBox>
                        <asp:Button ID="Button6" runat="server" Text="X" CssClass="cancel_button" />
                    </div>
                    <div class="row">
                        <asp:Label ID="Label11" runat="server" Text="Bank:" CssClass="label"></asp:Label>
                        <asp:TextBox ID="TextBox9" runat="server" CssClass="text_field_middle"></asp:TextBox>
                         <asp:Button ID="Button11" runat="server" Text="X" CssClass="cancel_button_empty" />
                    </div>
                    <div class="row">
                        <asp:Label ID="Label12" runat="server" Text="Bank service:" CssClass="label"></asp:Label>
                        <asp:TextBox ID="TextBox10" runat="server" CssClass="text_field_middle"></asp:TextBox>
                         <asp:Button ID="Button12" runat="server" Text="X" CssClass="cancel_button_empty" />
                    </div>
                </div>
                <div class="column">
                    <div class="row">
                        <asp:Label ID="Label13" runat="server" Text="Newspaper:" CssClass="label"></asp:Label>
                        <asp:TextBox ID="TextBox11" runat="server" CssClass="text_field"></asp:TextBox>
                         <asp:Button ID="Button13" runat="server" Text="X" CssClass="cancel_button_empty" />
                    </div>
                    <div class="row">
                        <asp:Label ID="Label14" runat="server" Text="News interest:" CssClass="label"></asp:Label>
                        <asp:TextBox ID="TextBox12" runat="server" CssClass="text_field"></asp:TextBox>
                         <asp:Button ID="Button14" runat="server" Text="X" CssClass="cancel_button_empty" />
                    </div>
                    <div class="row">
                        <asp:Label ID="Label15" runat="server" Text="Travel destination:" CssClass="label"></asp:Label>
                        <asp:TextBox ID="TextBox13" runat="server" CssClass="text_field"></asp:TextBox>
                         <asp:Button ID="Button15" runat="server" Text="X" CssClass="cancel_button_empty" />
                    </div>
                    <div class="row">
                        <asp:Label ID="Label16" runat="server" Text="Sport:" CssClass="label"></asp:Label>
                        <asp:TextBox ID="TextBox14" runat="server" CssClass="text_field"></asp:TextBox>
                         <asp:Button ID="Button16" runat="server" Text="X" CssClass="cancel_button_empty" />
                    </div>
                </div>
            </div>
            <div class="buttons_container">
                <asp:Button ID="Button1" runat="server" Text="Search" CssClass="search_button" />
                <asp:Button ID="Button2" runat="server" Text="Reset all" CssClass="delete_button" />
            </div>
            <hr class="line"/>
            <div class="results_container">
                <asp:Label ID="Label2" runat="server" Text="Results:" CssClass="Label1"></asp:Label>
                <asp:GridView ID="GridView1" runat="server"></asp:GridView>
            </div>
        </div>
    </form>
</body>
</html>
