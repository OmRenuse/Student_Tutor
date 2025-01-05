<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="Main_AdminPage.aspx.cs" Inherits="Project_Student_Website.Main_AdminPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <div class="container">
       <br />
       <asp:Button ID="Button1" runat="server" Text="Content_Editor" BackColor="#9999FF" OnClick="Button1_Click" PostBackUrl="~/Admin_Maker.aspx" /><br /> 
       <asp:Label ID="Label1" runat="server" Text="This button is use to insert the content in Pages"></asp:Label> <br /><br />
       <asp:Button ID="Button2" runat="server" Text="Suggestions" BackColor="#9999FF" PostBackUrl="~/FeedBack_SuggestionForm.aspx" /><br />
       <asp:Label ID="Label2" runat="server" Text="This button is use for Reading Suggestions"></asp:Label>
   </div>
</asp:Content>
