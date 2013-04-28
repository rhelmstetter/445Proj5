using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using Library;
using System.Data;
using System.Net;

public partial class _Default : Page
{
    Array pets = null;

    protected void Page_Load(object sender, EventArgs e)
    {
        HttpCookie myCookies = Request.Cookies["myKey"];

        if (myCookies != null)
        {
            gvDog.SelectedIndex = Convert.ToInt32(myCookies["gvDogIndex"]);
            gvCat.SelectedIndex = Convert.ToInt32(myCookies["gvCatIndex"]);
            gvBird.SelectedIndex = Convert.ToInt32(myCookies["gvBirdIndex"]);

            btnPurchase.Enabled = true;

            if (gvDog.SelectedIndex >= 0)
            {

            }

            if (gvCat.SelectedIndex >= 0)
            {

            }

            if (gvBird.SelectedIndex >= 0)
            {

            }
        }

        PetDao pet_dao = new PetDao();
        List<Pet> petList = new List<Pet>();
        List<Dog> dogList = new List<Dog>();
        List<Cat> catList = new List<Cat>();
        List<Bird> birdList = new List<Bird>();

        petList = pet_dao.listPets();

        for (int i = 0; i < petList.Count; i++)
        {
            switch (petList[i].getPetType())
            {
                case "Dog":
                    Dog d = new Dog();
                    d = (Dog)petList[i];
                    dogList.Add(d);
                    break;

                case "Cat":
                    Cat c = new Cat();
                    c = (Cat)petList[i];
                    catList.Add(c);
                    break;

                case "Bird":
                    Bird b = new Bird();
                    b = (Bird)petList[i];
                    birdList.Add(b);
                    break;
                default:
                    break;
            }

        }

        DataTable dtDogTable = new DataTable();
        dtDogTable.Columns.Add("ID");
        dtDogTable.Columns.Add("Breed");
        dtDogTable.Columns.Add("Color");
        dtDogTable.Columns.Add("Age");
        dtDogTable.Columns.Add("Price");
        dtDogTable.Columns.Add("Description");

        if (dogList.Count == 0)
        {
            dtDogTable.Rows.Add();
            dtDogTable.Rows[0]["ID"] = "NONE AVAILABE";
            gvDog.AutoGenerateSelectButton = false;
        }

        else
        {
            for (int i = 0; i < dogList.Count; i++)
            {
                dtDogTable.Rows.Add();
                dtDogTable.Rows[dtDogTable.Rows.Count - 1]["ID"] = dogList[i].getId();
                dtDogTable.Rows[dtDogTable.Rows.Count - 1]["Breed"] = dogList[i].getBreed();
                dtDogTable.Rows[dtDogTable.Rows.Count - 1]["Color"] = dogList[i].getColor();
                dtDogTable.Rows[dtDogTable.Rows.Count - 1]["Age"] = dogList[i].getAge();
                dtDogTable.Rows[dtDogTable.Rows.Count - 1]["Price"] = dogList[i].getPrice();
                dtDogTable.Rows[dtDogTable.Rows.Count - 1]["Description"] = dogList[i].getDescription();
            }
        }

        DataTable dtCatTable = new DataTable();
        dtCatTable.Columns.Add("ID");
        dtCatTable.Columns.Add("Breed");
        dtCatTable.Columns.Add("Color");
        dtCatTable.Columns.Add("Age");
        dtCatTable.Columns.Add("Price");
        dtCatTable.Columns.Add("Description");

        if (catList.Count == 0)
        {
            dtCatTable.Rows.Add();
            dtCatTable.Rows[0]["ID"] = "NONE AVAILABE";
            gvCat.AutoGenerateSelectButton = false;
        }

        else
        {
            for (int i = 0; i < catList.Count; i++)
            {
                dtDogTable.Rows.Add();
                dtCatTable.Rows[dtCatTable.Rows.Count - 1]["ID"] = catList[i].getId();
                dtCatTable.Rows[dtCatTable.Rows.Count - 1]["Breed"] = catList[i].getBreed();
                dtCatTable.Rows[dtCatTable.Rows.Count - 1]["Color"] = catList[i].getColor();
                dtCatTable.Rows[dtCatTable.Rows.Count - 1]["Age"] = catList[i].getAge();
                dtCatTable.Rows[dtCatTable.Rows.Count - 1]["Price"] = catList[i].getPrice();
                dtCatTable.Rows[dtCatTable.Rows.Count - 1]["Description"] = catList[i].getDescription();
            }
        }

        DataTable dtBirdTable = new DataTable();
        dtBirdTable.Columns.Add("ID");
        dtBirdTable.Columns.Add("Type");
        dtBirdTable.Columns.Add("Weight");
        dtBirdTable.Columns.Add("Age");
        dtBirdTable.Columns.Add("Price");
        dtBirdTable.Columns.Add("Description");

        if (birdList.Count == 0)
        {
            dtBirdTable.Rows.Add();
            dtBirdTable.Rows[0]["ID"] = "NONE AVAILABE";
            gvBird.AutoGenerateSelectButton = false;
        }

        else
        {
            for (int i = 0; i < birdList.Count; i++)
            {
                dtBirdTable.Rows.Add();
                dtBirdTable.Rows[dtBirdTable.Rows.Count - 1]["ID"] = birdList[i].getId();
                dtBirdTable.Rows[dtBirdTable.Rows.Count - 1]["Type"] = birdList[i].getType();
                dtBirdTable.Rows[dtBirdTable.Rows.Count - 1]["Weight"] = birdList[i].getWeight();
                dtBirdTable.Rows[dtBirdTable.Rows.Count - 1]["Age"] = birdList[i].getAge();
                dtBirdTable.Rows[dtBirdTable.Rows.Count - 1]["Price"] = birdList[i].getPrice();
                dtBirdTable.Rows[dtBirdTable.Rows.Count - 1]["Description"] = birdList[i].getDescription();
            }
        } 

        
        gvDog.DataSource = dtDogTable;
        gvCat.DataSource = dtCatTable;
        gvBird.DataSource = dtBirdTable;
        gvDog.DataBind();
        gvCat.DataBind();
        gvBird.DataBind();
    }

    public void dogIndexChanged(object sender, EventArgs e)
    {
        gvCat.SelectedIndex = -1;
        gvBird.SelectedIndex = -1;
        btnPurchase.Enabled = true;
    }

    public void catIndexChanged(object sender, EventArgs e)
    {
        gvDog.SelectedIndex = -1;
        gvBird.SelectedIndex = -1;
        btnPurchase.Enabled = true;
    }

    public void birdIndexChanged(object sender, EventArgs e)
    {
        gvDog.SelectedIndex = -1;
        gvCat.SelectedIndex = -1;
        btnPurchase.Enabled = true;
    }

    protected void btnPurchase_Click(object sender, EventArgs e)
    {

    }
}