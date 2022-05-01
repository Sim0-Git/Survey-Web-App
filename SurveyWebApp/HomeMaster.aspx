<%@ Page Title="" Language="C#" MasterPageFile="~/Master1.Master" AutoEventWireup="true" CodeBehind="HomeMaster.aspx.cs" Inherits="SurveyWebApp.HomeMaster" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div style="display: flex; justify-content: center;">
            <asp:Label ID="Title_1_lbl" runat="server" Text="Please answer the questions<br/>and click &quot;next&quot; in order to<br/>complete the survey" CssClass="Title_1_lbl"></asp:Label>
        </div>
        <div class="question_container">
            <asp:Label ID="question_label" Text="Enter your email:" runat="server" CssClass="question_label"></asp:Label>
            <asp:TextBox ID="email_txtbox" runat="server" placeholder="Email" CssClass="email_txtbox"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator_email" runat="server" ErrorMessage="Email cannot be empty" ForeColor="#FF0066" ControlToValidate="email_txtbox" Font-Size="10pt"></asp:RequiredFieldValidator>

            <asp:TextBox ID="text_box" runat="server" CssClass="text_box"></asp:TextBox>
            
            <asp:CheckBoxList ID="check_box_list" runat="server" CssClass="check_box_list"></asp:CheckBoxList>
            
            <asp:DropDownList ID="dropdown_list" runat="server" CssClass="dropdown_list"></asp:DropDownList>
            
            <asp:RadioButtonList ID="radio_button_list" runat="server" CssClass="radio_button_list"></asp:RadioButtonList>
            
        </div>
        <%--<asp:Label ID="option_selected_lbl" runat="server" Text="Label"></asp:Label> --%>
        <div class="btn_container">
            <asp:Button ID="next_btn2" Text="Next  >" runat="server" CssClass="next_btn2" OnClick="next_btn2_Click" />
        </div>
        <div>
            <asp:Button ID="Exit_btn" runat="server" Text="Exit survey" CssClass="Exit_btn" OnClick="Exit_btn_Click" CausesValidation="false" />
        </div>
    </div>
</asp:Content>
