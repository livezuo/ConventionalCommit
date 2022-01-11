using ConventionalCommit.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace ConventionalCommit.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class ConventionalCommitController : AbpController
    {
        protected ConventionalCommitController()
        {
            LocalizationResource = typeof(ConventionalCommitResource);
        }
    }
}