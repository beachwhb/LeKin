using System.Web.Mvc;

namespace LeKin.Web.Controllers
{
    public class AboutController : LeKinControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}