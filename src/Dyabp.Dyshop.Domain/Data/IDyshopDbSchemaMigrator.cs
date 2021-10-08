using System.Threading.Tasks;

namespace Dyabp.Dyshop.Data
{
    public interface IDyshopDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
