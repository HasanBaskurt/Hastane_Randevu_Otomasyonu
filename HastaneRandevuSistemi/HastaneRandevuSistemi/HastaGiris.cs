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
    
    public partial class HastaGiris : Form
    {
        public HastaGiris()
        {
            InitializeComponent();
        }

        // Veri Tabanı Bağlantısı
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-PC77Q2I;Initial Catalog=HastaneRandevu;Integrated Security=True");


        
        // Sorgu Fonksiyonu
        public int sorgu()
        {

            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select *From Hasta_Table where TC=(" + txtTc.Text.ToString() + ") and Sifre=(" + txtSifre.Text.ToString() + ")", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            int sonuc = 0;
            int sayac = 0;
            while (oku.Read())
            {
                
                sayac++;
                lblHastaId.Text= oku["Hasta_Id"].ToString();
            }


            if (sayac > 0)
            {
                sonuc = 1;
            }
            baglanti.Close();
            return sonuc;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            GirisFormu baslangic = new GirisFormu(); //Geçiş yapılacak formdan nesne oluşturuldu.
            this.Hide();                                  //Şuan ki form ekranı kapatıldı.
            baslangic.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtTc.Text != "" && txtSifre.Text != "") // Textler boş olup olmadığı kontrol edildi
            {


                if (sorgu() == 1) //Girilen değerler veri tabanındaki tabloda mevcut ise işlem gerçekleşti
                {
                    MessageBox.Show("Giriş başarılı");
                    Hasta_Randevu_Islem gorevliGecis = new Hasta_Randevu_Islem(); // Gorevli geçiş formundan nesne üretildi
                    gorevliGecis.lblHastaId.Text = lblHastaId.Text;
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

        private void HastaGiris_Load(object sender, EventArgs e)
        {

        }


        //Veri gizleme
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Checked) //CheckBox seçili ise parolayı goster text e gizle yaz
            {
                txtSifre.UseSystemPasswordChar = true;
                checkBox1.Text = "Gizle";
            }
            else if (checkBox1.CheckState == CheckState.Unchecked) //CheckBox seçili değil ise parolayı gizle ve text e göster yaz
            {
                txtSifre.UseSystemPasswordChar = false;
                checkBox1.Text = "Göster";
            }
        }

        //Harf girisi engelleme
        private void txtTc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtSifre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
