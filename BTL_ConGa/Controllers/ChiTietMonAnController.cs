using Microsoft.AspNetCore.Mvc;

namespace BTL_ConGa.Controllers
{
    public class ChiTietMonAnController : Controller
    {
        // com bo
        public IActionResult ComBoBurger()
        {
            return View("Views/ChiTietMonAn/ComBo/ComBoBurger.cshtml");
        }
        public IActionResult ComBoMyY()
        {
            return View("Views/ChiTietMonAn/ComBo/ComBoMyY.cshtml");
        }

        // thuc an tru
        public IActionResult ComDuiGaSotNguVi()
        {
            return View("Views/ChiTietMonAn/ThucAnTrua/ComDuiGaSotNguVi.cshtml");
        }
        public IActionResult ComGaKhongXuongSotNguVi()
        {
            return View("Views/ChiTietMonAn/ThucAnTrua/ComGaKhongXuongSotNguVi.cshtml");
        }
        // nuoc uong
        public IActionResult Coca()
        {
            return View("Views/ChiTietMonAn/NuocUong/Coca.cshtml");
        }
        public IActionResult Dasani()
        {
            return View("Views/ChiTietMonAn/NuocUong/Dasani.cshtml");
        }
        // dong gia
        public IActionResult BanhXepTom()
        {
            return View("Views/ChiTietMonAn/DongGia/BanhXepTom.cshtml");
        }
        public IActionResult MienCuonRongBien()
        {
            return View("Views/ChiTietMonAn/DongGia/MienCuonRongBien.cshtml");
        }
        // mon chinh
        public IActionResult CanhGaSotNguVi()
        {
            return View("Views/ChiTietMonAn/MonChinh/CanhGaSotNguVi.cshtml");
        }
        public IActionResult CanhGaSotCayChayLuoi()
        {
            return View("Views/ChiTietMonAn/MonChinh/CanhGaSotCayChayLuoi.cshtml");
        }
    }
}
