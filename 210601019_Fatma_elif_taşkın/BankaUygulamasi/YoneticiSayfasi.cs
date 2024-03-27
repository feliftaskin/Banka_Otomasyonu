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
    public partial class YoneticiSayfasi : Form
    {
        public YoneticiSayfasi()
        {
            InitializeComponent();
        }
        public Banka bankaApp;
        public static Banka Banka = new Banka();
        private void btn_musteriEkle_Click(object sender, EventArgs e)
        {
            if (musteriAdi.Text == "" || musteriSoyadi.Text == "" || musteriTc.Text == "" || musteriSifre.Text == "" || musteriTuru.Text == "")
            {
                MessageBox.Show("Bu alanlar boş bırakılamaz.");
            }
            else
            {
                Musteri EklenecekMusteri = new Musteri();
                EklenecekMusteri.Ad = musteriAdi.Text.ToUpper();
                EklenecekMusteri.Soyad = musteriSoyadi.Text.ToUpper();
                EklenecekMusteri.TcKimlikNo = Convert.ToInt64(musteriTc.Text);
                EklenecekMusteri.Sifre = Convert.ToInt32(musteriSifre.Text);
                EklenecekMusteri.Tip = musteriTuru.Text;
                YoneticiSayfasi.Banka.MusteriEkle(EklenecekMusteri);
            }
        }

        private void gelirGiderRaporunuGörüntüleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GelirGiderRaporu GelirGiderRaporu = new GelirGiderRaporu();
            GelirGiderRaporu.ShowDialog();
        }

        private void hakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu Banka Uygulaması Mehmet Can Çuhadar ve Fatma Elif Taşkın Tarafından Tasarlanmış ve Kodlanmıştır.", "Hakkında");
        }

        private void çıkışYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult cikis;
            cikis = MessageBox.Show("Çıkış Yapmak İstediğinizden Emin misiniz ?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (cikis == DialogResult.Yes)
            {
                GirisEkrani Giris = new GirisEkrani();
                this.Hide();
                Giris.ShowDialog();
                this.Close();
            }
        }

        private void müşterilerHesaplarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MusterilerVeHesaplar musterilerVeHesaplar = new MusterilerVeHesaplar();
            musterilerVeHesaplar.ShowDialog();
        }
    }
}
