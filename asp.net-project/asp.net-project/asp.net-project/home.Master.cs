﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace asp.net_project
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Home_Click(object sender, EventArgs e)
        {
            Response.Redirect("./home.aspx");
        }

        protected void News_Click(object sender, EventArgs e)
        {
            Response.Redirect("./news.aspx");
        }

        protected void Login_Click(object sender, EventArgs e)
        {
            Response.Redirect("./logowanie.aspx");
        }

        protected void AboutUs_Click(object sender, EventArgs e)
        {
            Response.Redirect("./aboutUs.aspx");
        }
    }
}