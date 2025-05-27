using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace Project5
{
    public partial class MemberPage : System.Web.UI.Page
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
                            if (Role == "Admin" || Role == "Member User")// access is only for member and Admin
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

        protected void Button1_Click(object sender, EventArgs e)// this calls already Developed Service and returns it's Functions
        {
            ServiceReference1.Service1Client NearestStore = new ServiceReference1.Service1Client();
            string zipCode = TextBox2.Text;
            string StoreName = TextBox3.Text;

            string NearStore = NearestStore.NearestStore(zipCode, StoreName);

            Label3.Text = NearStore;
        }
        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
                protected void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}