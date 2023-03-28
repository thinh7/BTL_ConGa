using Microsoft.AspNetCore.Mvc;

namespace BTL_ConGa.Controllers
{
    public class GioHangController : Controller
    {
        public IActionResult GioHang()
        {
            return View("Views/GioHang/GioHang.cshtml");
        }
        public IActionResult ThanhToan()
        {
            return View("Views/GioHang/ThanhToan.cshtml");
        }
    }
}
