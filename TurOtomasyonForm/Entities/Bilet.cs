using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurOtomasyonForm.Entities
{
    public class Bilet
    {
        public int Id { get; set; }
        public int KoltukNo { get; set; }
        public int KalkisYeriId { get; set; }
        public int VarisYeriId { get; set; }
        public int FirmaId { get; set; }
        public int YolcuId { get; set; }
        public  DateTime KalkisZamani { get; set; }
        public DateTime VarisZamani { get; set; }

    }
}
