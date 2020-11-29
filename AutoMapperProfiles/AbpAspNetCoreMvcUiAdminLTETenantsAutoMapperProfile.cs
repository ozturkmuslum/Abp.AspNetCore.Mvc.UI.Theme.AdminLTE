using AutoMapper;

namespace Prometyum.Abp.AspNetCore.Mvc.UI.Theme.AdminLTE.AutoMapperProfiles
{
    public class AbpAspNetCoreMvcUiAdminLTETenantsAutoMapperProfile : Profile
    {
        public AbpAspNetCoreMvcUiAdminLTETenantsAutoMapperProfile()
        {
            //List
            CreateMap<Volo.Abp.TenantManagement.TenantDto, Prometyum.Abp.AspNetCore.Mvc.UI.Theme.AdminLTE.Pages.TenantManagement.Tenants.EditModalModel.TenantInfoModel>();

            //CreateModal
            CreateMap<Prometyum.Abp.AspNetCore.Mvc.UI.Theme.AdminLTE.Pages.TenantManagement.Tenants.CreateModalModel.TenantInfoModel, Volo.Abp.TenantManagement.TenantCreateDto>()
                .MapExtraProperties();

            //EditModal
            CreateMap<Prometyum.Abp.AspNetCore.Mvc.UI.Theme.AdminLTE.Pages.TenantManagement.Tenants.EditModalModel.TenantInfoModel, Volo.Abp.TenantManagement.TenantUpdateDto>()
                .MapExtraProperties();



        }
    }
}
