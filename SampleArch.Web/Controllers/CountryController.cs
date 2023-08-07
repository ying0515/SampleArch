using SampleArch.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SampleArch.Web.Controllers
{
    public class CountryController : Controller
    {
        //initialize service object
        ICountryService _CountryService;

        public CountryController(ICountryService countryService)
        {
            _CountryService = countryService;
        }

        // GET: Country
        public ActionResult Index()
        {
            var data = _CountryService.GetAll();
            var aa = data.ToList();
            return View();
        }
    }
}