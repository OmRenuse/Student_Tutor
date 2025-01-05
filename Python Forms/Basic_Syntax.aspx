<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="Basic_Syntax.aspx.cs" Inherits="Project_Student_Website.Python_Forms.Basic_Syntax" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
       <section>
        <div class="container">
            <div class="row">
                <div class="col-12">
                    <p><asp:Label runat="server" Text="Pyhton :"></asp:Label> <asp:Label runat="server" Text=" Basic Syntax"></asp:Label></p>
                </div>
            </div>
            <div class="row">
                <div class="col-md-12">
                    <h4>Introduction</h4>
                    <p class="text-justify">
                        <asp:Label runat="server" Text="Label" ID="DefinationLabel"></asp:Label>
                    </p>
                <div class="col-md-12">
                    <h4>Image</h4>
                    <center><asp:Image ID="MyImage" runat="server" Height="300px" Width="300px" /></center>
                </div>

                </div>
                <div class="col-md-12">
                    <h4>Youtube Video Link</h4>
                    <p class="text-justify">
                        <asp:Label runat="server" Text="Label" ID="Youtubelbl"></asp:Label>
                    </p>
                </div>
                <div class="col-md-12">
                    <h4> Syntax</h4>
                    <p class="text-justify">
                        <asp:Label runat="server" Text="Label" ID="Syntaxlbl"></asp:Label>
                    </p>
                </div>
                <div class="col-md-12">
                    <h4> Example</h4>
                    <p class="text-justify">
                        <asp:Label runat="server" Text="Label" ID="Examplelbl"></asp:Label>
                    </p>
                </div>
                <div class="col-md-12">
                    <h4>Questions</h4>
                </div>
                <div class="col-md-12">
                    <h4>Theorey</h4>
                    <p class="text-justify">
                        <asp:Label runat="server" Text="Label" ID="Theoreylbl"></asp:Label>
                    </p>
                </div>
                <div class="col-md-12">
                    <h4>Coding</h4>
                    <p class="text-justify">
                        <asp:Label runat="server" Text="Label" ID="Codinglbl"></asp:Label>
                    </p>
                    <p class="text-justify">
                        <asp:Label runat="server" Text="Thank You...!" ID="Label5"></asp:Label>
                    </p>
                    <p class="text-justify">&nbsp;</p>
                </div>
                <!-- Add this div to display the image -->
                
            </div>
        </div>
    </section>

</asp:Content>
