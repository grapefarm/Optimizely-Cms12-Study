using CmsStudy.Models.Pages;
using EPiServer.Web.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace CmsStudy.Controllers.Pages
{
    public class GeneralPageController : BasePageController<GeneralPage>
    {
        public IActionResult Index(GeneralPage currentContent)
        {
            return PageView(currentContent);
        }
    }
}
