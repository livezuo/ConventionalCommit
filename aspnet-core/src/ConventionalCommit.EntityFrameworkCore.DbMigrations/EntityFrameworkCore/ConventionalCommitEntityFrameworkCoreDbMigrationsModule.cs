using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace ConventionalCommit.EntityFrameworkCore
{
    [DependsOn(
        typeof(ConventionalCommitEntityFrameworkCoreModule)
        )]
    public class ConventionalCommitEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<ConventionalCommitMigrationsDbContext>();
        }
    }
}
