using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OpdrachtenASP
{
    public partial class opdracht6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void toon_Click(object sender, EventArgs e)
        {
            /* Maak een variable aan waarmee je het getal opslaat en het convert naar een double */
            string g = getal.Text;
            double nummer = double.Parse(g);

            /* Maak een loop aan dat het tafel van 1 tot 10 gaat */
                for (int i = 1; i < 11; i++)
                {

                    double antwoord = nummer * i;

                    Label1.Text += nummer + " * " + i + " = " + antwoord + "<br/>";
                }
       
        }

        /* Maak een knop aan waarmee je de tafels kan resetten */
        protected void reset_Click(object sender, EventArgs e)
        {

            Label1.Text = String.Empty;

        }

    }
}