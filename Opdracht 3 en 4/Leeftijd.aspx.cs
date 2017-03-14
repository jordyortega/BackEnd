using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Opdracht_3_en_4
{
    public partial class Leeftijd : System.Web.UI.Page
    {

        //oud
        /*int dagPasen = 106;
        int dagen;
        int uren;
        int minuten;
        int seconden;*/

        //oud
        /*public static int GetDaysInYear(int year)
        {
            DateTime thisYear = new DateTime(year, 1, 1);
            DateTime nextYear = new DateTime(year + 1, 1, 1);

            return (nextYear - thisYear).Days;
        }*/

        protected void Page_Load(object sender, EventArgs e)
        {

            //nieuw
            DateTime vandaag = DateTime.Now;
            DateTime pasen = new DateTime(2017, 4, 16);

            TimeSpan periode = pasen - vandaag;

            //oud
            /* dagen = dagPasen - DateTime.Now.DayOfYear;//((DateTime.Now.DayOfYear*24)-DateTime.Now.Hour);
             if (dagen > 0)
             {
                 uren = (dagen * 24) - DateTime.Now.Hour;
                 minuten = (uren * 60) - DateTime.Now.Minute;
                 seconden = (minuten * 60) - DateTime.Now.Second;
             }
             else
             {
                 dagen += GetDaysInYear(DateTime.Now.Year);
                 uren = (dagen * 24) - DateTime.Now.Hour;
                 minuten = (uren * 60) - DateTime.Now.Minute;
                 seconden = (minuten * 60) - DateTime.Now.Second;
             }*/

            litVandaag.Text = DateTime.Now.Date.ToString("dd-MM-yyyy");
            litTijd.Text = DateTime.Now.TimeOfDay.ToString("hh\\:mm\\:ss");

            //oud
            //lblUren.Text = "" + uren + " uren";
            //lblMin.Text = "" + minuten + " minuten";
            //lblSec.Text = "" + seconden + " seconden";

            lblUren.Text = "" + Convert.ToInt32(periode.TotalHours) + " uren";
            lblMin.Text = "" + Convert.ToInt32(periode.TotalMinutes) + " minuten";
            lblSec.Text = "" + Convert.ToInt32(periode.TotalSeconds) + " seconden";

            //oud
           /* if (DateTime.Now.DayOfYear == dagPasen || DateTime.Now.DayOfYear == dagPasen + 1)
            {
                lblUren.Text = "Het is vandaag Pasen!";
                lblMin.Text = "";
                lblSec.Text = "";
            }*/
                                                                                                                                                
            if(pasen == vandaag)
            {
                lblUren.Text = "Het is vandaag Pasen!";
                lblMin.Text = "";
                lblSec.Text = "";
            }
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            //Label1.Text = Convert.ToString(kalVerjaardag.SelectedDate);
            Label1.Text = kalVerjaardag.SelectedDate.ToString("dd-MM-yyyy");
        }

        protected void btnLeeftijd_Click(object sender, EventArgs e)
        {
            if (kalVerjaardag.SelectedDate == DateTime.MinValue.Date)
                return;

            int age = DateTime.Now.Year - kalVerjaardag.SelectedDate.Year;

            if (DateTime.Now.Month < kalVerjaardag.SelectedDate.Month || (DateTime.Now.Month == kalVerjaardag.SelectedDate.Month && DateTime.Now.Day < kalVerjaardag.SelectedDate.Day))
                age--;

            Label2.Text = "" + age;

            if (DateTime.Now.Month == kalVerjaardag.SelectedDate.Month && DateTime.Now.Day == kalVerjaardag.SelectedDate.Day)
            {
                Label2.Text += ", gefeliciteerd!";
            }
        }
    }
}