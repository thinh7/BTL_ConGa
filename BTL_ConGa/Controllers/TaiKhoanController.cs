using BTL_ConGa.Models;
using Microsoft.AspNetCore.Mvc;

namespace BTL_ConGa.Controllers
{
    public class TaiKhoanController : Controller
    {
        BtlWebContext btlWeb = new BtlWebContext();
        public IActionResult TaiKhoan()
        {
            return View("Views/TaiKhoan/TaiKhoan.cshtml");
        }
        public IActionResult ChiTietTaiKhoan()
        {
            return View("Views/TaiKhoan/ChiTietTaiKhoan.cshtml");
        }
        public IActionResult DoiMatKhau()
        {
            return View("Views/TaiKhoan/DoiMatKhau.cshtml");
        }
        public IActionResult LichSuDatHang()
        {
            return View("Views/TaiKhoan/LichSuDatHang.cshtml");
        }
        public IActionResult DangNhap()
        {
            return View("Views/TaiKhoan/DangNhap.cshtml");
        }
        public IActionResult DangKy()
        {
            return View();
        }
        
    }
}
