using AbpUowMiddlewareBug.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace AbpUowMiddlewareBug.Permissions;

public class AbpUowMiddlewareBugPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(AbpUowMiddlewareBugPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(AbpUowMiddlewareBugPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<AbpUowMiddlewareBugResource>(name);
    }
}
