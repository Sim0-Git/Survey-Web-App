<%@ Page Title="" Language="C#" MasterPageFile="~/Master1.Master" AutoEventWireup="true" CodeBehind="HomeMaster.aspx.cs" Inherits="SurveyWebApp.HomeMaster" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="question_container">
           <asp:Label ID="question_label" Text="Enter your email:" runat="server" CssClass="question_label"></asp:Label>
             <%-- <asp:TextBox ID="email_txtbox" runat="server" placeholder="Email" CssClass="email_txtbox"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator_email" runat="server" ErrorMessage="Email cannot be empty" ForeColor="#FF0066" ControlToValidate="email_txtbox" Font-Size="10pt"></asp:RequiredFieldValidator> --%>

            <asp:PlaceHolder ID="placeHolder" runat="server"></asp:PlaceHolder>

        </div>
        <asp:Label ID="option_selected_lbl" runat="server" Text="Label"></asp:Label>
        <div class="btn_container">
            <asp:Button ID="next_btn2" Text="Next  >" runat="server" CssClass="next_btn2" OnClick="next_btn2_Click" />
        </div>
    </div>
</asp:Content>
