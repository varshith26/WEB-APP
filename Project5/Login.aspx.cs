using Encrypt2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows;
using System.Windows.Controls;
using System.Xml;
using System.Xml.Linq;
using System.Reflection.Emit;

namespace Project5
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        protected void Button2_Click(object sender, EventArgs e)
        {
            //Session["User"] = TextBox2.Text;
            string username = TextBox2.Text;
            string password = TextBox4.Text;

            XmlDocument xdoc = new XmlDocument();
            xdoc.Load(Server.MapPath("~/XmlFile1.xml")); //This code will load the Data xml document with the Login details.
            foreach (XmlNode node in xdoc.SelectNodes("/Details/Contact"))
            {
                String StoredUsername = node.SelectSingleNode("UserName").InnerText;
                String StoredPassword = node.SelectSingleNode("Password").InnerText;

                string pwd = Class1.DecryptString(StoredPassword);// Decrypt the Password to check if it's correct 
                

                if (username == StoredUsername && password == pwd)
                {
                    Session["User"] = username;
                    Response.Redirect("Default.aspx", true);
                    return;
                }
                

                
            }

            Label5.Text = "Invalid credentials. Please register.";// If Credientials are wrong display Error Message
            //MessageBox.Show("Invalid Credentials Please Register");
            //Response.Redirect("Login.aspx", true);
            
            }
    }
}