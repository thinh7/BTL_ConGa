using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor.Compilation;

namespace BTL_ConGa.Controllers
{
    public class TrangChuController : Controller
    {
        public IActionResult TrangChu()
        {
            return View("Views/TrangChu/TrangChu.cshtml");
        }
        
        
    }
}
