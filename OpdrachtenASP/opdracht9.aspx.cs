using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OpdrachtenASP
{
    public partial class opdracht9 : System.Web.UI.Page
    {
        public void Page_Load(object sender, EventArgs e)
        {
            /* Als de pagina niet voor het is returned*/
            if (!IsPostBack)
            {
                /* Als er een saldo in zit dan print je het uit */
                if (this.Session["saldo"] != null)
                {
                    saldo.Text = Session["saldo"].ToString();

                }

                /* Anders maak je een nieuwe saldo aan en print je het uit */
                else
                {

                    int sal = 1000;
                    Session["saldo"] = sal;
                    saldo.Text = Session["saldo"].ToString();
                }
            
            }

        }


        

        protected void klik_Click(object sender, EventArgs e)
        {
           /* U huidige pincode */ 
            int pincode = 1234;

            /* Maak de variable aan waarmee je de text opslaat als een int */
            int num;
            int bed;

            int.TryParse(pin.Text, out num);
            int.TryParse(bedrag.Text, out bed);

            // Sla de pincode op in de sessie
            Session["pincode"] = num;

            // Als de pincode bestaat
            if (Session["pincode"] != null)
                {

                    //Als de pincode die je hebt opgeslagen gelijk is aan de juiste pincode
                    if (Convert.ToInt32(Session["pincode"]) == pincode)
                    {
                        //Als saldo bestaat
                        if (Session["saldo"] != null)
                        {

                            if (bed > Convert.ToInt32(Session["saldo"]))
                            {

                                Response.Redirect("lowsaldo.aspx");

                            }

                            else
                            {

                                int totaal = (int)(Session["saldo"]) - bed;

                                Session["saldo"] = totaal;

                                Server.Transfer("totaalsaldo.aspx");
                            }

                        }
                        //Anders geeft het aan dat er geen saldo is 
                        else
                        {

                            Response.Redirect("nosaldo.aspx");

                        }

                    }
                    //Anders wordt je naar een pagine gebracht warain staat dat je pincode fout is
                    else
                    {

                        Response.Redirect("wrongpin.aspx");

                    }

                }
                //Stuur hem naar de pagina waar je aangeeft dat er geen pincode is ingevoerd
                else
                {

                    Response.Redirect("nopin.aspx");

                }
            
        }

    }
}