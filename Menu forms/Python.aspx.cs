using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project_Student_Website.Menu_forms
{
    public partial class Python : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            // Get the current page URL
            string currentPageUrl = Request.Url.AbsoluteUri;

            // Register the JavaScript function to copy the URL to clipboard and show a message
            string script = $@"<script>
                        function copyUrlToClipboard() {{
                            var dummy = document.createElement('textarea');
                            document.body.appendChild(dummy);
                            dummy.value = '{currentPageUrl}';
                            dummy.select();
                            document.execCommand('copy');
                            document.body.removeChild(dummy);
                            alert('URL copied to clipboard: {currentPageUrl}');
                        }}
                        setTimeout(function() {{
                            copyUrlToClipboard();
                        }}, 3000); // 3 seconds delay
                    </script>";

            // Register the script to the page
            ClientScript.RegisterStartupScript(this.GetType(), "CopyToClipboardScript", script);
        }
    }
}