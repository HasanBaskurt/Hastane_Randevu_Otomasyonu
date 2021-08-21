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
    public partial class Hasta_Islemleri : Form
    {
        public Hasta_Islemleri()
        {
            InitializeComponent();
        }

        // Veri Tabanı Bağlantısı
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-PC77Q2I;Initial Catalog=HastaneRandevu;Integrated Security=True");
        
        

        // Bir onceki sayfaya gelme Butonu
        private void button2_Click(object sender, EventArgs e)
        {
            Yonetici_Islem yonetici = new Yonetici_Islem();
            this.Hide();
            yonetici.Show();
        }

        // Kapatma Butonu
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        //Form Baslangic Kismi
        private void Hasta_Islemleri_Load(object sender, EventArgs e)
        {
            verilistele();
        }

        private void listele_Click(object sender, EventArgs e)
        {
            
        }

        //Listeleme Fonksiyonu
        private void verilistele()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select *From Hasta_Table", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Hasta_Id"].ToString();
                ekle.SubItems.Add(oku["Ad"].ToString());
                ekle.SubItems.Add(oku["Soyad"].ToString());
                ekle.SubItems.Add(oku["TC"].ToString());
                ekle.SubItems.Add(oku["Sifre"].ToString());
                hastaListe.Items.Add(ekle);


            }
            baglanti.Close();
        }


        // Sorgu Fonksiyonu
        public int sorgu()
        {
            int id = int.Parse(txt_IdSil.Text);
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select *From Hasta_Table where Hasta_Id=(" + id + ")", baglanti);
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

        // Ekleme Islemi
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtAd.Text != "" && txtSoyad.Text != "" && txtTc.Text != "" && txtSifre.Text != "")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into Hasta_Table (Ad,Soyad,TC,Sifre) values ('" + txtAd.Text.ToString() + "','" + txtSoyad.Text.ToString() + "','" + txtTc.Text.ToString() + "','" + txtSifre.Text.ToString() + "')", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                hastaListe.Items.Clear(); // ListBox Temizle
                verilistele();           // Listeleme Islemi
                txtAd.Clear();
                txtSoyad.Clear();
                txtTc.Clear();
                txtSifre.Clear();
                MessageBox.Show("Kayıt Eklendi ");
            }

            else
                MessageBox.Show("Lütfen gerekli alanları doldurunuz !");

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
                    SqlCommand komut = new SqlCommand("Delete From Hasta_Table where Hasta_Id =(" + id + ")", baglanti);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    hastaListe.Items.Clear(); // ListBox Temizle
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


        //Guncelleme Islemi
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if(id!=0)
            {
                if (txt_gAd.Text != "" && txt_gSoyad.Text != "" && txt_gTc.Text != "" && txt_gSifre.Text != "")
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("update Hasta_Table set Ad ='" + txt_gAd.Text.ToString() + "',Soyad ='" + txt_gSoyad.Text.ToString() + "',TC ='" + txt_gTc.Text.ToString() + "',Sifre ='" + txt_gSifre.Text.ToString() + "' where Hasta_Id=" + id + "", baglanti);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    hastaListe.Items.Clear(); // ListBox Temizle
                    verilistele();           // Listeleme Islemi
                    txt_gAd.Clear();
                    txt_gSoyad.Clear();
                    txt_gTc.Clear();
                    txt_gSifre.Clear();
                    MessageBox.Show("Kayıt güncellendi");
                    id = 0;
                }
                else
                    MessageBox.Show("Lütfen gerekli alanları doldurunuz !");
            }
            else
                MessageBox.Show("Lütfen listeden güncelemek istediğiniz hastayı seçiniz !");
        }



        //Lİsteden Secme Islemi
        int id = 0;
        private void hastaListe_MouseClick(object sender, MouseEventArgs e)
        {
            id = int.Parse(hastaListe.SelectedItems[0].SubItems[0].Text);
            txt_gAd.Text = hastaListe.SelectedItems[0].SubItems[1].Text;
            txt_gSoyad.Text = hastaListe.SelectedItems[0].SubItems[2].Text;
            txt_gTc.Text = hastaListe.SelectedItems[0].SubItems[3].Text;
            txt_gSifre.Text = hastaListe.SelectedItems[0].SubItems[4].Text;
        }

        // Harf girisi engelleme
        private void txtTc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtSifre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txt_IdSil_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txt_gTc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txt_gSifre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }


        // Sayi girisi engelleme
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

        private void txt_gSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }
    }
}
