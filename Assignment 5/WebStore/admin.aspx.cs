using System;
using System.Collections.Generic;
using System.IO;
using System.Collections;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using Library;

public partial class admin : System.Web.UI.Page
{
    PetDao dao = new PetDao();
    

    protected void Page_Load(object sender, EventArgs e)
    {
        List<Pet> list = dao.listPets();
        
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
                    if (inv.getPetType() == "Dog")
                    {
                        Library.Dog newDog = (Library.Dog)inv;
                        info = newDog.getId() + ": " + newDog.getPetType() + ": "
                            + newDog.getBreed();
                    }
                    else if (inv.getPetType() == "Cat")
                    {
                        Library.Cat newCat = (Library.Cat)inv;
                        info = newCat.getId() + ": " + newCat.getPetType() + ": "
                            + newCat.getBreed();
                    }
                    else if (inv.getPetType() == "Bird")
                    {
                        Library.Bird newBird = (Library.Bird)inv;
                        info = newBird.getId() + ": " + newBird.getPetType() + ": "
                            + newBird.getType();
                    }

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