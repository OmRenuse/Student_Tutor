using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project_Student_Website
{
    public partial class FeedBack_SuggestionForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            // Get the values from textboxes
            string name = txt_Name.Text;
            string suggestion = txt_Feedback.Text;

            // Define connection string
            string connectionString = ConfigurationManager.ConnectionStrings["OmConnectionString"].ConnectionString;

            // Define SQL query to insert data
            string query = "INSERT INTO FeedBack (Name, Suggestion) VALUES (@Name, @Suggestion)";

            // Establish connection and command objects
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                // Add parameters to the command to prevent SQL injection
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Suggestion", suggestion);

                // Open the connection
                connection.Open();

                // Execute the command
                int rowsAffected = command.ExecuteNonQuery();

                // Check if rows were affected
                if (rowsAffected > 0)
                {
                    // Data inserted successfully
                    // Show success message
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "FeedbackSubmitSuccess", "alert('Feedback submitted successfully!');", true);
                }
                else
                {
                    // Data insertion failed
                    // Show error message
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "FeedbackSubmitError", "alert('Failed to submit feedback!');", true);
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
               
            
        }
    }
}