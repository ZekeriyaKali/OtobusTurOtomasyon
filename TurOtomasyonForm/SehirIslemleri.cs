using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TurOtomasyonForm.DAL;
using TurOtomasyonForm.Entities;

namespace TurOtomasyonForm
{
    public partial class SehirIslemleri : Form
    {
        public SehirIslemleri()
        {
            InitializeComponent();
        }
        SehirDal sehirDal = new SehirDal();
        private void btnSehirGeriDön_Click(object sender, EventArgs e)
        {
            SecimEkrani secimEkrani = new SecimEkrani();
            secimEkrani.Show();
            this.Hide();
        }

        private void SehirIslemleri_Load(object sender, EventArgs e)
        {
            dgwSehirListele.DataSource = sehirDal.GetAll();
        }

        private void btnSehirEkle_Click(object sender, EventArgs e)
        {
            sehirDal.Add(new Sehir
            {
                SehirAd=tbxSehirAdEkle.Text
            }
                );
            dgwSehirListele.DataSource = sehirDal.GetAll();
            MessageBox.Show("Eklendi");
        }

        private void dgwSehirListele_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxSehirAdGuncelle.Text = dgwSehirListele.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnSehirGuncelle_Click(object sender, EventArgs e)
        {
            sehirDal.Update(new Sehir
            {
                Id= Convert.ToInt32(dgwSehirListele.CurrentRow.Cells[0].Value.ToString()),
                SehirAd = tbxSehirAdGuncelle.Text
            }
              );
            dgwSehirListele.DataSource = sehirDal.GetAll();
            MessageBox.Show("Güncellendi");
        }

        private void btnSehirSil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgwSehirListele.CurrentRow.Cells[0].Value);
            sehirDal.Delete(id);
            dgwSehirListele.DataSource = sehirDal.GetAll();
            MessageBox.Show("Silindi!");
        }
    }
}
