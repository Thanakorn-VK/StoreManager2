using StoreManager2.Application.Features.Brands.Commands.Create;
using StoreManager2.Application.Features.Brands.Queries.GetAllCached;
using StoreManager2.Application.Features.Brands.Queries.GetById;
using StoreManager2.Domain.Entities.Catalog;
using AutoMapper;

namespace StoreManager2.Application.Mappings
{
    internal class BrandProfile : Profile
    {
        public BrandProfile()
        {
            CreateMap<CreateBrandCommand, Brand>().ReverseMap();
            CreateMap<GetBrandByIdResponse, Brand>().ReverseMap();
            CreateMap<GetAllBrandsCachedResponse, Brand>().ReverseMap();
        }
    }
}