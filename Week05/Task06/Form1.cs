using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task06
{
    public partial class Form1 : Form
    {
        //Bir mashin sifarish programi qurun.Hemin programda mashinin markasini,modelini,yanacaq tipini,
        //kuza tipini,skorost tipini,motor tipini sece bileceyimiz combobox-lar goturun.
        //Onlardan elave rengini secmekcun colorDialog ve ilini secmek ucun datetimepicker goturun.
        //Bir listview ve Add button-i olsun.Listview-ya eyni adda columnlar girilsin.
        //Combobox-larin hamisi manual doldurulur ve ancaq marka secilen zaman model combosu dolur.
        //Add buttonu clicklendikden sonra hamisi temizlenir listview-dan bashqa. Butun componentler ucun validation girilsin.
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void comboBoxMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            string marka = comboBoxMarka.Text;

            switch (marka)
            {
                case "LADA(VAZ)":
                    comboBoxModel.Items.Clear();
                    comboBoxModel.Items.Add("2101");
                    comboBoxModel.Items.Add("2105");
                    comboBoxModel.Items.Add("2106");
                    comboBoxModel.Items.Add("2107");
                    comboBoxModel.Items.Add("21011");
                    break;
                case "Mercedes":
                    comboBoxModel.Items.Clear();
                    comboBoxModel.Items.Add("170 V");
                    comboBoxModel.Items.Add("A 140");
                    comboBoxModel.Items.Add("540K Replica");
                    comboBoxModel.Items.Add("Vaneo");
                    break;
                case "Ford":
                    comboBoxModel.Items.Clear();
                    comboBoxModel.Items.Add("Aerostar");
                    comboBoxModel.Items.Add("Bronco");
                    comboBoxModel.Items.Add("Ecosport");
                    comboBoxModel.Items.Add("Fiesta");
                    break;
                case "Land Rover":
                    comboBoxModel.Items.Clear();
                    comboBoxModel.Items.Add("Defender");
                    comboBoxModel.Items.Add("Discovery");
                    comboBoxModel.Items.Add("Range Rover");
                    comboBoxModel.Items.Add("RR Sport");
                    break;
                case "İsuzu":
                    comboBoxModel.Items.Clear();
                    comboBoxModel.Items.Add("Axiom");
                    comboBoxModel.Items.Add("Bogdan");
                    comboBoxModel.Items.Add("D - Max");
                    comboBoxModel.Items.Add("FTR 33M");
                    comboBoxModel.Items.Add("HC 40");
                    comboBoxModel.Items.Add("Forward");
                    break;

                default:
                    break;
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            

            string marka = comboBoxMarka.Text;
            string model = comboBoxModel.Text;
            string yanacaq = comboBoxYanacaq.Text;
            string kuza = comboBoxKuza.Text;
            string skorst = comboBoxSkorst.Text;
            int motor = Convert.ToInt32(comboBoxMotor.Text);
            string year = dateTimeYear.Text;


            ListViewItem product = new ListViewItem();
            product.Text = marka;
            product.SubItems.Add(model);
            product.SubItems.Add(yanacaq);
            product.SubItems.Add(kuza);
            product.SubItems.Add(skorst);
            product.SubItems.Add(motor.ToString());
            product.UseItemStyleForSubItems = false;
            product.SubItems.Add(string.Empty).BackColor = btnColor.BackColor;
            product.SubItems.Add(year);
            listProdact.Items.Add(product);

        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            using (ColorDialog clr = new ColorDialog())
            {
                if (clr.ShowDialog() == DialogResult.OK)
                {
                    btnColor.BackColor = clr.Color;
                }
            }
        }

        
    }
}
