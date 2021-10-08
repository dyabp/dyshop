using System;
using System.Collections.Generic;
using System.Text;
using Dyabp.Dyshop.Localization;
using Volo.Abp.Application.Services;

namespace Dyabp.Dyshop
{
    /* Inherit your application services from this class.
     */
    public abstract class DyshopAppService : ApplicationService
    {
        protected DyshopAppService()
        {
            LocalizationResource = typeof(DyshopResource);
        }
    }
}
