using ConventionalCommit.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace ConventionalCommit
{
    [DependsOn(
        typeof(ConventionalCommitEntityFrameworkCoreTestModule)
        )]
    public class ConventionalCommitDomainTestModule : AbpModule
    {

    }
}