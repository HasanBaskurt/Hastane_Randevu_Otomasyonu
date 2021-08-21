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
    public partial class Yonetici_Islem : Form
    {
        public Yonetici_Islem()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            YoneticiGiris yonetici = new YoneticiGiris();
            this.Hide();
            yonetici.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnDoktorIslem_Click(object sender, EventArgs e)
        {
            Doktor_Islemleri doktor = new Doktor_Islemleri();
            this.Hide();
            doktor.Show();
        }

        private void btnHastaIslem_Click(object sender, EventArgs e)
        {
            Hasta_Islemleri hasta = new Hasta_Islemleri();
            this.Hide();
            hasta.Show();

        }
    }
}
