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
using System.Diagnostics;

public partial class admin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.Cookies["Username"] == null)
            Response.Redirect("ourlogon.aspx");

        if ((Request.Cookies["Admin"].Value == "False") || (Request.Cookies["Admin"] == null))
            Response.Redirect("ourlogon.aspx");

        if (petBox.Items.Count < 1)
            refreshList();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (petBox.SelectedIndex == -1)
            return;
        string delete = petBox.SelectedItem.Text;
        Debug.WriteLine(delete);
        string[] item = delete.Split(' ');
        Library.PetDao stuff = new Library.PetDao();
        stuff.deletePet(item[0]);
        refreshList();
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        int intTemp;
        double doubTemp;
        if (typeRadio.SelectedIndex == -1)
            return;
        Pet p = new Pet();

        if (Int32.TryParse(ageBox.Text, out intTemp))
            p.setAge(intTemp);
        else
            return;
        if (descBox.Text.Length != 0)
            p.setDescription(descBox.Text);
        else
            return;
        if (idBox.Text.Length != 0)
            p.setId(idBox.Text);
        else
            return;
        if (Double.TryParse(priceBox.Text, out doubTemp))
            p.setPrice(doubTemp);
        else
            return;

        PetDao holder = new PetDao();
        switch (typeRadio.SelectedIndex)
        {
            case 0:
                Dog d = new Dog(p);
                if (breedBox.Text.Length != 0)
                    d.setBreed(breedBox.Text);
                else
                    return;
                if (colorBox.Text.Length != 0)
                    d.setColor(colorBox.Text);
                else
                    return;
                holder.addPet(d);
                break;
            case 2:
                Cat c = new Cat(p);
                if (breedBox.Text.Length != 0)
                    c.setBreed(breedBox.Text);
                else
                    return;
                if (colorBox.Text.Length != 0)
                    c.setColor(colorBox.Text);
                else
                    return;
                holder.addPet(c);
                break;
            case 1:
                Bird b = new Bird(p);
                if (typeBox.Text.Length != 0)
                    b.setType(typeBox.Text);
                else
                    return;
                if (Double.TryParse(weightBox.Text, out doubTemp))
                    b.setWeight(doubTemp);
                else
                    return;
                holder.addPet(b);
                break;
        }
        refreshList();

    }

    protected void refreshList()
    {
        petBox.Items.Clear();
        Library.PetDao stuff;
        stuff = new Library.PetDao();
        List<Library.Pet> pets = stuff.listPets();
        foreach (Library.Pet inv in pets)
        {
            string info = "";
            if (inv.getPetType() == "Dog")
            {
                Library.Dog newDog = (Library.Dog)inv;
                info = newDog.getId() + " - " + newDog.getPetType() + " - "
                    + newDog.getBreed();
            }
            else if (inv.getPetType() == "Cat")
            {
                Library.Cat newCat = (Library.Cat)inv;
                info = newCat.getId() + " - " + newCat.getPetType() + " - "
                    + newCat.getBreed();
            }
            else if (inv.getPetType() == "Bird")
            {
                Library.Bird newBird = (Library.Bird)inv;
                info = newBird.getId() + " - " + newBird.getPetType() + " - "
                    + newBird.getType();
            }
            petBox.Items.Add(info);
        }
    }
    
}