using AutoMapper;
using PlatformService.Dtos;
using PlatformService.Models;

namespace PlatformService.Profiles
{
    public class PlatformProfile : Profile
    {
        public PlatformProfile()
        {
            //Soure -> Target 

        CreateMap<Platform, PlatformReadDto>();
        CreateMap<PlatformCreateDto, Platform>();
        CreateMap<PlatformReadDto, PlatformManufacturerDto>();

        CreateMap<Platform, GrpcPlatformModel>()
                .ForMember(dest => dest.PlatformId, opt => opt.MapFrom(src =>src.Id))
                .ForMember(dest => dest.PlatformName, opt => opt.MapFrom(src =>src.PlatformName))
                .ForMember(dest => dest.Manufacturer, opt => opt.MapFrom(src =>src.Manufacturer));
        }
    }
}