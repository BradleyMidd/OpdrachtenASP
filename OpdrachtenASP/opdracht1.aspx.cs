using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OpdrachtenASP
{
    public partial class opdracht1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void verstuurKnop_Click(object sender, EventArgs e)
        {/* Maak 4 string variables aan waar je de text velden ophaalt*/
            string voorNaam = voornaamVeld.Text;
            string achterNaam = achternaamVeld.Text;
            string woonplaats = woonplaatsVeld.Text;
            string klas = klasVeld.Text;

            /* Maak 1 string variable waar je aan jezelf voorstelt met de4 variables */
            string voorstellen = "Hallo, " + voorNaam + " " + achterNaam + "<br />" + "Je woont in " + woonplaats + "<br />" + "Je zit in klas " + klas;
            /* Wanneer je op de knop drukt dan toont hij de voorstellen variable op */
            mijnBegroeting.Text = voorstellen;
        }
    }
}