using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OpdrachtenASP
{
    public partial class opdracht4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            /* Pak de cijfer van de cijferVeld */
            string cijferTekst = cijferVeld.Text;
            /* Convert de cijfertekst naar een double */
            double cijfer = double.Parse(cijferTekst);

            /* als cijfer lager is dan 10 voeg dan 2 euro per product toe*/
            if (cijfer < 10)
            {

                cijfer *= 2;

            }

            /* Anders als cijger hoger of gelijk is aan 10 en lager dan 50 voeg 1,50 euro toe per product*/
            else if (cijfer >= 10 && cijfer < 50)
            {

                cijfer *= 1.50;
            
            }

            /* Anders als cijger hoger of gelijk is aan 50 en lager dan 100 voeg 1,25 euro toe per product*/
            else if (cijfer >= 50 && cijfer < 100)
            {

                cijfer *= 1.25;
            
            }            
            
            /* Anders voeg je per product 1,10 euro */
            else
            {

                cijfer *= 1.10;
            
            }

            /* Het totale cijfer wordt omgezet naar een string */
            string totaal = cijfer.ToString();

            /* De totaal veld wordt dan gevuld met het string variable totaal */
            totaalVeld.Text = totaal;

        }
    }
}