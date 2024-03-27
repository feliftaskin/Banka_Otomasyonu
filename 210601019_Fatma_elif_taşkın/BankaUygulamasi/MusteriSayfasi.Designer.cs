
namespace BankaUygulamasi
{
    partial class MusteriSayfasi
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
            this.paraTransferiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paraYatırÇekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hesapÖzetiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkındaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışYapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.ListBox();
            this.btn_yeniHesapAc = new System.Windows.Forms.Button();
            this.btn_hesabiKapat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.yenile = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paraTransferiToolStripMenuItem,
            this.paraYatırÇekToolStripMenuItem,
            this.hesapÖzetiToolStripMenuItem,
            this.hakkındaToolStripMenuItem,
            this.çıkışYapToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(552, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // paraTransferiToolStripMenuItem
            // 
            this.paraTransferiToolStripMenuItem.Name = "paraTransferiToolStripMenuItem";
            this.paraTransferiToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.paraTransferiToolStripMenuItem.Text = "Para Transferi";
            this.paraTransferiToolStripMenuItem.Click += new System.EventHandler(this.paraTransferiToolStripMenuItem_Click);
            // 
            // paraYatırÇekToolStripMenuItem
            // 
            this.paraYatırÇekToolStripMenuItem.Name = "paraYatırÇekToolStripMenuItem";
            this.paraYatırÇekToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.paraYatırÇekToolStripMenuItem.Text = "Para Yatır / Çek";
            this.paraYatırÇekToolStripMenuItem.Click += new System.EventHandler(this.paraYatırÇekToolStripMenuItem_Click);
            // 
            // hesapÖzetiToolStripMenuItem
            // 
            this.hesapÖzetiToolStripMenuItem.Name = "hesapÖzetiToolStripMenuItem";
            this.hesapÖzetiToolStripMenuItem.Size = new System.Drawing.Size(104, 24);
            this.hesapÖzetiToolStripMenuItem.Text = "Hesap Özeti";
            this.hesapÖzetiToolStripMenuItem.Click += new System.EventHandler(this.hesapÖzetiToolStripMenuItem_Click);
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
            // dataGridView1
            // 
            this.dataGridView1.FormattingEnabled = true;
            this.dataGridView1.ItemHeight = 16;
            this.dataGridView1.Location = new System.Drawing.Point(13, 93);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(526, 308);
            this.dataGridView1.TabIndex = 3;
            // 
            // btn_yeniHesapAc
            // 
            this.btn_yeniHesapAc.Location = new System.Drawing.Point(307, 45);
            this.btn_yeniHesapAc.Name = "btn_yeniHesapAc";
            this.btn_yeniHesapAc.Size = new System.Drawing.Size(111, 41);
            this.btn_yeniHesapAc.TabIndex = 4;
            this.btn_yeniHesapAc.Text = "Yeni Hesap Aç";
            this.btn_yeniHesapAc.UseVisualStyleBackColor = true;
            this.btn_yeniHesapAc.Click += new System.EventHandler(this.btn_yeniHesapAc_Click);
            // 
            // btn_hesabiKapat
            // 
            this.btn_hesabiKapat.Location = new System.Drawing.Point(424, 45);
            this.btn_hesabiKapat.Name = "btn_hesabiKapat";
            this.btn_hesabiKapat.Size = new System.Drawing.Size(115, 41);
            this.btn_hesabiKapat.TabIndex = 5;
            this.btn_hesabiKapat.Text = "Hesabı Kapat";
            this.btn_hesabiKapat.UseVisualStyleBackColor = true;
            this.btn_hesabiKapat.Click += new System.EventHandler(this.btn_hesabiKapat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.No;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "Hesaplarım";
            // 
            // yenile
            // 
            this.yenile.Location = new System.Drawing.Point(197, 45);
            this.yenile.Name = "yenile";
            this.yenile.Size = new System.Drawing.Size(104, 41);
            this.yenile.TabIndex = 7;
            this.yenile.Text = "Yenile";
            this.yenile.UseVisualStyleBackColor = true;
            this.yenile.Click += new System.EventHandler(this.yenile_Click);
            // 
            // MusteriSayfasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 414);
            this.Controls.Add(this.yenile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_hesabiKapat);
            this.Controls.Add(this.btn_yeniHesapAc);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MusteriSayfasi";
            this.Text = "Anasayfa";
            this.Load += new System.EventHandler(this.MusteriSayfasi_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem paraTransferiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paraYatırÇekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hesapÖzetiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkındaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışYapToolStripMenuItem;
        public System.Windows.Forms.ListBox dataGridView1;
        private System.Windows.Forms.Button btn_yeniHesapAc;
        private System.Windows.Forms.Button btn_hesabiKapat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button yenile;
    }
}