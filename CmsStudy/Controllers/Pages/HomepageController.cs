using CmsStudy.Models.Pages;
using CmsStudy.Models.Pages.ViewModels;
using EPiServer;
using EPiServer.Web.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace CmsStudy.Controllers.Pages
{
    public class HomepageController : BasePageController<Homepage>
    {
        private readonly IContentLoader contentLoader;

        public HomepageController(IContentLoader contentLoader)
        {
            this.contentLoader = contentLoader;
        }
        public IActionResult Index(Homepage currentContent)
        {
            var viewModel = new HomepageViewModel(currentContent);

            viewModel.RelatedContent = contentLoader.GetChildren<AbstractContentPage>(currentContent.ContentLink);

            return PageView(viewModel);
        }
    }
}
