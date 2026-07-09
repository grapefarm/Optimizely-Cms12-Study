using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using System.ComponentModel.DataAnnotations;

namespace CmsStudy.Models.Pages
{
    [ContentType(
        DisplayName = "Homepage",
        Description = "Homepage",
        GUID = "F180E2EA-BC9B-475F-9F64-639FACA840C1",
        GroupName = "Specialized Content")]
    public class Homepage : AbstractContentPage
    {
    }
}
