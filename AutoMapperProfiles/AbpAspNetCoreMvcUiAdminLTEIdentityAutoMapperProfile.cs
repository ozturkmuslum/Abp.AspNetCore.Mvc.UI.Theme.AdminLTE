using AutoMapper;
using Volo.Abp.AutoMapper;
using Identity = Prometyum.Abp.AspNetCore.Mvc.UI.Theme.AdminLTE.Pages.Identity;

namespace Prometyum.Abp.AspNetCore.Mvc.UI.Theme.AdminLTE.AutoMapperProfiles
{
    public class AbpAspNetCoreMvcUiAdminLTEIdentityAutoMapperProfile : Profile
    {
        public AbpAspNetCoreMvcUiAdminLTEIdentityAutoMapperProfile()
        {
            CreateUserMappings();
            CreateRoleMappings();
        }

        protected virtual void CreateUserMappings()
        {
            //List
            CreateMap<Volo.Abp.Identity.IdentityUserDto, Identity.Users.EditModalModel.UserInfoViewModel>()
                .Ignore(x => x.Password);

            //CreateModal
            CreateMap<Identity.Users.CreateModalModel.UserInfoViewModel, Volo.Abp.Identity.IdentityUserCreateDto>()
                .MapExtraProperties()
                .ForMember(dest => dest.RoleNames, opt => opt.Ignore());

            CreateMap<Volo.Abp.Identity.IdentityRoleDto, Identity.Users.CreateModalModel.AssignedRoleViewModel>()
                .ForMember(dest => dest.IsAssigned, opt => opt.Ignore());

            //EditModal
            CreateMap<Identity.Users.EditModalModel.UserInfoViewModel, Volo.Abp.Identity.IdentityUserUpdateDto>()
                .MapExtraProperties()
                .ForMember(dest => dest.RoleNames, opt => opt.Ignore());

            CreateMap<Volo.Abp.Identity.IdentityRoleDto, Identity.Users.EditModalModel.AssignedRoleViewModel>()
                .ForMember(dest => dest.IsAssigned, opt => opt.Ignore());
        }


        protected virtual void CreateRoleMappings()
        {
            //List
            CreateMap<Volo.Abp.Identity.IdentityRoleDto, Identity.Roles.EditModalModel.RoleInfoModel>();

            //CreateModal
            CreateMap<Identity.Roles.CreateModalModel.RoleInfoModel, Volo.Abp.Identity.IdentityRoleCreateDto>()
                .MapExtraProperties();

            //EditModal
            CreateMap<Identity.Roles.EditModalModel.RoleInfoModel, Volo.Abp.Identity.IdentityRoleUpdateDto>()
                .MapExtraProperties();
        }
    }
}