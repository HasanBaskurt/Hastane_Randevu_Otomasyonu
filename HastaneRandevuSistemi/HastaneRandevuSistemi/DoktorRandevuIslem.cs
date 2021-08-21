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
    public partial class DoktorRandevuIslem : Form
    {
        // Veri Tabanı Bağlantısı
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-PC77Q2I;Initial Catalog=HastaneRandevu;Integrated Security=True");

        public DoktorRandevuIslem()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DoktorGiris grs = new DoktorGiris();
            this.Hide();
            grs.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        //Form Acildiginda
        private void DoktorRandevuIslem_Load(object sender, EventArgs e)
        {
            verilistele();
            randevuListele();
        }


        //Veri Listeleme Fonksiyonu
        private void verilistele()
        {
            int id = int.Parse(lblDoktorId.Text.ToString());
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select d.Ad,d.Soyad,b.Bolum_Ad,d.TC,d.Sifre from ( Bolum_Table b inner join Doktor_Table d on d.Bolum_Id=b.Bolum_Id)where d.Doktor_Id = '" + id + "'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {

                lblAd.Text = oku["Ad"].ToString();
                lblSoyad.Text = oku["Soyad"].ToString();
                lblBolum.Text = oku["Bolum_Ad"].ToString();
                lblTc.Text = oku["TC"].ToString();
                lblSifre.Text = oku["Sifre"].ToString();
                lblDoktor.Text = "Hoşgeldin " + oku["Ad"].ToString();
            }
            baglanti.Close();
        }


        //Randevu Listeleme
        private void randevuListele()
        {
            int id = int.Parse(lblDoktorId.Text.ToString());
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select r.Randevu_No,h.Ad,h.Soyad,h.TC,r.Tarih,r.Saat,r.Geldi_mi,r.Aciklama from (Hasta_Table h inner join Randevu_Table r on h.Hasta_Id=r.Hasta_Id) where r.Doktor_Id = '" + id + "'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                string kontrol;
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Randevu_No"].ToString();
                ekle.SubItems.Add(oku["Ad"].ToString());
                ekle.SubItems.Add(oku["Soyad"].ToString());
                ekle.SubItems.Add(oku["TC"].ToString());
                ekle.SubItems.Add(oku["Tarih"].ToString());
                ekle.SubItems.Add(oku["Saat"].ToString());
                if (oku["Geldi_mi"].ToString() == "True")
                    kontrol = "Geldi";
                else
                    kontrol = "Gelmedi !";
                ekle.SubItems.Add(kontrol);
                ekle.SubItems.Add(oku["Aciklama"].ToString());
                randevuListe.Items.Add(ekle);
            }
            baglanti.Close();
        }

        int randevuNo;
        private void randevuListe_MouseClick(object sender, MouseEventArgs e)
        {
            string kontrol;

            if (randevuListe.SelectedItems[0].SubItems[6].Text == "Geldi")
                kontrol = "true";
            else
                kontrol = "false";
            randevuNo = int.Parse(randevuListe.SelectedItems[0].SubItems[0].Text);
            lblAdSoyad.Text = randevuListe.SelectedItems[0].SubItems[1].Text + " " + randevuListe.SelectedItems[0].SubItems[2].Text;
            lblHastaTc.Text = randevuListe.SelectedItems[0].SubItems[3].Text;
            lblTarih.Text = randevuListe.SelectedItems[0].SubItems[4].Text;
            lblSaat.Text = randevuListe.SelectedItems[0].SubItems[5].Text;
            checkBox1.Checked= bool.Parse(kontrol);
            txtAciklama.Text= randevuListe.SelectedItems[0].SubItems[7].Text;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        //Gunceleme Fonksiyonu
        private void guncelle()
        {
            string kontrol = checkBox1.Checked.ToString();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update randevu_Table set Geldi_mi='"+checkBox1.Checked.ToString()+"',Aciklama ='" + txtAciklama.Text.ToString() + "' where Randevu_No=" + randevuNo + "", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            randevuListe.Items.Clear(); // ListBox Temizle
            randevuListele();     // Listeleme Islemi
            lblAdSoyad.Text= "------";
            lblHastaTc.Text = "------";
            lblTarih.Text = "------";
            lblSaat.Text = "------";
            checkBox1.Checked = false;
            txtAciklama.Text = "";
            randevuNo = 0;
        }
        private void btnGorevliGiris_Click(object sender, EventArgs e)
        {
            
            if (randevuNo != 0)
            {
                if (checkBox1.Checked == true )
                {
                    if(txtAciklama.Text != "")
                    {
                        guncelle();
                        MessageBox.Show("Kayıt eklendi");
                    }
                    else
                    {
                        MessageBox.Show("Hasta geldiği için lütfen açıklama ekleyiniz");
                    }
                    
                }
                else if(checkBox1.Checked == false)
                {
                    if(txtAciklama.Text == "")
                    {
                        guncelle();
                        MessageBox.Show("Kayıt eklendi");
                    }
                    else
                    {
                        MessageBox.Show("Hasta gelmediği için lütfen açıklama eklemeyiniz !");
                    }
                }
            }
            else
                MessageBox.Show("Lütfen listeden muayene yapmak istediğiniz hastayı seçiniz !");
        }
    }
}
