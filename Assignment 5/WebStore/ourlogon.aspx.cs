using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Library;
using System.Diagnostics;
using System.Configuration;
using System.Net;

public partial class ourlogon : System.Web.UI.Page
{
    User current;
    bool admin;

    protected void Page_Load(object sender, EventArgs e)
    {
        admin = false;
    }
    protected void btnLogon_Click(object sender, EventArgs e)
    {
        string userName = txtUserName.Text;
        string password = txtPassword.Text;

        if (userName == ConfigurationManager.AppSettings["ADMIN"] && password == ConfigurationManager.AppSettings["PASSWORD"])
        {
            admin = true;
        }

        else
        {
            UserDao dao = new UserDao();
            current = dao.loginUser(userName, password);
        }

            if ((current != null) ||  (admin == true))
            {
                if (admin)
                {
                    Response.Cookies["Username"].Value = "Admin";
                    Response.Cookies["Admin"].Value = "True";
                }
                else
                {
                    string name = current.getUsername();
                    Response.Cookies["Username"].Value = current.getUsername();
                    Response.Cookies["Admin"].Value = "False";
                }
                //HttpCookie myCookies = Request.Cookies["myKeyie"];
                //myCookies["Username"] = "test";// current.getUsername();

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