using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OpdrachtenASP
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            //Maak een datum aan van vandaag
            DateTime vandaag = DateTime.Now;

            //Pak de datum van sinterklaas
            DateTime sinterklaas = DateTime.Parse("5/12/2020");

            //Bereken het verschil tussen de datum van vandaag en dedag van sinterklaas
            TimeSpan verschil = sinterklaas.Subtract(vandaag);

            //Bepaal het verschil in dagen
            int aantalDagen = verschil.Days;

            {
                datumLabel.Text = vandaag.ToString();
                afterLabel.Text = verschil.Days.ToString();
            }


        }

    }
}
