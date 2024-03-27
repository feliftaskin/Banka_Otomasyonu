using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankaUygulamasi
{
    public partial class MusteriSayfasi : Form
    {
        public MusteriSayfasi()
        {
            InitializeComponent();
        }
        public static Musteri Musteri = new Musteri();
        public Musteri KaynakMusteri;

        private void paraTransferiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ParaTransferi paraTransferi = new ParaTransferi((Hesap)dataGridView1.SelectedItem, KaynakMusteri);
            paraTransferi.ShowDialog();
        }

        private void paraYatırÇekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ParaYatirCek paraYatirCek = new ParaYatirCek((Hesap)dataGridView1.SelectedItem);
            paraYatirCek.ShowDialog();
        }

        private void hesapÖzetiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HesapOzet hesapOzet = new HesapOzet((Hesap)dataGridView1.SelectedItem);
            hesapOzet.ShowDialog();
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

        private void MusteriSayfasi_Load(object sender, EventArgs e)
        {
            foreach (Musteri m1 in YoneticiSayfasi.Banka.MusteriListesi)
            {

                if (GirisEkrani.kisi.TcKimlikNo == m1.TcKimlikNo && GirisEkrani.kisi.Sifre == m1.Sifre)
                {
                    Musteri = m1;
                    this.KaynakMusteri = Musteri;
                    foreach (Hesap h in Musteri.Hesaplar)
                    {
                        dataGridView1.Items.Add(h);
                    }
                }
            }
        }

        private void btn_yeniHesapAc_Click(object sender, EventArgs e)
        {
            Hesap EklenecekHesap = new Hesap();
            bool kontrol = true;
            foreach (Hesap h in Musteri.Hesaplar)
            {
                if (h.HesapNo == EklenecekHesap.HesapNo)
                {
                    kontrol = false;
                }
            }
            if (kontrol == true)
            {
                Musteri.HesapAcma(EklenecekHesap);
                dataGridView1.Items.Clear();
                foreach (Musteri m1 in YoneticiSayfasi.Banka.MusteriListesi)
                {

                    if (GirisEkrani.kisi.TcKimlikNo == m1.TcKimlikNo && GirisEkrani.kisi.Sifre == m1.Sifre)
                    {
                        Musteri = m1;
                        foreach (Hesap h in Musteri.Hesaplar)
                        {
                            dataGridView1.Items.Add(h);
                        }
                    }
                }
            }
        }

        private void btn_hesabiKapat_Click(object sender, EventArgs e)
        {
            Hesap KapanacakHesap = (Hesap)dataGridView1.SelectedItem;
            if (KapanacakHesap.Bakiye == 0 && KapanacakHesap.EkHesapBakiye == 500)
            {
                Musteri.HesapKapama(KapanacakHesap);
                dataGridView1.Items.Clear();
                foreach (Musteri m1 in YoneticiSayfasi.Banka.MusteriListesi)
                {

                    if (GirisEkrani.kisi.TcKimlikNo == m1.TcKimlikNo && GirisEkrani.kisi.Sifre == m1.Sifre)
                    {
                        Musteri = m1;
                        foreach (Hesap h in Musteri.Hesaplar)
                        {
                            dataGridView1.Items.Add(h);
                        }
                    }
                }
            }
            else if (KapanacakHesap.Bakiye != 0 && KapanacakHesap.EkHesapBakiye != 500)
                MessageBox.Show("Hesabınızı Kapatmak İçin Bakiyeniz 0 TL Olmalı Ve Ek Hesabınıza Borcunuz Bulunmamalıdır!");
            else if (KapanacakHesap.Bakiye != 0)
                MessageBox.Show("Hesabınızı Kapatmak İçin Bakiyeniz 0 TL Olmalıdır!");
            else if (KapanacakHesap.EkHesapBakiye != 500)
                MessageBox.Show("500TL Limitli Ek Hesabınıza " + Convert.ToString(500 - KapanacakHesap.EkHesapBakiye) + "TL Borcunuz Bulunduğundan Hesabınız Kapatılamaz!");
        }   

        private void yenile_Click(object sender, EventArgs e)
        {
            dataGridView1.Items.Clear();
            foreach (Musteri m1 in YoneticiSayfasi.Banka.MusteriListesi)
            {

                if (GirisEkrani.kisi.TcKimlikNo == m1.TcKimlikNo && GirisEkrani.kisi.Sifre == m1.Sifre)
                {
                    Musteri = m1;
                    foreach (Hesap h in Musteri.Hesaplar)
                    {
                        dataGridView1.Items.Add(h);
                    }
                }
            }
        }
    }
}
