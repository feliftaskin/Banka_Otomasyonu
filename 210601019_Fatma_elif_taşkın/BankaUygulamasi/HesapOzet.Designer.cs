
namespace BankaUygulamasi
{
    partial class HesapOzet
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
            this.btn_ozetGoster = new System.Windows.Forms.Button();
            this.bitisTarihi = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.baslangicTarihi = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ozetGoster
            // 
            this.btn_ozetGoster.Location = new System.Drawing.Point(428, 46);
            this.btn_ozetGoster.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ozetGoster.Name = "btn_ozetGoster";
            this.btn_ozetGoster.Size = new System.Drawing.Size(169, 57);
            this.btn_ozetGoster.TabIndex = 11;
            this.btn_ozetGoster.Text = "Hesap Özetini Göster";
            this.btn_ozetGoster.UseVisualStyleBackColor = true;
            this.btn_ozetGoster.Click += new System.EventHandler(this.btn_ozetGoster_Click);
            // 
            // bitisTarihi
            // 
            this.bitisTarihi.Location = new System.Drawing.Point(130, 78);
            this.bitisTarihi.Margin = new System.Windows.Forms.Padding(4);
            this.bitisTarihi.Name = "bitisTarihi";
            this.bitisTarihi.Size = new System.Drawing.Size(265, 22);
            this.bitisTarihi.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 83);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Bitiş Tarihi";
            // 
            // baslangicTarihi
            // 
            this.baslangicTarihi.Location = new System.Drawing.Point(130, 46);
            this.baslangicTarihi.Margin = new System.Windows.Forms.Padding(4);
            this.baslangicTarihi.Name = "baslangicTarihi";
            this.baslangicTarihi.Size = new System.Drawing.Size(265, 22);
            this.baslangicTarihi.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Başlangıç Tarihi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 137);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(585, 267);
            this.dataGridView1.TabIndex = 12;
            // 
            // HesapOzet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 416);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_ozetGoster);
            this.Controls.Add(this.bitisTarihi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.baslangicTarihi);
            this.Controls.Add(this.label1);
            this.Name = "HesapOzet";
            this.Text = "HesapOzet";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ozetGoster;
        private System.Windows.Forms.DateTimePicker bitisTarihi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker baslangicTarihi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}