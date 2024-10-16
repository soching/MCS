using Microsoft.AspNetCore.Mvc;

namespace Group_Task.Controllers
{
    public class BoqWorkingType : Controller
    {
        public IActionResult Index()
        {
            return View();
        }   
        public IActionResult AddNewBoq()
        {
            return View();
        }
    }
}
