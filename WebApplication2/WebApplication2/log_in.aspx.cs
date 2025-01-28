using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;

            string filePath = Server.MapPath("NewUsers.txt");

            if (File.Exists(filePath))
            {
                try
                {
                    string[] lines = File.ReadAllLines(filePath);

                    bool isAuthenticated = false;

                    foreach (var line in lines)
                    {
                        string[] parts = line.Split(',');

                        if (parts.Length >= 3)
                        {
                            string storedEmail = parts[1].Split(':')[1].Trim();
                            string storedPassword = parts[2].Split(':')[1].Trim();

                            if (email == "admin@gmail.com" && password == "12312")
                            {
                                Response.Redirect("Admin.aspx");
                                return;
                            }

                            if (storedEmail == email && storedPassword == password)
                            {
                                Response.Redirect("User.aspx");

                                return;
                            }
                        }
                    }

                    if (isAuthenticated)
                    {
                        Response.Write("Login successful!");
                    }
                    else
                    {
                        Response.Write("Invalid email or password.");
                    }
                }
                catch (Exception ex)
                {
                    Response.Write("An error occurred: " + ex.Message);
                }
            }
            else
            {
                Response.Write("No registration data found.");
            }
        }
    }
}