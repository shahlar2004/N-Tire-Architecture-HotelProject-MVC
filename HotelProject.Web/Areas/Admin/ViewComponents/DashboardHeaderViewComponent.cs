using Microsoft.AspNetCore.Mvc;

namespace HotelProject.Web.Areas.Admin.ViewComponents
{
    public class DashboardHeaderViewComponent:ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
