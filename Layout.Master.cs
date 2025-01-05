using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project_Student_Website
{
    public partial class Layout : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Session["role"].Equals(""))
                {
                    LinkButton1.Visible = true; //user Login Link Button
                    LinkButton2.Visible = true; //SIgn up Link Button

                    LinkButton3.Visible = false; //Logout Link Button
                    LinkButton7.Visible = false; //Hello user Link Button

                    LinkButton6.Visible = true; //Admin Login Link Button
                    LinkButton10.Visible = false; //user Management Link Button
                    LinkButton11.Visible = false; //Admin Maker Link Button
                }
                else if (Session["role"].Equals("user"))
                {

                    LinkButton1.Visible = false; //user Login Link Button
                    LinkButton2.Visible = false; //SIgn up Link Button

                    LinkButton3.Visible = true; //Logout Link Button
                    LinkButton7.Visible = true; //Hello user Link Button
                    LinkButton7.Text = "Hello "+ Session["username"].ToString();


                    LinkButton6.Visible = true; //Admin Login Link Button
                    LinkButton10.Visible = false; //user Management Link Button
                    LinkButton11.Visible = false; //Admin Maker Link Button
                }
                else if (Session["role"].Equals("admin"))
                {

                    LinkButton1.Visible = false; //user Login Link Button
                    LinkButton2.Visible = false; //SIgn up Link Button

                    LinkButton3.Visible = true; //Logout Link Button
                    LinkButton7.Visible = true; //Hello user Link Button
                    LinkButton7.Text = "Hello Admin";


                    LinkButton6.Visible = false; //Admin Login Link Button
                    LinkButton10.Visible = true; //user Management Link Button
                    LinkButton11.Visible = true; //Admin Maker Link Button
                }
            }
            catch (Exception ex)
            {
                
            }
        }
       
       


        protected void Menu3_MenuItemClick1(object sender, MenuEventArgs e)
        {
            switch (e.Item.Value)
            {
                case "HTML5":
                    Response.Redirect("Menu forms\\Html5.aspx");
                    break;
                case "JavaScript":
                    Response.Redirect("Menu forms\\JavaScript.aspx");
                    break;
                case "CSS3":
                    Response.Redirect("Menu forms\\CSS3.aspx");
                    break;
                case "React JS":
                    Response.Redirect("Menu forms\\React JS.aspx");
                    break;
                case "Bootstrap":
                    Response.Redirect("Menu forms\\Bootstrap.aspx");
                    break;
                case "Python":
                    Response.Redirect("Menu forms\\Python.aspx");
                    break;
                case "Java":
                    Response.Redirect("Menu forms\\Java.aspx");
                    break;
                case "Node.JS":
                    Response.Redirect("Menu forms\\Node.JS.aspx");
                    break;
                case ".Net":
                    Response.Redirect("Menu forms\\.NET.aspx");
                    break;
                case "Django":
                    Response.Redirect("Menu forms\\Django.aspx");
                    break;
                case "Flask":
                    Response.Redirect("Menu forms\\Flask.aspx");
                    break;
                case "PHP":
                    Response.Redirect("Menu forms\\PHP.aspx");
                    break;
                case "MySQL":
                    Response.Redirect("Menu forms\\MySQL.aspx");
                    break;
                case "Oracle":
                    Response.Redirect("Menu forms\\Oracle.aspx");
                    break;
                case "MongoDB":
                    Response.Redirect("Menu forms\\MongoDB.aspx");
                    break;
                case "Android":
                    Response.Redirect("Menu forms\\Android.aspx");
                    break;
                case "Linux":
                    Response.Redirect("Menu forms\\Linux.aspx");
                    break;
                case "AWS":
                    Response.Redirect("Menu forms\\AWS.aspx");
                    break;
                case "HTTPs":
                    Response.Redirect("Menu forms\\HTTPs.aspx");
                    break;
                case "SSL/TLS":
                    Response.Redirect("Menu forms\\SSL&TLS.aspx");
                    break;
                case "Firewall":
                    Response.Redirect("Menu forms\\Firewall.aspx");
                    break;
            }
        }

        protected void LinkButton4_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            Session["username"] = "";
            Session["fullname"] = "";
            Session["role"] = "";
            Session["status"] = "";

            LinkButton1.Visible = true; //user Login Link Button
            LinkButton2.Visible = true; //SIgn up Link Button

            LinkButton3.Visible = false; //Logout Link Button
            LinkButton7.Visible = false; //Hello user Link Button

            LinkButton6.Visible = true; //Admin Login Link Button
            LinkButton10.Visible = false; //user Management Link Button
            LinkButton11.Visible = false; //Admin Maker Link Button
        }

        protected void LinkButton10_Click(object sender, EventArgs e)
        {
            Response.Redirect("User_Management_Page.aspx");
        }

        

        protected void LinkButton11_Click1(object sender, EventArgs e)
        {
            Response.Redirect("Admin_Maker.aspx");
        }
    }
}
