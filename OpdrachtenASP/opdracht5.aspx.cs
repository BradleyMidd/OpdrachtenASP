using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OpdrachtenASP
{
    public partial class opdracht5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void reken_Click(object sender, EventArgs e)
        {
            /* Maak een variable aan die als standard prijs heeft 3 eurp */
            double bodem = 3;

            /* Als er bij de checkbox zijn gecheckt dan komen er bedragen erbij */
            if (tom.Checked)
            {

                bodem += 1;

            }
            if (sal.Checked)
            {

                bodem += 2;

            }
            if (pep.Checked)
            {

                bodem += 2;

            }
            if (ham.Checked)
            {

                bodem += 2;

            }
            if (carp.Checked)
            {

                bodem += 2.50;

            }
            if (pap.Checked)
            {

                bodem += 2;

            }
            if (knof.Checked)
            {

                bodem += 1;

            }
            if (cham.Checked)
            {

                bodem += 2;

            }
            if (gor.Checked)
            {

                bodem += 2.50;

            }
            if (moz.Checked)
            {

                bodem += 1.50;

            }

            /* Pak het bedrag en maak het een string van */
            string totaalText =
            bodem.ToString();
            /* Print het bedrag uit */
            totaal.Text = totaalText;

        }
    }
}