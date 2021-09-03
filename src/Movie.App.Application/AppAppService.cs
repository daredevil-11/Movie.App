using System;
using System.Collections.Generic;
using System.Text;
using Movie.App.Localization;
using Volo.Abp.Application.Services;

namespace Movie.App
{
    /* Inherit your application services from this class.
     */
    public abstract class AppAppService : ApplicationService
    {
        protected AppAppService()
        {
            LocalizationResource = typeof(AppResource);
        }
    }
}
