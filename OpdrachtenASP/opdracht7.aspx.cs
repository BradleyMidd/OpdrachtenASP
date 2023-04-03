using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Globalization;

namespace OpdrachtenASP
{
    public partial class opdracht7 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /* Maak een variable aan dat gelijk is aan de datum van vandaag */
            DateTime t = DateTime.Now;
            /* Print uit de naam van de dag die we nu zitten in het nederlands */
            vandaag.Text = t.ToString("dddd", CultureInfo.CreateSpecificCulture("nl-NL"));

        }

        protected void is_Click(object sender, EventArgs e)
        {
            /* Pak de string van de over text waar je de aantal dagen invoert */
            string g = over.Text;
            /* Zet de string om naar int */
            int d = int.Parse(g);
            /* Maak een variable aan waarbij je dagen kan toevoegen via de int variable */
            DateTime add = DateTime.Today.AddDays(d);
            /* Zet het om naar een string en maak het naam van de dag in het nederlands*/
            string f = add.ToString("dddd", CultureInfo.CreateSpecificCulture("nl-NL"));
            /* Print de toekomstige dag */
            dan.Text = f;

        }
    }
}