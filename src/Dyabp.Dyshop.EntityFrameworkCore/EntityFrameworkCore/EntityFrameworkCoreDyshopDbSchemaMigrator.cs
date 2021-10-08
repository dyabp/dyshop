using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Dyabp.Dyshop.Data;
using Volo.Abp.DependencyInjection;

namespace Dyabp.Dyshop.EntityFrameworkCore
{
    public class EntityFrameworkCoreDyshopDbSchemaMigrator
        : IDyshopDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreDyshopDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the DyshopDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<DyshopDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}
