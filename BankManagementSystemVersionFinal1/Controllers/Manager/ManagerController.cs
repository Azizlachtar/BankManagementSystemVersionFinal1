using Microsoft.AspNetCore.Mvc;

namespace BankManagementSystemVersionFinal1.Controllers.Manager
{
    [Route("manager")]
    public class ManagerController : Controller
    {
        public IActionResult Index()
        {
            return View("~/Views/Manager/Index/Index.cshtml");
        }
    }
}
