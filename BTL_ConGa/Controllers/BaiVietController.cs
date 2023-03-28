using Microsoft.AspNetCore.Mvc;

namespace BTL_ConGa.Controllers
{
    public class BaiVietController : Controller
    {
        public IActionResult BaiViet()
        {
            return View("Views/BaiViet/BaiViet.cshtml");
        }
        public IActionResult ChiTietBaiViet()
        {
            return View("Views/BaiViet/ChiTietBaiViet.cshtml");
        }
    }
}
