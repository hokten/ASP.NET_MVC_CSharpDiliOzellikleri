using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CSharpDiliOzellikleri.Models
{
    public class Sepet : IEnumerable<Urun>
    {
        public List<Urun> Urunler { get; set; }
        public IEnumerator<Urun> GetEnumerator()
        {
            return Urunler.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
    
}