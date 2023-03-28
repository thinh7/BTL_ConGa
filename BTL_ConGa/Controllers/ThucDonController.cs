using Microsoft.AspNetCore.Mvc;

namespace BTL_ConGa.Controllers
{
    public class ThucDonController : Controller
    {
        public IActionResult ComBo()
        {
            return View("Views/ThucDon/ComBo.cshtml");
        }
        public IActionResult ThucAnTrua()
        {
            return View("Views/ThucDon/ThucAnTrua.cshtml");
        }
        public IActionResult NuocUong()
        {
            return View("Views/ThucDon/NuocUong.cshtml");
        }
        public IActionResult MonChinh()
        {
            return View("Views/ThucDon/MonChinh.cshtml");
        }
        public IActionResult DongGia()
        {
            return View("Views/ThucDon/DongGia.cshtml");
        }
    }
}
