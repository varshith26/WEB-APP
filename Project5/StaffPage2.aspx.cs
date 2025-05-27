using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Resources;
using System.Xml;

namespace Project5
{
    public partial class StaffPage2 : System.Web.UI.Page
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
                        if (Role == "Admin" || Role == "Staff 2 User")// access is only for Staff 2 User and admin
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

        protected void Button2_Click1(object sender, EventArgs e)
        {
            ServiceReference3.ServiceClient hash = new ServiceReference3.ServiceClient();

            String data = TextBox1.Text;
            string salt = TextBox2.Text;
            string outputHash=hash.Hash(data, salt);
            Label1.Text = outputHash;
        }
    }
}