using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CSharpDiliOzellikleri.Models
{
    public class Urun
    {
        private int urunID;
        private string adi;
        private string aciklama;
        private decimal fiyat;
        private string kategori;
        public int UrunID
        {
            get { return urunID; }
            set { urunID = value; }
        }
        public string Adi
        {
            get { return adi; }
            set { adi = value; }
        }
        public string Aciklama
        {
            get { return aciklama; }
            set { aciklama = value; }
        }
    }
}