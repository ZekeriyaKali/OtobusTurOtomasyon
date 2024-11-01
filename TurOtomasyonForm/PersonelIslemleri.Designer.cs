namespace TurOtomasyonForm
{
    partial class PersonelIslemleri
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnPersonelGuncelle = new System.Windows.Forms.Button();
            this.tbxPersonelTurGuncelle = new System.Windows.Forms.TextBox();
            this.tbxPersonelAdGuncelle = new System.Windows.Forms.TextBox();
            this.tbxPersonelSoyadGuncelle = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPersonelEkle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxPersonelTurEkle = new System.Windows.Forms.TextBox();
            this.tbxPersonelAdEkle = new System.Windows.Forms.TextBox();
            this.tbxPersonelSoyadEkle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPersonelSil = new System.Windows.Forms.Button();
            this.dgwPersonelListele = new System.Windows.Forms.DataGridView();
            this.btnPersonelGeriDon = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPersonelListele)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btnPersonelGuncelle);
            this.groupBox2.Controls.Add(this.tbxPersonelTurGuncelle);
            this.groupBox2.Controls.Add(this.tbxPersonelAdGuncelle);
            this.groupBox2.Controls.Add(this.tbxPersonelSoyadGuncelle);
            this.groupBox2.Location = new System.Drawing.Point(775, 115);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(225, 173);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Personel Güncelle";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Personel Tür:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Personel Soyadı:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Personel Adı:";
            // 
            // btnPersonelGuncelle
            // 
            this.btnPersonelGuncelle.Location = new System.Drawing.Point(104, 128);
            this.btnPersonelGuncelle.Name = "btnPersonelGuncelle";
            this.btnPersonelGuncelle.Size = new System.Drawing.Size(100, 25);
            this.btnPersonelGuncelle.TabIndex = 17;
            this.btnPersonelGuncelle.Text = "Güncelle";
            this.btnPersonelGuncelle.UseVisualStyleBackColor = true;
            this.btnPersonelGuncelle.Click += new System.EventHandler(this.btnPersonelGuncelle_Click);
            // 
            // tbxPersonelTurGuncelle
            // 
            this.tbxPersonelTurGuncelle.Location = new System.Drawing.Point(104, 31);
            this.tbxPersonelTurGuncelle.Name = "tbxPersonelTurGuncelle";
            this.tbxPersonelTurGuncelle.Size = new System.Drawing.Size(100, 20);
            this.tbxPersonelTurGuncelle.TabIndex = 0;
            // 
            // tbxPersonelAdGuncelle
            // 
            this.tbxPersonelAdGuncelle.Location = new System.Drawing.Point(104, 62);
            this.tbxPersonelAdGuncelle.Name = "tbxPersonelAdGuncelle";
            this.tbxPersonelAdGuncelle.Size = new System.Drawing.Size(100, 20);
            this.tbxPersonelAdGuncelle.TabIndex = 1;
            // 
            // tbxPersonelSoyadGuncelle
            // 
            this.tbxPersonelSoyadGuncelle.Location = new System.Drawing.Point(104, 92);
            this.tbxPersonelSoyadGuncelle.Name = "tbxPersonelSoyadGuncelle";
            this.tbxPersonelSoyadGuncelle.Size = new System.Drawing.Size(100, 20);
            this.tbxPersonelSoyadGuncelle.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPersonelEkle);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbxPersonelTurEkle);
            this.groupBox1.Controls.Add(this.tbxPersonelAdEkle);
            this.groupBox1.Controls.Add(this.tbxPersonelSoyadEkle);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(49, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(229, 173);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personel Ekle";
            // 
            // btnPersonelEkle
            // 
            this.btnPersonelEkle.Location = new System.Drawing.Point(102, 128);
            this.btnPersonelEkle.Name = "btnPersonelEkle";
            this.btnPersonelEkle.Size = new System.Drawing.Size(100, 25);
            this.btnPersonelEkle.TabIndex = 16;
            this.btnPersonelEkle.Text = "Ekle";
            this.btnPersonelEkle.UseVisualStyleBackColor = true;
            this.btnPersonelEkle.Click += new System.EventHandler(this.btnPersonelEkle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Personel Tür:";
            // 
            // tbxPersonelTurEkle
            // 
            this.tbxPersonelTurEkle.Location = new System.Drawing.Point(102, 31);
            this.tbxPersonelTurEkle.Name = "tbxPersonelTurEkle";
            this.tbxPersonelTurEkle.Size = new System.Drawing.Size(100, 20);
            this.tbxPersonelTurEkle.TabIndex = 0;
            // 
            // tbxPersonelAdEkle
            // 
            this.tbxPersonelAdEkle.Location = new System.Drawing.Point(102, 62);
            this.tbxPersonelAdEkle.Name = "tbxPersonelAdEkle";
            this.tbxPersonelAdEkle.Size = new System.Drawing.Size(100, 20);
            this.tbxPersonelAdEkle.TabIndex = 1;
            // 
            // tbxPersonelSoyadEkle
            // 
            this.tbxPersonelSoyadEkle.Location = new System.Drawing.Point(102, 92);
            this.tbxPersonelSoyadEkle.Name = "tbxPersonelSoyadEkle";
            this.tbxPersonelSoyadEkle.Size = new System.Drawing.Size(100, 20);
            this.tbxPersonelSoyadEkle.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Personel Soyadı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Personel Adı:";
            // 
            // btnPersonelSil
            // 
            this.btnPersonelSil.Location = new System.Drawing.Point(468, 318);
            this.btnPersonelSil.Name = "btnPersonelSil";
            this.btnPersonelSil.Size = new System.Drawing.Size(75, 25);
            this.btnPersonelSil.TabIndex = 23;
            this.btnPersonelSil.Text = "Sil";
            this.btnPersonelSil.UseVisualStyleBackColor = true;
            this.btnPersonelSil.Click += new System.EventHandler(this.btnPersonelSil_Click);
            // 
            // dgwPersonelListele
            // 
            this.dgwPersonelListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwPersonelListele.Location = new System.Drawing.Point(345, 107);
            this.dgwPersonelListele.Name = "dgwPersonelListele";
            this.dgwPersonelListele.Size = new System.Drawing.Size(322, 181);
            this.dgwPersonelListele.TabIndex = 22;
            this.dgwPersonelListele.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwPersonelListele_CellClick);
            // 
            // btnPersonelGeriDon
            // 
            this.btnPersonelGeriDon.Location = new System.Drawing.Point(49, 33);
            this.btnPersonelGeriDon.Name = "btnPersonelGeriDon";
            this.btnPersonelGeriDon.Size = new System.Drawing.Size(229, 23);
            this.btnPersonelGeriDon.TabIndex = 35;
            this.btnPersonelGeriDon.Text = "Seçim Ekranına Geri Dön!";
            this.btnPersonelGeriDon.UseVisualStyleBackColor = true;
            this.btnPersonelGeriDon.Click += new System.EventHandler(this.btnPersonelGeriDon_Click);
            // 
            // PersonelIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 450);
            this.Controls.Add(this.btnPersonelGeriDon);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnPersonelSil);
            this.Controls.Add(this.dgwPersonelListele);
            this.Name = "PersonelIslemleri";
            this.Text = "Personel İşlemleri";
            this.Load += new System.EventHandler(this.PersonelIslemleri_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPersonelListele)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnPersonelGuncelle;
        private System.Windows.Forms.TextBox tbxPersonelTurGuncelle;
        private System.Windows.Forms.TextBox tbxPersonelAdGuncelle;
        private System.Windows.Forms.TextBox tbxPersonelSoyadGuncelle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPersonelEkle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxPersonelTurEkle;
        private System.Windows.Forms.TextBox tbxPersonelAdEkle;
        private System.Windows.Forms.TextBox tbxPersonelSoyadEkle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPersonelSil;
        private System.Windows.Forms.DataGridView dgwPersonelListele;
        private System.Windows.Forms.Button btnPersonelGeriDon;
    }
}