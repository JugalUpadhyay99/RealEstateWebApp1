using Microsoft.AspNetCore.Mvc;
using RealEstate_BusinessEntity;
using RealEstate_BusinessService.Concreate;
using RealEstate_BusinessService.Interface;
using RealEstate_Repository.Interface;

namespace RealEstateWebApp1.Controllers
{
    public class PurposeController : Controller
    {
        private readonly IPurposeMasterService purposeMasterService;

        public PurposeController()
        {
            purposeMasterService = new PurposeMasterService();
        }
        public IActionResult Index()
        {
            return View();
        }
        public JsonResult GetAllPurpose()
        {
            return Json(new { data = purposeMasterService.GetAllPurpopse() });
        }
        [HttpGet]
        public PartialViewResult AddEditPurpose(int? id)
        {
            if (id.HasValue)
            {
                var d = purposeMasterService.GetPurposeById(id.Value);
                return PartialView("AddEditPurpose", d);
            }
            return PartialView("AddEditPurpose");
        }
        [HttpPost]
        public JsonResult SavePurpose(PurposeMasterViewModel purposeMasterViewModel)
        {
            var d = purposeMasterService.AddPurpose(purposeMasterViewModel);
            return Json(new { result = d, message = "Save info" });
        }
        [HttpPost]
        public JsonResult RemovePurpose(int id)
        {
            var d = purposeMasterService.RemovePurpose(id);
            return Json(new { result = d, message = "Removed info" });
        }
    }
}
