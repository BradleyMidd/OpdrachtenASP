using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OpdrachtenASP
{
    public partial class opdracht11 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /* Als de viewstate niet bestaat maak er een nieuwe viewstate aan waarbij het random getal opslaat */
            if (ViewState["teRadenGetal"] == null)
            {

                Random random = new Random();
                int teRadenGetal = random.Next(0, 100);
                ViewState["teRadenGetal"] = teRadenGetal;

            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            int ingevoerdGetal = int.Parse(TextBox1.Text);
            int teRadenGetal = (int)ViewState["teRadenGetal"];

            // De logica van het spel uitwerken
            //Ingevoerde getal met tegeradengetal vergelijken
            if (ingevoerdGetal > teRadenGetal)
            {

                Label1.Text = "Het getal is kleiner";

            }
            else if (ingevoerdGetal < teRadenGetal)
            {

                Label1.Text = "Het getal is groter";

            }
            else 
            {

                Label1.Text = "Goed geraden het getal is: " + teRadenGetal;

            }

        }
    }
}