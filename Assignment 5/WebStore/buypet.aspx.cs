using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.IO;
using System.Drawing;

public partial class buypet : System.Web.UI.Page
{
    public string animalType, age, price, description, breed, color, type, weight;
    ImageService.ServiceClient prxImage = new ImageService.ServiceClient();
    StringService.ServiceClient prxString = new StringService.ServiceClient();

    protected void Page_Load(object sender, EventArgs e)
    {
        string captchaString = prxString.GetRandomString("6");
        var image = System.Drawing.Image.FromStream(prxImage.GetImage(captchaString));
 
        animalType = "Bird";
        type = "Flying T-rex";
        weight = "10000000 pounds";
        age = "666";
        price = "your firstborn";
        description = "The unholy offspring of death and hell";

        //breed = "mixed";
        //price = " 100";
        //description = " ugly fatass mutt";

        //animalType = "Dog";

        switch(animalType)
        {
            case "Cat":
                imgPetPic.ImageUrl = "~/Images/cat.jpg";
                lblAnimalInfo.Text = "Breed:\t" + breed + "<br /> Color:\t" + color + "<br />Price:\t" + price + "<br />Description:\t" + description;
                break;
            case "Dog":
                imgPetPic.ImageUrl = "~/Images/dog.jpg";
                lblAnimalInfo.Text = "Breed:\t" + breed + "<br /> Age:\t" + age + "<br />Price:\t" + price + "<br />Description:\t" + description;
                break;
            case "Bird":
                imgPetPic.ImageUrl = "~/Images/bird.jpg";
                lblAnimalInfo.Text = "Type:\t" + type + "<br /> Age:\t" + age + "<br />Weight:\t" + weight + "<br />Price:\t" + price + "<br />Description:\t" + description;
                break;
            default:
                break;
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