using Microsoft.AspNetCore.Mvc;

namespace BlogForest.WebUI.Controllers
{
    public class YorumController : Controller
    {
        public IActionResult YorumList()
        {
            return View();
        }
    }
}
