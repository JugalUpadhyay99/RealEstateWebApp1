using Microsoft.AspNetCore.Mvc;
using RealEstate_BusinessEntity;
using RealEstate_BusinessService.Concreate;
using RealEstate_BusinessService.Interface;

namespace RealEstateWebApp1.Controllers
{
    public class CountryController : Controller
    {
        private readonly ICountryMasterService countryMasterService;

        public CountryController()
        {
            countryMasterService = new CountryMasterService();
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GetAllCountries()
        {
            return Json(new { data = countryMasterService.GetAllCountries() });
        }
        [HttpGet]
        public PartialViewResult AddEditCountry(int? id)
        {
            if (id.HasValue)
            {
                var d = countryMasterService.GetCountryById(id.Value);
                return PartialView("AddEditCountry", d);
               // return PartialView("~/Views/Country/AddEditCountry.cshtml", d);
            }
            return PartialView("AddEditCountry");

        }
        [HttpPost]
        public JsonResult AddCountry(CountryMasterViewModel countryDetailsViewModel)
        {
            var d = countryMasterService.AddCountry(countryDetailsViewModel);
            return Json(new { result = d, message = "Save info" });
        }
        [HttpPost]
        public JsonResult RemoveCountry(int id)
        {
            var d = countryMasterService.RemoveCountry(id);
            return Json(new { result = d, message = "Removed info" });
        }
    }
}
