using Volo.Abp.Identity;

namespace Prometyum.Abp.AspNetCore.Mvc.UI.Theme.AdminLTE.Pages.Identity.Users
{
    public class EditModalModel : Volo.Abp.Identity.Web.Pages.Identity.Users.EditModalModel
    {
        public EditModalModel(IIdentityUserAppService identityUserAppService) : base(identityUserAppService)
        {
        }
    }
}
