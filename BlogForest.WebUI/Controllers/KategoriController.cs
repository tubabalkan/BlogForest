using Microsoft.AspNetCore.Mvc;

namespace BlogForest.WebUI.Controllers
{
    public class KategoriController : Controller
    {
        public IActionResult KategoriList()
        {
            return View();
        }
    }
}
