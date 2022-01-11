using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace ConventionalCommit.EntityFrameworkCore
{
    public static class ConventionalCommitDbContextModelCreatingExtensions
    {
        public static void ConfigureConventionalCommit(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(ConventionalCommitConsts.DbTablePrefix + "YourEntities", ConventionalCommitConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
        }
    }
}