using Microsoft.AspNetCore.Mvc;

namespace PierreSweets.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      ViewBag.PageTitle = "Home";
      return View();
    }
  }
}