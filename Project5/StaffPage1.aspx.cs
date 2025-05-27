using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Controls;
using System.Windows;
using System.Windows.Documents;
using System.Xml;
using System.IO;

namespace Project5
{
    public partial class Contact : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string user = "";
            if (Session["User"] != null)
            {
                user = Session["User"].ToString();

                XmlDocument xdoc = new XmlDocument();
                xdoc.Load(Server.MapPath("~/XmlFile1.xml")); //This code will load the Data xml document with the Login details.
                foreach (XmlNode node in xdoc.SelectNodes("/Details/Contact"))
                {
                    String Username = node.SelectSingleNode("UserName").InnerText;
                    String Role = node.SelectSingleNode("Role").InnerText;// match  the user with his role to give him access

                        if (Username == user)

                    {
                        if (Role == "Admin" || Role == "Staff 1 User")// access is only for Staff1 user and Admin
                        {

                        }
                        else
                        {
                            Response.Redirect("ErrorPage.aspx", true);                        
                        }

                    }

                }
            }
            else
            {
                Response.Redirect("Login.aspx", true);
            }

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
            {
                using (MemoryStream memoryStream = new MemoryStream(FileUpload1.FileBytes))
                {
                    ServiceReference2.Service1Client wordCount = new ServiceReference2.Service1Client();
                    string result = wordCount.WordCount(memoryStream);
                    Label1.Text = result;
                }
            }
            else
            {
                Label1.Text = "Please select a file to upload.";
            }
        }
    }
}