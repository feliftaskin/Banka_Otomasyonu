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
    public partial class GirisEkrani : Form
    {
        public GirisEkrani()
        {
            InitializeComponent();
        }
        public static Kisi kisi = new Kisi();
        private void Anasayfa_Load(object sender, EventArgs e)
        {

        }

        private void btn_musteriGirisYap_Click(object sender, EventArgs e)
        {
            kisi.TcKimlikNo = Convert.ToInt64(musteri_tcKimlik.Text);
            kisi.Sifre = Convert.ToInt32(musteri_sifre.Text);
            MusteriSayfasi MusteriSayfasi = new MusteriSayfasi();
            bool kontrol = true;
            foreach (var musteri in YoneticiSayfasi.Banka.MusteriListesi)
            {
                if (musteri.TcKimlikNo == kisi.TcKimlikNo && musteri.Sifre == kisi.Sifre)
                {
                    this.Hide();
                    MusteriSayfasi.ShowDialog();
                    this.Close();
                    kontrol = false;
                }
            }
            if (kontrol == true)
                MessageBox.Show("TC Kimlik No Veya Şifre Yanlış!");
        }

        private void btn_personelGirisYap_Click(object sender, EventArgs e)
        {
            YoneticiSayfasi YetkiliGirisi = new YoneticiSayfasi();
            if (personel_kullaniciAdi.Text == "admin" && personel_sifre.Text == "sifre")
            {
                this.Hide();
                YetkiliGirisi.ShowDialog();
                this.Close();
            }
            else
                MessageBox.Show("Kullanıcı Adı veya Şifre Yanlış!");
        }
    }
}
