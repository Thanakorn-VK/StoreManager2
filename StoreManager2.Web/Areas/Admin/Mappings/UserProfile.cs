using StoreManager2.Infrastructure.Identity.Models;
using StoreManager2.Web.Areas.Admin.Models;
using AutoMapper;

namespace StoreManager2.Web.Areas.Admin.Mappings
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<ApplicationUser, UserViewModel>().ReverseMap();
        }
    }
}