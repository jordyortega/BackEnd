using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Oefening_3
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnMaakKaart_Click(object sender, EventArgs e)
        {
            // Het aanmaken van de variabelen (=Declareren)
            string Naam, Geslacht, Hobby, Opleiding;

            // Vullen van de variabele Naam (=Initialiseren)
            Naam = txtNaam.Text;

            // Initialiseren van de variabele Geslacht
            Geslacht = rbGeslacht.SelectedValue;

            // Initialiseren van de variabele Opleiding
            Opleiding = cbOpleiding.SelectedValue;

            // Initialiseren van de variabele Hobby
            Hobby = "Hobby: ";

            // Checken van de value van Checklist Hobby
            if (chkHobby.Items[0].Selected)
            {
                Hobby += "Gamen ";
            }

            // Checken van de value van Checklist Hobby
            if (chkHobby.Items[1].Selected)
            {
                Hobby += "Programmeren";
            }

            // Schrijft de ingevulde tekst op het scherm
            Label1.Text = "";
            Label1.Text += "Naam: "+Naam+"<br />";
            Label1.Text += Hobby + "<br />";
            Label1.Text += "Opleiding: " + Opleiding + "<br />";
            Label1.Text += "Geslacht: " + Geslacht + "<br />";
        }

        protected void rbView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(rbView.SelectedValue == "W")
            {
                Panel1.Visible = true;
            }
            else
            {
                Panel1.Visible = false;
            }
        }
    }
}