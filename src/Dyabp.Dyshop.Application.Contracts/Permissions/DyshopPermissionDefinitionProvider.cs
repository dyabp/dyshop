using Dyabp.Dyshop.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Dyabp.Dyshop.Permissions
{
    public class DyshopPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(DyshopPermissions.GroupName);
            //Define your own permissions here. Example:
            //myGroup.AddPermission(DyshopPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<DyshopResource>(name);
        }
    }
}
