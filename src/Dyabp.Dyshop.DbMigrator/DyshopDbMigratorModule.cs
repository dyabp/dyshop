using Dyabp.Dyshop.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Dyabp.Dyshop.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(DyshopEntityFrameworkCoreModule),
        typeof(DyshopApplicationContractsModule)
        )]
    public class DyshopDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
