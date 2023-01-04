using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using EconomizeAqui.Controllers;

namespace EconomizeAqui.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : EconomizeAquiControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
