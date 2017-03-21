using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Rekenmachine_Hoofdstuk5
{
    public partial class Reken : System.Web.UI.Page
    {

        decimal get1;
        decimal get2;
        decimal uitkomst;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnOptel_Click(object sender, EventArgs e)
        {
            // Valideren dat ingevoerde teken een cijfer is
           /* if(!txtGetal1.Text.Contains(",") && !txtGetal1.Text.Contains("0") && !txtGetal1.Text.Contains("1") && !txtGetal1.Text.Contains("2") && !txtGetal1.Text.Contains("3")
                && !txtGetal1.Text.Contains("4") && !txtGetal1.Text.Contains("5") && !txtGetal1.Text.Contains("6")
                && !txtGetal1.Text.Contains("7") && !txtGetal1.Text.Contains("8") && !txtGetal1.Text.Contains("9")
                ||
                !txtGetal2.Text.Contains(",") && !txtGetal2.Text.Contains("0") && !txtGetal2.Text.Contains("1") && !txtGetal2.Text.Contains("2") && !txtGetal2.Text.Contains("3")
                && !txtGetal2.Text.Contains("4") && !txtGetal2.Text.Contains("5") && !txtGetal2.Text.Contains("6")
                && !txtGetal2.Text.Contains("7") && !txtGetal2.Text.Contains("8") && !txtGetal2.Text.Contains("9"))
            {
                txtUitkomst.Text = "Alleen cijfers of komma!";
                return;
            }*/

            get1 = Convert.ToDecimal(txtGetal1.Text);
            get2 = Convert.ToDecimal(txtGetal2.Text);
            uitkomst = get1 + get2;
            txtUitkomst.Text = Convert.ToString(uitkomst);
        }

        protected void btnAftrek_Click(object sender, EventArgs e)
        {
            // Valideren dat ingevoerde teken een cijfer is
           /* if (!txtGetal1.Text.Contains(",") && !txtGetal1.Text.Contains("0") && !txtGetal1.Text.Contains("1") && !txtGetal1.Text.Contains("2") && !txtGetal1.Text.Contains("3")
                && !txtGetal1.Text.Contains("4") && !txtGetal1.Text.Contains("5") && !txtGetal1.Text.Contains("6")
                && !txtGetal1.Text.Contains("7") && !txtGetal1.Text.Contains("8") && !txtGetal1.Text.Contains("9")
                ||
                !txtGetal2.Text.Contains(",") && !txtGetal2.Text.Contains("0") && !txtGetal2.Text.Contains("1") && !txtGetal2.Text.Contains("2") && !txtGetal2.Text.Contains("3")
                && !txtGetal2.Text.Contains("4") && !txtGetal2.Text.Contains("5") && !txtGetal2.Text.Contains("6")
                && !txtGetal2.Text.Contains("7") && !txtGetal2.Text.Contains("8") && !txtGetal2.Text.Contains("9"))
            {
                txtUitkomst.Text = "Alleen cijfers of komma!";
                return;
            }*/

            get1 = Convert.ToDecimal(txtGetal1.Text);
            get2 = Convert.ToDecimal(txtGetal2.Text);
            uitkomst = get1 - get2;
            txtUitkomst.Text = Convert.ToString(uitkomst);
        }

        protected void txtGetal1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}