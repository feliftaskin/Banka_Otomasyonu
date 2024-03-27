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
    public partial class ParaTransferi : Form
    {
        public Hesap h;
        public Musteri KaynakMusteri;
        public Musteri HedefMusteri;
        public ParaTransferi(Hesap h1, Musteri m)
        {
            InitializeComponent();
            this.h = h1;
            this.KaynakMusteri = m;
        }
        private void ParaTransferi_Load(object sender, EventArgs e)
        {
            Musteri m1 = (Musteri)musteriler.SelectedItem;
            this.HedefMusteri = m1;
            foreach (Musteri m2 in YoneticiSayfasi.Banka.MusteriListesi)
            {
                musteriler.Items.Add(m2);
            }
        }

        private void btn_havaleYap_Click(object sender, EventArgs e)
        {
            Hesap h1 = (Hesap)musteriHesaplari.SelectedItem;
            MusteriSayfasi.Musteri.ParaHavale(h, h1, KaynakMusteri, HedefMusteri, Convert.ToDecimal(havaleTutari.Text));
        }

        private void musteriHesapListele_Click(object sender, EventArgs e)
        {
            Musteri m5 = (Musteri)musteriler.SelectedItem;
            this.HedefMusteri = m5;
            musteriHesaplari.Items.Clear();
            foreach (Musteri ms in YoneticiSayfasi.Banka.MusteriListesi)
            {
                if (m5.MusteriNo == ms.MusteriNo)
                {
                    foreach (Hesap h in ms.Hesaplar)
                    {
                        musteriHesaplari.Items.Add(h);
                    }
                }
            }
        }
    }
}
