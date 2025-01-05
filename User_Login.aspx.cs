using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Caching;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;

namespace Project_Student_Website
{
    public partial class User_Login : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["OmConnectionString"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        //userLogin
        protected void Button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                SqlConnection con = new SqlConnection(strcon);

                    con.Open();

                
                SqlCommand cmd = new SqlCommand("select * from user_Login where member_id='" + TextBox1.Text.Trim() + "' AND password='" + TextBox2.Text.Trim() + "'", con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Response.Write("<script>alert(' Login Successful');</script>");
                        Session["username"] = dr.GetValue(0).ToString();
                        Session["fullname"] = dr.GetValue(0).ToString();
                        Session["role"] = "user";
                        Session["status"] = dr.GetValue(9).ToString();
                    }
                    Response.Redirect("Home.aspx");
                }
                else
                {
                    Response.Write("<script>alert('Invalid credentials');</script>");
                }

            }
            catch (Exception ex)
            {

            }
        }
    }
}