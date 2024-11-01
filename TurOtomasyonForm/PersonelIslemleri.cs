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
    public partial class PersonelIslemleri : Form
    {
        public PersonelIslemleri()
        {
            InitializeComponent();
        }
        PersonelDal personelDal= new PersonelDal();
        private void btnPersonelGeriDon_Click(object sender, EventArgs e)
        {
            SecimEkrani secimEkrani = new SecimEkrani();
            secimEkrani.Show();
            this.Hide();
        }

        private void dgwPersonelListele_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxPersonelAdGuncelle.Text = dgwPersonelListele.CurrentRow.Cells[1].Value.ToString();
            tbxPersonelSoyadGuncelle.Text = dgwPersonelListele.CurrentRow.Cells[2].Value.ToString();
            tbxPersonelTurGuncelle.Text = dgwPersonelListele.CurrentRow.Cells[3].Value.ToString();
        }

        private void PersonelIslemleri_Load(object sender, EventArgs e)
        {
            dgwPersonelListele.DataSource = personelDal.GetAll();
        }

        private void btnPersonelEkle_Click(object sender, EventArgs e)
        {
            personelDal.Add(new Personel
            {
                PersonelAd=tbxPersonelAdEkle.Text,
                PersonelSoyad=tbxPersonelSoyadEkle.Text,
                PersonelTur=tbxPersonelTurEkle.Text
            });
            dgwPersonelListele.DataSource = personelDal.GetAll();
            MessageBox.Show("Eklendi"); 
        }

        private void btnPersonelGuncelle_Click(object sender, EventArgs e)
        {
            personelDal.Update(new Personel
            {
                Id= Convert.ToInt32(dgwPersonelListele.CurrentRow.Cells[0].Value.ToString()),
                PersonelAd = tbxPersonelAdGuncelle.Text,
                PersonelSoyad = tbxPersonelSoyadGuncelle.Text,
                PersonelTur = tbxPersonelTurGuncelle.Text
            });
            dgwPersonelListele.DataSource = personelDal.GetAll();
            MessageBox.Show("Güncellendi");
        }

        private void btnPersonelSil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgwPersonelListele.CurrentRow.Cells[0].Value);
            personelDal.Delete(id);
            dgwPersonelListele.DataSource = personelDal.GetAll();
            MessageBox.Show("Silindi!");
        }
    }
}
