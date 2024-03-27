using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankaUygulamasi
{
    public class Kisi
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public long TcKimlikNo { get; set; }
        public int Sifre { get; set; }
        public virtual void KisiBilgisiDoldur(long TcKimlik)
        {
            this.TcKimlikNo = TcKimlik;
        }
    }
}
