using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task04
{
    public partial class Form1 : Form
    {
        //Bir listbox,bir textbox,iki label ve 3 buttondan ibaret proqram qurun,
        //Buttonlardan birinin Add olsun ve textboxa gireceyimiz adlari listbox-da elave etsin.
        //Ikinci button-in adi Count olsun ve onu clickleyende listbox-daki datalarin sayini mesagebox-a cixarsin.
        //Sonuncu button-in adi ise Search olsun ve onu clickleyende axtardigimiz adin listde olub olmadigini gosteren mesaj cixarsin ekrana. Controllar:
        //1.listbox-a add olunacaq data kicik herfle de girilse her zaman boyuk olaraq daxil olsun liste.
        //2.Texbox-da boshluq qoyub ad yazib daxil ederken boshlugu silerek daxil edin liste.
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtBox.Text.ToUpper().Trim();
            
            if (!string.IsNullOrEmpty(name))
            {
                listBox1.Items.Add(name);
            }
            txtBox.Clear();
            txtBox.Focus();
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            MessageBox.Show(listBox1.Items.Count.ToString());
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchData = txtBox.Text.Trim().ToLower();
            if (listBox1.Items.Contains(searchData))
            {
                MessageBox.Show("Beli var!");
            }
            else
            {
                MessageBox.Show("Bu ad yoxdur!");
            }
        }
    }
}
