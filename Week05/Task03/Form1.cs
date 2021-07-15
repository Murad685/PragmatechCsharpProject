using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task03
{
    public partial class Form1 : Form
    {
        //Listbox goturun ve her defe elave et button-un clickleyende icine adlar daxil edin.
        //Daha sonra bir button da goturun adini Sil qoyun ve clicklenende listdeki datalari silmek mumkun olsun.
        //En sonda bir Qarishdir adinda bir button da elave edin ve hemin button clicklenende listbox-un icindeki datalari qarishdirmaq mumkun olsun.
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtBox.Text.Trim().ToLower();
            listBox.Items.Add(name);
            txtBox.Clear();
            txtBox.Focus();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            listBox.Items.Remove(listBox.SelectedItem);
        }

        private void btnMix_Click(object sender, EventArgs e)
        {
            Random rndm = new Random();

            for (int i = 0; i < listBox.Items.Count; i++)
            {
                int randomNumber = rndm.Next(0,listBox.Items.Count);

                Object list2 = listBox.Items[i];

                listBox.Items[i] = listBox.Items[randomNumber];
                listBox.Items[randomNumber] = list2;
            }

        }
    }
}
