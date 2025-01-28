using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAddBook_Click(object sender, EventArgs e)
        {
            
            Response.Redirect("AddBook.aspx");
        }

        
        protected void btnViewBooks_Click(object sender, EventArgs e)
        {
        
            Response.Redirect("showBook.aspx");
        }

        protected void btnedit_Click(object sender, EventArgs e)
        {
            Response.Redirect("EditBook.aspx");

        }
    }
}