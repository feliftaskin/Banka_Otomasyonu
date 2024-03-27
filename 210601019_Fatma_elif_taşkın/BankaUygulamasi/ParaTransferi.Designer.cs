
namespace BankaUygulamasi
{
    partial class ParaTransferi
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
            this.btn_havaleYap = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.havaleTutari = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.musteriHesaplari = new System.Windows.Forms.ListBox();
            this.musteriler = new System.Windows.Forms.ListBox();
            this.musteriHesapListele = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_havaleYap
            // 
            this.btn_havaleYap.Location = new System.Drawing.Point(374, 89);
            this.btn_havaleYap.Name = "btn_havaleYap";
            this.btn_havaleYap.Size = new System.Drawing.Size(140, 62);
            this.btn_havaleYap.TabIndex = 22;
            this.btn_havaleYap.Text = "Havale Yap";
            this.btn_havaleYap.UseVisualStyleBackColor = true;
            this.btn_havaleYap.Click += new System.EventHandler(this.btn_havaleYap_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(121, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "Havale Tutarı";
            // 
            // havaleTutari
            // 
            this.havaleTutari.Location = new System.Drawing.Point(86, 89);
            this.havaleTutari.Name = "havaleTutari";
            this.havaleTutari.Size = new System.Drawing.Size(177, 22);
            this.havaleTutari.TabIndex = 18;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.musteriHesapListele);
            this.groupBox1.Controls.Add(this.btn_havaleYap);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.havaleTutari);
            this.groupBox1.Location = new System.Drawing.Point(13, 338);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(579, 172);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Başka Hesaba Havale";
            // 
            // musteriHesaplari
            // 
            this.musteriHesaplari.FormattingEnabled = true;
            this.musteriHesaplari.ItemHeight = 16;
            this.musteriHesaplari.Location = new System.Drawing.Point(295, 22);
            this.musteriHesaplari.Margin = new System.Windows.Forms.Padding(4);
            this.musteriHesaplari.Name = "musteriHesaplari";
            this.musteriHesaplari.Size = new System.Drawing.Size(264, 276);
            this.musteriHesaplari.TabIndex = 26;
            // 
            // musteriler
            // 
            this.musteriler.FormattingEnabled = true;
            this.musteriler.ItemHeight = 16;
            this.musteriler.Location = new System.Drawing.Point(20, 22);
            this.musteriler.Margin = new System.Windows.Forms.Padding(4);
            this.musteriler.Name = "musteriler";
            this.musteriler.Size = new System.Drawing.Size(256, 276);
            this.musteriler.TabIndex = 27;
            // 
            // musteriHesapListele
            // 
            this.musteriHesapListele.Location = new System.Drawing.Point(374, 21);
            this.musteriHesapListele.Name = "musteriHesapListele";
            this.musteriHesapListele.Size = new System.Drawing.Size(140, 62);
            this.musteriHesapListele.TabIndex = 25;
            this.musteriHesapListele.Text = "Müşterinin Hesaplarını Listele";
            this.musteriHesapListele.UseVisualStyleBackColor = true;
            this.musteriHesapListele.Click += new System.EventHandler(this.musteriHesapListele_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.musteriHesaplari);
            this.groupBox2.Controls.Add(this.musteriler);
            this.groupBox2.Location = new System.Drawing.Point(13, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(579, 320);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Para Göndereceğiniz Hesabı Seçiniz";
            // 
            // ParaTransferi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 522);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ParaTransferi";
            this.Text = "ParaTransferi";
            this.Load += new System.EventHandler(this.ParaTransferi_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_havaleYap;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox havaleTutari;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.ListBox musteriHesaplari;
        public System.Windows.Forms.ListBox musteriler;
        private System.Windows.Forms.Button musteriHesapListele;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}