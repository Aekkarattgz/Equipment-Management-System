using Microsoft.AspNetCore.Mvc;

namespace Equipment_Management_System.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
