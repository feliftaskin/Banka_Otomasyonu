
namespace BankaUygulamasi
{
    partial class MusterilerVeHesaplar
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
            this.musteriHesaplari = new System.Windows.Forms.ListBox();
            this.musteriler = new System.Windows.Forms.ListBox();
            this.musteriHesapListele = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // musteriHesaplari
            // 
            this.musteriHesaplari.FormattingEnabled = true;
            this.musteriHesaplari.ItemHeight = 16;
            this.musteriHesaplari.Location = new System.Drawing.Point(286, 34);
            this.musteriHesaplari.Margin = new System.Windows.Forms.Padding(4);
            this.musteriHesaplari.Name = "musteriHesaplari";
            this.musteriHesaplari.Size = new System.Drawing.Size(264, 276);
            this.musteriHesaplari.TabIndex = 28;
            // 
            // musteriler
            // 
            this.musteriler.FormattingEnabled = true;
            this.musteriler.ItemHeight = 16;
            this.musteriler.Location = new System.Drawing.Point(22, 34);
            this.musteriler.Margin = new System.Windows.Forms.Padding(4);
            this.musteriler.Name = "musteriler";
            this.musteriler.Size = new System.Drawing.Size(256, 276);
            this.musteriler.TabIndex = 29;
            // 
            // musteriHesapListele
            // 
            this.musteriHesapListele.Location = new System.Drawing.Point(557, 132);
            this.musteriHesapListele.Name = "musteriHesapListele";
            this.musteriHesapListele.Size = new System.Drawing.Size(140, 73);
            this.musteriHesapListele.TabIndex = 30;
            this.musteriHesapListele.Text = "Müşterinin Hesaplarını Listele";
            this.musteriHesapListele.UseVisualStyleBackColor = true;
            this.musteriHesapListele.Click += new System.EventHandler(this.musteriHesapListele_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.musteriHesapListele);
            this.groupBox1.Controls.Add(this.musteriHesaplari);
            this.groupBox1.Controls.Add(this.musteriler);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(714, 343);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hesaplarını Görüntülemek İçin Bir Müşteri Seçiniz";
            // 
            // MusterilerVeHesaplar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 368);
            this.Controls.Add(this.groupBox1);
            this.Name = "MusterilerVeHesaplar";
            this.Text = "MusterilerVeHesaplar";
            this.Load += new System.EventHandler(this.MusterilerVeHesaplar_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListBox musteriHesaplari;
        public System.Windows.Forms.ListBox musteriler;
        private System.Windows.Forms.Button musteriHesapListele;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}