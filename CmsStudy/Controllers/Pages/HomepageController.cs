using CmsStudy.Models.Pages;
using EPiServer.Web.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace CmsStudy.Controllers.Pages
{
    public class HomepageController : BasePageController<Homepage>
    {
        public IActionResult Index(Homepage currentContent)
        {
            return PageView(currentContent);
        }
    }
}
