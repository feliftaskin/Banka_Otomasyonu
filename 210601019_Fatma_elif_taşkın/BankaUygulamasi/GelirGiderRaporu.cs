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
    public partial class GelirGiderRaporu : Form
    {
        public GelirGiderRaporu()
        {
            InitializeComponent();
            dataGridView1.Columns.Add("in_tutar", "Gelen Para");
            dataGridView1.Columns.Add("out_tutar", "Giden Para");
            dataGridView1.Columns.Add("toplam", "Bankadaki Para");
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GelirGiderRaporu_Load(object sender, EventArgs e)
        {
            label1.Text = "Tarih: " + DateTime.Now.ToLongDateString();
            label2.Text = "Saat: " + DateTime.Now.ToLongTimeString();
            decimal gelen_para = 0;
            decimal giden_para = 0;
            foreach (Musteri musteri in YoneticiSayfasi.Banka.MusteriListesi)
            {
                foreach (Hesap hesap in musteri.Hesaplar)
                {
                    foreach (HesapOzeti hesap_hareketi in hesap.HesapOzetleri)
                    {
                        if (hesap_hareketi.IslemTuru == "ParaCekYatir")
                        {
                            gelen_para += hesap_hareketi.EklenenPara;
                            giden_para += hesap_hareketi.CikanPara;
                        }
                    }
                }
            }
            dataGridView1.Rows.Clear();
            dataGridView1.Rows.Add(gelen_para.ToString(), giden_para.ToString(), (gelen_para - giden_para).ToString());
        }
    }
}
