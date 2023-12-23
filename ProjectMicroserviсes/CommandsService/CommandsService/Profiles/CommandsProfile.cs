using AutoMapper;
using CommandsService.Dtos;
using CommandsService.Models;
using PlatformService;

namespace CommandsService.Profiles
{
    public class CommandsProfile : Profile
    {
        public CommandsProfile()
        {
            //Soure -> Target 
             CreateMap<Platform, PlatformReadDto>();
            CreateMap<CommandCreateDto, Command>();
            CreateMap<Command, CommandCreateDto>();
            CreateMap<Command, CommandReadDto>();
            CreateMap<CommandReadDto, Command>();
             CreateMap<PlatformManufacturerDto, Platform>()
                 .ForMember(dest => dest.HealthPlatformId, opt => opt.MapFrom(src => src.Id));
            CreateMap<GrpcPlatformModel, Platform>()
                .ForMember(dest => dest.HealthPlatformId, opt => opt.MapFrom(src => src.PlatformId))
                .ForMember(dest => dest.PlatformName, opt => opt.MapFrom(src => src.PlatformName))
                .ForMember(dest => dest.Commands, opt => opt.Ignore());
             
        }
        
    }
}