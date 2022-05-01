<%@ Page Language="C#" MasterPageFile="~/Master1.Master" AutoEventWireup="true" CodeBehind="Summary.aspx.cs" Inherits="SurveyWebApp.Summary" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div style="display: flex; justify-content: center;">
            <asp:Label ID="Title_1_lbl" runat="server" Text="Review your answers.<br/>By clicking finish the survey will be complete." CssClass="Title_1_lbl"></asp:Label>
        </div>
        <div class="question_container">
            <div class="summary">
                <div class="summary_question">
                    <div class="summary_questions">
                        <asp:Label ID="email" runat="server" Text="Email:" CssClass="question_lbl"></asp:Label>
                        <asp:Label ID="age_q" runat="server" Text="Age:" CssClass="question_lbl"></asp:Label>
                        <asp:Label ID="gender_q" runat="server" Text="Gender:" CssClass="question_lbl"></asp:Label>
                        <asp:Label ID="state_q" runat="server" Text="State:" CssClass="question_lbl"></asp:Label>
                        <asp:Label ID="suburb_q" runat="server" Text="Suburb:" CssClass="question_lbl"></asp:Label>
                        <asp:Label ID="postCode_q" runat="server" Text="Post code:" CssClass="question_lbl"></asp:Label>
                        <asp:Label ID="bank_q" runat="server" Text="Bank:" CssClass="question_lbl"></asp:Label>
                        <asp:Label ID="service_q" runat="server" Text="Service:" CssClass="question_lbl"></asp:Label>
                        <asp:Label ID="newspaper_q" runat="server" Text="Newspaper:" CssClass="question_lbl"></asp:Label>
                        <asp:Label ID="interest_q" runat="server" Text="News Interest:" CssClass="question_lbl"></asp:Label>
                        <asp:Label ID="sport_q" runat="server" Text="Sport:" CssClass="question_lbl"></asp:Label>
                        <asp:Label ID="travel_q" runat="server" Text="Travel:" CssClass="question_lbl"></asp:Label>
                    </div>
                </div>
                <div class="summary_answers">
                    <asp:Label ID="user_email" runat="server" Text="Email" CssClass="answer_lbl"></asp:Label>
                    <asp:Label ID="age_lbl" runat="server" Text="Age" CssClass="answer_lbl"></asp:Label>
                    <asp:Label ID="gender_lbl" runat="server" Text="Gender" CssClass="answer_lbl"></asp:Label>
                    <asp:Label ID="state_lbl" runat="server" Text="State" CssClass="answer_lbl"></asp:Label>
                    <asp:Label ID="suburb_lbl" runat="server" Text="Suburb" CssClass="answer_lbl"></asp:Label>
                    <asp:Label ID="postCode_lbl" runat="server" Text="Post code" CssClass="answer_lbl"></asp:Label>
                    <asp:Label ID="bank_lbl" runat="server" Text="Bank" CssClass="answer_lbl"></asp:Label>
                    <asp:Label ID="service_lbl" runat="server" Text="Service" CssClass="answer_lbl"></asp:Label>
                    <asp:Label ID="newspaper_lbl" runat="server" Text="Newspaper" CssClass="answer_lbl"></asp:Label>
                    <asp:Label ID="news_interest_lbl" runat="server" Text="News Interest" CssClass="answer_lbl"></asp:Label>
                    <asp:Label ID="sport_interest_lbl" runat="server" Text="Sport" CssClass="answer_lbl"></asp:Label>
                    <asp:Label ID="travel_lbl" runat="server" Text="Travel" CssClass="answer_lbl"></asp:Label>
                </div>

            </div>
            
        </div>
        <div class="btn_container">
            <asp:Button ID="finish_btn" Text="Finish" runat="server" CssClass="next_btn2" OnClick="finish_btn_Click" />
        </div>
        <div>
            <asp:Button ID="Exit_btn" runat="server" Text="Exit survey" CssClass="Exit_btn" CausesValidation="false" OnClick="Exit_btn_Click" />
        </div>
    </div>
</asp:Content>

