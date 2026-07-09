using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json.Serialization;

namespace CmsStudy.Models.Blocks
{
    [ContentType(
    DisplayName = "Section Media Block",
    GUID = "DE173F7B-8E02-4690-83C1-A9417938ED1E")]
    public class SectionMediaBlock : BlockData
    {
        [Display(
            Name ="HeadLine",
            GroupName = SystemTabNames.Content,
            Order = 10)]
        public virtual string? HeadLine { get; set; }

        [Display(
            Name = "Body",
            GroupName = SystemTabNames.Content,
            Order = 20)]
        public virtual XhtmlString? Body { get; set; }

        [Display(
            Name = "Image",
            GroupName = SystemTabNames.Content,
            Order = 30)]
        [UIHint(UIHint.Image)]
        public virtual ContentReference? Image { get; set; }
    }
}
