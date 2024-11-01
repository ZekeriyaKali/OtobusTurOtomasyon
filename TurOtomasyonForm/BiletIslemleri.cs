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
    public partial class BiletIslemleri : Form
    {
        public BiletIslemleri()
        {
            InitializeComponent();
        }

        private void btnBiletGeriDon_Click(object sender, EventArgs e)
        {
            SecimEkrani secimEkrani = new SecimEkrani();
            secimEkrani.Show();
            this.Hide();
        }

        BiletDal biletDal = new BiletDal();
        private void BiletIslemleri_Load(object sender, EventArgs e)
        {
            dgwBiletListele.DataSource = biletDal.GetAll();
        }

        private void dgwBiletListele_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxKoltuknoGuncelle.Text = dgwBiletListele.CurrentRow.Cells[1].Value.ToString();
            tbxKalkisYeriIdGuncelle.Text = dgwBiletListele.CurrentRow.Cells[2].Value.ToString();
            tbxVarisYeriIdGuncelle.Text = dgwBiletListele.CurrentRow.Cells[3].Value.ToString();
            tbxFirmaIdGuncelle.Text = dgwBiletListele.CurrentRow.Cells[4].Value.ToString();
            tbxYolcuIdGuncelle.Text = dgwBiletListele.CurrentRow.Cells[5].Value.ToString();
            dtprKalkisZamaniGuncelle.Text = dgwBiletListele.CurrentRow.Cells[6].Value.ToString();
            dtprVarisZamaniGuncelle.Text = dgwBiletListele.CurrentRow.Cells[7].Value.ToString();
        }

        private void btnBiletEkle_Click(object sender, EventArgs e)
        {
            biletDal.Add(new Bilet
            {
                KoltukNo=Convert.ToInt32(tbxKoltuknoEkle.Text),
                KalkisYeriId=Convert.ToInt32(tbxKalkisYeriIdEkle.Text),
                VarisYeriId=Convert.ToInt32(tbxVarisYeriIdEkle.Text),
                FirmaId=Convert.ToInt32(tbxFirmaIdEkle.Text),
                YolcuId=Convert.ToInt32(tbxYolcuIdEkle.Text),
                KalkisZamani=Convert.ToDateTime(dtprKalkisZamaniEkle.Text),
                VarisZamani=Convert.ToDateTime(dtprVarisZamaniEkle.Text)
            });
            dgwBiletListele.DataSource = biletDal.GetAll();
            MessageBox.Show("Eklendi");
        }

        private void btnBiletGuncelle_Click(object sender, EventArgs e)
        {
            biletDal.Update(new Bilet
            {
                Id = Convert.ToInt32(dgwBiletListele.CurrentRow.Cells[0].Value.ToString()),
                KoltukNo = Convert.ToInt32(tbxKoltuknoGuncelle.Text),
                KalkisYeriId = Convert.ToInt32(tbxKalkisYeriIdGuncelle.Text),
                VarisYeriId = Convert.ToInt32(tbxVarisYeriIdGuncelle.Text),
                FirmaId = Convert.ToInt32(tbxFirmaIdGuncelle.Text),
                YolcuId = Convert.ToInt32(tbxYolcuIdGuncelle.Text),
                KalkisZamani = Convert.ToDateTime(dtprKalkisZamaniGuncelle.Text),
                VarisZamani = Convert.ToDateTime(dtprVarisZamaniGuncelle.Text)
            });
            dgwBiletListele.DataSource = biletDal.GetAll();
            MessageBox.Show("Güncellendi");
        }

        private void btnBiletSil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgwBiletListele.CurrentRow.Cells[0].Value);
            biletDal.Delete(id);
            dgwBiletListele.DataSource = biletDal.GetAll();
            MessageBox.Show("Silindi!");
        }
    }
}
