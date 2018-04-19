using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CSharpDiliOzellikleri.Models;

namespace CSharpDiliOzellikleri.Controllers
{
    public class HomeController : Controller
    {
        private IEnumerable<Urun> sepetim = new Sepet
        {
            Urunler = new List<Urun>
                {
                    new Urun {Adi="Kayık", Kategori="Spor", Fiyat=175M },
                    new Urun {Adi="Can Yeleği", Kategori="Sağlık", Fiyat=35M },
                    new Urun {Adi="Futbol Topu", Kategori="Spor", Fiyat=15M },
                    new Urun {Adi="Krampon", Kategori="Futbol", Fiyat=45M}
                }
        };

        // GET: Home
        public string Index()
        {
            return "Deneme istediğiniz URL'yi açın";
        }
        public ViewResult OtoOzellik()
        {
            // yeni bir urun nesnesi olustur
            Urun urunum = new Urun();
            // urunum nesnesinin Adi özelliğine bir değer ata
            urunum.Adi = "Kayık";
            // urunum nesnesinin Adi özelliğindeki değeri çek
            string urunIsmi = urunum.Adi;
            // view üret
            return View("Result",
            (object)String.Format("Ürün adı: {0}", urunIsmi));
        }
        public ViewResult UrunOlustur()
        {
            // urun nesnesi kısa ve kolay yolla oluşturuldu
            Urun urunum = new Urun
            {
                UrunID = 100,
                Adi = "Kayık",
                Aciklama = "Tek kişilik su taşıtı",
                Fiyat = 175M,
                Kategori = "Su Sporları"
            };
            return View("Result",
            (object)String.Format("Kategorisi : {0}", urunum.Kategori));
        }
        public ViewResult KoleksiyonOlustur()
        {
            string[] meyveDizisi = { "elma", "portakal", "armut" };
            List<int> tamsayiListesi = new List<int> { 10, 20, 30, 40 };
            Dictionary<string, int> sozlukDizisi = new Dictionary<string, int>
            {
                { "elma", 10 },
                { "portakal", 20 },
                { "armut", 30 }
            };
            return View("Result", (object)meyveDizisi[1]);
        }
        public ViewResult UzantiMetodlariKullan()
        {
            decimal sepetYekunu = sepetim.ToplamFiyat();
            return View("Result", (object)String.Format("Toplam Sepet Fiyatı : {0:c}", sepetYekunu));
        }
        public ViewResult UzantiMetodlariKullanEnum()
        {
            

            Urun[] urunDizisi =
            {
                new Urun {Adi="Kayık", Fiyat=175M },
                new Urun {Adi="Can Yeleği", Fiyat=35M },
                new Urun {Adi="Futbol Topu", Fiyat=15M },
                new Urun {Adi="Krampon", Fiyat=45M}
            };

            decimal sepetYekunu = sepetim.ToplamFiyat();
            decimal diziYekunu = urunDizisi.ToplamFiyat();
            return View("Result", (object)String.Format("Toplam Sepet Fiyatı : {0}, Ürün Dizisi Toplamı : {1}", sepetYekunu, diziYekunu));
        }

        public ViewResult KategoriFiltresi()
        {
            decimal toplam_fiyat = 0;
            foreach(Urun urn in sepetim.KategoriyeGoreFiltre("Spor"))
            {
                toplam_fiyat += urn.Fiyat;
            }
            return View("Result", (object)String.Format("Toplam Kategori Fiyatı : {0}", toplam_fiyat));

        }
        public ViewResult KategoriFiltresiFunc()
        {
            decimal toplam_fiyat = 0;
            foreach (Urun urn in sepetim.Filtre(urun => urun.Kategori=="Spor"))
            {
                toplam_fiyat += urn.Fiyat;
            }
            return View("Result", (object)String.Format("Toplam Kategori Fiyatı : {0}", toplam_fiyat));

        }

    }
}