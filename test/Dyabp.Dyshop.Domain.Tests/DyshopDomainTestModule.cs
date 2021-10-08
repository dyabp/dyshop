using Dyabp.Dyshop.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Dyabp.Dyshop
{
    [DependsOn(
        typeof(DyshopEntityFrameworkCoreTestModule)
        )]
    public class DyshopDomainTestModule : AbpModule
    {

    }
}