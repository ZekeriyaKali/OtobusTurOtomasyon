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
    public partial class FirmaIslemleri : Form
    {
        public FirmaIslemleri()
        {
            InitializeComponent();
        }

        private void btnFirmaGeriDon_Click(object sender, EventArgs e)
        {
            SecimEkrani secimEkrani = new SecimEkrani();
            secimEkrani.Show();
            this.Hide();
        }
        FirmaDal firmaDal= new FirmaDal();
        private void dgwFirmaListele_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxFirmaAdGuncelle.Text = dgwFirmaListele.CurrentRow.Cells[1].Value.ToString();
            tbxFirmaIletisimGuncelle.Text = dgwFirmaListele.CurrentRow.Cells[2].Value.ToString();
            tbxPersonelIdGuncelle.Text = dgwFirmaListele.CurrentRow.Cells[3].Value.ToString();
        }

        private void FirmaIslemleri_Load(object sender, EventArgs e)
        {
            dgwFirmaListele.DataSource = firmaDal.GetAll();
        }

        private void btnFirmaEkle_Click(object sender, EventArgs e)
        {
            firmaDal.Add(new Firma
            {
                FirmaAd=tbxFirmaAdEkle.Text,
                FirmaIletisim=Convert.ToInt32(tbxFirmaIletisimEkle.Text),
                PersonelId=Convert.ToInt32(tbxPersonelIdEkle.Text),
            });
            dgwFirmaListele.DataSource = firmaDal.GetAll();
            MessageBox.Show("Eklendi");
        }

        private void btnFirmaGuncelle_Click(object sender, EventArgs e)
        {
            firmaDal.Update(new Firma
            {
                Id = Convert.ToInt32(dgwFirmaListele.CurrentRow.Cells[0].Value.ToString()),
                FirmaAd = tbxFirmaAdGuncelle.Text,
                FirmaIletisim = Convert.ToInt32(tbxFirmaIletisimGuncelle.Text),
                PersonelId = Convert.ToInt32(tbxPersonelIdGuncelle.Text),
            });
            dgwFirmaListele.DataSource = firmaDal.GetAll();
            MessageBox.Show("Güncellendi");
        }

        private void btnFirmaSil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgwFirmaListele.CurrentRow.Cells[0].Value);
            firmaDal.Delete(id);
            dgwFirmaListele.DataSource = firmaDal.GetAll();
            MessageBox.Show("Silindi!");
        }
    }
}
