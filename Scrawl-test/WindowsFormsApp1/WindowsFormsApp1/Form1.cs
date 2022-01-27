using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double reqem1=0, reqem2=0, netice=0;
            reqem1=Convert.ToDouble(textBox1.Text);
            reqem2 = Convert.ToDouble(textBox2.Text);
            netice = reqem1 + reqem2;
            label4.Text = Convert.ToString(netice);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //label2.Text=textBox1.Text; ///text yerine yazi yazirsan gedir labelde yazilir o yeah
            //MessageBox.Show("sala,"); ////console write line tipa javascriptin alerti kimi
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double reqem1 = 0, reqem2 = 0, netice = 0;
            reqem1 = Convert.ToDouble(textBox1.Text);
            reqem2 = Convert.ToDouble(textBox2.Text);
            netice = reqem1 / reqem2;
            label4.Text = Convert.ToString(netice);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double reqem1 = 0, reqem2 = 0, netice = 0;
            reqem1 = Convert.ToDouble(textBox1.Text);
            reqem2 = Convert.ToDouble(textBox2.Text);
            netice = reqem1 - reqem2;
            label4.Text = Convert.ToString(netice);
        }


        private void button3_Click_1(object sender, EventArgs e)
        {
            double reqem1 = 0, reqem2 = 0, netice = 0;
            reqem1 = Convert.ToDouble(textBox1.Text);
            reqem2 = Convert.ToDouble(textBox2.Text);
            netice = reqem1 * reqem2;
            label4.Text = Convert.ToString(netice);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("salam sebuw");
        }
    }
}
