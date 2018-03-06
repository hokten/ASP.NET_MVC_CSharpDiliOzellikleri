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
        // GET: Home
        public string Index()
        {
            return "Deneme istediğini URL'yi açın";
        }
    }
}