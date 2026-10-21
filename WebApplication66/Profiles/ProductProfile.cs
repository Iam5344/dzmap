using AutoMapper;
using ProductManagement.DTOs;
using ProductManagement.Models;

namespace ProductManagement.Profiles
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<Product, ProductReadDto>()
                .ForMember(dest => dest.ImageUrls, opt => opt.MapFrom(src => src.Images.Select(i => i.Url)));

            CreateMap<ProductCreateDto, Product>()
                .ForMember(dest => dest.Images, opt => opt.MapFrom(src => src.ImageUrls.Select(url => new ProductImage { Url = url })));
        }
    }
}
