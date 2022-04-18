<%@ Page Title="" Language="C#" MasterPageFile="~/Master1.Master" AutoEventWireup="true" CodeBehind="QuestionMaster.aspx.cs" Inherits="SurveyWebApp.QuestionMaster" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="container">
            <div class="question_container">
                <asp:Label ID="question_label" Text="Gender:" runat="server" CssClass="question_label"></asp:Label>
                <%--<asp:DropDownList ID="droplist" runat="server" CssClass="droplist"></asp:DropDownList>--%>
                <asp:CheckBoxList ID="checkBoxList" runat="server" CssClass="checkBoxList" ></asp:CheckBoxList>
                <%--<asp:CheckBoxList ID="chkLstFavColor" runat="server" CssClass="checkBoxList" ></asp:CheckBoxList>--%>
            </div>
        </div>
</asp:Content>
