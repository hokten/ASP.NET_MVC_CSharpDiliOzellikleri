﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CSharpDiliOzellikleri.Models;

namespace CSharpDiliOzellikleri.Controllers
{
    public class HomeController : Controller
    {
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
            // yeni bir urun nesnesi oluştur.
            Urun urunum = new Urun();
            urunum.UrunID = 100;
            urunum.Adi = "Kayık";
            urunum.Aciklama = "Tek kişilik su taşıtı";
            urunum.Fiyat = 175M;
            urunum.Kategori = "Su Sporları";
            return View("Result",
            (object)String.Format("Kategorisi : {0}", urunum.Kategori));
        }
    }
}