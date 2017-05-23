using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace priemgetal
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            lblPrimeNumbers.Text = "";
        }

        public bool IsPrime(int number)
        {
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }

        protected void btnCheck_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(numberBox.Text);
            if (IsPrime(number))
            {
                lblPriem.Text = number + " is a prime number.";
            }
            else
            {
                lblPriem.Text = number + " is not a prime number.";
            }
        }

        protected void BtnCheckMax_Click(object sender, EventArgs e)
        {
            int number2 = Convert.ToInt32(maxNumberBox.Text);
            Stopwatch stopwatch = Stopwatch.StartNew();
            for (int i = 2; i <= number2; i++)
            {
                if (IsPrime(i))
                {
                    lblPrimeNumbers.Text += i.ToString() + ", ";
                }
            }
            TimeSpan totalDuration = stopwatch.Elapsed;
            TimeSpan durationForEachIteration =
                TimeSpan.FromTicks(totalDuration.Ticks / number2);

            lblTotaal.Text = totalDuration.ToString("fffffff");
            lblEach.Text = durationForEachIteration.ToString("fffffff");
        }

        private void berekenGGD()
        {
            int getal1 = Convert.ToInt32(txtGetal1.Text);
            int getal2 = Convert.ToInt32(txtGetal2.Text);
            int kleinste = 0;
            int grootste = 0;
            int GGD = 0;

            if (getal1 > getal2)
            {
                grootste = getal1;
                kleinste = getal2;
            }
            else
            {
                grootste = getal2;
                kleinste = getal1;
            }

            for (int i = 0; i <= kleinste; i++)
            {
                if (grootste % (kleinste - i) == 0 && kleinste % (kleinste - i) == 0)
                {
                    GGD = kleinste - i;
                    break;
                }
            }
            lblGgd.Text = "The greatest common divisor is " + GGD.ToString();
        }

        protected void ggdButton_Click(object sender, EventArgs e)
        {
            berekenGGD();
        }

        public static bool IsPalindrome(string value)
        {
            int min = 0;
            int max = value.Length - 1;
            while (true)
            {
                if (min > max)
                {
                    return true;
                }
                char a = value[min];
                char b = value[max];
                if (char.ToLower(a) != char.ToLower(b))
                {
                    return false;
                }
                min++;
                max--;
            }
        }

        protected void btnPalin_Click(object sender, EventArgs e)
        {
            string word = txtPalin.Text;

            if (IsPalindrome(word))
                lblPalin.Text = "Ja, "+word+" is een Palindrome.";
            else
                lblPalin.Text = "Nee, " + word + " is geen Palindrome.";
        }
    }
}