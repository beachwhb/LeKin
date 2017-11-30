using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace LeKin.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : LeKinControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}