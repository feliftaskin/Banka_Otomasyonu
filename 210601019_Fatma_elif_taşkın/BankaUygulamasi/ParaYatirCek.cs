using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BankaUygulamasi
{
    public partial class ParaYatirCek : Form
    {
        public Hesap h;
        public ParaYatirCek(Hesap h1)
        {
            InitializeComponent();
            this.h = h1;
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void btn_paraCek_Click(object sender, EventArgs e)
        {
            MusteriSayfasi.Musteri.ParaCek(h, Convert.ToInt64(cekilecekTutar.Text));
        }

        private void btn_paraYatir_Click(object sender, EventArgs e)
        {
            MusteriSayfasi.Musteri.ParaYatir(h, Convert.ToInt64(yatirilacakTutar.Text));
            MessageBox.Show(yatirilacakTutar.Text + " Tutarında Para Yatırdınız!");
        }
    }
}
