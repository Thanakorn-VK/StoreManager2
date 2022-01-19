using StoreManager2.Application.Features.Brands.Commands.Create;
using StoreManager2.Application.Features.Brands.Commands.Update;
using StoreManager2.Application.Features.Brands.Queries.GetAllCached;
using StoreManager2.Application.Features.Brands.Queries.GetById;
using StoreManager2.Web.Areas.Catalog.Models;
using AutoMapper;

namespace StoreManager2.Web.Areas.Catalog.Mappings
{
    internal class BrandProfile : Profile
    {
        public BrandProfile()
        {
            CreateMap<GetAllBrandsCachedResponse, BrandViewModel>().ReverseMap();
            CreateMap<GetBrandByIdResponse, BrandViewModel>().ReverseMap();
            CreateMap<CreateBrandCommand, BrandViewModel>().ReverseMap();
            CreateMap<UpdateBrandCommand, BrandViewModel>().ReverseMap();
        }
    }
}