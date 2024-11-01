using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TurOtomasyonForm
{
    public partial class SecimEkrani : Form
    {
        public SecimEkrani()
        {
            InitializeComponent();
        }

        private void btnBiletIslemleri_Click(object sender, EventArgs e)
        {
            BiletIslemleri biletIslemleri = new BiletIslemleri();
            biletIslemleri.Show();
            this.Hide();

        }

        private void btnFirmaIslemleri_Click(object sender, EventArgs e)
        {
            FirmaIslemleri firmaIslemleri = new FirmaIslemleri();
            firmaIslemleri.Show();
            this.Hide();
        }

        private void btnYolcuIslemleri_Click(object sender, EventArgs e)
        {
            YolcuIslemleri yolcuIslemleri=new YolcuIslemleri();
            yolcuIslemleri.Show();
            this.Hide();
        }

        private void btnPersonelIslemleri_Click(object sender, EventArgs e)
        {
            PersonelIslemleri personelIslemleri =new PersonelIslemleri();
            personelIslemleri.Show();
            this.Hide();
        }

        private void btnSehirIslemleri_Click(object sender, EventArgs e)
        {
            SehirIslemleri sehirIslemleri= new SehirIslemleri();
            sehirIslemleri.Show();
            this.Hide();
        }
    }
}
