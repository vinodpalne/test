using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoCompleteTextBoxDemo.Models;
namespace AutoCompleteTextBoxDemo.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        CountryDbContext objCountryDbContext = new CountryDbContext();

        public ActionResult Index()
        {
            return View();
        }
        public JsonResult GetCountryList()
        {
            var vData = from c in objCountryDbContext.Country
                        select c.CountryName;
            
            return Json(vData.ToList(), JsonRequestBehavior.AllowGet);
        }
    }
}
