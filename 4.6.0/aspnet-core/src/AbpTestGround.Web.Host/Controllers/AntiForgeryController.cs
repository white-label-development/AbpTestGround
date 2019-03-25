using Microsoft.AspNetCore.Antiforgery;
using AbpTestGround.Controllers;

namespace AbpTestGround.Web.Host.Controllers
{
    public class AntiForgeryController : AbpTestGroundControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
