namespace TurOtomasyonForm
{
    partial class SehirIslemleri
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSehirGuncelle = new System.Windows.Forms.Button();
            this.tbxSehirAdGuncelle = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSehirEkle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxSehirAdEkle = new System.Windows.Forms.TextBox();
            this.btnSehirSil = new System.Windows.Forms.Button();
            this.dgwSehirListele = new System.Windows.Forms.DataGridView();
            this.btnSehirGeriDön = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwSehirListele)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnSehirGuncelle);
            this.groupBox2.Controls.Add(this.tbxSehirAdGuncelle);
            this.groupBox2.Location = new System.Drawing.Point(705, 119);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(203, 119);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Şehir Güncelle";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Şehir Adı:";
            // 
            // btnSehirGuncelle
            // 
            this.btnSehirGuncelle.Location = new System.Drawing.Point(67, 76);
            this.btnSehirGuncelle.Name = "btnSehirGuncelle";
            this.btnSehirGuncelle.Size = new System.Drawing.Size(100, 25);
            this.btnSehirGuncelle.TabIndex = 17;
            this.btnSehirGuncelle.Text = "Güncelle";
            this.btnSehirGuncelle.UseVisualStyleBackColor = true;
            this.btnSehirGuncelle.Click += new System.EventHandler(this.btnSehirGuncelle_Click);
            // 
            // tbxSehirAdGuncelle
            // 
            this.tbxSehirAdGuncelle.Location = new System.Drawing.Point(85, 31);
            this.tbxSehirAdGuncelle.Name = "tbxSehirAdGuncelle";
            this.tbxSehirAdGuncelle.Size = new System.Drawing.Size(100, 20);
            this.tbxSehirAdGuncelle.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSehirEkle);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbxSehirAdEkle);
            this.groupBox1.Location = new System.Drawing.Point(54, 119);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(198, 119);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Şehir Ekle";
            // 
            // btnSehirEkle
            // 
            this.btnSehirEkle.Location = new System.Drawing.Point(50, 76);
            this.btnSehirEkle.Name = "btnSehirEkle";
            this.btnSehirEkle.Size = new System.Drawing.Size(100, 25);
            this.btnSehirEkle.TabIndex = 16;
            this.btnSehirEkle.Text = "Ekle";
            this.btnSehirEkle.UseVisualStyleBackColor = true;
            this.btnSehirEkle.Click += new System.EventHandler(this.btnSehirEkle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Şehir Adı:";
            // 
            // tbxSehirAdEkle
            // 
            this.tbxSehirAdEkle.Location = new System.Drawing.Point(76, 31);
            this.tbxSehirAdEkle.Name = "tbxSehirAdEkle";
            this.tbxSehirAdEkle.Size = new System.Drawing.Size(100, 20);
            this.tbxSehirAdEkle.TabIndex = 0;
            // 
            // btnSehirSil
            // 
            this.btnSehirSil.Location = new System.Drawing.Point(421, 227);
            this.btnSehirSil.Name = "btnSehirSil";
            this.btnSehirSil.Size = new System.Drawing.Size(75, 25);
            this.btnSehirSil.TabIndex = 31;
            this.btnSehirSil.Text = "Sil";
            this.btnSehirSil.UseVisualStyleBackColor = true;
            this.btnSehirSil.Click += new System.EventHandler(this.btnSehirSil_Click);
            // 
            // dgwSehirListele
            // 
            this.dgwSehirListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwSehirListele.Location = new System.Drawing.Point(303, 111);
            this.dgwSehirListele.Name = "dgwSehirListele";
            this.dgwSehirListele.Size = new System.Drawing.Size(322, 91);
            this.dgwSehirListele.TabIndex = 30;
            this.dgwSehirListele.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwSehirListele_CellClick);
            // 
            // btnSehirGeriDön
            // 
            this.btnSehirGeriDön.Location = new System.Drawing.Point(54, 33);
            this.btnSehirGeriDön.Name = "btnSehirGeriDön";
            this.btnSehirGeriDön.Size = new System.Drawing.Size(198, 23);
            this.btnSehirGeriDön.TabIndex = 34;
            this.btnSehirGeriDön.Text = "Seçim Ekranına Geri Dön!";
            this.btnSehirGeriDön.UseVisualStyleBackColor = true;
            this.btnSehirGeriDön.Click += new System.EventHandler(this.btnSehirGeriDön_Click);
            // 
            // SehirIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 340);
            this.Controls.Add(this.btnSehirGeriDön);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSehirSil);
            this.Controls.Add(this.dgwSehirListele);
            this.Name = "SehirIslemleri";
            this.Text = "Şehir İşlemleri";
            this.Load += new System.EventHandler(this.SehirIslemleri_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwSehirListele)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSehirGuncelle;
        private System.Windows.Forms.TextBox tbxSehirAdGuncelle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSehirEkle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxSehirAdEkle;
        private System.Windows.Forms.Button btnSehirSil;
        private System.Windows.Forms.DataGridView dgwSehirListele;
        private System.Windows.Forms.Button btnSehirGeriDön;
    }
}