using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using EconomizeAqui.Controllers;

namespace EconomizeAqui.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AboutController : EconomizeAquiControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
