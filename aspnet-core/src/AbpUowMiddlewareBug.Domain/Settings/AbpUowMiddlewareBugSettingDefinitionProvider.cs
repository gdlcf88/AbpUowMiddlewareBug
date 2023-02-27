using Volo.Abp.Settings;

namespace AbpUowMiddlewareBug.Settings;

public class AbpUowMiddlewareBugSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(AbpUowMiddlewareBugSettings.MySetting1));
    }
}
