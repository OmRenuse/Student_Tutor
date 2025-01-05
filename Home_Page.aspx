<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home_Page.aspx.cs" Inherits="Project_Student_Website.Home_First_Page" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        .positioned-div {
    width: 300px; /* Set the width of the container */
    height: 200px; /* Set the height of the container */
    overflow: hidden; /* Hide any overflow from the image */
    position: relative; /* Establish positioning context for the image */
                         }

 .positioned-div{
    width: 100%; /* Ensure the image fills the width of the container */
    height: 100%; /* Ensure the image fills the height of the container */
    object-fit: cover; /* Scale the image to be as large as possible while ensuring its aspect ratio is maintained */
}


           

.bubble-btn {
  background-color: #008CBA;
  color: white;
  border: none;
  border-radius: 50px;
  padding: 20px 40px;
  font-size: 16px;
  position: relative;
  transition: transform 0.3s;
}

.bubble-btn:hover {
  animation: bubble 0.4s ease-out;
}

@keyframes bubble {
  0% {
    transform: scale(1);
  }
  50% {
    transform: scale(1.2);
  }
  100% {
    transform: scale(1);
  }
}
.circular-image {
        border-radius: 50%;
    }


.button-64 {
  align-items: center;
  background-image: linear-gradient(144deg,#AF40FF, #5B42F3 50%,#00DDEB);
  border: 0;
  border-radius: 8px;
  box-shadow: rgba(151, 65, 252, 0.2) 0 15px 30px -5px;
  box-sizing: border-box;
  color: #FFFFFF;
  display: inline-block;
  margin: auto;
  font-family: Phantomsans, sans-serif;
  font-size: 25px;
  justify-content: center;
  max-width: 100%;
  min-width: 70px;
  padding: 3px;
  text-decoration: none;
  user-select: none;
  -webkit-user-select: none;
  touch-action: manipulation;
  white-space: nowrap;
  cursor: pointer; 
  background-color: rgb(5, 6, 45);
  padding: 3px;
  border-radius: 6px;
  transition: 300ms;
}



.button-64:active,
.button-64:hover {
  outline: 0;
}


.button-64:hover  {
  background: rgb(232, 112, 204);
}

@media (min-width: 768px) {
  .button-64 {
    font-size: 15px;
    min-width: 70px;
  }
}
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <header>
    <nav>
        <div style="width: 100%; height: 50px;">
                <asp:TextBox ID="TextBox1" runat="server" style="position: absolute; top: 18px; left: 604px; height: 30px; width: 318px; bottom: 187px; border-radius: 159px;"></asp:TextBox>
                <asp:ImageButton ID="ImageButton1" runat="server" style="position: absolute; top: 18px; left: 937px; height: 30px;  width: 30px; bottom: 608px;" alt="You Image" ImageUrl="~/search-icon-endless-icons-33.png" />
                <asp:ImageButton ID="ImageButton2" runat="server" CssClass="circular-image" style="position: absolute; top: 14px; left: 347px; height: 45px; bottom: 446px; width: 45px;" alt="Your Image" ImageUrl="~/OIG1.jpg" OnClick="ImageButton2_Click"/>
        </div>
    </nav>
    </header>
        <br />
            

       
       <div style=" position: relative;" >
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Btn_Home" runat="server" Text="Home" CssClass="button-64" OnClick="Btn_Home_Click" />
            <asp:Button ID="Btn_Python" runat="server" Text="Python" CssClass="button-64" OnClick="Btn_Python_Click" />
            <asp:Button ID="Btn_Java" runat="server" Text="Java" CssClass="button-64" />
            <asp:Button ID="Btn_JavaScript" runat="server" Text="JavaScript" CssClass="button-64" />
            <asp:Button ID="Btn_Cpp" runat="server" Text="C++" CssClass="button-64" />
            <asp:Button ID="Btn_SQL" runat="server" Text="SQL" CssClass="button-64" />
            <asp:Button ID="Btn_UXDesign" runat="server" Text="UX Design" CssClass="button-64" />
            <asp:Button ID="Btn_Frontend" runat="server" Text="Frontend" CssClass="button-64" />
            <asp:Button ID="Btn_Backend" runat="server" Text="Backend" CssClass="button-64" />

        </div> 
         <div><asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Python_Developer_Page.aspx" Text="Click Here"></asp:HyperLink></div>

        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem></asp:ListItem>
            <asp:ListItem></asp:ListItem>
            <asp:ListItem></asp:ListItem>
        </asp:DropDownList>

        <asp:Menu ID="Menu1" runat="server" Orientation="Horizontal" BackColor="#B5C7DE" DynamicHorizontalOffset="2" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#284E98" StaticSubMenuIndent="10px">
            <DynamicHoverStyle BackColor="#284E98" ForeColor="White" />
            <DynamicMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
            <DynamicMenuStyle BackColor="#B5C7DE" />
            <DynamicSelectedStyle BackColor="#507CD1" />
            <DynamicItemTemplate>
                <%# Eval("Text") %>
            </DynamicItemTemplate>
            <Items>
                <asp:MenuItem Text="Languages" Value="Languages">
                    <asp:MenuItem Text="Python" Value="Python"></asp:MenuItem>
                    <asp:MenuItem Text="Java" Value="New Item"></asp:MenuItem>
                    <asp:MenuItem Text="C++" Value="New Item"></asp:MenuItem>
                    <asp:MenuItem Text="Html/CSS" Value="New Item"></asp:MenuItem>
                    <asp:MenuItem Text="JavaScript" Value="JavaScript"></asp:MenuItem>
                </asp:MenuItem>
                <asp:MenuItem Text="New Item" Value="New Item"></asp:MenuItem>
                <asp:MenuItem Text="New Item" Value="New Item"></asp:MenuItem>
                <asp:MenuItem Text="New Item" Value="New Item"></asp:MenuItem>
            </Items>
            <StaticHoverStyle BackColor="#284E98" ForeColor="White" />
            <StaticMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
            <StaticSelectedStyle BackColor="#507CD1" />
        </asp:Menu>

        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="RequiredFieldValidator"></asp:RequiredFieldValidator>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>

    </form>
    
</body>
</html>
