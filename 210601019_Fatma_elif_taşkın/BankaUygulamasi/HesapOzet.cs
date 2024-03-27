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
    public partial class HesapOzet : Form
    {
        public Hesap ozetlenecek_hesap;
        public HesapOzet(Hesap ozeti_gosterilecek_hesap)
        {
            InitializeComponent();
            this.ozetlenecek_hesap = ozeti_gosterilecek_hesap;
            dataGridView1.Columns.Add("tutar", "Çekilen/Yatırılan");
            dataGridView1.Columns.Add("kime", "Kime/Kimden");
            dataGridView1.Columns.Add("tarih", "İşlem Tarihi");
            dataGridView1.Columns.Add("tur", "İşlem Tipi");
        }

        private void btn_ozetGoster_Click(object sender, EventArgs e)
        {
            ozetlenecek_hesap.LoadHesapHareketleriToGridView(dataGridView1, baslangicTarihi.Value, bitisTarihi.Value);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
