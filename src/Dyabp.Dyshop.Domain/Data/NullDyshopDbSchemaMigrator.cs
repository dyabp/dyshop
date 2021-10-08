using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Dyabp.Dyshop.Data
{
    /* This is used if database provider does't define
     * IDyshopDbSchemaMigrator implementation.
     */
    public class NullDyshopDbSchemaMigrator : IDyshopDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}