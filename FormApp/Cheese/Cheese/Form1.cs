using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cheese
{
    public partial class Shahmat : Form
    {
        public Shahmat()
        {
            InitializeComponent();
            

        }



        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="admin"&&textBox2.Text=="admin")
            {
                textBox1.Width = 0;
                textBox2.Width = 0;
                button2.Width = 0;
                label1.Text = "Shahmat oyununa xos geldiniz";
                int yer = 0;
                int i = 0;
                int j = 0;
                int top = 0;
                int left = 0;
                int top1 = 0;
                int left1 = 0;
                for (i = 0; i < 16; i++)
                {
                    for (j = 0; j < 8; j++)
                    {
                        if (left == 400)
                        {
                            top += 50;
                            left = 0;
                            top1 += 50;
                        }
                        if (i % 2 == 0)
                        {


                            if (yer == 1)
                            {
                                Button button = new Button();
                                button.Left = left;
                                button.Top = top1;
                                button.BackColor = Color.Black;
                                button.Size = new Size(50, 50);
                                Controls.Add(button);
                                yer = 0;
                                left += 50;


                            }
                            else
                            {
                                yer++;

                                Button button = new Button();
                                button.Left = left;
                                button.Top = top1;
                                button.BackColor = Color.White;
                                button.Size = new Size(50, 50);
                                Controls.Add(button);
                                left += 50;


                            }
                        }

                        else
                        {
                            if (left1 == 400)
                            {
                                top += 50;
                                left1 = 0;
                            }
                            if (yer == 1)
                            {
                                Button button = new Button();
                                button.Left = left1;
                                button.Top = top;
                                button.BackColor = Color.White;
                                button.Size = new Size(50, 50);
                                Controls.Add(button);
                                yer = 0;
                                left1 += 50;


                            }
                            else
                            {
                                yer++;

                                Button button = new Button();
                                button.Left = left1;
                                button.Top = top;
                                button.BackColor = Color.Black;
                                button.Size = new Size(50, 50);
                                Controls.Add(button);
                                left1 += 50;


                            }
                        }

                    }
                }
            }
            else
            {
                textBox1.Clear();
                textBox2.Clear();
                label1.Text = "Parolu duz yaz brat";
            }
        }
    }
    }



