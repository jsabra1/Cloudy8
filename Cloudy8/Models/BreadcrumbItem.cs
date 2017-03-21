using Sitecore.Data.Items;
using Sitecore.Diagnostics;
using Sitecore.Links;

namespace Cloudy8.Models
{
    public class BreadcrumbItem : Sitecore.Data.Items.CustomItem
    {
        public BreadcrumbItem(Item item)
    : base(item) { Assert.IsNotNull(item, "item"); }

        public string Title
        { get { return InnerItem["Title"]; } }

        public bool IsActive
        { get { return Sitecore.Context.Item.ID == InnerItem.ID; } }

        public string Url
        { get { return LinkManager.GetItemUrl(InnerItem); } }
    }
}