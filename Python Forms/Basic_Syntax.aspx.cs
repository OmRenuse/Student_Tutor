using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;

namespace Project_Student_Website.Python_Forms
{
    public partial class Basic_Syntax : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Call a method to fetch data from the database and set it to the label
                GetDataAndSetDefinationLabel();
                FetchAndSetImage();
                GetDataAndSetExampleLabel();
                GetDataAndSetYoutubeLabel();
                GetDataAndSetSyntaxLabel();
                GetDataAndSetTheoQueLabel();
                GetDataAndSetCodQueLabel();
            }
        }
        //DefinationIntro
        protected void GetDataAndSetDefinationLabel()
        {
            // Retrieve the connection string from the web.config file
            string connectionString = ConfigurationManager.ConnectionStrings["OmConnectionString"].ConnectionString;

            // SQL query to fetch data from the database
            string query = "SELECT Defination_Intro FROM ContentRoadmap WHERE Name = @Name AND Content_Name = @ContentName";

            // Create a SqlConnection object
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Create a SqlCommand object with the query and connection
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add parameters to the query
                    command.Parameters.AddWithValue("@Name", "Python");
                    command.Parameters.AddWithValue("@ContentName", "Syntax");

                    // Open the connection
                    connection.Open();

                    // Execute the query and get the result
                    object resultdefination = command.ExecuteScalar();

                    // Check if result is not null
                    if (resultdefination != null)
                    {
                        // Set the result to the label
                        DefinationLabel.Text = resultdefination.ToString();
                    }
                    else
                    {
                        // Handle the case when no data is retrieved
                        Label5.Text = "No data found";
                    }
                }
            }
        }
        //Image
        protected void FetchAndSetImage()
        {
            // Retrieve the connection string from the web.config file
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["OmConnectionString"].ConnectionString;

            // SQL query to fetch image data from the database
            string query = "SELECT Image_Content FROM ContentRoadmap WHERE Name = @Name AND Content_Name = @ContentName";

            // Create a SqlConnection object
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Create a SqlCommand object with the query and connection
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add parameters to the query
                    command.Parameters.AddWithValue("@Name", "Python");
                    command.Parameters.AddWithValue("@ContentName", "Syntax");

                    // Open the connection
                    connection.Open();

                    // Execute the query and get the result (image byte array)
                    byte[] imageData = (byte[])command.ExecuteScalar();

                    // Check if the image data is not null
                    if (imageData != null)
                    {
                        // Convert byte array to base64 string
                        string base64String = Convert.ToBase64String(imageData);

                        // Set the base64 string as the source for the Image control
                        MyImage.ImageUrl = "data:image/png;base64," + base64String;
                    }
                    else
                    {
                        // Handle the case when no image data is retrieved
                        MyImage.ImageUrl = ""; // Or set a default image URL
                    }
                }
            }
        }
        //YoutubeLink
        protected void GetDataAndSetYoutubeLabel()
        {
            // Retrieve the connection string from the web.config file
            string connectionString = ConfigurationManager.ConnectionStrings["OmConnectionString"].ConnectionString;

            // SQL query to fetch data from the database
            string query = "SELECT Youtube_Video FROM ContentRoadmap WHERE Name = @Name AND Content_Name = @ContentName";

            // Create a SqlConnection object
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Create a SqlCommand object with the query and connection
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add parameters to the query
                    command.Parameters.AddWithValue("@Name", "Python");
                    command.Parameters.AddWithValue("@ContentName", "Syntax");

                    // Open the connection
                    connection.Open();

                    // Execute the query and get the result
                    object resultdefination = command.ExecuteScalar();

                    // Check if result is not null
                    if (resultdefination != null)
                    {
                        // Set the result to the label
                        Youtubelbl.Text = resultdefination.ToString();
                    }
                    else
                    {
                        // Handle the case when no data is retrieved
                        Label5.Text = "No data found";
                    }
                }
            }
        }

        //Syntax
        protected void GetDataAndSetSyntaxLabel()
        {
            // Retrieve the connection string from the web.config file
            string connectionString = ConfigurationManager.ConnectionStrings["OmConnectionString"].ConnectionString;

            // SQL query to fetch data from the database
            string query = "SELECT Syntax FROM ContentRoadmap WHERE Name = @Name AND Content_Name = @ContentName";

            // Create a SqlConnection object
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Create a SqlCommand object with the query and connection
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add parameters to the query
                    command.Parameters.AddWithValue("@Name", "Python");
                    command.Parameters.AddWithValue("@ContentName", "Syntax");

                    // Open the connection
                    connection.Open();

                    // Execute the query and get the result
                    object resultdefination = command.ExecuteScalar();

                    // Check if result is not null
                    if (resultdefination != null)
                    {
                        // Set the result to the label
                        Syntaxlbl.Text = resultdefination.ToString();
                    }
                    else
                    {
                        // Handle the case when no data is retrieved
                        Label5.Text = "No data found";
                    }
                }
            }
        }
        //Example
        protected void GetDataAndSetExampleLabel()
        {
            // Retrieve the connection string from the web.config file
            string connectionString = ConfigurationManager.ConnectionStrings["OmConnectionString"].ConnectionString;

            // SQL query to fetch data from the database
            string query = "SELECT Example FROM ContentRoadmap WHERE Name = @Name AND Content_Name = @ContentName";

            // Create a SqlConnection object
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Create a SqlCommand object with the query and connection
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add parameters to the query
                    command.Parameters.AddWithValue("@Name", "Python");
                    command.Parameters.AddWithValue("@ContentName", "Syntax");

                    // Open the connection
                    connection.Open();

                    // Execute the query and get the result
                    object resultdefination = command.ExecuteScalar();

                    // Check if result is not null
                    if (resultdefination != null)
                    {
                        // Set the result to the label
                        Examplelbl.Text = resultdefination.ToString();
                    }
                    else
                    {
                        // Handle the case when no data is retrieved
                        Label5.Text = "No data found";
                    }
                }
            }
        }
        //Theorey Questions
        protected void GetDataAndSetTheoQueLabel()
        {
            // Retrieve the connection string from the web.config file
            string connectionString = ConfigurationManager.ConnectionStrings["OmConnectionString"].ConnectionString;

            // SQL query to fetch data from the database
            string query = "SELECT Que_Theorey FROM ContentRoadmap WHERE Name = @Name AND Content_Name = @ContentName";

            // Create a SqlConnection object
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Create a SqlCommand object with the query and connection
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add parameters to the query
                    command.Parameters.AddWithValue("@Name", "Python");
                    command.Parameters.AddWithValue("@ContentName", "Syntax");

                    // Open the connection
                    connection.Open();

                    // Execute the query and get the result
                    object resultdefination = command.ExecuteScalar();

                    // Check if result is not null
                    if (resultdefination != null)
                    {
                        // Set the result to the label
                        Theoreylbl.Text = resultdefination.ToString();
                    }
                    else
                    {
                        // Handle the case when no data is retrieved
                        Label5.Text = "No data found";
                    }
                }
            }
        }

        //CodingQuestions
        protected void GetDataAndSetCodQueLabel()
        {
            // Retrieve the connection string from the web.config file
            string connectionString = ConfigurationManager.ConnectionStrings["OmConnectionString"].ConnectionString;

            // SQL query to fetch data from the database
            string query = "SELECT Que_Coding FROM ContentRoadmap WHERE Name = @Name AND Content_Name = @ContentName";

            // Create a SqlConnection object
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Create a SqlCommand object with the query and connection
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add parameters to the query
                    command.Parameters.AddWithValue("@Name", "Python");
                    command.Parameters.AddWithValue("@ContentName", "Syntax");

                    // Open the connection
                    connection.Open();

                    // Execute the query and get the result
                    object resultdefination = command.ExecuteScalar();

                    // Check if result is not null
                    if (resultdefination != null)
                    {
                        // Set the result to the label
                        Codinglbl.Text = resultdefination.ToString();
                    }
                    else
                    {
                        // Handle the case when no data is retrieved
                        Label5.Text = "No data found";
                    }
                }
            }
        }

    }
}