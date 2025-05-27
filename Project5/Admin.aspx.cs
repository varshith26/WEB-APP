using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using Encrypt2;

namespace Project5
{
    public partial class Admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            string user = "";
            if (Session["User"] != null)// get the session state user
            {
                user = Session["User"].ToString();

                XmlDocument xdoc = new XmlDocument();
                xdoc.Load(Server.MapPath("~/XmlFile1.xml")); //This code will load the Data xml document with the Login details.
                foreach (XmlNode node in xdoc.SelectNodes("/Details/Contact"))// match  the user with his role to give him access
                {
                    String Username = node.SelectSingleNode("UserName").InnerText;
                    String Role = node.SelectSingleNode("Role").InnerText;

                    if (Username == user)

                    {
                        if (Role == "Admin")// access only for Admin
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

        protected void Button1_Click(object sender, EventArgs e)
        {
            {
                XmlDocument xdoc = new XmlDocument();
                xdoc.Load(Server.MapPath("~/XmlFile1.xml"));// Load the XML File after button click event

                String NewUser = TextBox1.Text;
                if (!IsUsernameTaken(xdoc, NewUser))// Check if the username is already taken
                {

                    XmlElement contact = xdoc.CreateElement("Contact");// Create necessary elements for the XML File

                    XmlElement UserName = xdoc.CreateElement("UserName");
                XmlText xmlName = xdoc.CreateTextNode(NewUser);

                XmlElement Role = xdoc.CreateElement("Role");
                XmlText xmlRole = xdoc.CreateTextNode(DropDownList1.SelectedValue);

                var EncryptedPwd = Class1.EncryptString(TextBox3.Text);// Call the Encrypted string dll class for encryption

                XmlElement Password = xdoc.CreateElement("Password");
                XmlText xmlpwd = xdoc.CreateTextNode(EncryptedPwd);// save the Encrypted Password

                UserName.AppendChild(xmlName);
                Role.AppendChild(xmlRole);
                Password.AppendChild(xmlpwd);
                contact.AppendChild(UserName);
                contact.AppendChild(Role);
                contact.AppendChild(Password);

                xdoc.DocumentElement.AppendChild(contact);

                xdoc.Save(Server.MapPath("~/XmlFile1.xml"));//write and Save the XML File

                Response.Redirect("Login.aspx", true);
            }
                else
                {
                    Label6.Text = "Username Already Taken Choose another";// return error if Username is already taken
                }
            }



        }
        private bool IsUsernameTaken(XmlDocument xdoc, string username)// traverse the XML File to check if Username is already taken 
        {
            XmlNodeList usernameNodes = xdoc.SelectNodes("//Contact/UserName");

            foreach (XmlNode node in usernameNodes)
            {
                if (node.InnerText == username)
                {
                    return true;
                }
            }

            return false;
        }


    }

}