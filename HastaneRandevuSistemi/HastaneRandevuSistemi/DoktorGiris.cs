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
    public partial class DoktorGiris : Form
    {
        
        public DoktorGiris()
        {
            InitializeComponent();
        }

        // Veri Tabanı Bağlantısı
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-PC77Q2I;Initial Catalog=HastaneRandevu;Integrated Security=True");

        // Sorgu Fonksiyonu
        public int sorgu()
        {

            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select *From Doktor_Table where TC=(" + txtTc.Text.ToString() + ") and Sifre=(" + txtSifre.Text.ToString() + ")", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            int sonuc = 0;
            int sayac = 0;
            while (oku.Read())
            {

                sayac++;
                lblDoktorId.Text = oku["Doktor_Id"].ToString();
            }


            if (sayac > 0)
            {
                sonuc = 1;
            }
            baglanti.Close();
            return sonuc;

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GirisFormu grs = new GirisFormu();
            this.Hide();
            grs.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtTc.Text != "" && txtSifre.Text != "") // Textler boş olup olmadığı kontrol edildi
            {


                if (sorgu() == 1) //Girilen değerler veri tabanındaki tabloda mevcut ise işlem gerçekleşti
                {
                    MessageBox.Show("Giriş başarılı");
                    DoktorRandevuIslem grs = new DoktorRandevuIslem(); // Gorevli geçiş formundan nesne üretildi
                    grs.lblDoktorId.Text = lblDoktorId.Text;
                    this.Hide();
                    grs.Show();                               // Oluşturulan nesnenin formu açıldı
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

        //Harf girişi engelleme
        private void txtTc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtSifre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void DoktorGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
