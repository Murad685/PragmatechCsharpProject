using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task05
{
    public partial class Form1 : Form
    {
        //Listview goturun ve Name,Surname,PhoneNumber,BirthDate adinda columnlar yaradin.
        //Name ve Surname daxil etmek ucun iki textbox goturun.
        //PhoneNumber ucun maskedtextbox ve birthdate ucun datetimepicker goturun.
        //Onlari doldurub Add button-un vuranda listview-nu doldurun.

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtBoxname.Text.Trim();
            string surname = txtBoxSurename.Text.Trim();
            string phonenum = maskedTxtBoxNumber.Text.Trim();
            string birthday = dateTimePickerBirthday.Text;


            ListViewItem item = new ListViewItem();

            item.Text = name;
            item.SubItems.Add(surname);
            item.SubItems.Add(phonenum);
            item.SubItems.Add(birthday);
            listView.Items.Add(item);

            txtBoxname.Clear();
            txtBoxSurename.Clear();
            maskedTxtBoxNumber.Clear();
        }
    }
}
