using StoreManager2.Web.Areas.Admin.Models;
using AutoMapper;
using System.Security.Claims;

namespace StoreManager2.Web.Areas.Admin.Mappings
{
    public class ClaimsProfile : Profile
    {
        public ClaimsProfile()
        {
            CreateMap<Claim, RoleClaimsViewModel>().ReverseMap();
        }
    }
}