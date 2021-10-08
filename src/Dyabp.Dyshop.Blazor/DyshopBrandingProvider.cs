using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Dyabp.Dyshop.Blazor
{
    [Dependency(ReplaceServices = true)]
    public class DyshopBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "Dyshop";
    }
}
