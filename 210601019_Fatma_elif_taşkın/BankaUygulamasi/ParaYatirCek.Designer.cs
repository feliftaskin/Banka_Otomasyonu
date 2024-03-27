
namespace BankaUygulamasi
{
    partial class ParaYatirCek
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_paraCek = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cekilecekTutar = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_paraYatir = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.yatirilacakTutar = new System.Windows.Forms.TextBox();
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
            this.tabControl1.Size = new System.Drawing.Size(240, 202);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Silver;
            this.tabPage1.Controls.Add(this.btn_paraCek);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.cekilecekTutar);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(232, 173);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Para Çekme";
            // 
            // btn_paraCek
            // 
            this.btn_paraCek.Location = new System.Drawing.Point(42, 96);
            this.btn_paraCek.Name = "btn_paraCek";
            this.btn_paraCek.Size = new System.Drawing.Size(140, 45);
            this.btn_paraCek.TabIndex = 5;
            this.btn_paraCek.Text = "Para Çek";
            this.btn_paraCek.UseVisualStyleBackColor = true;
            this.btn_paraCek.Click += new System.EventHandler(this.btn_paraCek_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Çekilecek Tutar";
            // 
            // cekilecekTutar
            // 
            this.cekilecekTutar.Location = new System.Drawing.Point(26, 54);
            this.cekilecekTutar.Name = "cekilecekTutar";
            this.cekilecekTutar.Size = new System.Drawing.Size(177, 22);
            this.cekilecekTutar.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Silver;
            this.tabPage2.Controls.Add(this.btn_paraYatir);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.yatirilacakTutar);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(232, 173);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Para Yatırma";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // btn_paraYatir
            // 
            this.btn_paraYatir.Location = new System.Drawing.Point(41, 97);
            this.btn_paraYatir.Name = "btn_paraYatir";
            this.btn_paraYatir.Size = new System.Drawing.Size(140, 45);
            this.btn_paraYatir.TabIndex = 10;
            this.btn_paraYatir.Text = "Para Yatır";
            this.btn_paraYatir.UseVisualStyleBackColor = true;
            this.btn_paraYatir.Click += new System.EventHandler(this.btn_paraYatir_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Yatırılacak Tutar";
            // 
            // yatirilacakTutar
            // 
            this.yatirilacakTutar.Location = new System.Drawing.Point(25, 52);
            this.yatirilacakTutar.Name = "yatirilacakTutar";
            this.yatirilacakTutar.Size = new System.Drawing.Size(177, 22);
            this.yatirilacakTutar.TabIndex = 6;
            // 
            // ParaYatirCek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 226);
            this.Controls.Add(this.tabControl1);
            this.Name = "ParaYatirCek";
            this.Text = "ParaYatirCek";
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
        private System.Windows.Forms.Button btn_paraCek;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cekilecekTutar;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_paraYatir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox yatirilacakTutar;
    }
}