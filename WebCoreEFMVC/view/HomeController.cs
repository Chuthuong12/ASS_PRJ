using Microsoft.AspNetCore.Mvc;
using System.Linq;
using WebCoreEFMVC.DataAccess;
namespace WebCoreEFMVC.view
{
    public class HomeController : Controller
    {
        QLdienthoaiContext context = new QLdienthoaiContext();
        public IActionResult Index()
        {
            ViewBag.Hedieuhanh = context.Hedieuhanhs.ToList();
            return View(context.Sanphams.ToList());
        }
        [HttpPost]
        public IActionResult Index(int cateid)
        {
            ViewBag.Selected = cateid;
            ViewBag.Hedieuhanh = context.Hedieuhanhs.ToList();
            var ListProduct = context.Sanphams.ToList();
            if (cateid != 0)
            {
                ListProduct = (from p in context.Sanphams
                               where p.Masp == cateid
                               select p).ToList();
            }
            return View(ListProduct);
        }
    }
}
