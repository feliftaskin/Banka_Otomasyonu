using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankaUygulamasi
{
    public class Hesap
    {
        public int HesapNo { get; set; }
        public decimal Bakiye { get; set; }
        public decimal EkHesapBakiye { get; set; }
        public List<HesapOzeti> HesapOzetleri;
        public Hesap()
        {
            Random r = new Random();
            this.HesapNo = r.Next(1, 1000);
            this.Bakiye = 0;
            this.EkHesapBakiye = 500;
            this.HesapOzetleri = new List<HesapOzeti>();
        }
        public void HesapDefteriEkle(HesapOzeti ozet)
        {
            this.HesapOzetleri.Add(ozet);
        }
        public void LoadHesapHareketleriToGridView(DataGridView grid, DateTime baslangic, DateTime bitis)
        {
            string tutar = "";
            string kim = "";
            string tur = "";
            grid.Rows.Clear();
            foreach (HesapOzeti hesap_hareketi in this.HesapOzetleri)
            {
                if (hesap_hareketi.IslemTarihi.Date >= baslangic.Date && hesap_hareketi.IslemTarihi.Date <= bitis.Date)
                {
                    if (hesap_hareketi.EklenenPara != 0)
                        tutar = "+" + hesap_hareketi.EklenenPara;
                    else
                        tutar = "-" + hesap_hareketi.CikanPara;
                    if (hesap_hareketi.IslemTuru == "ParaCekYatir")
                    {
                        kim = "";
                        tur = "Para Çekme/Yatırma";
                    }
                    else if (hesap_hareketi.IslemTuru == "ParaTransferi")
                    {
                        kim = hesap_hareketi.Kim.Ad + " " + hesap_hareketi.Kim.Soyad;
                        tur = "Para Transferi";
                    }
                    else
                    {
                        kim = "";
                        tur = "Havale Ücreti";
                    }

                    grid.Rows.Add(tutar, kim, hesap_hareketi.IslemTarihi.ToShortDateString(), tur);
                }
            }
        }
        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3} {4} {5} {6} {7}", "Hesap No:", HesapNo, " Bakiye:", Bakiye, "TL", "Ek Hesap Bakiye:", EkHesapBakiye, "TL");
        }
    }
}
