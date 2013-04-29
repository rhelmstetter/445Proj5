using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Library;

public partial class PetCountControl : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int count;
        PetDao dao = new PetDao();
        count = dao.getPetCount();

        if (count > -1)
            petCountlbl.Text = count.ToString();
    }
}