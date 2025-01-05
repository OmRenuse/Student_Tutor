<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Project_Student_Website.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        

    
    <%--Section 2--%>
      <section>
    <div class="container">
         <br />
     
          
        <div style="display: flex; justify-content: space-around;">

            <div class="flex: 1" style="background-color: #ceb3fa; border: 2px solid hidden; border-radius: 15px; padding: 10px; height: 400px; width: 350px;">
               <center>
                   <a href="Menu%20forms/Python.aspx" style="color: black;">
                  <img src="images/Pyhton%20Logo.jpg" style="height: 200px; width: 200px;">
                  <h4 style="font-family: Algerian; font-size: 24px;">Python</h4></a>
                  <p class="text-justify">Unlock the power of Python with our comprehensive course. From fundamentals to real-world applications, embark on a journey to master Python for development and data analysis.</p>
               </center>
            </div>
             
            <div class="flex: 1" style="background-color: #a1cbfe; border: 2px solid hidden; border-radius: 15px; padding: 10px; height: 400px; width: 350px;">
               <center>
                   <a href="Menu%20forms/Java.aspx" style="color: black;">
                  <img src="images/Java.jpg" style="height: 200px; width: 200px;" >
                   <h4 style="font-size: 24px; font-family: Algerian">Java</h4></a>
                  <p class="text-justify">Dive into the world of Java programming with our comprehensive course. Explore from the basics to advanced applications, and equip yourself with the skills to develop robust software and applications.</p>
               </center>
            </div>
             
            <div class="flex: 1" style="background-color: #929292; border: 2px solid hidden; border-radius: 15px; padding: 10px; height: 400px; width: 350px;">
               <center>
                   <a href="Menu%20forms/Cpp.aspx" style="color: black;">
                  <img src="images/CppLogo.jpg" style="height: 200px; width: 200px;">
                   <h4 style="font-size: 24px; font-family: ALgerian">C++</h4></a>
                  <p class="text-justify">Discover the power of C++ through our comprehensive course. From foundational concepts to advanced programming, gain the expertise to create high-performance software and applications.</p>
               </center>
            </div>
         </div>
      </div>
          
   </section>



    <%--Section 3--%>
   <section>

       <div  style="border: 2px solid hidden;  padding: 0px; height: 50px; background-color: #3b7bff;">
      <center>
         <h2>-Trending Tutorials-</h2>
      </center>
       </div>
   <div class="container">
      <div class="row">
        <div class="m-auto" style=" border: 2px solid hidden; border-radius: 15px; padding: 10px; height: 325px; width: 375px;">
            <center>
                <a href="Trending%20Tutorials/Generative_Ai.aspx" style="color: black;">
                <img src="images/Generative%20ai.png" style="height: 240px; width: 400px; border-radius: 15px;">
               <h4 style="font-size: 24px; font-family: Algerian">Generative AI</h4>
               </a>
            </center>
         </div>
         <div class="m-auto" style="border: 2px solid hidden; border-radius: 15px; padding: 10px; height: 325px; width: 375px;">
            <center>
                <a href="Trending%20Tutorials/Digital_Marketing.aspx" style="color: black;">
                <img src="images/DigitalMarketing.jpg" style="height: 225px; width: 400px; border-radius: 15px;">
               <h4 style="font-size: 24px; font-family: Algerian">Digital Marketing</h4>
               </a>
            </center>
         </div>
         
      </div>
   </div>
</section>



    <%--Section 4--%>
      <section>
<div class="row">
   <div class="col-12">
       <div  style="border: 2px solid hidden;  padding: 0px; height: 50px; background-color: #3b7bff;">
      <center>
         <h2>-Exam Preparation-</h2>
      </center>
       </div>
   </div>
</div>
   <div class="container">
      
      <div class="row">
        <div class="col-md-12">     
            <a href="Exam%20Preparations/CSE_Gate.aspx" style="color: black;">
            <img src="images/Gate%20CSE.png" style="height: 200px; width: 370px;">
            <h4>CSE Gate Exam</h4>
            </a>
            <p class="text-justify"> Overall, the CSE GATE exam is highly competitive and requires thorough preparation to secure a good score, opening up opportunities for higher education and employment in prestigious institutions and organizations in India.</p>
      </div>
         <div class="col-md-12">       
             <a href="Exam%20Preparations/Mathematics_Gate.aspx" style="color: black;">
             <img src="images/GateMathematics.jpeg" style="height: 200px; width: 300px;">
            <h4>Mathematics Gate Exam</h4>
            </a>
            <p class="text-justify">In summary, the Mathematics GATE exam is an important opportunity for candidates interested in pursuing higher education and research in mathematics and related fields in India. It requires thorough preparation and a strong understanding of undergraduate-level mathematics concepts.</p>   
      </div>
     </div>
    </div>

          </section>


          <%--Section 5--%>
    <div class="row">
   <div class="col-12">
       <div  style="border: 2px solid hidden;  padding: 0px; height: 50px; background-color: #3b7bff;">
      <center>
         <h2>-Our Goals-</h2>
      </center>
       </div>
   </div>
</div>
     <section>
      <div class="container">
         <div class="row">
            <div class="col-md-12">
               <center>
                  <img width="150px" src="images/OursGoalsLogo.png"  style="height: 200px; width: 200px;">
                  <h4>Bits Of Atom</h4>
                  <p class="text-justify">Welcome to Bits Of Atom, your go-to platform for free knowledge and resources tailored to students and developers. My name is Om.B.Renuse, and I am passionate about empowering the next generation of learners and innovators. With a background in IT(Honours) in Somaiya Vidyavihar Uiversity, I founded this platform to provide a wealth of educational content, tutorials, and tools to support your learning journey. Whether you're a student seeking to broaden your knowledge or a developer striving to enhance your skills, I am committed to curating valuable resources to facilitate your growth. Join me in this endeavor as we embark on a collaborative quest for knowledge and mastery. Together, let's unlock your potential and achieve great things.<br />Here Everyone Is Anonymus So Take Care.</p>
                </center>
         </div>
      </div>
       </div>
   </section>

</asp:Content>
