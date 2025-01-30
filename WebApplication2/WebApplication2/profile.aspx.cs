using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class profile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            // Enable textboxes for editing
            txtName.ReadOnly = false;
            txtEmail.ReadOnly = false;
            txtPhone.ReadOnly = false;
            txtAddress.ReadOnly = false;

            // Show the "Save" button and hide the "Edit" button
            btnSave.Visible = true;
            btnEdit.Visible = false;
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            // Save the updated profile information to the database or session
            // Example: UpdateUserProfile(txtName.Text, txtEmail.Text, txtPhone.Text, txtAddress.Text);

            // Disable textboxes after saving
            txtName.ReadOnly = true;
            txtEmail.ReadOnly = true;
            txtPhone.ReadOnly = true;
            txtAddress.ReadOnly = true;

            // Hide the "Save" button and show the "Edit" button again
            btnSave.Visible = false;
            btnEdit.Visible = true;
        }

    }
}