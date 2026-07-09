using CmsStudy.Models.Pages;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using System.ComponentModel.DataAnnotations;

namespace CmsStudy.Models.Blocks
{
    [ContentType(
        DisplayName = "Link Grid Block",
        GUID = "8AFA5541-E8BC-4C5E-AB9C-CFFC8AFD1147")]
    public class LinkGridBlock : BlockData
    {
        [Display(
            Name = "Links",
            GroupName = SystemTabNames.Content,
            Order = 10)]
        [AllowedTypes(AllowedTypes = new[] {typeof(AbstractContentPage) })]
        public virtual ContentArea? Links { get; set; }
    }
}
