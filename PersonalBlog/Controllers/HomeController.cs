using Microsoft.AspNetCore.Mvc;
using PersonalBlog.Interfaces;
using PersonalBlog.Models;
using System.Diagnostics;

namespace PersonalBlog.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDataService _dataService;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, IDataService dataService)
        {
            _logger = logger;
            _dataService = dataService;
        }

        [Route("Post")]
        [HttpGet]
        public async Task<IActionResult> CreatePost(Post model)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("Validation", "Please provide all values");
            }

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Post(Post model)
        {
            await _dataService.Create(model);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Index()
        {
            var allRows = await _dataService.GetAll();
            return View(allRows);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}