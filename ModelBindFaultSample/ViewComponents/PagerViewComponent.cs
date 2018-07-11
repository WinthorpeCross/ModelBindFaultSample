using Microsoft.AspNetCore.Mvc;
using ModelBindFaultSample.ViewModels;
using System.Threading.Tasks;

namespace ModelBindFaultSample.ViewComponents
{
    public class PagerViewComponent : ViewComponent
    {
        public Task<IViewComponentResult> InvokeAsync(PagedResultBase result)
        {
            return Task.FromResult((IViewComponentResult)View("Default", result));
        }
    }
}
