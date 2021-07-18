
namespace Task06
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.comboBoxModel = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimeYear = new System.Windows.Forms.DateTimePicker();
            this.listProdact = new System.Windows.Forms.ListView();
            this.columnmarka = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnmodel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnyanacaq = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnkuza = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnskorst = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnmotor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columncolor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnyear = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxMotor = new System.Windows.Forms.ComboBox();
            this.comboBoxYanacaq = new System.Windows.Forms.ComboBox();
            this.comboBoxMarka = new System.Windows.Forms.ComboBox();
            this.comboBoxSkorst = new System.Windows.Forms.ComboBox();
            this.comboBoxKuza = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnColor = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxModel
            // 
            this.comboBoxModel.BackColor = System.Drawing.Color.Black;
            this.comboBoxModel.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxModel.ForeColor = System.Drawing.Color.Ivory;
            this.comboBoxModel.FormattingEnabled = true;
            this.comboBoxModel.Location = new System.Drawing.Point(309, 142);
            this.comboBoxModel.Name = "comboBoxModel";
            this.comboBoxModel.Size = new System.Drawing.Size(121, 23);
            this.comboBoxModel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Snap ITC", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(435, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Maşın Sifarişi";
            // 
            // dateTimeYear
            // 
            this.dateTimeYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeYear.Location = new System.Drawing.Point(309, 365);
            this.dateTimeYear.Name = "dateTimeYear";
            this.dateTimeYear.Size = new System.Drawing.Size(121, 20);
            this.dateTimeYear.TabIndex = 2;
            // 
            // listProdact
            // 
            this.listProdact.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.listProdact.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnmarka,
            this.columnmodel,
            this.columnyanacaq,
            this.columnkuza,
            this.columnskorst,
            this.columnmotor,
            this.columncolor,
            this.columnyear});
            this.listProdact.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listProdact.ForeColor = System.Drawing.Color.White;
            this.listProdact.GridLines = true;
            this.listProdact.HideSelection = false;
            this.listProdact.Location = new System.Drawing.Point(547, 105);
            this.listProdact.Name = "listProdact";
            this.listProdact.Size = new System.Drawing.Size(677, 280);
            this.listProdact.TabIndex = 4;
            this.listProdact.UseCompatibleStateImageBehavior = false;
            this.listProdact.View = System.Windows.Forms.View.Details;
            // 
            // columnmarka
            // 
            this.columnmarka.Text = "Marka";
            this.columnmarka.Width = 78;
            // 
            // columnmodel
            // 
            this.columnmodel.Text = "Model";
            this.columnmodel.Width = 85;
            // 
            // columnyanacaq
            // 
            this.columnyanacaq.Text = "Yanacaq növü";
            this.columnyanacaq.Width = 102;
            // 
            // columnkuza
            // 
            this.columnkuza.Text = "Kuza növü";
            this.columnkuza.Width = 89;
            // 
            // columnskorst
            // 
            this.columnskorst.Text = "Skorst";
            this.columnskorst.Width = 97;
            // 
            // columnmotor
            // 
            this.columnmotor.Text = "Motor növü";
            this.columnmotor.Width = 76;
            // 
            // columncolor
            // 
            this.columncolor.Text = "Rəngi";
            this.columncolor.Width = 64;
            // 
            // columnyear
            // 
            this.columnyear.Text = "İL";
            this.columnyear.Width = 80;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Black;
            this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
            this.btnAdd.Font = new System.Drawing.Font("Wide Latin", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Yellow;
            this.btnAdd.Location = new System.Drawing.Point(209, 417);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(179, 44);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Sifariş et";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(184, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Bütün Markalar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(184, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Bütün Modellər";
            // 
            // comboBoxMotor
            // 
            this.comboBoxMotor.BackColor = System.Drawing.Color.Black;
            this.comboBoxMotor.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxMotor.ForeColor = System.Drawing.Color.Ivory;
            this.comboBoxMotor.FormattingEnabled = true;
            this.comboBoxMotor.Items.AddRange(new object[] {
            "50",
            "100",
            "150",
            "200",
            "250",
            "300",
            "800",
            "900",
            "1000"});
            this.comboBoxMotor.Location = new System.Drawing.Point(309, 295);
            this.comboBoxMotor.Name = "comboBoxMotor";
            this.comboBoxMotor.Size = new System.Drawing.Size(121, 23);
            this.comboBoxMotor.TabIndex = 8;
            // 
            // comboBoxYanacaq
            // 
            this.comboBoxYanacaq.BackColor = System.Drawing.Color.Black;
            this.comboBoxYanacaq.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxYanacaq.ForeColor = System.Drawing.Color.Ivory;
            this.comboBoxYanacaq.FormattingEnabled = true;
            this.comboBoxYanacaq.Items.AddRange(new object[] {
            "Benzin",
            "Dizel",
            "Qaz",
            "Elektro",
            "Hibrid"});
            this.comboBoxYanacaq.Location = new System.Drawing.Point(309, 180);
            this.comboBoxYanacaq.Name = "comboBoxYanacaq";
            this.comboBoxYanacaq.Size = new System.Drawing.Size(121, 23);
            this.comboBoxYanacaq.TabIndex = 9;
            // 
            // comboBoxMarka
            // 
            this.comboBoxMarka.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.comboBoxMarka.BackColor = System.Drawing.Color.Black;
            this.comboBoxMarka.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxMarka.ForeColor = System.Drawing.Color.Ivory;
            this.comboBoxMarka.FormattingEnabled = true;
            this.comboBoxMarka.Items.AddRange(new object[] {
            "LADA(VAZ)",
            "Mercedes",
            "Ford",
            "Land Rover",
            "İsuzu"});
            this.comboBoxMarka.Location = new System.Drawing.Point(309, 105);
            this.comboBoxMarka.Name = "comboBoxMarka";
            this.comboBoxMarka.Size = new System.Drawing.Size(121, 23);
            this.comboBoxMarka.TabIndex = 10;
            this.comboBoxMarka.SelectedIndexChanged += new System.EventHandler(this.comboBoxMarka_SelectedIndexChanged);
            // 
            // comboBoxSkorst
            // 
            this.comboBoxSkorst.BackColor = System.Drawing.Color.Black;
            this.comboBoxSkorst.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxSkorst.ForeColor = System.Drawing.Color.Ivory;
            this.comboBoxSkorst.FormattingEnabled = true;
            this.comboBoxSkorst.Items.AddRange(new object[] {
            "Mexaniki",
            "Avtomat",
            "Robotlaşdırılmış",
            "Variator"});
            this.comboBoxSkorst.Location = new System.Drawing.Point(309, 255);
            this.comboBoxSkorst.Name = "comboBoxSkorst";
            this.comboBoxSkorst.Size = new System.Drawing.Size(121, 23);
            this.comboBoxSkorst.TabIndex = 11;
            // 
            // comboBoxKuza
            // 
            this.comboBoxKuza.BackColor = System.Drawing.Color.Black;
            this.comboBoxKuza.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxKuza.ForeColor = System.Drawing.Color.Ivory;
            this.comboBoxKuza.FormattingEnabled = true;
            this.comboBoxKuza.Items.AddRange(new object[] {
            "Avtobus",
            "Dartqı",
            "Furqon",
            "Kupe",
            "Sedan",
            "Van",
            "Yük maşını",
            "Pikap",
            "Offroader / SUV"});
            this.comboBoxKuza.Location = new System.Drawing.Point(309, 219);
            this.comboBoxKuza.Name = "comboBoxKuza";
            this.comboBoxKuza.Size = new System.Drawing.Size(121, 23);
            this.comboBoxKuza.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(184, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Yanacaq növü";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(184, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Kuza növü";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(184, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Sürətlər qutusu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(184, 302);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Motor növü,sm3";
            // 
            // btnColor
            // 
            this.btnColor.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnColor.Location = new System.Drawing.Point(309, 332);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(121, 23);
            this.btnColor.TabIndex = 17;
            this.btnColor.UseVisualStyleBackColor = false;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(184, 332);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 16);
            this.label8.TabIndex = 18;
            this.label8.Text = "Rəngi";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(184, 365);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 16);
            this.label9.TabIndex = 19;
            this.label9.Text = "İlini daxil edin:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 525);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxKuza);
            this.Controls.Add(this.comboBoxSkorst);
            this.Controls.Add(this.comboBoxMarka);
            this.Controls.Add(this.comboBoxYanacaq);
            this.Controls.Add(this.comboBoxMotor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.listProdact);
            this.Controls.Add(this.dateTimeYear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxModel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxModel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listProdact;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ColumnHeader columnmarka;
        private System.Windows.Forms.ColumnHeader columnmodel;
        private System.Windows.Forms.ColumnHeader columnyanacaq;
        private System.Windows.Forms.ColumnHeader columnkuza;
        private System.Windows.Forms.ColumnHeader columnskorst;
        private System.Windows.Forms.ColumnHeader columnmotor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxMotor;
        private System.Windows.Forms.ComboBox comboBoxYanacaq;
        private System.Windows.Forms.ComboBox comboBoxMarka;
        private System.Windows.Forms.ComboBox comboBoxSkorst;
        private System.Windows.Forms.ComboBox comboBoxKuza;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimeYear;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ColumnHeader columncolor;
        private System.Windows.Forms.ColumnHeader columnyear;
    }
}

