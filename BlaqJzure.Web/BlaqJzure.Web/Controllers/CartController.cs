using Microsoft.AspNetCore.Mvc;

namespace BlaqJzure.Web.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
