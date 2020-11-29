using Volo.Abp.Identity;

namespace Prometyum.Abp.AspNetCore.Mvc.UI.Theme.AdminLTE.Pages.Identity.Roles
{
    public class CreateModalModel : Volo.Abp.Identity.Web.Pages.Identity.Roles.CreateModalModel
    {
        public CreateModalModel(IIdentityRoleAppService identityRoleAppService) : base(identityRoleAppService)
        {
        }
    }
}