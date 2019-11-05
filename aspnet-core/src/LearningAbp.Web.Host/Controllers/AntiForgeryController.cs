using Microsoft.AspNetCore.Antiforgery;
using LearningAbp.Controllers;

namespace LearningAbp.Web.Host.Controllers
{
    public class AntiForgeryController : LearningAbpControllerBase
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
