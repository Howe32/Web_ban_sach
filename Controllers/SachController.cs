using Microsoft.AspNetCore.Mvc;
using Webbansach.Models;

namespace Webbansach.Controllers
{
    public class SachController : Controller
    {
        #region "ChuDe"
        // GET: ChudeController1
        public IActionResult ChuDe()
        {
            AppDbContext context = new AppDbContext();
            List<ChuDe> dsChuDe = context.ChuDes.ToList();
            return View(dsChuDe);
        }
        #endregion

        #region "Sach"
        public IActionResult Sach()
        {
            AppDbContext context = new AppDbContext();
            List<Sach> dsSach = context.Saches.ToList();
            return View(dsSach);
        }


        #endregion
    }
}