using Microsoft.AspNetCore.Mvc;
using RealEstate_BusinessEntity;
using RealEstate_BusinessService.Concreate;
using RealEstate_BusinessService.Interface;

namespace RealEstateWebApp1.Controllers
{
    public class PropertyTypeController : Controller
    {
        private readonly IPropertyTypeMasterService propertyTypeMasterService;

        public PropertyTypeController()
        {
            propertyTypeMasterService = new PropertyTypeMasterService();
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public JsonResult GetAllPropertyType()
        {
            return Json(new { data = propertyTypeMasterService.GetAllPropertyType() });
        }
        [HttpGet]
        public PartialViewResult AddEditPropertyType(int? id)
        {
            if (id.HasValue)
            {
                var d = propertyTypeMasterService.GetPropertyTypeById(id.Value);
                return PartialView("AddEditPropertyType",d);
            }          
            return PartialView("AddEditPropertyType");
        }
        [HttpPost]
        public JsonResult SaveType(PropertyTypeMasterViewModel propertyTypeMasterViewModel)
        {
            var d = propertyTypeMasterService.AddPropertyType(propertyTypeMasterViewModel);
            return Json(new { result = d, message = "Save info" });
        }
        [HttpPost]
        public JsonResult RemovePropertyType(int id)
        {
            var d = propertyTypeMasterService.RemovePropertyType(id);
            return Json(new { result = d, message = "Removed info" });
        }
    }
}
