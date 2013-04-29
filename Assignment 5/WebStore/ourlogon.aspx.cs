using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Library;
using System.Diagnostics;
using System.Configuration;
using System;

public partial class ourlogon : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnLogon_Click(object sender, EventArgs e)
    {
        string userName = txtUserName.Text;
        string password = txtPassword.Text;

        UserDao dao = new UserDao();
        User current = dao.loginUser(userName, password);

        if (current != null)
        {
            Debug.WriteLine("Logged IN Correctly!!!");
            Response.Redirect("default.aspx");
        }

        else
        {
            lblErro.Visible = true;
            lblErro.Text = "Password and User Name combination are not valid.";
        }

    }
}