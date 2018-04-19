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
        public static IEnumerable<Urun> KategoriyeGoreFiltre(this IEnumerable<Urun> urunEnum, 
            string filtreKategori)
        {
            foreach(Urun urn in urunEnum)
            {
                if(urn.Kategori == filtreKategori)
                {
                    yield return urn;
                }
            }
        }

        public static IEnumerable<Urun> Filtre(
            this IEnumerable<Urun> urunEnum, Func<Urun, bool> filtreSecimi)
        {
            foreach(Urun urn in urunEnum)
            {
                if(filtreSecimi(urn))
                {
                    yield return urn;
                }
            }
        }
    }
}