using Dyabp.Dyshop.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Dyabp.Dyshop.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class DyshopController : AbpControllerBase
    {
        protected DyshopController()
        {
            LocalizationResource = typeof(DyshopResource);
        }
    }
}