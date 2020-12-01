using AutoMapper;
using Prometyum.Abp.AspNetCore.Mvc.UI.Theme.AdminLTE.Pages.TenantManagement.Tenants;
using Volo.Abp.TenantManagement;
using TenantManagement=Volo.Abp.TenantManagement.Web.Pages.TenantManagement;

namespace Prometyum.Abp.AspNetCore.Mvc.UI.Theme.AdminLTE.AutoMapperProfiles
{
    public class AbpAspNetCoreMvcUiAdminLTETenantsAutoMapperProfile : Profile
    {
        public AbpAspNetCoreMvcUiAdminLTETenantsAutoMapperProfile()
        {

            //List
            CreateMap<TenantDto, TenantManagement.Tenants.EditModalModel.TenantInfoModel>();

            //CreateModal
            CreateMap<TenantManagement.Tenants.CreateModalModel.TenantInfoModel, TenantCreateDto>()
                .MapExtraProperties();

            //EditModal
            CreateMap<TenantManagement.Tenants.EditModalModel.TenantInfoModel, TenantUpdateDto>()
                .MapExtraProperties();



        }
    }
}
