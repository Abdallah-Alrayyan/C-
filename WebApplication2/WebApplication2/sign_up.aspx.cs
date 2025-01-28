using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }



        protected void btnRegister_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            string repeatPassword = txtRepeatPassword.Text;

            if (password == repeatPassword)
            {
                string filePath = Server.MapPath("NewUsers.txt");

                string dataToSave = $"Name: {name}, Email: {email}, Password: {password}\n";

                try
                {
                    if (!File.Exists(filePath))
                    {
                        File.WriteAllText(filePath, dataToSave);
                    }
                    else
                    {
                        File.AppendAllText(filePath, dataToSave);
                    }


                    Response.Write("Registration successful! Your data has been saved.");
                    Response.Redirect("log_in.aspx");
                }
                catch (Exception ex)
                {
                    Response.Write("An error occurred: " + ex.Message);
                }
            }
            else
            {
                Response.Write("Passwords do not match.");
            }
        }





    }
}