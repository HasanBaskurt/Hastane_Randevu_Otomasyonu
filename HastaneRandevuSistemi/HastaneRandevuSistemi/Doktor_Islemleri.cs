using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HastaneRandevuSistemi
{
    public partial class Doktor_Islemleri : Form
    {
        // Veri Tabanı Bağlantısı
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-PC77Q2I;Initial Catalog=HastaneRandevu;Integrated Security=True");

        public Doktor_Islemleri()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Yonetici_Islem yonetici = new Yonetici_Islem();
            this.Hide();
            yonetici.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void Doktor_Islemleri_Load(object sender, EventArgs e)
        {
            verilistele();
            lblListe.Text = "DOKTOR BİLGİ LİSTESİ";
            lblBilgi.ForeColor = Color.Yellow;        
            lblMuayene.ForeColor = Color.White;
        }



        // Muayene Listele
        private void muayeneListele()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select r.Randevu_No,h.Ad,h.Soyad,h.TC,r.Tarih,r.Saat,r.Geldi_mi,r.Aciklama from ((Doktor_Table d inner join Randevu_Table r on d.Doktor_Id=r.Doktor_Id) inner join Hasta_Table h on h.Hasta_Id=r.Hasta_Id) where r.Doktor_Id='"+ id + "' ", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            doktorListe.Clear();

            doktorListe.Columns.Add("Randevu_No",100);
            doktorListe.Columns.Add("Hasta_Ad", 100);
            doktorListe.Columns.Add("Hasta_Soyad", 100);
            doktorListe.Columns.Add("TC", 100);
            doktorListe.Columns.Add("Tarih", 100);
            doktorListe.Columns.Add("Saat", 100);
            doktorListe.Columns.Add("Geldi_mi", 100);
            doktorListe.Columns.Add("Aciklama", 100);
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Randevu_No"].ToString();
                ekle.SubItems.Add(oku["Ad"].ToString());
                ekle.SubItems.Add(oku["Soyad"].ToString());
                ekle.SubItems.Add(oku["TC"].ToString());
                ekle.SubItems.Add(oku["Tarih"].ToString());
                ekle.SubItems.Add(oku["Saat"].ToString());
                ekle.SubItems.Add(oku["Geldi_mi"].ToString());
                ekle.SubItems.Add(oku["Aciklama"].ToString());
                doktorListe.Items.Add(ekle);


            }
            baglanti.Close();
        }
        //Listeleme Fonksiyonu
        private void verilistele()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select d.Doktor_Id,d.Ad,d.Soyad,d.TC,b.Bolum_Ad from (Doktor_Table d inner join Bolum_Table b on d.Bolum_Id=b.Bolum_Id)", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            doktorListe.Clear();

            doktorListe.Columns.Add("Doktor_Id", 100);
            doktorListe.Columns.Add("Ad", 100);
            doktorListe.Columns.Add("Soyad", 100);
            doktorListe.Columns.Add("TC", 100);
            doktorListe.Columns.Add("Bolum_Ad", 100);
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Doktor_Id"].ToString();
                ekle.SubItems.Add(oku["Ad"].ToString());
                ekle.SubItems.Add(oku["Soyad"].ToString());
                ekle.SubItems.Add(oku["TC"].ToString());
                ekle.SubItems.Add(oku["Bolum_Ad"].ToString());
                doktorListe.Items.Add(ekle);


            }
            baglanti.Close();
        }

        // Sorgu Fonksiyonu
        public int sorgu()
        {
            int id = int.Parse(txt_IdSil.Text);
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select *From Doktor_Table where Doktor_Id=(" + id + ")", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            int sonuc = 0;
            int sayac = 0;
            while (oku.Read())
            {
                sayac++;

            }


            if (sayac > 0)
            {
                sonuc = 1;
            }
            baglanti.Close();
            return sonuc;

        }

        int deger;
        //Bolum Id
        private int bolumId(string combo)
        {
            
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select *From Bolum_Table where Bolum_Ad='" + combo + "'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {

                deger = int.Parse(oku["Bolum_Id"].ToString());
            }
            baglanti.Close();
            return deger;
        }
        //Ekleme Islemi
        int veri;
        private void btnEkle_Click(object sender, EventArgs e)
        {
            
            if (txtAd.Text != "" && txtSoyad.Text != "" && txtTc.Text != "" && comboBoxBolum.Text != "")
            {
                veri = bolumId(comboBoxBolum.Text);
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into Doktor_Table (Ad,Soyad,TC,Bolum_Id) values ('" + txtAd.Text.ToString() + "','" + txtSoyad.Text.ToString() + "','" + txtTc.Text.ToString() + "','" + veri + "')", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                doktorListe.Items.Clear(); // ListBox Temizle
                verilistele();           // Listeleme Islemi-
                txtAd.Clear();
                txtSoyad.Clear();
                txtTc.Clear();
                comboBoxBolum.Text = null;
                MessageBox.Show("Kayıt Eklendi ");
            }

            else
                MessageBox.Show("Lütfen gerekli alanları doldurunuz !");
        }


        // sayı engelleme
        private void txtAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void txtSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void txt_gAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void txt_gSayfa_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }


        //Harf girisi engelleme
        private void txtTc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txt_gYazar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txt_IdSil_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }


        //Silme Islemi
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (txt_IdSil.Text != "")
            {
                int id = int.Parse(txt_IdSil.Text);
                if (sorgu() == 1)
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("Delete From Doktor_Table where Doktor_Id =(" + id + ")", baglanti);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    doktorListe.Items.Clear(); // ListBox Temizle
                    verilistele();           // Listeleme Islemi
                    txt_IdSil.Clear();
                    MessageBox.Show("Kayıt silindi");

                }
                else
                    MessageBox.Show("Kayıt bulunamadı");
            }
            else
                MessageBox.Show("Lütfen id giriniz !");
        }


        //Listeden Secme Islemi
        int id = 0;
        private void doktorListe_MouseClick(object sender, MouseEventArgs e)
        {
            if(lblListe.Text != "MUAYENE BİLGİ LİSTESİ")
            {
                id = int.Parse(doktorListe.SelectedItems[0].SubItems[0].Text);
                txt_gAd.Text = doktorListe.SelectedItems[0].SubItems[1].Text;
                txt_gSoyad.Text = doktorListe.SelectedItems[0].SubItems[2].Text;
                txt_gTc.Text = doktorListe.SelectedItems[0].SubItems[3].Text;
                comboBox_gBolum.Text = doktorListe.SelectedItems[0].SubItems[4].Text;
            }
            
        }

        //Guncelleme Islemi
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            veri = bolumId(comboBox_gBolum.Text);
            if (id != 0)
            {
                if (txt_gAd.Text != "" && txt_gSoyad.Text != "" && txt_gTc.Text != "" && comboBox_gBolum.Text != "")
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("update Doktor_Table set Ad ='" + txt_gAd.Text.ToString() + "',Soyad ='" + txt_gSoyad.Text.ToString() + "',TC ='" + txt_gTc.Text.ToString() + "',Bolum_Id ='" + veri + "' where Doktor_Id=" + id + "", baglanti);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    doktorListe.Items.Clear(); // ListBox Temizle
                    verilistele();           // Listeleme Islemi
                    txt_gAd.Clear();
                    txt_gSoyad.Clear();
                    txt_gTc.Clear();
                    comboBox_gBolum.Text = null;
                    MessageBox.Show("Kayıt güncellendi");
                    id = 0;
                }
                else
                    MessageBox.Show("Lütfen gerekli alanları doldurunuz !");
            }
            else
                MessageBox.Show("Lütfen listeden güncelemek istediğiniz doktoru seçiniz !");
        }


        //Muayene bilgisi click
        private void pictureBoxIadeBilgi_MouseClick(object sender, MouseEventArgs e)
        {

        }

        //Doktor bilgi click
        private void pictureBoxKitapBilgi_Click(object sender, EventArgs e)
        {
            verilistele();
            lblListe.Text = "DOKTOR BİLGİ LİSTESİ";     // Labeldaki yazı değişti
            lblBilgi.ForeColor = Color.Yellow;        // İade label i pasif rengi aldı
            lblMuayene.ForeColor = Color.White;
            lblBilgilendirme.Text = "Not: Muayene bilgisini öğrenmek istediğiniz doktorun listeden üzerine tıklayıp iade bilgisi butonuna basınız.";
        }

        private void pictureBoxMuayeneBilgi_Click(object sender, EventArgs e)
        {
            if (id != 0)
            {
                muayeneListele();
                lblListe.Text = "MUAYENE BİLGİ LİSTESİ";
                lblBilgi.ForeColor = Color.White;
                lblMuayene.ForeColor = Color.Yellow;
                lblBilgilendirme.Text = "Not: Doktor bilgilerine geri dönmek için doktor bilgisi butonuna basınız.";

            }
            
            else
                MessageBox.Show("Lütfen doktor seçiniz !");

            
        }
    }
}


