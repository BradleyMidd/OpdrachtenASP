using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OpdrachtenASP
{
    public partial class opdracht2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


        }

        protected void plus_Click(object sender, EventArgs e)
        {

            string a = nummer1.Text;
            string b = nummer2.Text;

            double g1 = double.Parse(a);
            double g2 = double.Parse(b);

            double antwoord = g1 + g2;

            string antwoordTekst = antwoord.ToString();

            antwoordVeld.Text = antwoordTekst;

        }

        protected void min_Click(object sender, EventArgs e)
        {


            string a = nummer1.Text;
            string b = nummer2.Text;

            double g1 = double.Parse(a);
            double g2 = double.Parse(b);

            double antwoord = g1 - g2;

            string antwoordTekst = antwoord.ToString();

            antwoordVeld.Text = antwoordTekst;

        }

        protected void keer_Click(object sender, EventArgs e)
        {


            string a = nummer1.Text;
            string b = nummer2.Text;

            double g1 = double.Parse(a);
            double g2 = double.Parse(b);

            double antwoord = g1 * g2;

            string antwoordTekst = antwoord.ToString();

            antwoordVeld.Text = antwoordTekst;

        }

        protected void delen_Click(object sender, EventArgs e)
        {


            string a = nummer1.Text;
            string b = nummer2.Text;

            double g1 = double.Parse(a);
            double g2 = double.Parse(b);

            double antwoord = g1 / g2;

            string antwoordTekst = antwoord.ToString();

            antwoordVeld.Text = antwoordTekst;

        }
    }
}