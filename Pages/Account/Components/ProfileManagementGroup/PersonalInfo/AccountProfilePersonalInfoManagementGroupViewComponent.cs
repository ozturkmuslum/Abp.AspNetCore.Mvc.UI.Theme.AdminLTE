using Volo.Abp.Identity;

namespace Prometyum.Abp.AspNetCore.Mvc.UI.Theme.AdminLTE.Pages.Account.Components.ProfileManagementGroup.PersonalInfo
{
    public class AccountProfilePersonalInfoManagementGroupViewComponent : Volo.Abp.Account.Web.Pages.Account.Components.ProfileManagementGroup.PersonalInfo.AccountProfilePersonalInfoManagementGroupViewComponent
    {
        public AccountProfilePersonalInfoManagementGroupViewComponent(IProfileAppService profileAppService) : base(profileAppService)
        {
        }
    }
}
