using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExchangerApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double pul=Convert.ToDouble(Pulundeyeri.Text);

            if (ComboFrom.SelectedItem == "Manat" && ComboTo.SelectedItem == "Dollar")
            {
                double result = pul * 0.59;
                Netice.Text = "Netice " + result + " " + "$";
            }
            if (ComboFrom.SelectedItem == "Manat" && ComboTo.SelectedItem == "Euro")
            {
                double result = pul * 0.51;
                Netice.Text = "Netice " + result + " " + "€";
            }
            if (ComboFrom.SelectedItem == "Manat" && ComboTo.SelectedItem == "Lira")
            {
                double result = pul * 7.98;
                Netice.Text = "Netice " + result + " " + "₺";
            }
            if (ComboFrom.SelectedItem == "Dollar" && ComboTo.SelectedItem == "Manat")
            {
                double result = pul * 1.70;
                Netice.Text = "Netice " + result + " " + "₼";
            }
            if (ComboFrom.SelectedItem == "Dollar" && ComboTo.SelectedItem == "Euro")
            {
                double result = pul * 0.87;
                Netice.Text = "Netice " + result + " " + "€";
            }
            if (ComboFrom.SelectedItem == "Dollar" && ComboTo.SelectedItem == "Lira")
            {
                double result = pul * 13.57;
                Netice.Text = "Netice " + result + " " + "₺";
            }
            if (ComboFrom.SelectedItem == "Euro" && ComboTo.SelectedItem == "Manat")
            {
                double result = pul * 1.95;
                Netice.Text = "Netice " + result + " " + "₼";
            }
            if (ComboFrom.SelectedItem == "Euro" && ComboTo.SelectedItem == "Dollar")
            {
                double result = pul * 1.14;
                Netice.Text = "Netice " + result + " " + "$";
            }
            if (ComboFrom.SelectedItem == "Euro" && ComboTo.SelectedItem == "Lira")
            {
                double result = pul * 15.54;
                Netice.Text = "Netice " + result + " " + "₺";
            }
            if (ComboFrom.SelectedItem == "Lira" && ComboTo.SelectedItem == "Dollar")
            {
                double result = pul * 0.074;
                Netice.Text = "Netice " + result + " " + "$";
            }
            if (ComboFrom.SelectedItem == "Lira" && ComboTo.SelectedItem == "Manat")
            {
                double result = pul * 0.13;
                Netice.Text = "Netice " + result + " " + "₼";
            }
            if (ComboFrom.SelectedItem == "Lira" && ComboTo.SelectedItem == "Euro")
            {
                double result = pul * 0.064;
                Netice.Text = "Netice " + result + " " + "€";
            }
        }

        private void sifirla_Click(object sender, EventArgs e)
        {
            Pulundeyeri.Text = "";
            ComboFrom.SelectedIndex = 0;
            ComboTo.SelectedIndex = 0;
            Netice.Text = "Netice";
        }
    }
}
