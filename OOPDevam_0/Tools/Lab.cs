using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDevam_0.Tools
{
    public class Lab
    {
        public string LabNo { get; set; }
        public string Kati { get; set; }
        public List<Ogrenci> Ogrenciler { get; set; }

        public string BilgiGoster()
        {
            return $"{LabNo}..Katı => {Kati}";
        }

    }
}
