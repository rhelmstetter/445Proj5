<%@ Application Language="C#" %>
<%@ Import Namespace="WebStore" %>
<%@ Import Namespace="System.Web.Optimization" %>

<script runat="server">

    void Application_Start(object sender, EventArgs e)
    {
        // Code that runs on application startup
        BundleConfig.RegisterBundles(BundleTable.Bundles);
        AuthConfig.RegisterOpenAuth();
    }
    
    void Application_End(object sender, EventArgs e)
    {
        //  Code that runs on application shutdown

    }

    void Application_Error(object sender, EventArgs e)
    {
        // Code that runs when an unhandled error occurs
        Exception exception = Server.GetLastError();
        if (exception != null)
        {
            if (HttpContext.Current.Server != null)
            {
                HttpContext.Current.Server.Transfer("/Error.aspx");
            }
        }

        

    }

</script>
