using Volo.Abp.Identity;

namespace Prometyum.Abp.AspNetCore.Mvc.UI.Theme.AdminLTE.Pages.Identity.Users
{
    public class CreateModalModel : Volo.Abp.Identity.Web.Pages.Identity.Users.CreateModalModel
    {
        public CreateModalModel(IIdentityUserAppService identityUserAppService) : base(identityUserAppService)
        {
        }
    }
}
