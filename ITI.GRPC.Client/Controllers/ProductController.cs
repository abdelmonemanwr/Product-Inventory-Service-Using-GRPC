using Microsoft.AspNetCore.Mvc;

namespace ITI.GRPC.Server.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
