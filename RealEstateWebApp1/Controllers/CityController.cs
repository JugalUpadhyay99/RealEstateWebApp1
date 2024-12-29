using Microsoft.AspNetCore.Mvc;
using RealEstate_BusinessEntity;
using RealEstate_BusinessService.Concreate;
using RealEstate_BusinessService.Interface;
using RealEstate_Repository.Concreate;

namespace RealEstateWebApp1.Controllers
{
    public class CityController : Controller
    {
        private readonly ICityMasterService cityMasterService;
        private readonly IStateMasterService stateMasterService;


        public CityController()
        {
            cityMasterService = new CityMasterService();
            stateMasterService = new StateMasterService();
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult GetAllCity()
        {
            return Json(new { data = cityMasterService.GetAllCity() });
        }
        [HttpGet]
        public PartialViewResult AddEditCity(int? id)
        {
            CityMasterViewModel cityMasterViewModel1 = new CityMasterViewModel();
            cityMasterViewModel1.StateMasters = stateMasterService.GetAllStates();
            if (id.HasValue)
            {
                
                cityMasterViewModel1.StateMasters = stateMasterService.GetAllStates();
                var d = cityMasterService.GetCityById(id.Value);
                return PartialView("AddEditCity",d);
            }
            return PartialView("AddEditCity", cityMasterViewModel1);
        }
        [HttpPost]
        public JsonResult SaveCity(CityMasterViewModel cityMasterViewModel) 
        {
            CityMasterViewModel cityMasterViewModel1 = new CityMasterViewModel();
            cityMasterViewModel1.StateMasters = stateMasterService.GetAllStates();
            var d = cityMasterService.AddCity(cityMasterViewModel);
            return Json(new { result = d, message = "Save info" });
        }
        [HttpPost]
        public JsonResult RemoveCity(int id)
        {
            var d = cityMasterService.RemoveCity(id);
            return Json(new { result = d, message = "Removed info" });
        }
    }
}
