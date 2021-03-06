﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace asp.net_project
{
    public partial class WebForm8 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "SELECT * from users where Category like 'business'";
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string PID = "PID" +reader.GetInt32(reader.GetOrdinal("PID"));
                newsGrid.InnerHtml += "<div class='news' id='"+PID+"' onClick='postRedirect' runat='server'><h1 class='title'>" + reader.GetString(reader.GetOrdinal("Title")) + "</h1><img src='" + reader.GetString(reader.GetOrdinal("Thumbnail")) + "'class='thumbnail'/><h3 class='author'>" + reader.GetString(reader.GetOrdinal("Author")) + "</h3></div>";
            }
            con.Close();
        }

        protected void postRedirect(object sender, EventArgs e)
        {
            Response.Redirect("newsDisplay.aspx");
        }
    }
}