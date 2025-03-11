using AutoMapper;
using CafeMenu.Data.Dto;
using CafeMenu.Data.Entities;
using CafeMenu.Models;

namespace CafeMenu
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<CategoryDto, CategoryModel>();
            CreateMap<CategoryDto, Category>();
            CreateMap<Category, CategoryDto>();
            CreateMap<Category, CategoryModel>();
        }
        
    }
}
