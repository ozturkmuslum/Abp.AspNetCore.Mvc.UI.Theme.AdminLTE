using AutoMapper;

namespace Prometyum.Abp.AspNetCore.Mvc.UI.Theme.AdminLTE.AutoMapperProfiles
{
    public class AbpAspNetCoreMvcUiAdminLTETenantsAutoMapperProfile : Profile
    {
        public AbpAspNetCoreMvcUiAdminLTETenantsAutoMapperProfile()
        {
            //List
            CreateMap<Volo.Abp.TenantManagement.TenantDto, global::Prometyum.Abp.AspNetCore.Mvc.UI.Theme.AdminLTE.Pages.TenantManagement.Tenants.EditModalModel.TenantInfoModel>();

            //CreateModal
            CreateMap<global::Prometyum.Abp.AspNetCore.Mvc.UI.Theme.AdminLTE.Pages.TenantManagement.Tenants.CreateModalModel.TenantInfoModel, Volo.Abp.TenantManagement.TenantCreateDto>()
                .MapExtraProperties();

            //EditModal
            CreateMap<global::Prometyum.Abp.AspNetCore.Mvc.UI.Theme.AdminLTE.Pages.TenantManagement.Tenants.EditModalModel.TenantInfoModel, Volo.Abp.TenantManagement.TenantUpdateDto>()
                .MapExtraProperties();



        }
    }
}
