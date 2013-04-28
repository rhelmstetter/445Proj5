using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text.RegularExpressions;
using Library;

public partial class confirmation : System.Web.UI.Page
{
    PetDao pet_dao = new PetDao();
    Pet petToBuy;
    Cat cat;
    Dog dog;
    Bird bird;

    protected void Page_Load(object sender, EventArgs e)
    {
        string s = (string)Session["pet_to_buy"];
            
        if (String.IsNullOrEmpty(s))
        {
            int x;
            x = 5;
        }

        else
        {
            petToBuy = pet_dao.StringToObject(s);
        }
    }


    protected void btnGetDirections_Click(object sender, EventArgs e)
    {
        DirectionsService.ServiceClient prxDirections = new DirectionsService.ServiceClient();

        string[] prxyOutput = new string[3];
        string[][] directions = new string[3][];
        string sUserAddress, sShelterAddress;

        sUserAddress = txtAddress.Text + " " + txtInputCity.Text + " " + txtInputState.Text;
        sShelterAddress = "699 S. Mill Ave. Tempe AZ";

        prxyOutput = prxDirections.tripCalculator(sShelterAddress, sUserAddress);

        int length = Regex.Matches(prxyOutput[0], "~").Count + 1;

        for (int i = 0; i < 3; i++)
        {
            directions[i] = new string[length];
            directions[i] = prxyOutput[i].Split('~');
        }

        // create the data table
        DataTable dt = new DataTable();
        dt.Columns.Add("Directions");
        dt.Columns.Add("Distance");
        dt.Columns.Add("Time");

        // add all the directiosnn to the table
        for (int i = 0; i < length; i++)
        {
            dt.Rows.Add();
            dt.Rows[dt.Rows.Count - 1]["Directions"] = HttpUtility.HtmlDecode(directions[0][i].ToString());
            dt.Rows[dt.Rows.Count - 1]["Distance"] = HttpUtility.HtmlDecode(directions[1][i].ToString());
            dt.Rows[dt.Rows.Count - 1]["Time"] = HttpUtility.HtmlDecode(directions[2][i].ToString());

        }

        // data bind
        gvDrivingDirections.DataSource = dt;
        gvDrivingDirections.DataBind();

        string totalDistance = directions[1][directions[1].Length - 1];
        string totalTime = directions[2][directions[2].Length - 1];

        // display
        lblDistance.Text = "Total distance is " + totalDistance + ".";
        lblTime.Text = "Total time is " + totalTime + ".";
        lblTime.Visible = true;
        lblDistance.Visible = true;
    }

    protected void gvDrivingDirections_DataRowBound(object sender, GridViewRowEventArgs e)
    {
        //Using below loop i have formatted that html content and show as like in web page
        foreach (TableCell cell in e.Row.Cells)
        {
            cell.Text = Server.HtmlDecode(cell.Text);
        }
    }
}