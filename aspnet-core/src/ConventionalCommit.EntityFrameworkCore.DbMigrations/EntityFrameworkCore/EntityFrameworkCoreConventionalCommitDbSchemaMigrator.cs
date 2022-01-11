using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ConventionalCommit.Data;
using Volo.Abp.DependencyInjection;

namespace ConventionalCommit.EntityFrameworkCore
{
    public class EntityFrameworkCoreConventionalCommitDbSchemaMigrator
        : IConventionalCommitDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreConventionalCommitDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the ConventionalCommitMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<ConventionalCommitMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}