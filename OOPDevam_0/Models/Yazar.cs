using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDevam_0.Models
{
    public class Yazar
    {
        public string Ismi { get; set; }
        public string SoyIsmi { get; set; }
        public List<Kitap> Kitaplari { get; set; }

    }
}
