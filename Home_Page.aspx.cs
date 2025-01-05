using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project_Student_Website
{
    public partial class Home_First_Page : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btn_Python_Click(object sender, EventArgs e)
        {
            Response.Redirect("Python_Developer_Page.aspx");
        }

        protected void Btn_Home_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home_Page.aspx");
        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("Home_Page.aspx");
        }

        protected void Menu1_MenuItemClick(object sender, MenuEventArgs e)
        {

        }
    }
}