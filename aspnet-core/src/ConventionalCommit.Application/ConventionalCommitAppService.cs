using System;
using System.Collections.Generic;
using System.Text;
using ConventionalCommit.Localization;
using Volo.Abp.Application.Services;

namespace ConventionalCommit
{
    /* Inherit your application services from this class.
     */
    public abstract class ConventionalCommitAppService : ApplicationService
    {
        protected ConventionalCommitAppService()
        {
            LocalizationResource = typeof(ConventionalCommitResource);
        }
    }
}
