using System;

namespace Web
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ltrTest.Text = new DAL.HelloWorld().Test();
        }
    }
}