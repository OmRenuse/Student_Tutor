using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Controls;
using System.Drawing;
using System.Reflection.Emit;
using System.Web.Services.Description;

namespace Project_Student_Website
{
    public partial class User_Singup : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["OmConnectionString"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        // sign up button click event
        protected void SignupButton1_Click(object sender, EventArgs e)
        {
            if (checkMemberExists())
            {

                Response.Write("<script>alert('Member Already Exist with this Member ID, try other ID');</script>");
            }
            else
            {
                signUpNewMember();
            }
        }

        // user defined method
        bool checkMemberExists()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("SELECT * from user_Login where member_id='" + TextBox8.Text.Trim() + "';", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count >= 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
                return false;
            }
        }
        void signUpNewMember()
        {


            using (SqlConnection con = new SqlConnection(strcon))
            {
                con.Open();

                string insert = "INSERT INTO user_Login (full_name, dob, contact_no, email, state, city, pincode, full_address, member_id, password, account_status) " +
                    "VALUES (@full_name, @dob, @contact_no, @email, @state, @city, @pincode, @full_address, @member_id, @password, @account_status)";

                SqlCommand cmd = new SqlCommand(insert, con);

                cmd.Parameters.AddWithValue("@full_name", TextBox1.Text);
                cmd.Parameters.AddWithValue("@dob", TextBox2.Text);
                cmd.Parameters.AddWithValue("@contact_no", TextBox3.Text);
                cmd.Parameters.AddWithValue("@email", TextBox4.Text);
                cmd.Parameters.AddWithValue("@state", DropDownList1.SelectedItem.Value);
                cmd.Parameters.AddWithValue("@city", TextBox6.Text);
                cmd.Parameters.AddWithValue("@pincode", TextBox7.Text);
                cmd.Parameters.AddWithValue("@full_address", TextBox5.Text);
                cmd.Parameters.AddWithValue("@member_id", TextBox8.Text);
                cmd.Parameters.AddWithValue("@password", TextBox10.Text);
                cmd.Parameters.AddWithValue("@account_status", "pending");

                try
                {
                    cmd.ExecuteNonQuery();

                    con.Close();
                    Response.Write("<script>alert('Sign Up Successful. Go to User Login to Login');</script>");
                }
                catch (Exception ex)
                {
                    Response.Write("<script>alert('" + ex.Message + "');</script>");
                }


            }




            }




        }




    }
    