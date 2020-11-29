﻿using AutoMapper;
using Volo.Abp.AutoMapper;

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
            CreateMap<Volo.Abp.Identity.IdentityUserDto, global::Prometyum.Abp.AspNetCore.Mvc.UI.Theme.AdminLTE.Pages.Identity.Users.EditModalModel.UserInfoViewModel>()
                .Ignore(x => x.Password);

            //CreateModal
            CreateMap<global::Prometyum.Abp.AspNetCore.Mvc.UI.Theme.AdminLTE.Pages.Identity.Users.CreateModalModel.UserInfoViewModel, Volo.Abp.Identity.IdentityUserCreateDto>()
                .MapExtraProperties()
                .ForMember(dest => dest.RoleNames, opt => opt.Ignore());

            CreateMap<Volo.Abp.Identity.IdentityRoleDto, global::Prometyum.Abp.AspNetCore.Mvc.UI.Theme.AdminLTE.Pages.Identity.Users.CreateModalModel.AssignedRoleViewModel>()
                .ForMember(dest => dest.IsAssigned, opt => opt.Ignore());

            //EditModal
            CreateMap<global::Prometyum.Abp.AspNetCore.Mvc.UI.Theme.AdminLTE.Pages.Identity.Users.EditModalModel.UserInfoViewModel, Volo.Abp.Identity.IdentityUserUpdateDto>()
                .MapExtraProperties()
                .ForMember(dest => dest.RoleNames, opt => opt.Ignore());

            CreateMap<Volo.Abp.Identity.IdentityRoleDto, global::Prometyum.Abp.AspNetCore.Mvc.UI.Theme.AdminLTE.Pages.Identity.Users.EditModalModel.AssignedRoleViewModel>()
                .ForMember(dest => dest.IsAssigned, opt => opt.Ignore());
        }


        protected virtual void CreateRoleMappings()
        {
            //List
            CreateMap<Volo.Abp.Identity.IdentityRoleDto, global::Prometyum.Abp.AspNetCore.Mvc.UI.Theme.AdminLTE.Pages.Identity.Roles.EditModalModel.RoleInfoModel>();

            //CreateModal
            CreateMap<global::Prometyum.Abp.AspNetCore.Mvc.UI.Theme.AdminLTE.Pages.Identity.Roles.CreateModalModel.RoleInfoModel, Volo.Abp.Identity.IdentityRoleCreateDto>()
                .MapExtraProperties();

            //EditModal
            CreateMap<global::Prometyum.Abp.AspNetCore.Mvc.UI.Theme.AdminLTE.Pages.Identity.Roles.EditModalModel.RoleInfoModel, Volo.Abp.Identity.IdentityRoleUpdateDto>()
                .MapExtraProperties();
        }
    }
}