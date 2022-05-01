<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RespondentRegisterForm.aspx.cs" Inherits="SurveyWebApp.RespondentRegisterForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="RespondentRegister.css" rel="stylesheet" />
    <script>
        $("#submit_btn").click(function () {
            $("#email_txtbox").hide();
        })
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="left_container">
                <asp:Label ID="Label1" runat="server" Text="Thanks for completing the survey" CssClass="Label1"></asp:Label>
                <asp:Label ID="Label2" runat="server" Text="Would you like to subscribe</br> and become member</br> of the program?" CssClass="Label2"></asp:Label>
                <asp:Button ID="skip_btn" runat="server" Text="Skip" CssClass="btn_skip" OnClick="skip_btn_Click" CausesValidation="false"/>
            </div>
            <div class="right_container">
                <asp:Image ID="user_img" runat="server" ImageUrl="~/Images/rocket_login.png" CssClass="user_img" />
                <asp:Label ID="Label3" runat="server" Text="Please fill upp all the fields to subscribe" CssClass="Label3"></asp:Label>
                <div class="form_container">
                    <asp:Label ID="email_lbl" runat="server" Text="Email" CssClass="form_lbl"></asp:Label>
                    <asp:TextBox ID="email_txtbox" runat="server" placeholder="Email" CssClass="form_txt"></asp:TextBox>
                    <asp:TextBox ID="newEmail_txtbox" runat="server"  placeholder="Email" CssClass="newEmail_txtbox"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator_email" runat="server" ErrorMessage="Email cannot be empty" ForeColor="#FF0066" ControlToValidate="email_txtbox" Font-Size="10pt"></asp:RequiredFieldValidator>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator_newEmail" runat="server" ErrorMessage="Email cannot be empty" ForeColor="#FF0066" ControlToValidate="newEmail_txtbox" Font-Size="10pt"></asp:RequiredFieldValidator>
                    <asp:Label ID="name_lb" runat="server" Text="First name" CssClass="form_lbl"></asp:Label>
                    <asp:TextBox ID="name_txtbox" runat="server" placeholder="Name" CssClass="form_txt"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator_name" runat="server" ErrorMessage="Name cannot be empty" ForeColor="#FF0066" ControlToValidate="name_txtbox" Font-Size="10pt"></asp:RequiredFieldValidator>
                    <asp:Label ID="surname_lb" runat="server" Text="Second name" CssClass="form_lbl"></asp:Label>
                    <asp:TextBox ID="surname_txtbox" runat="server" placeholder="Surname" CssClass="form_txt"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator_surname" runat="server" ErrorMessage="Surname cannot be empty" ForeColor="#FF0066" ControlToValidate="surname_txtbox" Font-Size="10pt"></asp:RequiredFieldValidator>
                    <asp:Label ID="phone_lbl" runat="server" Text="Phone number" CssClass="form_lbl"></asp:Label>
                    <asp:TextBox ID="phone_txtbox" runat="server" placeholder="Phone" CssClass="form_txt"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator_phone" runat="server" ErrorMessage="Phone cannot be empty" ForeColor="#FF0066" ControlToValidate="phone_txtbox" Font-Size="10pt"></asp:RequiredFieldValidator>
                    <asp:Label ID="dob_lbl" runat="server" Text="Date of birth" CssClass="form_lbl"></asp:Label>
                    <asp:TextBox ID="dob_txtbox" runat="server" placeholder="dd/mm/yy" CssClass="form_txt">01/01/2000</asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator_dob" runat="server" ErrorMessage="Dob cannot be empty" ForeColor="#FF0066" ControlToValidate="dob_txtbox" Font-Size="10pt"></asp:RequiredFieldValidator>
                    <asp:Button ID="calendar_btn" runat="server" Text="Calendar" CssClass="calendar_btn" OnClick="calendar_btn_Click" />
                    <asp:Calendar ID="calendar" runat="server" BackColor="#3399FF" BorderStyle="None" Font-Size="10pt" ForeColor="White" OnSelectionChanged="calendar_SelectionChanged" Visible="False"></asp:Calendar>
                </div>
                <asp:Button ID="submit_btn" runat="server" Text="Submit" CssClass="btn_submit" OnClick="submit_btn_Click" />
                <asp:Label ID="server_check" runat="server" Text=""></asp:Label>
            </div>
        </div>
    </form>
</body>
</html>
