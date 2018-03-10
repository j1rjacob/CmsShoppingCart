using CmsShoppingCart.Models.Data;
using System.Web.Mvc;

namespace CmsShoppingCart.Models.ViewModels.Pages
{
    public class SidebarVM
    {
        public SidebarVM()
        {
                
        }

        public SidebarVM(SidebarDTO row)
        {
            Id = row.Id;
            Body = row.Body;
        }
        public int Id { get; set; }
        [AllowHtml]
        public string Body { get; set; }
    }
}