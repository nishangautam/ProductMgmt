using Microsoft.AspNetCore.Mvc;

namespace ProductMgmt.Controllers{
    public class ProductController : Controller{
        public IActionResult Index(){
            return View();
        }
        public IActionResult Details(){
            ViewBag.Title="Details";
            return View();
        }
    }
}
