using Microsoft.AspNetCore.Mvc;
using RealEstate_BusinessEntity;
using RealEstate_BusinessService.Concreate;
using RealEstate_BusinessService.Interface;
using RealEstate_DataEntity;

namespace RealEstateWebApp1.Controllers
{
    public class StateController : Controller
    {
        private readonly IStateMasterService stateMasterService;
        private readonly ICountryMasterService countryMasterService;
        public StateController() 
        {
            stateMasterService = new StateMasterService();
            countryMasterService = new CountryMasterService();
        }
        public IActionResult Index()
        {
            StateMasterViewModel stateMasterViewModel1 = new StateMasterViewModel();
            stateMasterViewModel1.CountryMasters = countryMasterService.GetAllCountries();
            return View();
        }
        [HttpGet]

        public IActionResult GetAllStates()
        {
            return Json(new { data = stateMasterService.GetAllStates() });
        }
        [HttpGet]
        public PartialViewResult AddEditState(int? id)
        {
            StateMasterViewModel stateMasterViewModel1 = new StateMasterViewModel();
            stateMasterViewModel1.CountryMasters = countryMasterService.GetAllCountries();
            if (id.HasValue) 
            {
                stateMasterViewModel1.CountryMasters = countryMasterService.GetAllCountries();
                var d = stateMasterService.GetStateById(id.Value);
                return PartialView("AddEditState",d);
            }
            return PartialView("AddEditState",stateMasterViewModel1);
        }
        [HttpPost]
        public JsonResult SaveState(StateMasterViewModel stateMasterViewModel)
        {
            StateMasterViewModel stateMasterViewModel1 = new StateMasterViewModel();
            stateMasterViewModel1.CountryMasters = countryMasterService.GetAllCountries();
            var d = stateMasterService.AddState(stateMasterViewModel);
            return Json(new { result = d, message = "Save info" });
        }

        [HttpPost]
        public JsonResult RemoveState(int id)
        {
            var d = stateMasterService.RemoveState(id);
            return Json(new { result = d, message = "Removed info" });
        }
    }
}
