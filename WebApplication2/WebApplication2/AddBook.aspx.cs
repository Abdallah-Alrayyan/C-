using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class WebForm8 : System.Web.UI.Page
    {
        protected void btnAddBook_Click(object sender, EventArgs e)
        {
            // Get values from TextBoxes
            string bookId = txtId.Text;
            string bookName = txtName.Text;
            string bookKind = txtKind.Text;
            string bookLevel =txtLevel.Text;

            // Path to the books.txt file in the App_Data folder
            string filePath = Server.MapPath("NewBooks.txt");

            // Check if the file exists
            if (!File.Exists(filePath))
            {
                // If the file doesn't exist, create it
                File.Create(filePath).Close();
            }

            // Append the book data to the file
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine($"{bookId},{bookName},{bookKind},{bookLevel}");
            }

            // Optionally, you can clear the textboxes after saving
            txtId.Text = "";
            txtName.Text = "";
            txtKind.Text = "";
            txtLevel.Text = "";

            // Display a message or redirect (optional)
            Response.Write("<script>alert('Book added successfully!');</script>");
        }
    }
}