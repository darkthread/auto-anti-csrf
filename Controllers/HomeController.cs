using Microsoft.AspNetCore.Mvc;

namespace auto_csrf.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(string data)
        {
            return Content($"Received data: {data}");
        }
        
        [HttpGet]
        public IActionResult Ajax()
        {
            return View();
        }
        public record Entity(string Name, int Count);
        [HttpPost]
        public IActionResult Ajax([FromBody]Entity data)
        {
            return Json(data);
        }
    }
}