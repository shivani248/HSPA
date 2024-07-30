using AutoMapper;
using WebAPI.Controllers;
using WebAPI.Controllers.Dtos;
using WebAPI.Dtos;
using WebAPI.Model;
using WebAPI.Models;

namespace WebAPI.Helpers
{
    public class AutoMapperProfile : Profile
    {
       public AutoMapperProfile ()
        {
            CreateMap<City, CityDto>().ReverseMap();//source , destination to be mapped
            /* CreateMap<CityDto, City>();*///source , destination to be mapped
            /*reateMap<CityDto, cityFromDb>();*/
            CreateMap<City, CityUpdateDto>().ReverseMap();
            CreateMap<Property, PropertyDto>().ReverseMap();
            CreateMap<Photo, PhotoDto>().ReverseMap();


            CreateMap<Property, PropertyListDto>()
                .ForMember(d => d.City, opt => opt.MapFrom(src => src.City!.Name))
                .ForMember(d => d.Country, opt => opt.MapFrom(src => src.City!.Country))
                .ForMember(d => d.PropertyType, opt => opt.MapFrom(src => src.PropertyType!.Name))
                .ForMember(d => d.FurnishingType, opt => opt.MapFrom(src => src.FurnishingType!.Name))
                 .ForMember(d => d.Photo, opt => opt.MapFrom(src => src.Photos
                                .FirstOrDefault(p => p.IsPrimary).ImageUrl)); ;

            CreateMap<Property, PropertyDetailDto>()
             .ForMember(d => d.City, opt => opt.MapFrom(src => src.City.Name))
             .ForMember(d => d.Country, opt => opt.MapFrom(src => src.City.Country))
             .ForMember(d => d.PropertyType, opt => opt.MapFrom(src => src.PropertyType.Name))
             .ForMember(d => d.FurnishingType, opt => opt.MapFrom(src => src.FurnishingType.Name));

            CreateMap<FurnishingType, KeyValuePairDto>();

            CreateMap<PropertyType, KeyValuePairDto>().ReverseMap();

        }
    }
}
