using Volo.Abp.Settings;

namespace ConventionalCommit.Settings
{
    public class ConventionalCommitSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(ConventionalCommitSettings.MySetting1));
        }
    }
}
