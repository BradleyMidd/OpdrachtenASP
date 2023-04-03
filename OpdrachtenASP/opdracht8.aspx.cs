using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OpdrachtenASP
{
    public partial class opdracht8aspx : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


        }

        /* Maak een variable aan waar je de clicks begint */
        private int clickcount = 0;

        protected void add_Click(object sender, EventArgs e)
        {
            /* Als de sessie iets bevat dan komt er steeds een nummer erbij */
            if (Session["clickcount"] != null)
                clickcount = (int)Session["clickcount"];

            clickcount++;
            Session["clickcount"] = clickcount;

            /* Print de hoeveelheid clicks die je gedaan hebt */
            number.Text = clickcount.ToString();

        }

        protected void reset_Click(object sender, EventArgs e)
        {
            /* Maak de sessie van je hoeveelheid clicks naar 0 en print het uit */
            Session["clickcount"] = 0;
            number.Text = Session["clickcount"].ToString();

        }
    }
}