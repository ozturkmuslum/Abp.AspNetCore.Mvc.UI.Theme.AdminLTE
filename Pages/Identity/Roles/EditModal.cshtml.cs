using Volo.Abp.Identity;

namespace Prometyum.Abp.AspNetCore.Mvc.UI.Theme.AdminLTE.Pages.Identity.Roles
{
    public class EditModalModel : Volo.Abp.Identity.Web.Pages.Identity.Roles.EditModalModel
    {
        public EditModalModel(IIdentityRoleAppService identityRoleAppService) : base(identityRoleAppService)
        {
        }
    }
}