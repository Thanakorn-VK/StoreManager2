using StoreManager2.Application.Features.Products.Commands.Create;
using StoreManager2.Application.Features.Products.Commands.Update;
using StoreManager2.Application.Features.Products.Queries.GetAllCached;
using StoreManager2.Application.Features.Products.Queries.GetById;
using StoreManager2.Web.Areas.Catalog.Models;
using AutoMapper;

namespace StoreManager2.Web.Areas.Catalog.Mappings
{
    internal class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<GetAllProductsCachedResponse, ProductViewModel>().ReverseMap();
            CreateMap<GetProductByIdResponse, ProductViewModel>().ReverseMap();
            CreateMap<CreateProductCommand, ProductViewModel>().ReverseMap();
            CreateMap<UpdateProductCommand, ProductViewModel>().ReverseMap();
        }
    }
}