using Microsoft.AspNetCore.Mvc;

namespace CRUDBestBuyPro.Controllers
{
    public class TemplateController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
