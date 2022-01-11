using System.Threading.Tasks;

namespace ConventionalCommit.Data
{
    public interface IConventionalCommitDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
