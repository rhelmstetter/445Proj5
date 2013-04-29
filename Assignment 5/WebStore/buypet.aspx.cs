using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.IO;
using System.Drawing;
using Library;

public partial class buypet : System.Web.UI.Page
{
    PetDao pet_dao = new PetDao();
    Pet petToBuy;
    public string animalType, name, age, price, description, breed, color, type, weight;
    ImageService.ServiceClient prxImage = new ImageService.ServiceClient();
    StringService.ServiceClient prxString = new StringService.ServiceClient();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.Cookies["Username"] == null)
            Response.Redirect("ourlogon.aspx");

        if ((Request.Cookies["Admin"] == null))
            Response.Redirect("ourlogon.aspx");

        else
        {

            string s = (string)Session["pet_to_buy"];

            if (String.IsNullOrEmpty(s))
            {
                Response.Redirect("sorry.aspx");
            }

            else
            {
                lblAnimalInfo.Visible = true;
                imgPetPic.Visible = true;

                petToBuy = pet_dao.StringToObject(s);

                string captchaString = prxString.GetRandomString("6");
                var image = System.Drawing.Image.FromStream(prxImage.GetImage(captchaString));

                animalType = petToBuy.getPetType();
                name = petToBuy.getId();
                age = petToBuy.getAge().ToString();
                price = petToBuy.getPrice().ToString();
                description = petToBuy.getDescription();

                switch (animalType)
                {
                    case "Cat":
                        Cat c = (Cat)petToBuy;
                        color = c.getColor();
                        breed = c.getBreed();
                        imgPetPic.ImageUrl = "~/Images/cat.jpg";
                        lblAnimalInfo.Text = "Name:\t" + name + "<br />Breed:\t" + breed + "<br /> Color:\t" + color + "<br />Price:\t" + price + "<br />Description:\t" + description;
                        break;

                    case "Dog":
                        Dog d = (Dog)petToBuy;
                        color = d.getColor();
                        breed = d.getBreed();
                        imgPetPic.ImageUrl = "~/Images/dog.jpg";
                        lblAnimalInfo.Text = "Name:\t" + name + "<br />Breed:\t" + breed + "<br />Age:\t" + age + "<br > Color:\t" + color + "<br />Price:\t" + price + "<br />Description:\t" + description;
                        break;

                    case "Bird":
                        Bird b = (Bird)petToBuy;
                        type = b.getType();
                        weight = b.getWeight().ToString();
                        imgPetPic.ImageUrl = "~/Images/bird.jpg";
                        lblAnimalInfo.Text = "Type:\t" + type + "<br /> Age:\t" + age + "<br />Weight:\t" + weight + "<br />Price:\t" + price + "<br />Description:\t" + description;
                        break;
                    default:
                        break;
                }
            }

        }
    }
    protected void btnBuy_Click(object sender, EventArgs e)
    {
        Response.Redirect("confirmation.aspx");
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("default.aspx");
    }
}