using EPiServer.Core;
using EPiServer.DataAnnotations;
using EPiServer.Framework.DataAnnotations;
using System.ComponentModel.DataAnnotations;

namespace CmsStudy.Models.Media
{
    [ContentType(
        DisplayName = "Image",
        GUID = "C4213291-3455-4695-B9B7-A4B145C57257")]
    [MediaDescriptor(ExtensionString = "jpg,jpeg,png")]
    public class ImageFile :ImageData
    {
        [Display(
            Name = "Alternate Text")]
        public virtual string? AltText { get; set; }
    }
}
