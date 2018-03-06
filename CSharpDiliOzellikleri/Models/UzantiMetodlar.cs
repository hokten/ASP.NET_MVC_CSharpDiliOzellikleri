using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CSharpDiliOzellikleri.Models
{
    public static class UzantiMetodlar
    {
        public static decimal ToplamFiyat(this Sepet sepetim)
        {
            decimal yekun = 0;
            foreach (Urun urn in sepetim.Urunler)
            {
                yekun += urn.Fiyat;
            }
            return yekun;
        }
    }
}