using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task02
{
    public partial class Form1 : Form
    {
        //Bir label,textbox,button ve listbox goturun.button-u clickledikce textboxa girilmish deyerleri listbox-a elave edin.
        //Her defe elave etdikden sonra textbox-u temizleyin,
        //coursorun textboxda qalmasini temin edin ve listbox-a deyer elave ederken textboxdan gelen deyerin validation-in yoxlayin.
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string surname = txtBox.Text.Trim().ToUpper();
            listBox1.Items.Add(surname);
            txtBox.Clear();
        }

    }
}
