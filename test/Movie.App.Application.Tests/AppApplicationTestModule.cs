using Volo.Abp.Modularity;

namespace Movie.App
{
    [DependsOn(
        typeof(AppApplicationModule),
        typeof(AppDomainTestModule)
        )]
    public class AppApplicationTestModule : AbpModule
    {

    }
}