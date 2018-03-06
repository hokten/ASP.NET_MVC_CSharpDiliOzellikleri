using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CSharpDiliOzellikleri.Models
{
    public class Urun
    {
        private string adi;

        public int UrunID { get; set; }
        public string Adi
        {
            get
            {
                return UrunID + adi;
            }
            set
            {
                adi = value;
            }
        }
        public string Aciklama { get; set; }
        public decimal Fiyat { get; set; }
        public string Kategori { set; get; }
    }
}