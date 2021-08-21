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
    public partial class YoneticiGiris : Form
    {
        public YoneticiGiris()
        {
            InitializeComponent();
        }

        // Veri Tabanı Bağlantısı
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-PC77Q2I;Initial Catalog=HastaneRandevu;Integrated Security=True");


        private void pictureBox3_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GirisFormu baslangic = new GirisFormu(); //Geçiş yapılacak formdan nesne oluşturuldu.
            this.Hide();                                  //Şuan ki form ekranı kapatıldı.
            baslangic.Show();
        }

        // Sorgu Fonksiyonu
        public int sorgu()
        {
            
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select *From Yonetici_Table where TC=(" + txtGorevliTc.Text.ToString() + ") and Sifre=(" + txtGorevliSifre.Text.ToString() + ")", baglanti);
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

        // Giris ıslemi
        private void btnYoneticiGiris_Click(object sender, EventArgs e)
        {
            if (txtGorevliTc.Text != "" && txtGorevliSifre.Text != "") // Textler boş olup olmadığı kontrol edildi
            {
                

                if (sorgu() == 1) //Girilen değerler veri tabanındaki tabloda mevcut ise işlem gerçekleşti
                {
                    MessageBox.Show("Giriş başarılı");
                    Yonetici_Islem gorevliGecis = new Yonetici_Islem(); // Gorevli geçiş formundan nesne üretildi
                    this.Hide();                                           // Bulunduğumuz fonksiyon kapatıldı
                    gorevliGecis.Show();                                  // Oluşturulan nesnenin formu açıldı
                }

                else
                {
                    MessageBox.Show("Hatalı giriş");
                }

            }

            else
            {
                MessageBox.Show("Gerekli alanları doldurunuz !");
            }
        }

        private void YoneticiGiris_Load(object sender, EventArgs e)
        {

        }

        // Veri gizleme
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Checked) //CheckBox seçili ise parolayı goster text e gizle yaz
            {
                txtGorevliSifre.UseSystemPasswordChar = true;
                checkBox1.Text = "Gizle";
            }
            else if (checkBox1.CheckState == CheckState.Unchecked) //CheckBox seçili değil ise parolayı gizle ve text e göster yaz
            {
                txtGorevliSifre.UseSystemPasswordChar = false;
                checkBox1.Text = "Göster";
            }
        }


        //Harf Girisi Engelleme
        private void txtGorevliTc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtGorevliSifre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
