
namespace BankaUygulamasi
{
    partial class GirisEkrani
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.musteri_sifre = new System.Windows.Forms.TextBox();
            this.musteri_tcKimlik = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_musteriGirisYap = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.personel_sifre = new System.Windows.Forms.TextBox();
            this.personel_kullaniciAdi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_personelGirisYap = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(339, 399);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Silver;
            this.tabPage1.Controls.Add(this.musteri_sifre);
            this.tabPage1.Controls.Add(this.musteri_tcKimlik);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btn_musteriGirisYap);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(331, 370);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Müşteri Girişi";
            // 
            // musteri_sifre
            // 
            this.musteri_sifre.Location = new System.Drawing.Point(91, 191);
            this.musteri_sifre.Name = "musteri_sifre";
            this.musteri_sifre.Size = new System.Drawing.Size(155, 22);
            this.musteri_sifre.TabIndex = 4;
            // 
            // musteri_tcKimlik
            // 
            this.musteri_tcKimlik.Location = new System.Drawing.Point(91, 118);
            this.musteri_tcKimlik.Name = "musteri_tcKimlik";
            this.musteri_tcKimlik.Size = new System.Drawing.Size(155, 22);
            this.musteri_tcKimlik.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Şifre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "TC Kimlik No";
            // 
            // btn_musteriGirisYap
            // 
            this.btn_musteriGirisYap.BackColor = System.Drawing.Color.Transparent;
            this.btn_musteriGirisYap.Location = new System.Drawing.Point(113, 247);
            this.btn_musteriGirisYap.Name = "btn_musteriGirisYap";
            this.btn_musteriGirisYap.Size = new System.Drawing.Size(100, 39);
            this.btn_musteriGirisYap.TabIndex = 0;
            this.btn_musteriGirisYap.Text = "Giriş Yap";
            this.btn_musteriGirisYap.UseVisualStyleBackColor = false;
            this.btn_musteriGirisYap.Click += new System.EventHandler(this.btn_musteriGirisYap_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Silver;
            this.tabPage2.Controls.Add(this.personel_sifre);
            this.tabPage2.Controls.Add(this.personel_kullaniciAdi);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.btn_personelGirisYap);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(331, 370);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Personel Girişi";
            // 
            // personel_sifre
            // 
            this.personel_sifre.Location = new System.Drawing.Point(91, 191);
            this.personel_sifre.Name = "personel_sifre";
            this.personel_sifre.Size = new System.Drawing.Size(155, 22);
            this.personel_sifre.TabIndex = 9;
            // 
            // personel_kullaniciAdi
            // 
            this.personel_kullaniciAdi.Location = new System.Drawing.Point(91, 118);
            this.personel_kullaniciAdi.Name = "personel_kullaniciAdi";
            this.personel_kullaniciAdi.Size = new System.Drawing.Size(155, 22);
            this.personel_kullaniciAdi.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Şifre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Kullanıcı Adı";
            // 
            // btn_personelGirisYap
            // 
            this.btn_personelGirisYap.BackColor = System.Drawing.Color.Transparent;
            this.btn_personelGirisYap.Location = new System.Drawing.Point(113, 247);
            this.btn_personelGirisYap.Name = "btn_personelGirisYap";
            this.btn_personelGirisYap.Size = new System.Drawing.Size(100, 39);
            this.btn_personelGirisYap.TabIndex = 5;
            this.btn_personelGirisYap.Text = "Giriş Yap";
            this.btn_personelGirisYap.UseVisualStyleBackColor = false;
            this.btn_personelGirisYap.Click += new System.EventHandler(this.btn_personelGirisYap_Click);
            // 
            // GirisEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 422);
            this.Controls.Add(this.tabControl1);
            this.Name = "GirisEkrani";
            this.Text = "Giriş Ekranı";
            this.Load += new System.EventHandler(this.Anasayfa_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox musteri_sifre;
        private System.Windows.Forms.TextBox musteri_tcKimlik;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_musteriGirisYap;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox personel_sifre;
        private System.Windows.Forms.TextBox personel_kullaniciAdi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_personelGirisYap;
    }
}

