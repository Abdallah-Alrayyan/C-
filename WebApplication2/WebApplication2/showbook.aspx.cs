using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

           
            string filePath = Server.MapPath("NewBooks.txt");

         
            if (File.Exists(filePath))
            {
               
                string[] lines = File.ReadAllLines(filePath);

              
                if (lines.Length > 0)
                {
                    foreach (var line in lines)
                    {
                       
                        string[] bookData = line.Split(',');

                       
                        string rowHtml = $"<tr><td>{bookData[0]}</td><td>{bookData[1]}</td><td>{bookData[2]}</td><td>{bookData[3]}</td></tr>";
                        booksTableBody.InnerHtml += rowHtml;
                    }
                }
                else
                {
                
                    booksTableBody.InnerHtml = "<tr><td colspan='4'>No books available.</td></tr>";
                }
            }
            else
            {
              
                booksTableBody.InnerHtml = "<tr><td colspan='4'>No books available.</td></tr>";
            }
        }

        protected void btnGoHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("home.aspx");
        }
    }
}