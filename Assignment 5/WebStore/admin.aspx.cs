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
                    int type = 0;
                    string info = "";
                    // petBox.Items.Add(child.InnerText);
                    if(inv.getType() == "Dog")
                        info = inv.getId() + ": " + inv.getPetType + ": "
                            + (Library.Dog)inv.getBreed();
                    else if(inv.GetType() == "Cat")
                        info = inv.getId() + ": " + inv.getPetType + ": "
                            +(Library.Cat)inv.getBreed();
                    else if(inv.GetType() == "Bird")
                        info = inv.getId() + ": " + inv.getPetType + ": "
                            +(Library.Bird)inv.getType();

                    petBox.Items.Add(info);
                }
            }
        }
        finally
        {
            fs.Close();
        }
    }
}