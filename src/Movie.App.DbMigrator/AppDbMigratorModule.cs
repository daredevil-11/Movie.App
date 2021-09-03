using Movie.App.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Movie.App.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(AppEntityFrameworkCoreModule),
        typeof(AppApplicationContractsModule)
        )]
    public class AppDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
