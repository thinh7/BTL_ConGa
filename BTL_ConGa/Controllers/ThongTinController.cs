using Microsoft.AspNetCore.Mvc;

namespace BTL_ConGa.Controllers
{
    public class ThongTinController : Controller
    {
        public IActionResult GioiThieu()
        {
            return View("Views/ThongTin/GioiThieu.cshtml");
        }
        public IActionResult LienHe()
        {
            return View("Views/ThongTin/LienHe.cshtml");
        }
        public IActionResult DiaChiNhaHang()
        {
            return View("Views/ThongTin/DiaChiNhaHang.cshtml");
        }
    }
}
