using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Controls;
using Encrypt2;

namespace Project5
{
    public partial class About : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            var EncryptedPwd = Class1.EncryptString(TextBox1.Text);// this gives encrypted value
            Label1.Text = EncryptedPwd;

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            var DecryptedString = Class1.DecryptString(TextBox2.Text);// this gives encrypted value
            Label2.Text = DecryptedString;

        }
    }
}