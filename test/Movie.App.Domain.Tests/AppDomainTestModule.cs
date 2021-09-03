using Movie.App.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Movie.App
{
    [DependsOn(
        typeof(AppEntityFrameworkCoreTestModule)
        )]
    public class AppDomainTestModule : AbpModule
    {

    }
}