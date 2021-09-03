using Movie.App.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Movie.App.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class AppController : AbpController
    {
        protected AppController()
        {
            LocalizationResource = typeof(AppResource);
        }
    }
}