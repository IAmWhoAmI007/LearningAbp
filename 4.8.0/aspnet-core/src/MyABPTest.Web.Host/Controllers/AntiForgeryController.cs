using Microsoft.AspNetCore.Antiforgery;
using MyABPTest.Controllers;

namespace MyABPTest.Web.Host.Controllers
{
    public class AntiForgeryController : MyABPTestControllerBase
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
