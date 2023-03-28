using BTL_ConGa.Models;
using BTL_ConGa.Models.TaiKhoanAPI;
using BTL_ConGa.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BTL_ConGa.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaiKhoanAPIController : ControllerBase
    {
        private readonly IUserInforService _userInforService;
        BtlWebContext db = new BtlWebContext();
        public TaiKhoanAPIController(IUserInforService userInforService, BtlWebContext db)
        {
            _userInforService = userInforService;
            this.db = db;
        }
        // Tu sinh ra ma KhachHang

        
        [HttpPost]
        public async Task<IActionResult> DangKy([FromBody]TaiKhoanIn4Model taiKhoan)
        {
            try
            {
                var itemCheckExsits = db.TaiKhoans.FirstOrDefault(x => x.TaiKhoan1 == taiKhoan.Username);
                if(itemCheckExsits != null)
                    throw new Exception("Đăng kí không thành công");
                await _userInforService.Register(taiKhoan);
                return Ok();
            }
            catch
            {
                throw new Exception("Đăng kí không thành công"); 
            }
        }
        
    }
}
