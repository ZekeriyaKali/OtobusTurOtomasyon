using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurOtomasyonForm.Entities
{
    public class Firma
    {
        public int Id { get; set; }
        public string FirmaAd { get; set; }
        public double FirmaIletisim { get; set; }
        public int PersonelId { get; set; }
    }
}
