using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OpdrachtenASP
{
    public partial class opdracht10 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void voeg_Click(object sender, EventArgs e)
        {
            /* Maak een array aan waar je alle nummers opslaat */
            double[] n;

            if (ViewState["nummers"] != null)
            {

                n = (double[])ViewState["nummers"];

            }
            else
            {

                n = new double[0];

            }

            /* Pak het nummer van de textbox */
            int c = int.Parse(cijfer.Text);
            /* Tel hoe groot de array nu is */
            int aantal = n.Length;
            /* Vergroot de array met 1 */
            Array.Resize(ref n, aantal + 1);
            /* Voeg de cijfer toe aan de array */
            n[aantal] = c;
            /* Sla de array op in de sessie */
            ViewState.Add("nummers", n);

            /* Maak een loop waar je alle informatie toevoegt */
            foreach (int nummer in n)
            {
                double total = n.Sum();
                double average = total / n.Count();

                aant.Text = "Aantal cijfers: " + n.Count();
                gem.Text = "Gemiddeld: " + average;
                hoog.Text = "Hoogste cijfer: " + n.Max();
                laag.Text = "Laagste cijfer: " + n.Min();
            }

        }
    }
}