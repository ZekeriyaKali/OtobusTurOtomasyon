using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TurOtomasyonForm.DAL;
using TurOtomasyonForm.Entities;

namespace TurOtomasyonForm
{
    public partial class YolcuIslemleri : Form
    {
        public YolcuIslemleri()
        {
            InitializeComponent();
        }
        YolcuDal yolcuDal = new YolcuDal();
        private void btnYolcuGeriDon_Click(object sender, EventArgs e)
        {
            SecimEkrani secimEkrani = new SecimEkrani();
            secimEkrani.Show();
            this.Hide();
        }

        private void YolcuIslemleri_Load(object sender, EventArgs e)
        {
            dgwYolcuListele.DataSource = yolcuDal.GetAll();
        }

        private void dgwYolcuListele_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxYolcuAdGuncelle.Text = dgwYolcuListele.CurrentRow.Cells[1].Value.ToString();
            tbxYolcuSoyadGuncelle.Text= dgwYolcuListele.CurrentRow.Cells[2].Value.ToString();
            tbxYolcuTelefonGuncelle.Text = dgwYolcuListele.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnYolcuGuncelle_Click(object sender, EventArgs e)
        {
            yolcuDal.Update(new Yolcu
            {
                Id = Convert.ToInt32(dgwYolcuListele.CurrentRow.Cells[0].Value.ToString()),
                YolcuAd=tbxYolcuAdGuncelle.Text,
                YolcuSoyad=tbxYolcuSoyadGuncelle.Text,
                YolcuTelefon=Convert.ToInt32(tbxYolcuTelefonGuncelle.Text)
            }
                );
            dgwYolcuListele.DataSource = yolcuDal.GetAll();
            MessageBox.Show("Güncellendi");
        }

        private void btnYolcuEkle_Click(object sender, EventArgs e)
        {
            yolcuDal.Add(new Yolcu
            {
                YolcuAd = tbxYolcuAdEkle.Text,
                YolcuSoyad = tbxYolcuSoyadEkle.Text,
                YolcuTelefon = Convert.ToInt32(tbxYolcuTelefonEkle.Text)
            }
               );
            dgwYolcuListele.DataSource = yolcuDal.GetAll();
            MessageBox.Show("Eklendi");
        }

        private void btnYolcuSil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgwYolcuListele.CurrentRow.Cells[0].Value);
            yolcuDal.Delete(id);
            dgwYolcuListele.DataSource = yolcuDal.GetAll();
            MessageBox.Show("Silindi!");
        }
    }
}
