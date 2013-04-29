using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;

public partial class CurrentUser : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        HttpCookie myCookies = Request.Cookies["myKey"];
        if ((myCookies == null) || (myCookies["Username"] == ""))
        {
            lblUser.Text = "Hello, Guest";
        }
        else
        {
            lblUser.Text = "Hello, " + myCookies["Username"];
        }
        
    }
}