using Volo.Abp.Modularity;

namespace ConventionalCommit
{
    [DependsOn(
        typeof(ConventionalCommitApplicationModule),
        typeof(ConventionalCommitDomainTestModule)
        )]
    public class ConventionalCommitApplicationTestModule : AbpModule
    {

    }
}