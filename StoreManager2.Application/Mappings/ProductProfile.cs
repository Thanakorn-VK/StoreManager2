using StoreManager2.Application.Features.Products.Commands.Create;
using StoreManager2.Application.Features.Products.Queries.GetAllCached;
using StoreManager2.Application.Features.Products.Queries.GetAllPaged;
using StoreManager2.Application.Features.Products.Queries.GetById;
using StoreManager2.Domain.Entities.Catalog;
using AutoMapper;

namespace StoreManager2.Application.Mappings
{
    internal class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<CreateProductCommand, Product>().ReverseMap();
            CreateMap<GetProductByIdResponse, Product>().ReverseMap();
            CreateMap<GetAllProductsCachedResponse, Product>().ReverseMap();
            CreateMap<GetAllProductsResponse, Product>().ReverseMap();
        }
    }
}