using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Opdracht_6
{
    public partial class _default : System.Web.UI.Page
    {
        //gaat voorkomen dat je 2 keer achter elkaar op = kan drukken
        private static Boolean isClicked;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        // kort aanroepen dat alles moet worden gewist
        protected void clear()
        {
            lGetal1.Text = string.Empty;
            lGetal2.Text = string.Empty;
            lBereken.Text = string.Empty;
            lUitkomst.Text = string.Empty;
            lblScherm.Text = string.Empty;
        }

        protected void button1_Click(object sender, EventArgs e)
        {
            if (lUitkomst.Text.Length > 0)
            {
                clear();
            }
            if (lblScherm.Text.Length == 1 && lblScherm.Text.Contains("0"))
            {
                lblScherm.Text = "";
            }
            if (lblScherm.Text.Length < 7)
            {
                lblScherm.Text += "1";
            }
            isClicked = false;
        }

        protected void button2_Click(object sender, EventArgs e)
        {
            if (lUitkomst.Text.Length > 0)
            {
                clear();
            }
            if (lblScherm.Text.Length == 1 && lblScherm.Text.Contains("0"))
            {
                lblScherm.Text = "";
            }
            if (lblScherm.Text.Length < 7)
            {
                lblScherm.Text += "2";
            }
            isClicked = false;
        }

        protected void button3_Click(object sender, EventArgs e)
        {
            if (lUitkomst.Text.Length > 0)
            {
                clear();
            }
            if (lblScherm.Text.Length == 1 && lblScherm.Text.Contains("0"))
            {
                lblScherm.Text = "";
            }
            if (lblScherm.Text.Length < 7)
            {
                lblScherm.Text += "3";
            }
            isClicked = false;
        }

        protected void button4_Click(object sender, EventArgs e)
        {
            if (lUitkomst.Text.Length > 0)
            {
                clear();
            }
            if (lblScherm.Text.Length == 1 && lblScherm.Text.Contains("0"))
            {
                lblScherm.Text = "";
            }
            if (lblScherm.Text.Length < 7)
            {
                lblScherm.Text += "4";
            }
            isClicked = false;
        }

        protected void button5_Click(object sender, EventArgs e)
        {
            if (lUitkomst.Text.Length > 0)
            {
                clear();
            }
            if (lblScherm.Text.Length == 1 && lblScherm.Text.Contains("0"))
            {
                lblScherm.Text = "";
            }
            if (lblScherm.Text.Length < 7)
            {
                lblScherm.Text += "5";
            }
            isClicked = false;
        }

        protected void button6_Click(object sender, EventArgs e)
        {
            if (lUitkomst.Text.Length > 0)
            {
                clear();
            }
            if (lblScherm.Text.Length == 1 && lblScherm.Text.Contains("0"))
            {
                lblScherm.Text = "";
            }
            if (lblScherm.Text.Length < 7)
            {
                lblScherm.Text += "6";
            }
            isClicked = false;
        }

        protected void button7_Click(object sender, EventArgs e)
        {
            if (lUitkomst.Text.Length > 0)
            {
                clear();
            }
            if (lblScherm.Text.Length == 1 && lblScherm.Text.Contains("0"))
            {
                lblScherm.Text = "";
            }
            if (lblScherm.Text.Length < 7)
            {
                lblScherm.Text += "7";
            }
            isClicked = false;
        }

        protected void button8_Click(object sender, EventArgs e)
        {
            if (lUitkomst.Text.Length > 0)
            {
                clear();
            }
            if (lblScherm.Text.Length == 1 && lblScherm.Text.Contains("0"))
            {
                lblScherm.Text = "";
            }
            if (lblScherm.Text.Length < 7)
            {
                lblScherm.Text += "8";
            }
            isClicked = false;
        }

        protected void button9_Click(object sender, EventArgs e)
        {
            if (lUitkomst.Text.Length > 0)
            {
                clear();
            }
            if (lblScherm.Text.Length == 1 && lblScherm.Text.Contains("0"))
            {
                lblScherm.Text = "";
            }
            if (lblScherm.Text.Length < 7)
            {
                lblScherm.Text += "9";
            }
            isClicked = false;
        }

        protected void button0_Click(object sender, EventArgs e)
        {
            if (lUitkomst.Text.Length > 0)
            {
                clear();
            }
            if (lblScherm.Text.Length == 1 && lblScherm.Text.Contains("0"))
            {
                lblScherm.Text = "";
            }
            if (lblScherm.Text.Length < 7)
            {
                lblScherm.Text += "0";
            }
            isClicked = false;
        }
        protected void buttonPunt_Click(object sender, EventArgs e)
        {
            if (lUitkomst.Text.Length > 0)
            {
                clear();
            }
            if (!lblScherm.Text.Contains(","))
            {
                clear();
                lblScherm.Text += "0,";
            }
            isClicked = false;
        }

        protected void buttonProcent_Click(object sender, EventArgs e)
        {
            lGetal1.Text = lblScherm.Text;
            lGetal2.Text = string.Empty;
            lUitkomst.Text = string.Empty;
            lblScherm.Text = "0";
            lBereken.Text = "%";
            isClicked = false;
        }

        protected void buttonMin_Click(object sender, EventArgs e)
        {
            lGetal1.Text = lblScherm.Text;
            lGetal2.Text = string.Empty;
            lUitkomst.Text = string.Empty;
            lblScherm.Text = "0";
            lBereken.Text = "-";
            isClicked = false;
        }

        protected void buttonPlus_Click(object sender, EventArgs e)
        {
            lGetal1.Text = lblScherm.Text;
            lGetal2.Text = string.Empty;
            lUitkomst.Text = string.Empty;
            lblScherm.Text = "0";
            lBereken.Text = "+";
            isClicked = false;
        }

        protected void buttonMaal_Click(object sender, EventArgs e)
        {
            lGetal1.Text = lblScherm.Text;
            lGetal2.Text = string.Empty;
            lUitkomst.Text = string.Empty;
            lblScherm.Text = "0";
            lBereken.Text = "×";
            isClicked = false;
        }

        protected void buttonDelen_Click(object sender, EventArgs e)
        {
            lGetal1.Text = lblScherm.Text;
            lGetal2.Text = string.Empty;
            lUitkomst.Text = string.Empty;
            lblScherm.Text = "0";
            lBereken.Text = "÷";
            isClicked = false;
        }

        protected void buttonCos_Click(object sender, EventArgs e)
        {
            lGetal1.Text = lblScherm.Text;
            lBereken.Text = "Cos";
            isClicked = false;
        }

        protected void buttonTan_Click(object sender, EventArgs e)
        {
            lGetal1.Text = lblScherm.Text;
            lBereken.Text = "Tan";
            isClicked = false;
        }

        protected void buttonO1_Click(object sender, EventArgs e)
        {
            lGetal1.Text = lblScherm.Text;
            lBereken.Text = "O1";
            isClicked = false;
        }

        protected void buttonO2_Click(object sender, EventArgs e)
        {
            lGetal1.Text = lblScherm.Text;
            lBereken.Text = "O2";
            isClicked = false;
        }

        protected void buttonM2_Click(object sender, EventArgs e)
        {

        }

        protected void buttonBack_Click(object sender, EventArgs e)
        {
            lblScherm.Text = lblScherm.Text.Substring(0, lblScherm.Text.Length - 1);
            if (lblScherm.Text.Length == 0)
            {
                lblScherm.Text = "0";
            }
        }

        protected void buttonClear_Click(object sender, EventArgs e)
        {
            clear();
            lblScherm.Text = "0";
            isClicked = false;
        }

        protected void buttonIs_Click(object sender, EventArgs e)
        {
            // als er niks is ingevuld of er is al op de = teken gedrukt, return
            if (isClicked || (lblScherm.Text.Length == 1 && lblScherm.Text.Contains("0")))
                return;

            // geef aan dat er al een x op = is gedrukt
            isClicked = true;

            //bekijken of je het 2e getal wel uberhaupt invult, anders gewoon 0 maken zodat bijv 3 = 3 krijgt
            if (lGetal1.Text.Length == 0)
                lGetal1.Text = "0";

            double G1 = Convert.ToDouble(lblScherm.Text);
            double G2 = Convert.ToDouble(lGetal1.Text);
            double uitkomst = 0;

            // wanneer je gelijk op = drukt na intikken van getal
            if (G2 == 0)
            {
                lGetal1.Text = G1.ToString();
                lGetal2.Text = " =";
                lUitkomst.Text = G1.ToString();
                return;
            }
            if (lBereken.Text == "+")
            {
                uitkomst = G1 + G2;
            }
            if (lBereken.Text == "-")
            {
                uitkomst = G2 - G1;
            }
            if (lBereken.Text == "×")
            {
                uitkomst = G1 * G2;
            }
            if (lBereken.Text == "÷")
            {
                uitkomst = G2 / G1;
            }
            if (lBereken.Text == "%")
            {
                uitkomst = G2 % G1;
            }
            if (lBereken.Text == "O2")
            {
                uitkomst = Math.Round(((2 * G1) * Math.PI), 2);
            }
            if (lBereken.Text == "O1")
            {
                uitkomst = Math.Round(((G1 * G1) * Math.PI), 2);
            }
            if (lBereken.Text == "Cos")
            {
                uitkomst = Math.Round((Math.Cos(G1)), 2);
            }
            if (lBereken.Text == "Tan")
            {
                uitkomst = Math.Round((Math.Tan(G1)), 2);
            }

            // als een berekening maar 1 getal nodig heeft, gebruiken we getal2 als een "=" teken
            if (lBereken.Text == "O2" || lBereken.Text == "O1" || lBereken.Text == "Tan" || lBereken.Text == "Cos")
            {
                lGetal2.Text = " =";
            }
            else
            {
                lGetal2.Text = "" + G1.ToString() + " =";
            }
            lUitkomst.Text = uitkomst.ToString();
            lblScherm.Text = uitkomst.ToString();
        }
    }
}