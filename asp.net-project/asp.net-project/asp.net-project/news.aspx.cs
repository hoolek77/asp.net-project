﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace asp.net_project
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void News_Weather_Click(object sender, EventArgs e)
        {
            Response.Redirect("./news-weather.aspx");
        }

        protected void News_Business_Click(object sender, EventArgs e)
        {
            Response.Redirect("./news-business.aspx");
        }
    }
}