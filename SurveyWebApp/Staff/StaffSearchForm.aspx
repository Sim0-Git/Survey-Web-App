<%@ Page Language="C#" MasterPageFile="~/Master2.Master" AutoEventWireup="true" CodeBehind="StaffSearchForm.aspx.cs" Inherits="SurveyWebApp.StaffSearchForm" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
        <div class="main_container">
            <asp:Label ID="Label1" runat="server" Text="Search by criteria:" CssClass="Label1"></asp:Label>
            <div class="search_form_container">
                <div class="column">
                    <div class="row">
                        <asp:Label ID="Label3" runat="server" Text="First name:" CssClass="label"></asp:Label>
                        <asp:TextBox ID="first_name_txt" runat="server" CssClass="text_field"></asp:TextBox>
                        <asp:Button ID="Button3" runat="server" Text="X" CssClass="cancel_button" OnClick="Button3_Click" />
                    </div>
                    <div class="row">
                        <asp:Label ID="Label4" runat="server" Text="Second name:" CssClass="label"></asp:Label>
                        <asp:TextBox ID="second_name_txt" runat="server" CssClass="text_field"></asp:TextBox>
                        <asp:Button ID="Button4" runat="server" Text="X" CssClass="cancel_button" OnClick="Button4_Click" />
                    </div>
                    <div class="row">
                        <asp:Label ID="Label5" runat="server" Text="Gender:" CssClass="label"></asp:Label>
                        <asp:DropDownList ID="gender_list" runat="server" CssClass="drop_list">
                            <asp:ListItem Text="Select" Enabled="true" Value="-1"></asp:ListItem>
                            <asp:ListItem Text="Male" Value="1"></asp:ListItem>
                            <asp:ListItem Text="Female" Value="2"></asp:ListItem>
                            <asp:ListItem Text="Other" Value="3"></asp:ListItem>
                        </asp:DropDownList>
                        <asp:Button ID="Button7" runat="server" Text="X" CssClass="cancel_button_empty" />
                    </div>
                    <div class="row">
                        <asp:Label ID="Label6" runat="server" Text="Age range:" CssClass="label"></asp:Label>
                        <asp:DropDownList ID="age_list" runat="server" CssClass="drop_list">
                            <asp:ListItem Text="Select" Enabled="true" Value="-1"></asp:ListItem>
                            <asp:ListItem Text="18-25" Value="1"></asp:ListItem>
                            <asp:ListItem Text="26-35" Value="2"></asp:ListItem>
                            <asp:ListItem Text="36-45" Value="3"></asp:ListItem>
                            <asp:ListItem Text="45+" Value="4"></asp:ListItem>
                        </asp:DropDownList>
                        <asp:Button ID="Button8" runat="server" Text="X" CssClass="cancel_button_empty" />
                    </div>
                </div>
                <div class="column">
                    <div class="row">
                        <asp:Label ID="Label7" runat="server" Text="State:" CssClass="label"></asp:Label>
                        <asp:DropDownList ID="state_list" runat="server" CssClass="drop_list">
                            <asp:ListItem Text="Select" Enabled="true" Value="-1"></asp:ListItem>
                            <asp:ListItem Text="NSW" Value="1"></asp:ListItem>
                            <asp:ListItem Text="VIC" Value="2"></asp:ListItem>
                            <asp:ListItem Text="NT" Value="3"></asp:ListItem>
                            <asp:ListItem Text="SA" Value="4"></asp:ListItem>
                            <asp:ListItem Text="WA" Value="5"></asp:ListItem>
                        </asp:DropDownList>
                        <asp:Button ID="Button9" runat="server" Text="X" CssClass="cancel_button_empty" />
                    </div>
                    <div class="row">
                        <asp:Label ID="Label8" runat="server" Text="Suburb:" CssClass="label"></asp:Label>
                        <asp:TextBox ID="suburb_txt" runat="server" CssClass="text_field_middle"></asp:TextBox>
                        <asp:Button ID="Button10" runat="server" Text="X" CssClass="cancel_button_empty" />
                    </div>
                    <div class="row">
                        <asp:Label ID="Label9" runat="server" Text="Post code:" CssClass="label"></asp:Label>
                        <asp:TextBox ID="post_code_txt" runat="server" CssClass="text_field_middle"></asp:TextBox>
                        <asp:Button ID="Button5" runat="server" Text="X" CssClass="cancel_button_empty" />
                    </div>
                </div>
                <div class="column">
                    <div class="row">
                        <asp:Label ID="Label10" runat="server" Text="Email:" CssClass="label"></asp:Label>
                        <asp:TextBox ID="email_txt" runat="server" CssClass="text_field_middle"></asp:TextBox>
                        <asp:Button ID="Button6" runat="server" Text="X" CssClass="cancel_button" OnClick="Button6_Click" />
                    </div>
                    <div class="row">
                        <asp:Label ID="Label11" runat="server" Text="Bank:" CssClass="label"></asp:Label>
                        <asp:DropDownList ID="bank_list" runat="server" CssClass="drop_list">
                            <asp:ListItem Text="Select" Enabled="true" Value="-1"></asp:ListItem>
                            <asp:ListItem Text="Commonwealth" Value="1"></asp:ListItem>
                            <asp:ListItem Text="NAB" Value="2"></asp:ListItem>
                            <asp:ListItem Text="Westpack" Value="3"></asp:ListItem>
                            <asp:ListItem Text="ANZ" Value="4"></asp:ListItem>
                            <asp:ListItem Text="St. George" Value="5"></asp:ListItem>
                        </asp:DropDownList>
                        <asp:Button ID="Button11" runat="server" Text="X" CssClass="cancel_button_empty" />
                    </div>
                    <div class="row">
                        <asp:Label ID="Label12" runat="server" Text="Bank service:" CssClass="label"></asp:Label>
                        <asp:DropDownList ID="service_list" runat="server" CssClass="drop_list">
                            <asp:ListItem Text="Select" Enabled="true" Value="-1"></asp:ListItem>
                            <asp:ListItem Text="Internet banking" Value="1"></asp:ListItem>
                            <asp:ListItem Text="Home loan" Value="2"></asp:ListItem>
                            <asp:ListItem Text="Credit card" Value="3"></asp:ListItem>
                            <asp:ListItem Text="Share investment" Value="4"></asp:ListItem>
                        </asp:DropDownList>
                        <asp:Button ID="Button12" runat="server" Text="X" CssClass="cancel_button_empty" />
                    </div>
                </div>
                <div class="column">
                    <div class="row">
                        <asp:Label ID="Label13" runat="server" Text="Newspaper:" CssClass="label"></asp:Label>
                        <asp:DropDownList ID="newspaper_list" runat="server" CssClass="drop_list">
                            <asp:ListItem Text="Select" Enabled="true" Value="-1"></asp:ListItem>
                            <asp:ListItem Text="Not interested" Value="1"></asp:ListItem>
                            <asp:ListItem Text="The Australian" Value="2"></asp:ListItem>
                            <asp:ListItem Text="Herald Sun" Value="3"></asp:ListItem>
                            <asp:ListItem Text="The Daily Telegraph" Value="4"></asp:ListItem>
                            <asp:ListItem Text="The Age" Value="5"></asp:ListItem>
                            <asp:ListItem Text="The Mercury" Value="6"></asp:ListItem>
                        </asp:DropDownList>
                        <asp:Button ID="Button13" runat="server" Text="X" CssClass="cancel_button_empty" />
                    </div>
                    <div class="row">
                        <asp:Label ID="Label14" runat="server" Text="News interest:" CssClass="label"></asp:Label>
                        <asp:DropDownList ID="interest_list" runat="server" CssClass="drop_list">
                            <asp:ListItem Text="Select" Enabled="true" Value="-1"></asp:ListItem>
                            <asp:ListItem Text="Property" Value="1"></asp:ListItem>
                            <asp:ListItem Text="Sport" Value="2"></asp:ListItem>
                            <asp:ListItem Text="Financial" Value="3"></asp:ListItem>
                            <asp:ListItem Text="Entertainment" Value="4"></asp:ListItem>
                            <asp:ListItem Text="Lifestyle" Value="5"></asp:ListItem>
                            <asp:ListItem Text="Travel" Value="6"></asp:ListItem>
                            <asp:ListItem Text="Politics" Value="7"></asp:ListItem>
                        </asp:DropDownList>
                        <asp:Button ID="Button14" runat="server" Text="X" CssClass="cancel_button_empty" />
                    </div>
                    <div class="row">
                        <asp:Label ID="Label15" runat="server" Text="Travel destination:" CssClass="label"></asp:Label>
                        <asp:DropDownList ID="travel_list" runat="server" CssClass="drop_list">
                            <asp:ListItem Text="Select" Enabled="true" Value="-1"></asp:ListItem>
                            <asp:ListItem Text="Australia" Value="1"></asp:ListItem>
                            <asp:ListItem Text="Europe" Value="2"></asp:ListItem>
                            <asp:ListItem Text="Pacific" Value="3"></asp:ListItem>
                            <asp:ListItem Text="North America" Value="4"></asp:ListItem>
                            <asp:ListItem Text="South America" Value="5"></asp:ListItem>
                            <asp:ListItem Text="Asia" Value="6"></asp:ListItem>
                            <asp:ListItem Text="Africa" Value="7"></asp:ListItem>
                        </asp:DropDownList>
                        <asp:Button ID="Button15" runat="server" Text="X" CssClass="cancel_button_empty" />
                    </div>
                    <div class="row">
                        <asp:Label ID="Label16" runat="server" Text="Sport:" CssClass="label"></asp:Label>
                        <asp:DropDownList ID="sport_list" runat="server" CssClass="drop_list">
                            <asp:ListItem Text="Select" Enabled="true" Value="-1"></asp:ListItem>
                            <asp:ListItem Text="AFL" Value="1"></asp:ListItem>
                            <asp:ListItem Text="Football" Value="2"></asp:ListItem>
                            <asp:ListItem Text="Cricket" Value="3"></asp:ListItem>
                            <asp:ListItem Text="Racing" Value="4"></asp:ListItem>
                            <asp:ListItem Text="Motorsport" Value="5"></asp:ListItem>
                            <asp:ListItem Text="Basketball" Value="6"></asp:ListItem>
                            <asp:ListItem Text="Tennis" Value="7"></asp:ListItem>
                        </asp:DropDownList>
                        <asp:Button ID="Button16" runat="server" Text="X" CssClass="cancel_button_empty" />
                    </div>
                </div>
            </div>
            <div class="buttons_container">
                <asp:Button ID="Button1" runat="server" Text="Search" CssClass="search_button" OnClick="Button1_Click" />
                <asp:Button ID="Button2" runat="server" Text="Reset all" CssClass="delete_button" OnClick="Button2_Click" />
            </div>
            <asp:Label ID="Result_lbl" runat="server" Text="Label"></asp:Label>
            <hr class="line" />
            <div class="results_container">
                <asp:Label ID="Label2" runat="server" Text="Results:" CssClass="Label1"></asp:Label>
                <asp:GridView ID="staff_search_grid" runat="server"></asp:GridView>
            </div>
        </div>
    
</asp:Content>
