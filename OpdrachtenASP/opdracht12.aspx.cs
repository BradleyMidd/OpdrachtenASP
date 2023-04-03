using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OpdrachtenASP
{
    public partial class opdracht12 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void plus_Click(object sender, EventArgs e)
        {

            double g1 = 0;
            double g2 = 0;

            try
            {
                g1 = double.Parse(nummer1.Text);
                g2 = double.Parse(nummer2.Text);
                double plus = g1 + g2;
                antwoordVeld.Text = plus.ToString();
            }


            catch (Exception exc)
            {

                antwoordVeld.Text = "Er is iets fouts gegaan... ";
                antwoordVeld.Text += exc.Message;

            }

        }

        protected void min_Click(object sender, EventArgs e)
        {
            double g1 = 0;
            double g2 = 0;

            try
            {
                g1 = double.Parse(nummer1.Text);
                g2 = double.Parse(nummer2.Text);
                double min = g1 - g2;
                antwoordVeld.Text = min.ToString();
            }


            catch (Exception exc)
            {

                antwoordVeld.Text = "Er is iets fouts gegaan... ";
                antwoordVeld.Text += exc.Message;

            }
        }

        protected void keer_Click(object sender, EventArgs e)
        {
            double g1 = 0;
            double g2 = 0;

            try
            {
                g1 = double.Parse(nummer1.Text);
                g2 = double.Parse(nummer2.Text);
                double keer = g1 * g2;
                antwoordVeld.Text = keer.ToString();
            }


            catch (Exception exc)
            {

                antwoordVeld.Text = "Er is iets fouts gegaan... ";
                antwoordVeld.Text += exc.Message;

            }
        }

        protected void delen_Click(object sender, EventArgs e)
        {
            double g1 = 0;
            double g2 = 0;

            try
            {
                g1 = double.Parse(nummer1.Text);
                g2 = double.Parse(nummer2.Text);
                double delen = g1 / g2;
                antwoordVeld.Text = delen.ToString();
            }


            catch (Exception exc)
            {

                antwoordVeld.Text = "Er is iets fouts gegaan... ";
                antwoordVeld.Text += exc.Message;

            }
        }
    }
}