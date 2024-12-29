using Microsoft.AspNetCore.Mvc;
using RealEstate_BusinessEntity;
using RealEstate_BusinessService.Concreate;
using RealEstate_BusinessService.Interface;

namespace RealEstateWebApp1.Controllers
{
    public class RoleController : Controller
    {
        private readonly IRoleMasterService roleMasterService;

        public RoleController()
        {
            roleMasterService = new RoleMasterService();
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public JsonResult GetAllRole()
        {
            return Json(new { data = roleMasterService.GetAllRole() });
        }
        [HttpGet]
        public PartialViewResult AddEditRole(int? id)
        {
            if (id.HasValue)
            {
                var d = roleMasterService.GetRoleById(id.Value);
                return PartialView("AddEditRole", d);
            }
            return PartialView("AddEditRole");
        }
        [HttpPost]
        public JsonResult SaveRole(RoleMasterViewModel roleMasterViewModel)
        {
            var d = roleMasterService.AddRole(roleMasterViewModel);
            return Json(new { result = d, message = "Save info" });
        }
        [HttpPost]
        public JsonResult RemoveRole(int id)
        {
            var d = roleMasterService.RemoveRole(id);
            return Json(new { result = d, message = "Removed info" });
        }
    }
}
