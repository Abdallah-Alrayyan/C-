﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }


        protected void Sign_Click(object sender, EventArgs e)
        {
            Response.Redirect("sign_up.aspx");
        }

        protected void Log_Click(object sender, EventArgs e)
        {
            Response.Redirect("log_in.aspx");

        }
    }
}

