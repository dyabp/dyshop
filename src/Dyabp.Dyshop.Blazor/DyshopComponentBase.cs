using Dyabp.Dyshop.Localization;
using Volo.Abp.AspNetCore.Components;

namespace Dyabp.Dyshop.Blazor
{
    public abstract class DyshopComponentBase : AbpComponentBase
    {
        protected DyshopComponentBase()
        {
            LocalizationResource = typeof(DyshopResource);
        }
    }
}
