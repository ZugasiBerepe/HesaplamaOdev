using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HesaplamaOdev
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }        
        protected void BtnCikart_Click(object sender, EventArgs e)
        {
            int Sayi1, Sayi2;

            Sayi1 = Convert.ToInt32(txtSayi1.Text);
            Sayi2 = Convert.ToInt32(txtSayi2.Text);

            lblSonuc.Text = (Sayi1 - Sayi2).ToString();

            txtSayi1.Text = "";
            txtSayi2.Text = "";
        }

        protected void BtnCarp_Click(object sender, EventArgs e)
        {
            int Sayi1, Sayi2;

            Sayi1 = Convert.ToInt32(txtSayi1.Text);
            Sayi2 = Convert.ToInt32(txtSayi2.Text);

            lblSonuc.Text = (Sayi1 * Sayi2).ToString();

            txtSayi1.Text = "";
            txtSayi2.Text = "";
        }

        protected void BtnBol_Click(object sender, EventArgs e)
        {
            int Sayi1, Sayi2;

            Sayi1 = Convert.ToInt32(txtSayi1.Text);
            Sayi2 = Convert.ToInt32(txtSayi2.Text);            

            lblSonuc.Text = (Sayi1/Sayi2).ToString();

            txtSayi1.Text = "";
            txtSayi2.Text = "";
        }

        protected void BtnTopla_Click(object sender, EventArgs e)
        {
            int Sayi1, Sayi2;

            Sayi1 = Convert.ToInt32(txtSayi1.Text);
            Sayi2 = Convert.ToInt32(txtSayi2.Text);

            lblSonuc.Text = (Sayi1 + Sayi2).ToString();


            txtSayi1.Text = "";
            txtSayi2.Text = "";
        }
    }
}
    
 