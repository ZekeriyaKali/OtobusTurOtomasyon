namespace TurOtomasyonForm
{
    partial class SecimEkrani
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
            this.btnBiletIslemleri = new System.Windows.Forms.Button();
            this.btnPersonelIslemleri = new System.Windows.Forms.Button();
            this.btnFirmaIslemleri = new System.Windows.Forms.Button();
            this.btnSehirIslemleri = new System.Windows.Forms.Button();
            this.btnYolcuIslemleri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBiletIslemleri
            // 
            this.btnBiletIslemleri.Location = new System.Drawing.Point(36, 40);
            this.btnBiletIslemleri.Name = "btnBiletIslemleri";
            this.btnBiletIslemleri.Size = new System.Drawing.Size(97, 34);
            this.btnBiletIslemleri.TabIndex = 0;
            this.btnBiletIslemleri.Text = "Bilet İşlemleri";
            this.btnBiletIslemleri.UseVisualStyleBackColor = true;
            this.btnBiletIslemleri.Click += new System.EventHandler(this.btnBiletIslemleri_Click);
            // 
            // btnPersonelIslemleri
            // 
            this.btnPersonelIslemleri.Location = new System.Drawing.Point(165, 102);
            this.btnPersonelIslemleri.Name = "btnPersonelIslemleri";
            this.btnPersonelIslemleri.Size = new System.Drawing.Size(107, 34);
            this.btnPersonelIslemleri.TabIndex = 1;
            this.btnPersonelIslemleri.Text = "Personel İşlemleri";
            this.btnPersonelIslemleri.UseVisualStyleBackColor = true;
            this.btnPersonelIslemleri.Click += new System.EventHandler(this.btnPersonelIslemleri_Click);
            // 
            // btnFirmaIslemleri
            // 
            this.btnFirmaIslemleri.Location = new System.Drawing.Point(36, 102);
            this.btnFirmaIslemleri.Name = "btnFirmaIslemleri";
            this.btnFirmaIslemleri.Size = new System.Drawing.Size(97, 34);
            this.btnFirmaIslemleri.TabIndex = 2;
            this.btnFirmaIslemleri.Text = "Firma İşlemleri";
            this.btnFirmaIslemleri.UseVisualStyleBackColor = true;
            this.btnFirmaIslemleri.Click += new System.EventHandler(this.btnFirmaIslemleri_Click);
            // 
            // btnSehirIslemleri
            // 
            this.btnSehirIslemleri.Location = new System.Drawing.Point(100, 163);
            this.btnSehirIslemleri.Name = "btnSehirIslemleri";
            this.btnSehirIslemleri.Size = new System.Drawing.Size(99, 34);
            this.btnSehirIslemleri.TabIndex = 3;
            this.btnSehirIslemleri.Text = "Şehir İşlemleri";
            this.btnSehirIslemleri.UseVisualStyleBackColor = true;
            this.btnSehirIslemleri.Click += new System.EventHandler(this.btnSehirIslemleri_Click);
            // 
            // btnYolcuIslemleri
            // 
            this.btnYolcuIslemleri.Location = new System.Drawing.Point(165, 40);
            this.btnYolcuIslemleri.Name = "btnYolcuIslemleri";
            this.btnYolcuIslemleri.Size = new System.Drawing.Size(107, 34);
            this.btnYolcuIslemleri.TabIndex = 4;
            this.btnYolcuIslemleri.Text = "Yolcu İşlemleri";
            this.btnYolcuIslemleri.UseVisualStyleBackColor = true;
            this.btnYolcuIslemleri.Click += new System.EventHandler(this.btnYolcuIslemleri_Click);
            // 
            // SecimEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 213);
            this.Controls.Add(this.btnYolcuIslemleri);
            this.Controls.Add(this.btnSehirIslemleri);
            this.Controls.Add(this.btnFirmaIslemleri);
            this.Controls.Add(this.btnPersonelIslemleri);
            this.Controls.Add(this.btnBiletIslemleri);
            this.Name = "SecimEkrani";
            this.Text = "Seçim Ekranı";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBiletIslemleri;
        private System.Windows.Forms.Button btnPersonelIslemleri;
        private System.Windows.Forms.Button btnFirmaIslemleri;
        private System.Windows.Forms.Button btnSehirIslemleri;
        private System.Windows.Forms.Button btnYolcuIslemleri;
    }
}

