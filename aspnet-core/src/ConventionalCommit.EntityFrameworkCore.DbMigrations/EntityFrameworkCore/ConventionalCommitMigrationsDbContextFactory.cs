using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace ConventionalCommit.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class ConventionalCommitMigrationsDbContextFactory : IDesignTimeDbContextFactory<ConventionalCommitMigrationsDbContext>
    {
        public ConventionalCommitMigrationsDbContext CreateDbContext(string[] args)
        {
            ConventionalCommitEfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<ConventionalCommitMigrationsDbContext>()
                .UseNpgsql(configuration.GetConnectionString("Default"));

            return new ConventionalCommitMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../ConventionalCommit.DbMigrator/"))
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
