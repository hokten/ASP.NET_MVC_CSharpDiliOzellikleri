using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CSharpDiliOzellikleri.Models
{
    public class Urun
    {
        public int UrunID { get; set; }
        public string Adi { get; set; }
        public string Aciklama { get; set; }
        public decimal Fiyat { get; set; }
        public string Kategori { set; get; }
    }
}