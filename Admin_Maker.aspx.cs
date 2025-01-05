using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Data;

namespace Project_Student_Website
{
    public partial class Admin_Maker : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                PopulateMainDropdown();
            }
        }

        protected void PopulateMainDropdown()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["OmConnectionString"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT Name FROM MainRoadmap", con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                ddlMain.DataSource = reader;
                ddlMain.DataTextField = "Name";
                ddlMain.DataValueField = "Name";
                ddlMain.DataBind();
                con.Close();
            }
        }

        protected void ddlMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedName = ddlMain.SelectedValue;
            string connectionString = ConfigurationManager.ConnectionStrings["OmConnectionString"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT Content_Name FROM ContentRoadmap WHERE Name = @Name", con);
                cmd.Parameters.AddWithValue("@Name", selectedName);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                ddlContent.DataSource = reader;
                ddlContent.DataTextField = "Content_Name";
                ddlContent.DataValueField = "Content_Name";
                ddlContent.DataBind();
                con.Close();
            }
        }

        

        protected void ddlContent_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedName = ddlMain.SelectedValue;
            string selectedContent = ddlContent.SelectedValue;
            string connectionString = ConfigurationManager.ConnectionStrings["OmConnectionString"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                // Fetch Syntax for Label5
                SqlCommand cmd = new SqlCommand("SELECT Defination_Intro FROM ContentRoadmap WHERE Name = @Name AND Content_Name = @ContentName", con);
                cmd.Parameters.AddWithValue("@Name", selectedName);
                cmd.Parameters.AddWithValue("@ContentName", selectedContent);
                con.Open();
                object definationIntroObj = cmd.ExecuteScalar();
                if (definationIntroObj != DBNull.Value)
                {
                    string definationIntro = (string)definationIntroObj;
                    Label5.Text = !string.IsNullOrEmpty(definationIntro) ? definationIntro : "No data found";
                }
                else
                {
                    Label5.Text = "No data found";
                }

                // Fetch Youtube for Label6
                SqlCommand cmdYT = new SqlCommand("SELECT Youtube_Video FROM ContentRoadmap WHERE Name = @Name AND Content_Name = @ContentName", con);
                cmdYT.Parameters.AddWithValue("@Name", selectedName);
                cmdYT.Parameters.AddWithValue("@ContentName", selectedContent);
                object YoutubeObj = cmdYT.ExecuteScalar();
                if (YoutubeObj != DBNull.Value)
                {
                    string Youtube = (string)YoutubeObj;
                    Label6.Text = !string.IsNullOrEmpty(Youtube) ? Youtube : "No data found";
                }
                else
                {
                    Label6.Text = "No data found";
                }

                // Fetch Syntax for Label7
                SqlCommand cmdSyn = new SqlCommand("SELECT Syntax FROM ContentRoadmap WHERE Name = @Name AND Content_Name = @ContentName", con);
                cmdSyn.Parameters.AddWithValue("@Name", selectedName);
                cmdSyn.Parameters.AddWithValue("@ContentName", selectedContent);
                object syntaxObj = cmdSyn.ExecuteScalar();
                if (syntaxObj != DBNull.Value)
                {
                    string syntax = (string)syntaxObj;
                    Label7.Text = !string.IsNullOrEmpty(syntax) ? syntax : "No data found";
                }
                else
                {
                    Label7.Text = "No data found";
                }


                // Fetch Example for Label8
                SqlCommand cmdExa = new SqlCommand("SELECT Example FROM ContentRoadmap WHERE Name = @Name AND Content_Name = @ContentName", con);
                cmdExa.Parameters.AddWithValue("@Name", selectedName);
                cmdExa.Parameters.AddWithValue("@ContentName", selectedContent);
                object ExampleObj = cmdExa.ExecuteScalar();
                if (syntaxObj != DBNull.Value)
                {
                    string Example = (string)ExampleObj;
                    Label8.Text = !string.IsNullOrEmpty(Example) ? Example : "No data found";
                }
                else
                {
                    Label8.Text = "No data found";
                }

                // Fetch Syntax for Label10
                SqlCommand cmdQT = new SqlCommand("SELECT Que_Theorey FROM ContentRoadmap WHERE Name = @Name AND Content_Name = @ContentName", con);
                cmdQT.Parameters.AddWithValue("@Name", selectedName);
                cmdQT.Parameters.AddWithValue("@ContentName", selectedContent);
                object Que_TheoreyObj = cmdQT.ExecuteScalar();
                if (Que_TheoreyObj != DBNull.Value)
                {
                    string Que_Theorey = (string)Que_TheoreyObj;
                    Label10.Text = !string.IsNullOrEmpty(Que_Theorey) ? Que_Theorey : "No data found";
                }
                else
                {
                    Label10.Text = "No data found";
                }

                // Fetch Syntax for Label12
                SqlCommand cmdQC = new SqlCommand("SELECT Que_Coding FROM ContentRoadmap WHERE Name = @Name AND Content_Name = @ContentName", con);
                cmdQC.Parameters.AddWithValue("@Name", selectedName);
                cmdQC.Parameters.AddWithValue("@ContentName", selectedContent);
                object Que_CodingObj = cmdQC.ExecuteScalar();
                if (Que_CodingObj != DBNull.Value)
                {
                    string Que_Coding = (string)Que_TheoreyObj;
                    Label12.Text = !string.IsNullOrEmpty(Que_Coding) ? Que_Coding : "No data found";
                }
                else
                {
                    Label12.Text = "No data found";
                }

                con.Close();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string selectedName = ddlMain.SelectedValue;
            string selectedContent = ddlContent.SelectedValue;
            string definationintroValue = TextBox1.Text;
            string youtubevideoValue = TextBox2.Text;
            string syntaxValue = TextBox3.Text;
            string exampleValue = TextBox4.Text;
            string quetheoreyValue = TextBox5.Text;
            string quecodingValue = TextBox6.Text;

            string connectionString = ConfigurationManager.ConnectionStrings["OmConnectionString"].ConnectionString;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                // Check if the record already exists based on Name and Content_Name
                SqlCommand cmdCheckExistence = new SqlCommand("SELECT COUNT(*) FROM ContentRoadmap WHERE Name = @Name AND Content_Name = @ContentName", con);
                cmdCheckExistence.Parameters.AddWithValue("@Name", selectedName);
                cmdCheckExistence.Parameters.AddWithValue("@ContentName", selectedContent);

                con.Open();
                int existingRecordCount = (int)cmdCheckExistence.ExecuteScalar();

                if (existingRecordCount > 0)
                {
                    // If the record exists, perform an update
                    SqlCommand cmdUpdate = new SqlCommand("UPDATE ContentRoadmap SET Defination_Intro = @DefinationIntro, Youtube_Video = @YoutubeVideo, Syntax = @Syntax, Example = @Example, Que_Theorey = @QueTheorey, Que_Coding = @QueCoding WHERE Name = @Name AND Content_Name = @ContentName", con);
                    cmdUpdate.Parameters.AddWithValue("@Name", selectedName);
                    cmdUpdate.Parameters.AddWithValue("@ContentName", selectedContent);
                    cmdUpdate.Parameters.AddWithValue("@DefinationIntro", definationintroValue);
                    cmdUpdate.Parameters.AddWithValue("@YoutubeVideo", youtubevideoValue);
                    cmdUpdate.Parameters.AddWithValue("@Syntax", syntaxValue);
                    cmdUpdate.Parameters.AddWithValue("@Example", exampleValue);
                    cmdUpdate.Parameters.AddWithValue("@QueTheorey", quetheoreyValue);
                    cmdUpdate.Parameters.AddWithValue("@QueCoding", quecodingValue);

                    try
                    {
                        int rowsAffected = cmdUpdate.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            lbl_result1.Text = "Update successful";
                        }
                        else
                        {
                            lbl_result1.Text = "Update failed";
                        }
                    }
                    catch (Exception ex)
                    {
                        lbl_result1.Text = "An error occurred: " + ex.Message;
                    }
                }
                else
                {
                    // If the record doesn't exist, perform an insertion
                    SqlCommand cmdInsert = new SqlCommand("INSERT INTO ContentRoadmap (Name, Content_Name, Defination_Intro, Youtube_Video, Syntax, Example, Que_Theorey, Que_Coding) VALUES (@Name, @ContentName, @DefinationIntro, @YoutubeVideo, @Syntax, @Example, @QueTheorey, @QueCoding)", con);
                    cmdInsert.Parameters.AddWithValue("@Name", selectedName);
                    cmdInsert.Parameters.AddWithValue("@ContentName", selectedContent);
                    cmdInsert.Parameters.AddWithValue("@DefinationIntro", definationintroValue);
                    cmdInsert.Parameters.AddWithValue("@YoutubeVideo", youtubevideoValue);
                    cmdInsert.Parameters.AddWithValue("@Syntax", syntaxValue);
                    cmdInsert.Parameters.AddWithValue("@Example", exampleValue);
                    cmdInsert.Parameters.AddWithValue("@QueTheorey", quetheoreyValue);
                    cmdInsert.Parameters.AddWithValue("@QueCoding", quecodingValue);
                    try
                    {
                        int rowsAffected = cmdInsert.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            lbl_result1.Text = "Insertion successful";
                        }
                        else
                        {
                            lbl_result1.Text = "Insertion failed";
                        }
                    }
                    catch (Exception ex)
                    {
                        lbl_result1.Text = "An error occurred: " + ex.Message;
                    }
                }
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            
            
        }

        protected void btnImgUpload_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
            {
                HttpPostedFile uploadedFile = FileUpload1.PostedFile;
                if (IsImage(uploadedFile))
                {
                    string selectedName = ddlMain.SelectedValue;
                    string selectedContent = ddlContent.SelectedValue;
                    string connectionString = ConfigurationManager.ConnectionStrings["OmConnectionString"].ConnectionString;

                    try
                    {
                        using (SqlConnection con = new SqlConnection(connectionString))
                        {
                            using (SqlCommand cmd = new SqlCommand("UPDATE ContentRoadmap SET Image_Content = @ImageContent WHERE Name = @Name AND Content_Name = @ContentName", con))
                            {
                                cmd.Parameters.AddWithValue("@Name", selectedName);
                                cmd.Parameters.AddWithValue("@ContentName", selectedContent);
                                cmd.Parameters.Add("@ImageContent", SqlDbType.VarBinary).Value = uploadedFile.InputStream;

                                con.Open();
                                int rowsAffected = cmd.ExecuteNonQuery();
                                if (rowsAffected > 0)
                                {
                                    lbl_result1.Text = "Image uploaded successfully";
                                }
                                else
                                {
                                    lbl_result1.Text = "Failed to upload image";
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        lbl_result1.Text = "An error occurred while uploading image: " + ex.Message;
                    }
                }
                else
                {
                    lbl_result1.Text = "Please upload a valid image file (.jpg, .jpeg, .png)";
                }
            }
            else
            {
                lbl_result1.Text = "Please select an image file to upload";
            }
        }

        private bool IsImage(HttpPostedFile file)
        {
            if (file.ContentType.ToLower().StartsWith("image/") && file.ContentLength > 0)
            {
                try
                {
                    using (var img = System.Drawing.Image.FromStream(file.InputStream))
                    {
                        return true;
                    }
                }
                catch
                {
                    return false;
                }
            }
            return false;
        }
    }
}