
namespace BankaUygulamasi
{
    partial class YoneticiSayfasi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gelirGiderRaporunuGörüntüleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkındaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışYapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.musteriSifre = new System.Windows.Forms.TextBox();
            this.musteriTc = new System.Windows.Forms.TextBox();
            this.btn_musteriEkle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.musteriSoyadi = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.musteriTuru = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.musteriAdi = new System.Windows.Forms.TextBox();
            this.müşterilerHesaplarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gelirGiderRaporunuGörüntüleToolStripMenuItem,
            this.müşterilerHesaplarToolStripMenuItem,
            this.hakkındaToolStripMenuItem,
            this.çıkışYapToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(609, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gelirGiderRaporunuGörüntüleToolStripMenuItem
            // 
            this.gelirGiderRaporunuGörüntüleToolStripMenuItem.Name = "gelirGiderRaporunuGörüntüleToolStripMenuItem";
            this.gelirGiderRaporunuGörüntüleToolStripMenuItem.Size = new System.Drawing.Size(231, 24);
            this.gelirGiderRaporunuGörüntüleToolStripMenuItem.Text = "Gelir Gider Raporunu Görüntüle";
            this.gelirGiderRaporunuGörüntüleToolStripMenuItem.Click += new System.EventHandler(this.gelirGiderRaporunuGörüntüleToolStripMenuItem_Click);
            // 
            // hakkındaToolStripMenuItem
            // 
            this.hakkındaToolStripMenuItem.Name = "hakkındaToolStripMenuItem";
            this.hakkındaToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.hakkındaToolStripMenuItem.Text = "Hakkında";
            this.hakkındaToolStripMenuItem.Click += new System.EventHandler(this.hakkındaToolStripMenuItem_Click);
            // 
            // çıkışYapToolStripMenuItem
            // 
            this.çıkışYapToolStripMenuItem.Name = "çıkışYapToolStripMenuItem";
            this.çıkışYapToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.çıkışYapToolStripMenuItem.Text = "Çıkış Yap";
            this.çıkışYapToolStripMenuItem.Click += new System.EventHandler(this.çıkışYapToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.musteriSifre);
            this.groupBox1.Controls.Add(this.musteriTc);
            this.groupBox1.Controls.Add(this.btn_musteriEkle);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.musteriSoyadi);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.musteriTuru);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.musteriAdi);
            this.groupBox1.Location = new System.Drawing.Point(12, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(585, 295);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri Ekle";
            // 
            // musteriSifre
            // 
            this.musteriSifre.Location = new System.Drawing.Point(338, 140);
            this.musteriSifre.Name = "musteriSifre";
            this.musteriSifre.Size = new System.Drawing.Size(177, 22);
            this.musteriSifre.TabIndex = 33;
            // 
            // musteriTc
            // 
            this.musteriTc.Location = new System.Drawing.Point(53, 140);
            this.musteriTc.Name = "musteriTc";
            this.musteriTc.Size = new System.Drawing.Size(177, 22);
            this.musteriTc.TabIndex = 31;
            // 
            // btn_musteriEkle
            // 
            this.btn_musteriEkle.Location = new System.Drawing.Point(338, 196);
            this.btn_musteriEkle.Name = "btn_musteriEkle";
            this.btn_musteriEkle.Size = new System.Drawing.Size(177, 54);
            this.btn_musteriEkle.TabIndex = 30;
            this.btn_musteriEkle.Text = "Müşteri Ekle";
            this.btn_musteriEkle.UseVisualStyleBackColor = true;
            this.btn_musteriEkle.Click += new System.EventHandler(this.btn_musteriEkle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 27;
            this.label2.Text = "TC Kimlik No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(335, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "Soyadı";
            // 
            // musteriSoyadi
            // 
            this.musteriSoyadi.Location = new System.Drawing.Point(338, 73);
            this.musteriSoyadi.Name = "musteriSoyadi";
            this.musteriSoyadi.Size = new System.Drawing.Size(177, 22);
            this.musteriSoyadi.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(335, 111);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 17);
            this.label9.TabIndex = 23;
            this.label9.Text = "Şifre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "Müşteri Türü";
            // 
            // musteriTuru
            // 
            this.musteriTuru.FormattingEnabled = true;
            this.musteriTuru.Items.AddRange(new object[] {
            "Bireysel",
            "Ticari"});
            this.musteriTuru.Location = new System.Drawing.Point(53, 212);
            this.musteriTuru.Name = "musteriTuru";
            this.musteriTuru.Size = new System.Drawing.Size(177, 24);
            this.musteriTuru.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(50, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "Adı";
            // 
            // musteriAdi
            // 
            this.musteriAdi.Location = new System.Drawing.Point(53, 73);
            this.musteriAdi.Name = "musteriAdi";
            this.musteriAdi.Size = new System.Drawing.Size(177, 22);
            this.musteriAdi.TabIndex = 18;
            // 
            // müşterilerHesaplarToolStripMenuItem
            // 
            this.müşterilerHesaplarToolStripMenuItem.Name = "müşterilerHesaplarToolStripMenuItem";
            this.müşterilerHesaplarToolStripMenuItem.Size = new System.Drawing.Size(154, 24);
            this.müşterilerHesaplarToolStripMenuItem.Text = "Müşteriler/Hesaplar";
            this.müşterilerHesaplarToolStripMenuItem.Click += new System.EventHandler(this.müşterilerHesaplarToolStripMenuItem_Click);
            // 
            // YoneticiSayfasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 335);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "YoneticiSayfasi";
            this.Text = "YoneticiSayfasi";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gelirGiderRaporunuGörüntüleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkındaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışYapToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox musteriSifre;
        private System.Windows.Forms.TextBox musteriTc;
        private System.Windows.Forms.Button btn_musteriEkle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox musteriSoyadi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox musteriTuru;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox musteriAdi;
        private System.Windows.Forms.ToolStripMenuItem müşterilerHesaplarToolStripMenuItem;
    }
}