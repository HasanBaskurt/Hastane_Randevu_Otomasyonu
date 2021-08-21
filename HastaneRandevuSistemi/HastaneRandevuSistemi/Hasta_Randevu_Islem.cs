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
    public partial class Hasta_Randevu_Islem : Form
    {
        public Hasta_Randevu_Islem()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HastaGiris hasta = new HastaGiris();
            this.Hide();
            hasta.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        // Veri Tabanı Bağlantısı
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-PC77Q2I;Initial Catalog=HastaneRandevu;Integrated Security=True");

        
        //Listeleme Fonksiyonu
        private void verilistele()
        {
            int id = int.Parse(lblHastaId.Text.ToString());
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select *From Hasta_Table where Hasta_Id=(" + id + ")", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                
                lblAd.Text = oku["Ad"].ToString();
                lblSoyad.Text = oku["Soyad"].ToString();
                lblTc.Text = oku["TC"].ToString();
                lblSifre.Text = oku["Sifre"].ToString();
                lblHasta.Text="Hoşgeldin "+ oku["Ad"].ToString();
            }
            baglanti.Close();
        }


        
        //Bolum Listeleme Fonksiyonu
        private void bolumlistele()
        {
            
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select *From Bolum_Table", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                
                comboBoxBolum.Items.Add(oku["Bolum_Ad"].ToString());
            }
            baglanti.Close();
        }


        //Doktor Listeleme Fonksiyonu
       
        private void doktorlistele()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select  * From Doktor_Table where Bolum_Id='" + id+"'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                comboBoxDoktor.Items.Add(oku["Ad"].ToString()+" "+ oku["Soyad"].ToString());
                //doktorId = int.Parse(oku["Doktor_Id"].ToString());
            }
            baglanti.Close();
        }
        private void Hasta_Randevu_Islem_Load(object sender, EventArgs e)
        {
            
            lblCeza.Text = gelmeKontrolu().ToString();
            randevuListele();
            verilistele();
            bolumlistele();

        }

        private void lblHastaId_Click(object sender, EventArgs e)
        {

        }


        //Bolum tiklama 
        int id;
        private void comboBoxBolum_MouseClick(object sender, MouseEventArgs e)
        {
            

        }


        //ComboBox secme
        private void comboBoxBolum_SelectedIndexChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select *From Bolum_Table where Bolum_Ad='" + comboBoxBolum.Text + "'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {

                id = int.Parse(oku["Bolum_Id"].ToString());
            }
            baglanti.Close();
            comboBoxDoktor.Items.Clear();
            doktorlistele();

            
                
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtSaat.Text = "";
            txtSaat.Text = btn1.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtSaat.Text = "";
            txtSaat.Text = btn2.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtSaat.Text = "";
            txtSaat.Text = btn3.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtSaat.Text = "";
            txtSaat.Text = btn4.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtSaat.Text = "";
            txtSaat.Text = btn5.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtSaat.Text = "";
            txtSaat.Text = btn6.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtSaat.Text = "";
            txtSaat.Text = btn7.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtSaat.Text = "";
            txtSaat.Text = btn8.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtSaat.Text = "";
            txtSaat.Text = btn9.Text;
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            txtSaat.Text = "";
            txtSaat.Text = btn10.Text;
        }

        private void btn11_Click(object sender, EventArgs e)
        {
            txtSaat.Text = "";
            txtSaat.Text = btn11.Text;
        }

        private void btn12_Click(object sender, EventArgs e)
        {
            txtSaat.Text = "";
            txtSaat.Text = btn12.Text;
        }

        private void btn13_Click(object sender, EventArgs e)
        {
            txtSaat.Text = "";
            txtSaat.Text = btn13.Text;
        }

        private void btn14_Click(object sender, EventArgs e)
        {
            txtSaat.Text = "";
            txtSaat.Text = btn14.Text;
        }

        private void btn15_Click(object sender, EventArgs e)
        {
            txtSaat.Text = "";
            txtSaat.Text = btn15.Text;
        }

        private void btn16_Click(object sender, EventArgs e)
        {
            txtSaat.Text = "";
            txtSaat.Text = btn16.Text;
        }


        //Button renklendirme fonksiyonu
        private void butonRenk()
        {
            //renklendirme
            btn1.BackColor = Color.Lime; btn2.BackColor = Color.Lime; btn3.BackColor = Color.Lime; btn4.BackColor = Color.Lime;
            btn5.BackColor = Color.Lime; btn6.BackColor = Color.Lime; btn7.BackColor = Color.Lime; btn8.BackColor = Color.Lime;
            btn9.BackColor = Color.Lime; btn10.BackColor = Color.Lime; btn11.BackColor = Color.Lime; btn12.BackColor = Color.Lime;
            btn13.BackColor = Color.Lime; btn14.BackColor = Color.Lime; btn15.BackColor = Color.Lime; btn16.BackColor = Color.Lime;

            // enabled kontrol
            btn1.Enabled = true; btn2.Enabled = true; btn3.Enabled = true; btn4.Enabled = true;
            btn5.Enabled = true; btn6.Enabled = true; btn7.Enabled = true; btn8.Enabled = true;
            btn9.Enabled = true; btn10.Enabled = true; btn11.Enabled = true; btn12.Enabled = true;
            btn13.Enabled = true; btn14.Enabled = true; btn15.Enabled = true; btn16.Enabled = true;

        }

        // Saat doluluğu kontrolu
        private void saatKontrolu(DateTime tarih)
        {
            string saatsizTarih;

            string[] splittedText = tarih.ToString().Split(' ');
            saatsizTarih = splittedText[0];
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from Randevu_Table where Doktor_Id='"+doktorId+"' and Tarih='"+saatsizTarih+"' ", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                
                if (oku["Saat"].ToString() == btn1.Text)
                {
                    btn1.BackColor = Color.Gray;
                    btn1.Enabled = false;
                }
                    

                else if (oku["Saat"].ToString() == btn2.Text)
                {
                    btn2.BackColor = Color.Gray;
                    btn2.Enabled = false;
                }

                else if (oku["Saat"].ToString() == btn3.Text)
                {
                    btn3.BackColor = Color.Gray;
                    btn3.Enabled = false;
                }

                else if (oku["Saat"].ToString() == btn4.Text)
                {
                    btn4.BackColor = Color.Gray;
                    btn4.Enabled = false;
                }

                else if (oku["Saat"].ToString() == btn5.Text)
                {
                    btn5.BackColor = Color.Gray;
                    btn5.Enabled = false;
                }

                else if (oku["Saat"].ToString() == btn6.Text)
                {
                    btn6.BackColor = Color.Gray;
                    btn6.Enabled = false;
                }

                else if (oku["Saat"].ToString() == btn7.Text)
                {
                    btn7.BackColor = Color.Gray;
                    btn7.Enabled = false;
                }

                else if (oku["Saat"].ToString() == btn8.Text)
                {
                    btn8.BackColor = Color.Gray;
                    btn8.Enabled = false;
                }

                else if (oku["Saat"].ToString() == btn9.Text)
                {
                    btn9.BackColor = Color.Gray;
                    btn9.Enabled = false;
                }

                else if (oku["Saat"].ToString() == btn10.Text)
                {
                    btn10.BackColor = Color.Gray;
                    btn10.Enabled = false;
                }

                else if (oku["Saat"].ToString() == btn11.Text)
                {
                    btn11.BackColor = Color.Gray;
                    btn11.Enabled = false;
                }

                else if (oku["Saat"].ToString() == btn12.Text)
                {
                    btn12.BackColor = Color.Gray;
                    btn12.Enabled = false;
                }

                else if (oku["Saat"].ToString() == btn13.Text)
                {
                    btn13.BackColor = Color.Gray;
                    btn13.Enabled = false;
                }

                else if (oku["Saat"].ToString() == btn14.Text)
                {
                    btn14.BackColor = Color.Gray;
                    btn14.Enabled = false;
                }

                else if (oku["Saat"].ToString() == btn15.Text)
                {
                    btn15.BackColor = Color.Gray;
                    btn15.Enabled = false;
                }
                else if (oku["Saat"].ToString() == btn16.Text)
                {
                    btn16.BackColor = Color.Gray;
                    btn16.Enabled = false;
                }



            }
            baglanti.Close();
        }
        // Geldi mi fonksiyonu
        private int gelmeKontrolu()
        {
            int sonuc=0;
            int id = int.Parse(lblHastaId.Text.ToString());
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select Geldi_mi from Randevu_Table where Hasta_Id = '" + id + "'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {

                if (oku["Geldi_mi"].ToString() == "False")
                    sonuc++;
            }
            baglanti.Close();
            return sonuc;
        }


        //Randevu Listeleme   
        private void randevuListele()
        {
            int id = int.Parse(lblHastaId.Text.ToString());
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select r.Randevu_No,b.Bolum_Ad,d.Ad,d.Soyad,r.Tarih,r.Saat,r.Geldi_mi from ((Doktor_Table d inner join Randevu_Table r on d.Doktor_Id=r.Doktor_Id) inner join Bolum_Table b on b.Bolum_Id=d.Bolum_Id)where r.Hasta_Id = '" + id+"'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {

                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Randevu_No"].ToString();
                ekle.SubItems.Add(oku["Bolum_Ad"].ToString());
                ekle.SubItems.Add(oku["Ad"].ToString());
                ekle.SubItems.Add(oku["Soyad"].ToString());
                ekle.SubItems.Add(oku["Tarih"].ToString());
                ekle.SubItems.Add(oku["Saat"].ToString());
                randevuListe.Items.Add(ekle);
            }
            baglanti.Close();
        }

        int tarihSayac = 0;
        int saatSayac = 0;
        private int randevuDoktorKontrol()
        {
            int sayac = 0;
            
            int id = int.Parse(lblHastaId.Text.ToString());
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from Randevu_Table where Hasta_Id = '" + id + "'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                if (doktorId.ToString()== oku["Doktor_Id"].ToString() && dtRandevu.Text == oku["Tarih"].ToString())
                    sayac++;

                if (dtRandevu.Text == oku["Tarih"].ToString())
                    tarihSayac++;

                if (dtRandevu.Text == oku["Tarih"].ToString() && txtSaat.Text==oku["Saat"].ToString())
                    saatSayac++;

            }
            baglanti.Close();
            return sayac;
        }

        //Randevu ekleme
        private void randevuEkleme()
        {
            DateTime bugun = DateTime.Today;
            //DateTime secimTarih = DateTime.Parse(dtRandevu.Text);
            DateTime secimTarih = trh;
            string saatsizTarih;

            string[] splittedText = secimTarih.ToString().Split(' ');
            saatsizTarih = splittedText[0];
            
            if (comboBoxBolum.Text != "" && comboBoxDoktor.Text != "" && dtRandevu.Text != "" && txtSaat.Text != "")
            {
                if(secimTarih>=bugun)
                {
                    if (randevuDoktorKontrol() == 0)
                    {
                        if (tarihSayac < 5)
                        {
                            if (saatSayac == 0)
                            {
                                int hastaId = int.Parse(lblHastaId.Text.ToString());

                                baglanti.Open();
                                SqlCommand komut = new SqlCommand("insert into Randevu_Table (Hasta_Id,Bolum_Id,Doktor_Id,Tarih,Saat) values ('" + hastaId + "','" + id + "','" + doktorId + "','" +  saatsizTarih + "','" + txtSaat.Text + "')", baglanti);
                                komut.ExecuteNonQuery();
                                baglanti.Close();
                                randevuListe.Items.Clear(); // ListBox Temizle
                                randevuListele();          // Listeleme Islemi
                                saatKontrolu(dtRandevu.Value);
                                comboBoxBolum.Text = null;
                                comboBoxDoktor.Text = null;
                                dtRandevu.Text = null;
                                txtSaat.Text = null;
                                MessageBox.Show("Kayıt Eklendi ");
                               
                                
                            }
                            else
                                MessageBox.Show("Gün içerisinde aynı saatte başka bir randevunuz var !");
                            saatSayac = 0;

                        }
                        else
                            MessageBox.Show("Gün içerisinde en fazla 3 randevu alabilirsiniz !");
                            tarihSayac = 0;
                            
                        



                    }
                    else
                    {
                        MessageBox.Show("Gün içerisinde aynı doktordan sadece 1 defa randevu alabilirsiniz !");
                    }
                }

                else
                    MessageBox.Show("Bugünden geçmiş bir tarihe randevu alınamaz !");


            }

            else
                MessageBox.Show("Lütfen gerekli alanları doldurunuz !");

            
        }

        private void btnAl_Click(object sender, EventArgs e)
        {
            if(int.Parse(lblCeza.Text)<3)
            {
                
                randevuEkleme();
                butonRenk();

            }
            
            else
               MessageBox.Show("3 defa randevuya gelmediğiniz için randevu alamazsınız !");
        }

        // Sorgu Fonksiyonu
        
        public int sorgu()
        {
            int idSil = int.Parse(txt_IdSil.Text);
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select *From Randevu_Table where Randevu_No=(" + idSil + ")", baglanti);
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
        // Randevu Iptal Etme
        private void randevuIptal()
        {
            

            if (txt_IdSil.Text != "")
            {
                int idSil = int.Parse(txt_IdSil.Text);
                int id = int.Parse(txt_IdSil.Text);
                if (sorgu() == 1)
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("Delete From Randevu_Table where Randevu_No =(" + idSil + ")", baglanti);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    randevuListe.Items.Clear(); // ListBox Temizle
                    randevuListele();          // Listeleme Islemi
                    txt_IdSil.Clear();
                    MessageBox.Show("Randevu iptal edildi");

                }
                else
                    MessageBox.Show("Kayıt bulunamadı");
            }
            else
                MessageBox.Show("Lütfen id giriniz !");
        }
        //Doktor Id
        int doktorId;
        private void comboBoxDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ad, soyad;

            string[] splittedText = comboBoxDoktor.Text.ToString().Split(' ');
            ad=splittedText[0];
            soyad= splittedText[1];
            
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From Doktor_Table  where Ad='" + ad + "'and Soyad='" + soyad + "'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {

                doktorId = int.Parse(oku["Doktor_Id"].ToString());
            }
            baglanti.Close();
            dtRandevu.Value = DateTime.Today;
            butonRenk();
            saatKontrolu(dtRandevu.Value);
            randevuDoktorKontrol();
            

        }

        private void btnTeslim_Click(object sender, EventArgs e)
        {
            randevuIptal();
        }


        //Harf girisi engelleme
        private void txt_IdSil_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }


        //Tarih
        DateTime trh;
        private void dtRandevu_ValueChanged(object sender, EventArgs e)
        {
            butonRenk();
            trh = dtRandevu.Value;
            saatKontrolu(trh);
            
        }
    }
}
