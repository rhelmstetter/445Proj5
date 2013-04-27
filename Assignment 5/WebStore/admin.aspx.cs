using System;
using System.Collections.Generic;
using System.IO;
using System.Collections;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

public partial class admin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string xmlLoc = Path.Combine(Request.PhysicalApplicationPath, 
            @"Listing.xml");
        FileStream fs = null;
        try
        {  
            if(File.Exists(xmlLoc))
            {
                fs = new FileStream(xmlLoc, FileMode.Open,
                    FileAccess.Read);
                XmlDocument xd = new XmlDocument();
                xd.Load(fs);
                fs.Close();
                List<Library.Pet> pets = Library.petDAO.listPets();
                //XmlNode node = xd.LastChild;
                //XmlNodeList children = node.ChildNodes;
                foreach(Library.Pet inv in pets)
                {
                   // petBox.Items.Add(child.InnerText);
                   string desc = inv.id;
                   petBox.Items.Add(
                }
            }
        }
        finally
        {
            fs.Close();
        }
    }
}