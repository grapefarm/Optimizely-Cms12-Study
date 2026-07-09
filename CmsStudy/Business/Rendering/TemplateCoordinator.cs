using CmsStudy.Models.Blocks;
using CmsStudy.Models.Pages;
using EPiServer.Core;
using EPiServer.ServiceLocation;
using EPiServer.Web.Mvc;

namespace CmsStudy.Business.Rendering
{
    [ServiceConfiguration]
    public class TemplateCoordinator : IViewTemplateModelRegistrator
    {
        public void Register(TemplateModelCollection viewTemplateModelRegistrator)
        {
            RegisterBlock<SectionMediaBlock>(viewTemplateModelRegistrator);
            RegisterBlock<LinkGridBlock>(viewTemplateModelRegistrator);


            viewTemplateModelRegistrator.Add(typeof(AbstractContentPage), new EPiServer.DataAbstraction.TemplateModel
            {
                Name = "AbstractContentPage-LinkGrid",
                AvailableWithoutTag = false,
                Tags = new[] { "LinkGrid"},
                Inherit=true,
                TemplateTypeCategory = EPiServer.Framework.Web.TemplateTypeCategories.MvcPartialView,
                Path = "~/Views/AbstractContentPage/LinkGrid.cshtml"
            });
        }

        private void RegisterBlock<T>(TemplateModelCollection viewTemplateModelRegistrator) where T : BlockData
        {
            viewTemplateModelRegistrator.Add(typeof(T), new EPiServer.DataAbstraction.TemplateModel
            {
                Name = "SectionMediaBlock-Default",
                AvailableWithoutTag = true,
                TemplateTypeCategory = EPiServer.Framework.Web.TemplateTypeCategories.MvcPartialView,
                Path = $"~/Views/Blocks/{typeof(T).Name}.cshtml"
            });
        }
    }
}
