using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task01
{
    public partial class Form1 : Form
    {
        // % /  - operatorlarindan ibaret calculator yaradin.Calculator-da iki numericUpdown, 
        //bir combobox ve labellar olsun.Emeliyyat aparacagimiz operatorlari combobox-da saxlayin.
        //Emeliyyatlari switch/case-le edin ve result-i label-a cixardin. 
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void numericUpDown1_ValueChanged_1(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(numericUpDown1.Value);
            int c = 0;
            int b = Convert.ToInt32(numericUpDown2.Value);
            string ch = comboBox1.Text;

            switch (ch)
            {
                case "/":
                    c = a / b;
                    break;
                case "%":
                    c = a % b;
                    break;

                default:
                    break;
            }
            response.Text = c.ToString();
        }

        private void numericUpDown2_ValueChanged_1(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(numericUpDown1.Value);
            int c = 0;
            int b = Convert.ToInt32(numericUpDown2.Value);
            string ch = comboBox1.Text;

            switch (ch)
            {
                case "/":
                    if (b != 0)
                    {
                        c = a / b;
                    }
                    else
                    {
                        MessageBox.Show("Yalnish emeliyyat!");
                    }
                    break;
                case "%":
                    if (b != 0)
                    {
                        c = a % b;
                    }
                    else
                    {
                        MessageBox.Show("Yalnish emeliyyat!");
                    }
                    break;

                default:
                    break;
            }
            response.Text = c.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(numericUpDown1.Text);
            int c = 0;
            int b = Convert.ToInt32(numericUpDown2.Text);
            string ch = comboBox1.Text;

            switch (ch)
            {
                case "/":
                    if (b != 0)
                    {
                        c = a / b;
                    }
                    else
                    {
                        MessageBox.Show("Yalnish emeliyyat!");
                    }
                    break;
                case "%":
                    if (b != 0)
                    {
                        c = a % b;
                    }
                    else
                    {
                        MessageBox.Show("Yalnish emeliyyat!");
                    }
                    
                    break;

                default:
                    break;
            }
            response.Text = c.ToString();
        }
    }
}
