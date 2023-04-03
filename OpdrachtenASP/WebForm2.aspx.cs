using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OpdrachtenASP
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            double getal = 0;
            double breuk = 0;

            try
            {

                getal = double.Parse(TextBox1.Text);
                breuk = 1 / getal;
                Label1.Text = "De breuk van " + getal + " is " + breuk;

            }
            catch (Exception exc)
            {

                Label1.Text = "Er is iets fouts gegaan...";
                Label1.Text += exc.Message;
            
            }


        }
    }
}