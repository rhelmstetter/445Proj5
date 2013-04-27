using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CurrentUser : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        String user;
        user = "Guest";
        // if (someone logged in)
        // set user to someone else
        lblUser.Text = "Hello, " + user;
    }
}