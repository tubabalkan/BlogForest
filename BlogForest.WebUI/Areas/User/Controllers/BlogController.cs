using BlogForest.BusinessLayer.Abstract;
using BlogForest.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BlogForest.WebUI.Areas.User.Controllers
{
    [Area("User")]
    public class BlogController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly IBlogService _blogService;

        public BlogController(UserManager<AppUser> userManager, IBlogService blogService)
        {
            _userManager = userManager;
            _blogService = blogService;
        }

        public async Task<IActionResult> MyBlogList()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            var blogList = _blogService.TGetBlogsByAppUser(values.Id);
            return View(blogList);
        }
    }
}
