﻿using System;
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
    protected void Page_Load(object sender, EventArgs e)
    {
        refreshList();               
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        //string current = petBox.SelectedValue;
        //string[] info = current.Split(' ');
        //Library.PetDao.deletePet(info[0]);
        //refreshList();
    }

    protected void refreshList()
    {

        Library.PetDao stuff;
        stuff = new Library.PetDao();
        List<Library.Pet> pets = stuff.listPets();
        petBox.Items.Add(pets.Count.ToString());
        foreach (Library.Pet inv in pets)
        {
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