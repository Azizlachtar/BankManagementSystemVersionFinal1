using Microsoft.AspNetCore.Mvc;

namespace BankManagementSystemVersionFinal1.Controllers.Manager
{

    public class ManagerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
