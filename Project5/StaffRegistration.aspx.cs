using System;
using System.Collections.Generic;
using System.EnterpriseServices.CompensatingResourceManager;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using Encrypt2;

namespace Project5
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            {
                XmlDocument xdoc = new XmlDocument();
                xdoc.Load(Server.MapPath("~/XmlFile1.xml"));// Load the XML File after button click event

                String NewUser = TextBox1.Text;
                if (!IsUsernameTaken(xdoc, NewUser))// Check if the username is already taken
                {

                    XmlElement contact = xdoc.CreateElement("Contact");
                    XmlElement UserName = xdoc.CreateElement("UserName");
                    XmlText xmlName = xdoc.CreateTextNode(NewUser);// Create necessary elements for the XML File

                    XmlElement Role = xdoc.CreateElement("Role");
                    XmlText xmlRole = xdoc.CreateTextNode("Member User");

                    var EncryptedPwd = Class1.EncryptString(TextBox3.Text);// Call the Encrypted string dll class for encryption

                    XmlElement Password = xdoc.CreateElement("Password");
                    XmlText xmlPwd = xdoc.CreateTextNode(EncryptedPwd);// save the Encrypted Password

                    UserName.AppendChild(xmlName);
                    Role.AppendChild(xmlRole);
                    Password.AppendChild(xmlPwd);
                    contact.AppendChild(UserName);
                    contact.AppendChild(Role);
                    contact.AppendChild(Password);

                    xdoc.DocumentElement.AppendChild(contact);

                    xdoc.Save(Server.MapPath("~/XmlFile1.xml"));//Write and Save the XML File

                    Response.Redirect("Login.aspx", true);
                }
                else
                {
                    Label5.Text = "Username Already Taken Choose another";//return error if Username is already taken
                }

            }

           
        }
        private bool IsUsernameTaken(XmlDocument xdoc, string username)
        {
            XmlNodeList usernameNodes = xdoc.SelectNodes("//Contact/UserName");// traverse the XML File to check if Username is already taken 

            foreach (XmlNode node in usernameNodes)
            {
                if (node.InnerText == username)
                {
                    return true;
                }
            }

            return false;
        }



        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}