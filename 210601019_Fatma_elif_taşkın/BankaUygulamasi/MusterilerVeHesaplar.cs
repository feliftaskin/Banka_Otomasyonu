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
    public partial class MusterilerVeHesaplar : Form
    {
        public MusterilerVeHesaplar()
        {
            InitializeComponent();
        }

        private void MusterilerVeHesaplar_Load(object sender, EventArgs e)
        {
            Musteri m1 = (Musteri)musteriler.SelectedItem;
            foreach (Musteri m2 in YoneticiSayfasi.Banka.MusteriListesi)
            {
                musteriler.Items.Add(m2);
            }
        }

        private void musteriHesapListele_Click(object sender, EventArgs e)
        {
            Musteri m5 = (Musteri)musteriler.SelectedItem;
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
