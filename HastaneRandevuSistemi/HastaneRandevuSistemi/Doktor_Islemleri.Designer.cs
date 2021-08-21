
namespace HastaneRandevuSistemi
{
    partial class Doktor_Islemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Doktor_Islemleri));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSil = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_IdSil = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_gBolum = new System.Windows.Forms.ComboBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBoxBolum = new System.Windows.Forms.ComboBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtTc = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_gTc = new System.Windows.Forms.TextBox();
            this.txt_gSoyad = new System.Windows.Forms.TextBox();
            this.txt_gAd = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.lblBilgilendirme = new System.Windows.Forms.Label();
            this.lblBilgi = new System.Windows.Forms.Label();
            this.pictureBoxDoktorBilgi = new System.Windows.Forms.PictureBox();
            this.lblMuayene = new System.Windows.Forms.Label();
            this.pictureBoxMuayeneBilgi = new System.Windows.Forms.PictureBox();
            this.lblListe = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.doktorListe = new System.Windows.Forms.ListView();
            this.Doktor_Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Soyad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Bolum_Ad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.lblOgrenci = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDoktorBilgi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMuayeneBilgi)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkRed;
            this.panel2.Controls.Add(this.btnSil);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txt_IdSil);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(28, 456);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(329, 123);
            this.panel2.TabIndex = 41;
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.FloralWhite;
            this.btnSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.ForeColor = System.Drawing.Color.Black;
            this.btnSil.Location = new System.Drawing.Point(241, 64);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 24);
            this.btnSil.TabIndex = 12;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(3, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 20);
            this.label8.TabIndex = 3;
            this.label8.Text = "Doktor Id : ";
            // 
            // txt_IdSil
            // 
            this.txt_IdSil.Location = new System.Drawing.Point(124, 66);
            this.txt_IdSil.Name = "txt_IdSil";
            this.txt_IdSil.Size = new System.Drawing.Size(100, 22);
            this.txt_IdSil.TabIndex = 2;
            this.txt_IdSil.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_IdSil_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Yellow;
            this.label7.Location = new System.Drawing.Point(104, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(168, 29);
            this.label7.TabIndex = 1;
            this.label7.Text = "DOKTOR SİL";
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(124, 147);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(592, 36);
            this.label13.TabIndex = 29;
            this.label13.Text = "Not: Güncellemek istediğiniz doktorun listeden üzerine tıklayınız .\r\n \r\n\r\n";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(490, 44);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 20);
            this.label12.TabIndex = 28;
            this.label12.Text = "TC";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(633, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 20);
            this.label10.TabIndex = 27;
            this.label10.Text = "Bölüm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(303, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 20);
            this.label5.TabIndex = 26;
            this.label5.Text = "Soyad";
            // 
            // comboBox_gBolum
            // 
            this.comboBox_gBolum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_gBolum.FormattingEnabled = true;
            this.comboBox_gBolum.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.comboBox_gBolum.Items.AddRange(new object[] {
            "Nöroloji",
            "Kardiyoloji",
            "Göz",
            "Dahiliye",
            "Cildiye"});
            this.comboBox_gBolum.Location = new System.Drawing.Point(616, 76);
            this.comboBox_gBolum.Name = "comboBox_gBolum";
            this.comboBox_gBolum.Size = new System.Drawing.Size(100, 24);
            this.comboBox_gBolum.TabIndex = 25;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.FloralWhite;
            this.btnGuncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.ForeColor = System.Drawing.Color.Black;
            this.btnGuncelle.Location = new System.Drawing.Point(377, 113);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(92, 31);
            this.btnGuncelle.TabIndex = 24;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(133, 44);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 20);
            this.label11.TabIndex = 19;
            this.label11.Text = "Ad ";
            // 
            // comboBoxBolum
            // 
            this.comboBoxBolum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBolum.FormattingEnabled = true;
            this.comboBoxBolum.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.comboBoxBolum.Items.AddRange(new object[] {
            "Nöroloji",
            "Kardiyoloji",
            "Göz",
            "Dahiliye",
            "Cildiye"});
            this.comboBoxBolum.Location = new System.Drawing.Point(154, 208);
            this.comboBoxBolum.Name = "comboBoxBolum";
            this.comboBoxBolum.Size = new System.Drawing.Size(100, 24);
            this.comboBoxBolum.TabIndex = 26;
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.OldLace;
            this.btnEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.ForeColor = System.Drawing.Color.Black;
            this.btnEkle.Location = new System.Drawing.Point(170, 254);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 27);
            this.btnEkle.TabIndex = 11;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtTc
            // 
            this.txtTc.Location = new System.Drawing.Point(154, 167);
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(100, 22);
            this.txtTc.TabIndex = 9;
            this.txtTc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTc_KeyPress);
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(154, 119);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(100, 22);
            this.txtSoyad.TabIndex = 8;
            this.txtSoyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoyad_KeyPress);
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(154, 71);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 22);
            this.txtAd.TabIndex = 6;
            this.txtAd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAd_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(94, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "TC :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(63, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Bölüm :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(63, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Soyad :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.comboBoxBolum);
            this.panel1.Controls.Add(this.btnEkle);
            this.panel1.Controls.Add(this.txtTc);
            this.panel1.Controls.Add(this.txtSoyad);
            this.panel1.Controls.Add(this.txtAd);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(28, 109);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(329, 316);
            this.panel1.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(87, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ad :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(86, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "DOKTOR EKLE";
            // 
            // txt_gTc
            // 
            this.txt_gTc.Location = new System.Drawing.Point(461, 76);
            this.txt_gTc.Name = "txt_gTc";
            this.txt_gTc.Size = new System.Drawing.Size(100, 22);
            this.txt_gTc.TabIndex = 16;
            this.txt_gTc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_gYazar_KeyPress);
            // 
            // txt_gSoyad
            // 
            this.txt_gSoyad.Location = new System.Drawing.Point(290, 76);
            this.txt_gSoyad.Name = "txt_gSoyad";
            this.txt_gSoyad.Size = new System.Drawing.Size(100, 22);
            this.txt_gSoyad.TabIndex = 15;
            this.txt_gSoyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_gSayfa_KeyPress);
            // 
            // txt_gAd
            // 
            this.txt_gAd.Location = new System.Drawing.Point(102, 76);
            this.txt_gAd.Name = "txt_gAd";
            this.txt_gAd.Size = new System.Drawing.Size(100, 22);
            this.txt_gAd.TabIndex = 14;
            this.txt_gAd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_gAd_KeyPress);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.comboBox_gBolum);
            this.panel3.Controls.Add(this.btnGuncelle);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.txt_gTc);
            this.panel3.Controls.Add(this.txt_gSoyad);
            this.panel3.Controls.Add(this.txt_gAd);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Location = new System.Drawing.Point(384, 396);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(788, 183);
            this.panel3.TabIndex = 42;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.Yellow;
            this.label9.Location = new System.Drawing.Point(316, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(266, 29);
            this.label9.TabIndex = 1;
            this.label9.Text = "DOKTOR GÜNCELLE";
            // 
            // lblBilgilendirme
            // 
            this.lblBilgilendirme.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBilgilendirme.ForeColor = System.Drawing.Color.Khaki;
            this.lblBilgilendirme.Location = new System.Drawing.Point(60, 226);
            this.lblBilgilendirme.Name = "lblBilgilendirme";
            this.lblBilgilendirme.Size = new System.Drawing.Size(733, 55);
            this.lblBilgilendirme.TabIndex = 0;
            this.lblBilgilendirme.Text = "Not: Muayene bilgisini öğrenmek istediğiniz doktorun listeden üzerine tıklayıp ia" +
    "de bilgisi butonuna basınız.";
            // 
            // lblBilgi
            // 
            this.lblBilgi.AutoSize = true;
            this.lblBilgi.BackColor = System.Drawing.Color.Transparent;
            this.lblBilgi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBilgi.ForeColor = System.Drawing.Color.White;
            this.lblBilgi.Location = new System.Drawing.Point(61, 40);
            this.lblBilgi.Name = "lblBilgi";
            this.lblBilgi.Size = new System.Drawing.Size(110, 18);
            this.lblBilgi.TabIndex = 6;
            this.lblBilgi.Text = "Doktor Bilgisi";
            // 
            // pictureBoxDoktorBilgi
            // 
            this.pictureBoxDoktorBilgi.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxDoktorBilgi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxDoktorBilgi.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDoktorBilgi.Image")));
            this.pictureBoxDoktorBilgi.Location = new System.Drawing.Point(87, 3);
            this.pictureBoxDoktorBilgi.Name = "pictureBoxDoktorBilgi";
            this.pictureBoxDoktorBilgi.Size = new System.Drawing.Size(41, 37);
            this.pictureBoxDoktorBilgi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDoktorBilgi.TabIndex = 5;
            this.pictureBoxDoktorBilgi.TabStop = false;
            this.pictureBoxDoktorBilgi.Click += new System.EventHandler(this.pictureBoxKitapBilgi_Click);
            // 
            // lblMuayene
            // 
            this.lblMuayene.AutoSize = true;
            this.lblMuayene.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMuayene.ForeColor = System.Drawing.Color.White;
            this.lblMuayene.Location = new System.Drawing.Point(627, 40);
            this.lblMuayene.Name = "lblMuayene";
            this.lblMuayene.Size = new System.Drawing.Size(125, 18);
            this.lblMuayene.TabIndex = 4;
            this.lblMuayene.Text = "Muayene Bilgisi";
            // 
            // pictureBoxMuayeneBilgi
            // 
            this.pictureBoxMuayeneBilgi.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxMuayeneBilgi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxMuayeneBilgi.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMuayeneBilgi.Image")));
            this.pictureBoxMuayeneBilgi.Location = new System.Drawing.Point(654, 3);
            this.pictureBoxMuayeneBilgi.Name = "pictureBoxMuayeneBilgi";
            this.pictureBoxMuayeneBilgi.Size = new System.Drawing.Size(41, 37);
            this.pictureBoxMuayeneBilgi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMuayeneBilgi.TabIndex = 3;
            this.pictureBoxMuayeneBilgi.TabStop = false;
            this.pictureBoxMuayeneBilgi.Click += new System.EventHandler(this.pictureBoxMuayeneBilgi_Click);
            this.pictureBoxMuayeneBilgi.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBoxIadeBilgi_MouseClick);
            // 
            // lblListe
            // 
            this.lblListe.AutoSize = true;
            this.lblListe.BackColor = System.Drawing.Color.Transparent;
            this.lblListe.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblListe.ForeColor = System.Drawing.Color.Yellow;
            this.lblListe.Location = new System.Drawing.Point(255, 22);
            this.lblListe.Name = "lblListe";
            this.lblListe.Size = new System.Drawing.Size(297, 29);
            this.lblListe.TabIndex = 1;
            this.lblListe.Text = "DOKTOR BİLGİ LİSTESİ";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Blue;
            this.panel4.Controls.Add(this.doktorListe);
            this.panel4.Controls.Add(this.lblBilgilendirme);
            this.panel4.Controls.Add(this.lblBilgi);
            this.panel4.Controls.Add(this.pictureBoxDoktorBilgi);
            this.panel4.Controls.Add(this.lblMuayene);
            this.panel4.Controls.Add(this.pictureBoxMuayeneBilgi);
            this.panel4.Controls.Add(this.lblListe);
            this.panel4.Location = new System.Drawing.Point(384, 109);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(788, 281);
            this.panel4.TabIndex = 43;
            // 
            // doktorListe
            // 
            this.doktorListe.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Doktor_Id,
            this.Ad,
            this.Soyad,
            this.TC,
            this.Bolum_Ad});
            this.doktorListe.HideSelection = false;
            this.doktorListe.Location = new System.Drawing.Point(64, 73);
            this.doktorListe.Name = "doktorListe";
            this.doktorListe.Size = new System.Drawing.Size(688, 141);
            this.doktorListe.TabIndex = 7;
            this.doktorListe.UseCompatibleStateImageBehavior = false;
            this.doktorListe.View = System.Windows.Forms.View.Details;
            this.doktorListe.MouseClick += new System.Windows.Forms.MouseEventHandler(this.doktorListe_MouseClick);
            // 
            // Doktor_Id
            // 
            this.Doktor_Id.Text = "Doktor_Id";
            this.Doktor_Id.Width = 100;
            // 
            // Ad
            // 
            this.Ad.Text = "Ad";
            this.Ad.Width = 100;
            // 
            // Soyad
            // 
            this.Soyad.Text = "Soyad";
            this.Soyad.Width = 100;
            // 
            // TC
            // 
            this.TC.Text = "TC";
            this.TC.Width = 100;
            // 
            // Bolum_Ad
            // 
            this.Bolum_Ad.Text = "Bolum_Id";
            this.Bolum_Ad.Width = 100;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(1128, 22);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(44, 54);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 39;
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
            this.button2.Location = new System.Drawing.Point(28, 40);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 34);
            this.button2.TabIndex = 38;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblOgrenci
            // 
            this.lblOgrenci.AutoSize = true;
            this.lblOgrenci.BackColor = System.Drawing.Color.Transparent;
            this.lblOgrenci.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOgrenci.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblOgrenci.Location = new System.Drawing.Point(476, 40);
            this.lblOgrenci.Name = "lblOgrenci";
            this.lblOgrenci.Size = new System.Drawing.Size(330, 36);
            this.lblOgrenci.TabIndex = 37;
            this.lblOgrenci.Text = "DOKTOR  İŞLEMLERİ";
            // 
            // Doktor_Islemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblOgrenci);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Doktor_Islemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doktor_Islemleri";
            this.Load += new System.EventHandler(this.Doktor_Islemleri_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDoktorBilgi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMuayeneBilgi)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_IdSil;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_gBolum;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBoxBolum;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtTc;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_gTc;
        private System.Windows.Forms.TextBox txt_gSoyad;
        private System.Windows.Forms.TextBox txt_gAd;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblBilgilendirme;
        private System.Windows.Forms.Label lblBilgi;
        private System.Windows.Forms.PictureBox pictureBoxDoktorBilgi;
        private System.Windows.Forms.Label lblMuayene;
        private System.Windows.Forms.PictureBox pictureBoxMuayeneBilgi;
        private System.Windows.Forms.Label lblListe;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblOgrenci;
        private System.Windows.Forms.ListView doktorListe;
        private System.Windows.Forms.ColumnHeader Doktor_Id;
        private System.Windows.Forms.ColumnHeader Ad;
        private System.Windows.Forms.ColumnHeader Soyad;
        private System.Windows.Forms.ColumnHeader TC;
        private System.Windows.Forms.ColumnHeader Bolum_Ad;
    }
}