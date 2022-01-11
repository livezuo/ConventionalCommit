using ConventionalCommit.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace ConventionalCommit.Permissions
{
    public class ConventionalCommitPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(ConventionalCommitPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(ConventionalCommitPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<ConventionalCommitResource>(name);
        }
    }
}
