<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="FeedBack_SuggestionForm.aspx.cs" Inherits="Project_Student_Website.FeedBack_SuggestionForm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<section>
<div class="container">
    <div style="border: 2px solid black;  padding: 3px; height: 400px; width: 900px; border-radius: 15px; background-color: ;">
    <asp:Button ID="Button1" runat="server" Text="Back" OnClick="Button1_Click" PostBackUrl="~/Home.aspx" /><br /><br />
    <asp:Label ID="Label1" runat="server" Text="Name : "></asp:Label><asp:TextBox ID="txt_Name" runat="server" Height="27px" Width="307px"></asp:TextBox><br /><br />
    <asp:Label ID="Label2" runat="server" Text="Please Enter Your Valuable Suggestion here : "></asp:Label>
    <asp:TextBox ID="txt_Feedback" runat="server" Height="27px" Width="400px"></asp:TextBox><br />
    <asp:Button ID="Button2" runat="server" Text="Submit" OnClick="Button2_Click" />
        </div>
</div>
</section>
</asp:Content>
