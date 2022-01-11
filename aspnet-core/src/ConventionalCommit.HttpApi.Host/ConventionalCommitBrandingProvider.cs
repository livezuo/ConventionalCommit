using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace ConventionalCommit
{
    [Dependency(ReplaceServices = true)]
    public class ConventionalCommitBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "ConventionalCommit";
    }
}
