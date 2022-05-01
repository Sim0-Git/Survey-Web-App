<%@ Page Title="" Language="C#" MasterPageFile="~/Master1.Master" AutoEventWireup="true" CodeBehind="FinalScreen.aspx.cs" Inherits="SurveyWebApp.FinalScreen" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="login_box">
       
        <asp:Label runat="server" Text="Thank you for completing<br/> this survey" CssClass="thank_lbl" ></asp:Label>
        <asp:Button runat="server" Text="Close" CssClass="close_btn" OnClick="Unnamed2_Click" />
    </div>
</asp:Content>
