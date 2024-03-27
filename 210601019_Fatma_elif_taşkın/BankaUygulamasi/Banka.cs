﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankaUygulamasi
{
    public class Banka
    {
        public List<Musteri> MusteriListesi { get; set; }
        public decimal ToplamPara { get; set; }
        public decimal GelenPara { get; set; }
        public decimal GidenPara { get; set; }
        public Banka()
        {
            this.ToplamPara = this.GelenPara - this.GidenPara;
            this.GelenPara = 0;
            this.GidenPara = 0;
            this.MusteriListesi = new List<Musteri>();
        }
        public void MusteriEkle(Musteri m)
        {
            bool kontrol = true;
            foreach (Musteri ms in MusteriListesi)
            {
                if (ms.TcKimlikNo == m.TcKimlikNo)
                    kontrol = false;
            }
            if (kontrol == true)
            {
                MusteriListesi.Add(m);
                System.Windows.Forms.MessageBox.Show("Yeni Müşteri Eklendi!");
            }
            else
                System.Windows.Forms.MessageBox.Show("Bu Müşteri Zaten Kayıtlı!");
        }
    }
}
