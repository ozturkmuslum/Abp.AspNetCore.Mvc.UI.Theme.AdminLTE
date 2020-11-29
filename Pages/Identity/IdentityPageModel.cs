using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;
using Volo.Abp.Identity.Web;

namespace Prometyum.Abp.AspNetCore.Mvc.UI.Theme.AdminLTE.Pages.Identity
{
    public abstract class IdentityPageModel : AbpPageModel
    {
        protected IdentityPageModel()
        {
            ObjectMapperContext = typeof(AbpIdentityWebModule);
        }
    }
}
