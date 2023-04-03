using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OpdrachtenASP
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void verstuurKnop_Click(object sender, EventArgs e)
        {

            string voorNaam = voornaamVeld.Text;
            string achterNaam = achternaamVeld.Text;

            string valentijnsString = "Hallo lieve " + voorNaam + " " + achterNaam + " wat hou ik toch van jou";
            mijnBegroeting.Text = valentijnsString;

        }
    }
}