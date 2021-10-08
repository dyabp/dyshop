using Volo.Abp.Settings;

namespace Dyabp.Dyshop.Settings
{
    public class DyshopSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(DyshopSettings.MySetting1));
        }
    }
}
