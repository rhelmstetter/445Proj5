using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Library;
using System.Diagnostics;
using System.Configuration;


public partial class Account_Login : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        RegisterHyperLink.NavigateUrl = "Register.aspx";
        //OpenAuthLogin.ReturnUrl = Request.QueryString["ReturnUrl"];

        var returnUrl = HttpUtility.UrlEncode(Request.QueryString["ReturnUrl"]);
        if (!String.IsNullOrEmpty(returnUrl))
        {
            RegisterHyperLink.NavigateUrl += "?ReturnUrl=" + returnUrl;
        }
    }


    protected void Unnamed6_Click(object sender, EventArgs e)
    {
        string name = ConfigurationManager.AppSettings["ADMIN"];
        string password = ConfigurationManager.AppSettings["ADMIN"];

        

        UserDao dao = new UserDao();

        User admin = new User(1, "admin", "pass");

        dao.addUser(admin);



        User current = dao.loginUser("admin", "pass");

        if (current != null)
        {
            Debug.WriteLine("Logged IN Correctly!!!");
        }
        else
        {
            
        }

        
    }
}

