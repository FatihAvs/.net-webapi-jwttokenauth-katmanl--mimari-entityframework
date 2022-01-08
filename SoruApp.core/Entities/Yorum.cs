using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoruApp.core.Entities
{
    public class Yorum
    {
        public int Id { get; set; }
        public int UrunId { get; set; }
        public string  YazanNick { get; set; }
        public string YorumunKendisi { get; set; }
    }
}
