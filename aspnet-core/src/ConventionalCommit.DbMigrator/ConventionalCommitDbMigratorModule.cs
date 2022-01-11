using ConventionalCommit.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace ConventionalCommit.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(ConventionalCommitEntityFrameworkCoreDbMigrationsModule),
        typeof(ConventionalCommitApplicationContractsModule)
        )]
    public class ConventionalCommitDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
