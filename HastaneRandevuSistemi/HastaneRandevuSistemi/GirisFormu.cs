using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneRandevuSistemi
{
    public partial class GirisFormu : Form
    {
        public GirisFormu()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnGorevliGiris_Click(object sender, EventArgs e)
        {

            YoneticiGiris grvGiris = new YoneticiGiris(); // Yonetici giris formundan nesne oluşturuldu
            this.Hide();                                       // Bulunan form kapatıldı
            grvGiris.Show();                                  //Yönetici giris formu açıldı
        }

        private void btnHastaLogin_Click(object sender, EventArgs e)
        {

            HastaGiris hastaGiris = new HastaGiris(); 
            this.Hide();                                       
            hastaGiris.Show();                                
        }

        private void btnDoktorIslem_Click(object sender, EventArgs e)
        {
            DoktorGiris drGiris = new DoktorGiris(); // Doktor giris formundan nesne oluşturuldu
            this.Hide();                                       // Bulunan form kapatıldı
            drGiris.Show();
        }
    }
}
