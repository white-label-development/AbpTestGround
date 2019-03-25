using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using AbpTestGround.Controllers;

namespace AbpTestGround.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AboutController : AbpTestGroundControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
