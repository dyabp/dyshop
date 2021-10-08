using Volo.Abp.Modularity;

namespace Dyabp.Dyshop
{
    [DependsOn(
        typeof(DyshopApplicationModule),
        typeof(DyshopDomainTestModule)
        )]
    public class DyshopApplicationTestModule : AbpModule
    {

    }
}