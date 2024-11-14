using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDevam_0.Tools
{
    public class Ogrenci
    {
        public string Ismi { get; set; }
        public string SoyIsmi { get; set; }
        public Lab Labi { get; set; }

        public string BilgiGoster()
        {
            return $"{Ismi} {SoyIsmi}..Lab => {Labi.BilgiGoster()}";
        }

    }
}
