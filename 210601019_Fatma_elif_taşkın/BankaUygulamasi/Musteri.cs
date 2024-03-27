using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankaUygulamasi
{
    public class Musteri : Kisi
    {
        public List<Hesap> Hesaplar { get; set; }
        public Hesap Hesap1 { get; set; }
        public string Tip { get; set; }
        public int MusteriNo { get; set; }
        public Musteri()
        {
            this.Hesaplar = new List<Hesap>();
            this.Hesap1 = new Hesap();
            Hesaplar.Add(Hesap1);
            Random r = new Random();
            this.MusteriNo = r.Next(1, 10000);
        }
        public override void KisiBilgisiDoldur(long TcKimlik)
        {
            base.KisiBilgisiDoldur(TcKimlik);

        }
        public Musteri(string ad, string soyad, int musterino, int sifre)
        {
            this.Ad = ad.ToUpper();
            this.Soyad = soyad.ToUpper();
            this.MusteriNo = musterino;
            this.Sifre = sifre;
        }
        public void HesapAcma(Hesap h)
        {
            Hesaplar.Add(h);
        }
        public void HesapKapama(Hesap h)
        {
            Hesaplar.Remove(h);
        }
        public void ParaCek(Hesap h, decimal Tutar)
        {
            foreach (Hesap hs in Hesaplar)
            {
                if (hs.HesapNo == h.HesapNo)
                {
                    if (Tutar <= 750 && Tutar <= (h.Bakiye + h.EkHesapBakiye))
                    {
                        if (Tutar <= h.Bakiye)
                        {
                            h.Bakiye -= Tutar;
                            YoneticiSayfasi.Banka.GidenPara -= h.Bakiye;
                            System.Windows.Forms.MessageBox.Show(Tutar + " Tutarında Para Çektiniz!");

                            HesapOzeti hesap_hareketi_h1 = new HesapOzeti();
                            hesap_hareketi_h1.EklenenPara = 0;
                            hesap_hareketi_h1.CikanPara = Tutar;
                            hesap_hareketi_h1.Kim = this;
                            hesap_hareketi_h1.IslemTarihi = DateTime.Now;
                            hesap_hareketi_h1.IslemTuru = "ParaCekYatir";

                            h.HesapDefteriEkle(hesap_hareketi_h1);
                        }
                        else if (h.EkHesapBakiye >= (Tutar - h.Bakiye))
                        {
                            h.EkHesapBakiye -= (Tutar - h.Bakiye);
                            h.Bakiye = 0;
                            System.Windows.Forms.MessageBox.Show("Hesabınızın Bakiyesi Yetersiz Olduğundan Ek Hesabınızdan da Para Çekildi!");
                            System.Windows.Forms.MessageBox.Show(Tutar + " Tutarında Para Çektiniz!");

                            HesapOzeti hesap_hareketi_h1 = new HesapOzeti();
                            hesap_hareketi_h1.EklenenPara = 0;
                            hesap_hareketi_h1.CikanPara = Tutar;
                            hesap_hareketi_h1.Kim = this;
                            hesap_hareketi_h1.IslemTarihi = DateTime.Now;
                            hesap_hareketi_h1.IslemTuru = "ParaCekYatir";

                            h.HesapDefteriEkle(hesap_hareketi_h1);
                        }
                    }
                    else if (Tutar > 750)
                        System.Windows.Forms.MessageBox.Show("Günlük Para Çekme Limiti 750TL'dir. Aynı Gün İçerisinde 750TL'den Fazla Para Çekemezsiniz!");
                    else if (Tutar > (h.Bakiye + h.EkHesapBakiye))
                        System.Windows.Forms.MessageBox.Show("Bakiyeniz Ve Ek Hesap Limitiniz Yetersiz!");
                }
            }
        }
        public void ParaYatir(Hesap h, decimal Tutar)
        {
            foreach (Hesap hs in Hesaplar)
            {
                if (hs.HesapNo == h.HesapNo)
                {
                    if (h.EkHesapBakiye < 500)
                    {
                        if (Tutar < (500 - h.EkHesapBakiye))
                        {
                            System.Windows.Forms.MessageBox.Show((500 - h.EkHesapBakiye) + "TL Tutarındaki Ek Hesap Borcunuzun " + Tutar + "TL'si Ödenmiştir!");
                            h.EkHesapBakiye += Tutar;
                            HesapOzeti hesap_hareketi_h1 = new HesapOzeti();
                            hesap_hareketi_h1.EklenenPara = Tutar;
                            hesap_hareketi_h1.CikanPara = 0;
                            hesap_hareketi_h1.Kim = this;
                            hesap_hareketi_h1.IslemTarihi = DateTime.Now;
                            hesap_hareketi_h1.IslemTuru = "ParaCekYatir";

                            h.HesapDefteriEkle(hesap_hareketi_h1);
                            YoneticiSayfasi.Banka.GelenPara += Tutar;
                        }
                        else if (Tutar >= (500 - h.EkHesapBakiye))
                        {
                            System.Windows.Forms.MessageBox.Show((500 - h.EkHesapBakiye) + "TL Tutarındaki Ek Hesap Borcunuz Ödenmiştir!");
                            h.Bakiye += Tutar - (500 - h.EkHesapBakiye);
                            h.EkHesapBakiye = 500;
                            HesapOzeti hesap_hareketi_h1 = new HesapOzeti();
                            hesap_hareketi_h1.EklenenPara = Tutar;
                            hesap_hareketi_h1.CikanPara = 0;
                            hesap_hareketi_h1.Kim = this;
                            hesap_hareketi_h1.IslemTarihi = DateTime.Now;
                            hesap_hareketi_h1.IslemTuru = "ParaCekYatir";

                            h.HesapDefteriEkle(hesap_hareketi_h1);
                            YoneticiSayfasi.Banka.GelenPara += Tutar;
                        }
                    }
                    else
                    {
                        h.Bakiye += Tutar;
                        HesapOzeti hesap_hareketi_h1 = new HesapOzeti();
                        hesap_hareketi_h1.EklenenPara = Tutar;
                        hesap_hareketi_h1.CikanPara = 0;
                        hesap_hareketi_h1.Kim = this;
                        hesap_hareketi_h1.IslemTarihi = DateTime.Now;
                        hesap_hareketi_h1.IslemTuru = "ParaCekYatir";

                        h.HesapDefteriEkle(hesap_hareketi_h1);
                        YoneticiSayfasi.Banka.GelenPara += Tutar;
                    }
                }
            }
        }
        public void ParaHavale(Hesap h1, Hesap h2, Musteri KaynakMusteri, Musteri HedefMusteri, decimal tutar)
        {
            if (h1 == h2)
                System.Windows.Forms.MessageBox.Show("Parayı Gönderen Hesap Ve Parayı Alan Hesap Aynı Olamaz!");
            else
            {
                decimal havaleucreti = 0;
                if (KaynakMusteri.Tip == "Bireysel")
                {
                    havaleucreti = (tutar * 2) / 100;
                    if ((tutar + havaleucreti) <= h1.Bakiye)
                    {
                        System.Windows.Forms.MessageBox.Show("Bireysel müşteri olduğunuz için " + Convert.ToString(havaleucreti) + "TL havale ucreti kesildi!");
                        h1.Bakiye -= havaleucreti;
                        h1.Bakiye -= tutar;
                        YoneticiSayfasi.Banka.GidenPara -= h1.Bakiye;
                        h2.Bakiye += tutar;
                        HesapOzeti hesap_hareketi_h1 = new HesapOzeti();
                        hesap_hareketi_h1.EklenenPara = 0;
                        hesap_hareketi_h1.CikanPara = tutar;
                        hesap_hareketi_h1.Kim = HedefMusteri;
                        hesap_hareketi_h1.IslemTuru = "ParaTransferi";
                        hesap_hareketi_h1.IslemTarihi = DateTime.Now;

                        HesapOzeti hesap_hareketi_h2 = new HesapOzeti();
                        hesap_hareketi_h2.EklenenPara = tutar;
                        hesap_hareketi_h2.CikanPara = 0;
                        hesap_hareketi_h2.IslemTuru = "ParaTransferi";
                        hesap_hareketi_h2.Kim = KaynakMusteri;
                        hesap_hareketi_h2.IslemTarihi = hesap_hareketi_h1.IslemTarihi;

                        HesapOzeti hesap_hareketi_h3 = new HesapOzeti();
                        hesap_hareketi_h3.EklenenPara = 0;
                        hesap_hareketi_h3.CikanPara = havaleucreti;
                        hesap_hareketi_h3.Kim = KaynakMusteri;
                        hesap_hareketi_h3.IslemTuru = "HavaleUcreti";
                        hesap_hareketi_h3.IslemTarihi = DateTime.Now;

                        h1.HesapDefteriEkle(hesap_hareketi_h1);
                        h1.HesapDefteriEkle(hesap_hareketi_h3);
                        h2.HesapDefteriEkle(hesap_hareketi_h2);

                        System.Windows.Forms.MessageBox.Show(Convert.ToString(tutar) + "TL Tutarında Havale Gerçekleştirdiniz!");
                    }
                    else if (h1.EkHesapBakiye >= ((tutar + havaleucreti) - h1.Bakiye))
                    {
                        h1.EkHesapBakiye -= ((tutar + havaleucreti) - h1.Bakiye);
                        h1.Bakiye = 0;
                        YoneticiSayfasi.Banka.GidenPara -= h1.Bakiye;
                        h2.Bakiye += tutar;
                        HesapOzeti hesap_hareketi_h1 = new HesapOzeti();
                        hesap_hareketi_h1.EklenenPara = 0;
                        hesap_hareketi_h1.CikanPara = tutar;
                        hesap_hareketi_h1.Kim = HedefMusteri;
                        hesap_hareketi_h1.IslemTuru = "ParaTransferi";
                        hesap_hareketi_h1.IslemTarihi = DateTime.Now;

                        HesapOzeti hesap_hareketi_h2 = new HesapOzeti();
                        hesap_hareketi_h2.EklenenPara = tutar;
                        hesap_hareketi_h2.CikanPara = 0;
                        hesap_hareketi_h2.IslemTuru = "ParaTransferi";
                        hesap_hareketi_h2.Kim = KaynakMusteri;
                        hesap_hareketi_h2.IslemTarihi = hesap_hareketi_h1.IslemTarihi;

                        HesapOzeti hesap_hareketi_h3 = new HesapOzeti();
                        hesap_hareketi_h3.EklenenPara = 0;
                        hesap_hareketi_h3.CikanPara = havaleucreti;
                        hesap_hareketi_h3.Kim = KaynakMusteri;
                        hesap_hareketi_h3.IslemTuru = "HavaleUcreti";
                        hesap_hareketi_h3.IslemTarihi = DateTime.Now;

                        h1.HesapDefteriEkle(hesap_hareketi_h1);
                        h1.HesapDefteriEkle(hesap_hareketi_h3);
                        h2.HesapDefteriEkle(hesap_hareketi_h2);
                        System.Windows.Forms.MessageBox.Show("Hesabınızın Bakiyesi Yetersiz Olduğundan Ek Hesabınızdan da Para Çekildi!");
                        System.Windows.Forms.MessageBox.Show("Bireysel müşteri olduğunuz için " + Convert.ToString(havaleucreti) + "TL havale ucreti kesildi!");
                        System.Windows.Forms.MessageBox.Show(Convert.ToString(tutar) + "TL Tutarında Havale Gerçekleştirdiniz!");
                    }
                    else
                        System.Windows.Forms.MessageBox.Show("Bakiyeniz Yetersiz!");
                }
                else if (KaynakMusteri.Tip == "Ticari")
                {
                    if (tutar <= h1.Bakiye)
                    {
                        h1.Bakiye -= tutar;
                        YoneticiSayfasi.Banka.GidenPara -= h1.Bakiye;
                        h2.Bakiye += tutar;
                        HesapOzeti hesap_hareketi_h1 = new HesapOzeti();
                        hesap_hareketi_h1.EklenenPara = 0;
                        hesap_hareketi_h1.CikanPara = tutar;
                        hesap_hareketi_h1.Kim = HedefMusteri;
                        hesap_hareketi_h1.IslemTuru = "ParaTransferi";
                        hesap_hareketi_h1.IslemTarihi = DateTime.Now;

                        HesapOzeti hesap_hareketi_h2 = new HesapOzeti();
                        hesap_hareketi_h2.EklenenPara = tutar;
                        hesap_hareketi_h2.CikanPara = 0;
                        hesap_hareketi_h2.IslemTuru = "ParaTransferi";
                        hesap_hareketi_h2.Kim = KaynakMusteri;
                        hesap_hareketi_h2.IslemTarihi = hesap_hareketi_h1.IslemTarihi;

                        h1.HesapDefteriEkle(hesap_hareketi_h1);
                        h2.HesapDefteriEkle(hesap_hareketi_h2);

                        System.Windows.Forms.MessageBox.Show(Convert.ToString(tutar) + "TL Tutarında Havale Gerçekleştirdiniz!");
                    }
                    else if (h1.EkHesapBakiye >= (tutar - h1.Bakiye))
                    {
                        h1.EkHesapBakiye -= (tutar - h1.Bakiye);
                        h1.Bakiye = 0;
                        YoneticiSayfasi.Banka.GidenPara -= h1.Bakiye;
                        h2.Bakiye += tutar;
                        HesapOzeti hesap_hareketi_h1 = new HesapOzeti();
                        hesap_hareketi_h1.EklenenPara = 0;
                        hesap_hareketi_h1.CikanPara = tutar;
                        hesap_hareketi_h1.Kim = HedefMusteri;
                        hesap_hareketi_h1.IslemTuru = "ParaTransferi";
                        hesap_hareketi_h1.IslemTarihi = DateTime.Now;

                        HesapOzeti hesap_hareketi_h2 = new HesapOzeti();
                        hesap_hareketi_h2.EklenenPara = tutar;
                        hesap_hareketi_h2.CikanPara = 0;
                        hesap_hareketi_h2.IslemTuru = "ParaTransferi";
                        hesap_hareketi_h2.Kim = KaynakMusteri;
                        hesap_hareketi_h2.IslemTarihi = hesap_hareketi_h1.IslemTarihi;

                        h1.HesapDefteriEkle(hesap_hareketi_h1);
                        h2.HesapDefteriEkle(hesap_hareketi_h2);
                        System.Windows.Forms.MessageBox.Show("Hesabınızın Bakiyesi Yetersiz Olduğundan Ek Hesabınızdan da Para Çekildi!");
                        System.Windows.Forms.MessageBox.Show(Convert.ToString(tutar) + "TL Tutarında Havale Gerçekleştirdiniz!");
                    }
                    else
                        System.Windows.Forms.MessageBox.Show("Bakiyeniz Yetersiz!");
                }
            }
        }
        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3} {4} {5} {6} {7}", "Ad:", Ad, " Soyad:", Soyad, " Müşteri No:", MusteriNo, " Tipi:", Tip);
        }
    }
}
