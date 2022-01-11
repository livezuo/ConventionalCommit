using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace ConventionalCommit.Data
{
    /* This is used if database provider does't define
     * IConventionalCommitDbSchemaMigrator implementation.
     */
    public class NullConventionalCommitDbSchemaMigrator : IConventionalCommitDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}