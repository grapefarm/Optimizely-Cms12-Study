using CmsStudy.Models.Blocks;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using System.ComponentModel.DataAnnotations;

namespace CmsStudy.Models.Pages
{
    [ContentType(
        DisplayName = "General Page",
        GUID = "0F44BB20-7C45-472B-AB63-157C670C45D9",
        GroupName = "General Content")]
    public class GeneralPage : AbstractContentPage
    {


        [Display(
            Name = "HeadLine",  
            GroupName = SystemTabNames.Content,
            Order = 10)]
        public virtual string? HeadLine { get; set; }
        [Display(
            Name = "HeadLine Slug",
            GroupName = SystemTabNames.Content,
            Order = 20)]
        public virtual string? HeadLineSlug { get; set; }
        [Display(
            Name = "Body",
            GroupName = SystemTabNames.Content,
            Order = 30)]
        public virtual XhtmlString? Body { get; set; }

        [Display(
            Name = "Bottom Content Area",
            GroupName = SystemTabNames.Content,
            Order = 40)]
        [AllowedTypes(AllowedTypes = new[] { typeof(SectionMediaBlock), typeof(LinkGridBlock)})]
        public virtual ContentArea? BottomContentArea {get; set; }
    }
}
