using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoruApp.core.Dtos
{
    public class UrunDto
    {
        public int Id { get; set; }
        public string CategoryIsmi { get; set; }
        public string Urunismi { get; set; }
        public string UrunAciklamasi { get; set; }
    }
}
