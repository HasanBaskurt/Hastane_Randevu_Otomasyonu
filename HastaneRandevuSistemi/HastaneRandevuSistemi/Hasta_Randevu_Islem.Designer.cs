
namespace HastaneRandevuSistemi
{
    partial class Hasta_Randevu_Islem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hasta_Randevu_Islem));
            this.lblHasta = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.randevuListe = new System.Windows.Forms.ListView();
            this.Randevu_No = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Bolum_Adi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Doktor_Adi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Doktor_Soyadi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tarih = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Saat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblListe = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtSaat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn13 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn10 = new System.Windows.Forms.Button();
            this.btnAl = new System.Windows.Forms.Button();
            this.btn14 = new System.Windows.Forms.Button();
            this.btn15 = new System.Windows.Forms.Button();
            this.btn11 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn16 = new System.Windows.Forms.Button();
            this.btn12 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxDoktor = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtRandevu = new System.Windows.Forms.DateTimePicker();
            this.comboBoxBolum = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTeslim = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblCeza = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.lblSifre = new System.Windows.Forms.Label();
            this.lblTc = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_IdSil = new System.Windows.Forms.TextBox();
            this.lblHastaId = new System.Windows.Forms.Label();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.BackColor = System.Drawing.Color.Transparent;
            this.lblHasta.Font = new System.Drawing.Font("Ravie", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHasta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblHasta.Location = new System.Drawing.Point(517, 16);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(443, 40);
            this.lblHasta.TabIndex = 46;
            this.lblHasta.Text = "Hoşgeldin  Hasta Adı";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Controls.Add(this.randevuListe);
            this.panel5.Controls.Add(this.lblListe);
            this.panel5.Location = new System.Drawing.Point(348, 79);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(823, 211);
            this.panel5.TabIndex = 53;
            // 
            // randevuListe
            // 
            this.randevuListe.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Randevu_No,
            this.Bolum_Adi,
            this.Doktor_Adi,
            this.Doktor_Soyadi,
            this.Tarih,
            this.Saat});
            this.randevuListe.HideSelection = false;
            this.randevuListe.Location = new System.Drawing.Point(24, 43);
            this.randevuListe.Name = "randevuListe";
            this.randevuListe.Size = new System.Drawing.Size(769, 151);
            this.randevuListe.TabIndex = 2;
            this.randevuListe.UseCompatibleStateImageBehavior = false;
            this.randevuListe.View = System.Windows.Forms.View.Details;
            // 
            // Randevu_No
            // 
            this.Randevu_No.Text = "Randevu No";
            this.Randevu_No.Width = 100;
            // 
            // Bolum_Adi
            // 
            this.Bolum_Adi.Text = "Bölüm Adı";
            this.Bolum_Adi.Width = 100;
            // 
            // Doktor_Adi
            // 
            this.Doktor_Adi.Text = "Doktor Adı";
            this.Doktor_Adi.Width = 100;
            // 
            // Doktor_Soyadi
            // 
            this.Doktor_Soyadi.Text = "Doktor Soyadı";
            this.Doktor_Soyadi.Width = 100;
            // 
            // Tarih
            // 
            this.Tarih.Text = "Tarih";
            this.Tarih.Width = 100;
            // 
            // Saat
            // 
            this.Saat.Text = "Saat";
            this.Saat.Width = 50;
            // 
            // lblListe
            // 
            this.lblListe.AutoSize = true;
            this.lblListe.BackColor = System.Drawing.Color.Transparent;
            this.lblListe.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblListe.ForeColor = System.Drawing.Color.Yellow;
            this.lblListe.Location = new System.Drawing.Point(267, 11);
            this.lblListe.Name = "lblListe";
            this.lblListe.Size = new System.Drawing.Size(345, 29);
            this.lblListe.TabIndex = 1;
            this.lblListe.Text = "ALDIĞIN RANDEVU LİSTESİ";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(1127, 8);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(44, 54);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 48;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.DimGray;
            this.button2.ImageKey = "reply.png";
            this.button2.Location = new System.Drawing.Point(30, 26);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 34);
            this.button2.TabIndex = 47;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtSaat
            // 
            this.txtSaat.Enabled = false;
            this.txtSaat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSaat.ForeColor = System.Drawing.Color.Black;
            this.txtSaat.Location = new System.Drawing.Point(227, 182);
            this.txtSaat.Name = "txtSaat";
            this.txtSaat.Size = new System.Drawing.Size(134, 22);
            this.txtSaat.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(58, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 20);
            this.label3.TabIndex = 33;
            this.label3.Text = "Randevu Saati :";
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.Lime;
            this.btn5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn5.Location = new System.Drawing.Point(415, 102);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(75, 35);
            this.btn5.TabIndex = 32;
            this.btn5.Text = "10:20";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.Lime;
            this.btn9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn9.Location = new System.Drawing.Point(415, 143);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(75, 35);
            this.btn9.TabIndex = 31;
            this.btn9.Text = "12:00";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn13
            // 
            this.btn13.BackColor = System.Drawing.Color.Lime;
            this.btn13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn13.Location = new System.Drawing.Point(415, 184);
            this.btn13.Name = "btn13";
            this.btn13.Size = new System.Drawing.Size(75, 35);
            this.btn13.TabIndex = 30;
            this.btn13.Text = "14:00";
            this.btn13.UseVisualStyleBackColor = false;
            this.btn13.Click += new System.EventHandler(this.btn13_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtSaat);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btn5);
            this.panel1.Controls.Add(this.btn9);
            this.panel1.Controls.Add(this.btn13);
            this.panel1.Controls.Add(this.btn1);
            this.panel1.Controls.Add(this.btn6);
            this.panel1.Controls.Add(this.btn10);
            this.panel1.Controls.Add(this.btnAl);
            this.panel1.Controls.Add(this.btn14);
            this.panel1.Controls.Add(this.btn15);
            this.panel1.Controls.Add(this.btn11);
            this.panel1.Controls.Add(this.btn7);
            this.panel1.Controls.Add(this.btn16);
            this.panel1.Controls.Add(this.btn12);
            this.panel1.Controls.Add(this.btn8);
            this.panel1.Controls.Add(this.btn4);
            this.panel1.Controls.Add(this.btn3);
            this.panel1.Controls.Add(this.btn2);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.comboBoxDoktor);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dtRandevu);
            this.panel1.Controls.Add(this.comboBoxBolum);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(348, 317);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(823, 276);
            this.panel1.TabIndex = 49;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(411, 234);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(351, 40);
            this.label8.TabIndex = 35;
            this.label8.Text = "Randevu saatini üzerine tıklayıp seçebilirsiniz.\r\n\r\n";
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.Lime;
            this.btn1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn1.Location = new System.Drawing.Point(415, 62);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 35);
            this.btn1.TabIndex = 29;
            this.btn1.Text = "09:00";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.Lime;
            this.btn6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn6.Location = new System.Drawing.Point(496, 102);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(75, 35);
            this.btn6.TabIndex = 28;
            this.btn6.Text = "10:40";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn10
            // 
            this.btn10.BackColor = System.Drawing.Color.Lime;
            this.btn10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn10.Location = new System.Drawing.Point(496, 143);
            this.btn10.Name = "btn10";
            this.btn10.Size = new System.Drawing.Size(75, 35);
            this.btn10.TabIndex = 27;
            this.btn10.Text = "13:00";
            this.btn10.UseVisualStyleBackColor = false;
            this.btn10.Click += new System.EventHandler(this.btn10_Click);
            // 
            // btnAl
            // 
            this.btnAl.BackColor = System.Drawing.Color.FloralWhite;
            this.btnAl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAl.Location = new System.Drawing.Point(227, 225);
            this.btnAl.Name = "btnAl";
            this.btnAl.Size = new System.Drawing.Size(134, 35);
            this.btnAl.TabIndex = 11;
            this.btnAl.Text = "Randevu Al";
            this.btnAl.UseVisualStyleBackColor = false;
            this.btnAl.Click += new System.EventHandler(this.btnAl_Click);
            // 
            // btn14
            // 
            this.btn14.BackColor = System.Drawing.Color.Lime;
            this.btn14.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn14.Location = new System.Drawing.Point(496, 184);
            this.btn14.Name = "btn14";
            this.btn14.Size = new System.Drawing.Size(75, 35);
            this.btn14.TabIndex = 26;
            this.btn14.Text = "14:20";
            this.btn14.UseVisualStyleBackColor = false;
            this.btn14.Click += new System.EventHandler(this.btn14_Click);
            // 
            // btn15
            // 
            this.btn15.BackColor = System.Drawing.Color.Lime;
            this.btn15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn15.Location = new System.Drawing.Point(577, 184);
            this.btn15.Name = "btn15";
            this.btn15.Size = new System.Drawing.Size(75, 35);
            this.btn15.TabIndex = 25;
            this.btn15.Text = "14:40";
            this.btn15.UseVisualStyleBackColor = false;
            this.btn15.Click += new System.EventHandler(this.btn15_Click);
            // 
            // btn11
            // 
            this.btn11.BackColor = System.Drawing.Color.Lime;
            this.btn11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn11.Location = new System.Drawing.Point(577, 143);
            this.btn11.Name = "btn11";
            this.btn11.Size = new System.Drawing.Size(75, 35);
            this.btn11.TabIndex = 24;
            this.btn11.Text = "13:20";
            this.btn11.UseVisualStyleBackColor = false;
            this.btn11.Click += new System.EventHandler(this.btn11_Click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.Lime;
            this.btn7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn7.Location = new System.Drawing.Point(577, 103);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(75, 35);
            this.btn7.TabIndex = 23;
            this.btn7.Text = "11:00";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn16
            // 
            this.btn16.BackColor = System.Drawing.Color.Lime;
            this.btn16.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn16.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn16.Location = new System.Drawing.Point(655, 184);
            this.btn16.Name = "btn16";
            this.btn16.Size = new System.Drawing.Size(75, 35);
            this.btn16.TabIndex = 22;
            this.btn16.Text = "15:00";
            this.btn16.UseVisualStyleBackColor = false;
            this.btn16.Click += new System.EventHandler(this.btn16_Click);
            // 
            // btn12
            // 
            this.btn12.BackColor = System.Drawing.Color.Lime;
            this.btn12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn12.Location = new System.Drawing.Point(655, 143);
            this.btn12.Name = "btn12";
            this.btn12.Size = new System.Drawing.Size(75, 35);
            this.btn12.TabIndex = 21;
            this.btn12.Text = "13:40";
            this.btn12.UseVisualStyleBackColor = false;
            this.btn12.Click += new System.EventHandler(this.btn12_Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.Lime;
            this.btn8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn8.Location = new System.Drawing.Point(656, 103);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(75, 35);
            this.btn8.TabIndex = 20;
            this.btn8.Text = "11:20";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.Lime;
            this.btn4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn4.Location = new System.Drawing.Point(656, 62);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(75, 35);
            this.btn4.TabIndex = 19;
            this.btn4.Text = "10:00";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.Lime;
            this.btn3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn3.Location = new System.Drawing.Point(577, 62);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(75, 35);
            this.btn3.TabIndex = 18;
            this.btn3.Text = "09:40";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.Lime;
            this.btn2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn2.Location = new System.Drawing.Point(496, 62);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(75, 35);
            this.btn2.TabIndex = 17;
            this.btn2.Text = "09:20";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(126, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Doktor :";
            // 
            // comboBoxDoktor
            // 
            this.comboBoxDoktor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDoktor.FormattingEnabled = true;
            this.comboBoxDoktor.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.comboBoxDoktor.Location = new System.Drawing.Point(227, 106);
            this.comboBoxDoktor.Name = "comboBoxDoktor";
            this.comboBoxDoktor.Size = new System.Drawing.Size(131, 24);
            this.comboBoxDoktor.TabIndex = 15;
            this.comboBoxDoktor.SelectedIndexChanged += new System.EventHandler(this.comboBoxDoktor_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(50, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Randevu Tarihi :";
            // 
            // dtRandevu
            // 
            this.dtRandevu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtRandevu.Location = new System.Drawing.Point(227, 143);
            this.dtRandevu.Name = "dtRandevu";
            this.dtRandevu.Size = new System.Drawing.Size(131, 22);
            this.dtRandevu.TabIndex = 13;
            this.dtRandevu.ValueChanged += new System.EventHandler(this.dtRandevu_ValueChanged);
            // 
            // comboBoxBolum
            // 
            this.comboBoxBolum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBolum.FormattingEnabled = true;
            this.comboBoxBolum.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.comboBoxBolum.Location = new System.Drawing.Point(227, 68);
            this.comboBoxBolum.Name = "comboBoxBolum";
            this.comboBoxBolum.Size = new System.Drawing.Size(131, 24);
            this.comboBoxBolum.TabIndex = 12;
            this.comboBoxBolum.SelectedIndexChanged += new System.EventHandler(this.comboBoxBolum_SelectedIndexChanged);
            this.comboBoxBolum.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBoxBolum_MouseClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(129, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Bölüm :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(272, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "RANDEVU ALMA İŞLEMİ";
            // 
            // btnTeslim
            // 
            this.btnTeslim.BackColor = System.Drawing.Color.FloralWhite;
            this.btnTeslim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTeslim.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTeslim.Location = new System.Drawing.Point(112, 117);
            this.btnTeslim.Name = "btnTeslim";
            this.btnTeslim.Size = new System.Drawing.Size(104, 35);
            this.btnTeslim.TabIndex = 11;
            this.btnTeslim.Text = "İptal Et";
            this.btnTeslim.UseVisualStyleBackColor = false;
            this.btnTeslim.Click += new System.EventHandler(this.btnTeslim_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(20, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Randevu No:\r\n";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Yellow;
            this.label6.Location = new System.Drawing.Point(27, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(248, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "RANDEVU İPTAL ETME";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Controls.Add(this.lblCeza);
            this.panel4.Controls.Add(this.label);
            this.panel4.Controls.Add(this.lblSifre);
            this.panel4.Controls.Add(this.lblTc);
            this.panel4.Controls.Add(this.lblSoyad);
            this.panel4.Controls.Add(this.lblAd);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.label16);
            this.panel4.Location = new System.Drawing.Point(30, 79);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(298, 310);
            this.panel4.TabIndex = 51;
            // 
            // lblCeza
            // 
            this.lblCeza.AutoSize = true;
            this.lblCeza.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCeza.ForeColor = System.Drawing.Color.Yellow;
            this.lblCeza.Location = new System.Drawing.Point(173, 261);
            this.lblCeza.Name = "lblCeza";
            this.lblCeza.Size = new System.Drawing.Size(47, 18);
            this.lblCeza.TabIndex = 13;
            this.lblCeza.Text = "Ceza";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label.ForeColor = System.Drawing.Color.FloralWhite;
            this.label.Location = new System.Drawing.Point(78, 261);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(57, 18);
            this.label.TabIndex = 12;
            this.label.Text = "Ceza :";
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSifre.ForeColor = System.Drawing.Color.Yellow;
            this.lblSifre.Location = new System.Drawing.Point(172, 223);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(43, 18);
            this.lblSifre.TabIndex = 11;
            this.lblSifre.Text = "Şifre";
            // 
            // lblTc
            // 
            this.lblTc.AutoSize = true;
            this.lblTc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTc.ForeColor = System.Drawing.Color.Yellow;
            this.lblTc.Location = new System.Drawing.Point(173, 176);
            this.lblTc.Name = "lblTc";
            this.lblTc.Size = new System.Drawing.Size(30, 18);
            this.lblTc.TabIndex = 10;
            this.lblTc.Text = "No";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSoyad.ForeColor = System.Drawing.Color.Yellow;
            this.lblSoyad.Location = new System.Drawing.Point(173, 124);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(55, 18);
            this.lblSoyad.TabIndex = 9;
            this.lblSoyad.Text = "Soyad";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAd.ForeColor = System.Drawing.Color.Yellow;
            this.lblAd.Location = new System.Drawing.Point(173, 82);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(27, 18);
            this.lblAd.TabIndex = 8;
            this.lblAd.Text = "Ad";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.FloralWhite;
            this.label12.Location = new System.Drawing.Point(82, 223);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 18);
            this.label12.TabIndex = 5;
            this.label12.Text = "Şifre :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.FloralWhite;
            this.label11.Location = new System.Drawing.Point(96, 176);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 18);
            this.label11.TabIndex = 4;
            this.label11.Text = "TC :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.FloralWhite;
            this.label10.Location = new System.Drawing.Point(71, 124);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 18);
            this.label10.TabIndex = 3;
            this.label10.Text = "Soyad :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.FloralWhite;
            this.label9.Location = new System.Drawing.Point(99, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 18);
            this.label9.TabIndex = 2;
            this.label9.Text = "Ad :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.ForeColor = System.Drawing.Color.Yellow;
            this.label16.Location = new System.Drawing.Point(94, 26);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(127, 25);
            this.label16.TabIndex = 1;
            this.label16.Text = "BİLGİLERİN";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Red;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.txt_IdSil);
            this.panel3.Controls.Add(this.btnTeslim);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(30, 401);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(298, 192);
            this.panel3.TabIndex = 50;
            // 
            // txt_IdSil
            // 
            this.txt_IdSil.Location = new System.Drawing.Point(175, 74);
            this.txt_IdSil.Name = "txt_IdSil";
            this.txt_IdSil.Size = new System.Drawing.Size(100, 22);
            this.txt_IdSil.TabIndex = 12;
            this.txt_IdSil.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_IdSil_KeyPress);
            // 
            // lblHastaId
            // 
            this.lblHastaId.AutoSize = true;
            this.lblHastaId.Location = new System.Drawing.Point(1002, 40);
            this.lblHastaId.Name = "lblHastaId";
            this.lblHastaId.Size = new System.Drawing.Size(0, 17);
            this.lblHastaId.TabIndex = 54;
            this.lblHastaId.Visible = false;
            this.lblHastaId.Click += new System.EventHandler(this.lblHastaId_Click);
            // 
            // Hasta_Randevu_Islem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.lblHastaId);
            this.Controls.Add(this.lblHasta);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Hasta_Randevu_Islem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hasta_Randevu_Islem";
            this.Load += new System.EventHandler(this.Hasta_Randevu_Islem_Load);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblListe;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtSaat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn13;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn10;
        private System.Windows.Forms.Button btnAl;
        private System.Windows.Forms.Button btn14;
        private System.Windows.Forms.Button btn15;
        private System.Windows.Forms.Button btn11;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn16;
        private System.Windows.Forms.Button btn12;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxDoktor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtRandevu;
        private System.Windows.Forms.ComboBox comboBoxBolum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTeslim;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.Label lblTc;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Label lblHastaId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListView randevuListe;
        private System.Windows.Forms.ColumnHeader Randevu_No;
        private System.Windows.Forms.ColumnHeader Bolum_Adi;
        private System.Windows.Forms.ColumnHeader Doktor_Adi;
        private System.Windows.Forms.ColumnHeader Doktor_Soyadi;
        private System.Windows.Forms.ColumnHeader Tarih;
        private System.Windows.Forms.ColumnHeader Saat;
        private System.Windows.Forms.TextBox txt_IdSil;
        private System.Windows.Forms.Label lblCeza;
        private System.Windows.Forms.Label label;
    }
}