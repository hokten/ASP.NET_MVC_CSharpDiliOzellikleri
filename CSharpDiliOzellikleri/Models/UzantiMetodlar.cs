using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CSharpDiliOzellikleri.Models
{
    public static class UzantiMetodlar
    {
        public static decimal ToplamFiyat(this IEnumerable<Urun> urunEnum)
        {
            decimal yekun = 0;
            foreach (Urun urn in urunEnum)
            {
                yekun += urn.Fiyat;
            }
            return yekun;
        }
    }
}