using CmsStudy.Models.Pages;
using EPiServer.Core;
using EPiServer.Web.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace CmsStudy.Controllers.Pages
{
    public class BasePageController<T> : PageController<T> where T : PageData
    {
        protected IActionResult PageView(T model)
        {
            return View($"~/Views/Pages/{typeof(T).Name}.cshtml", model);
        }
    }
}
