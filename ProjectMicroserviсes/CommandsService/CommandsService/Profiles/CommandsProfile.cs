using AutoMapper;
using CommandsService.Dtos;
using CommandsService.Models;

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
             CreateMap<PlatformManufacturerDto, Platform>()
                 .ForMember(dest => dest.HealthPlatformId, opt => opt.MapFrom(src => src.Id));
            // CreateMap<GrpcPlatformModel, Platform>()
            //     .ForMember(dest => dest.ExternalID, opt => opt.MapFrom(src => src.PlatformId))
            //     .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
            //     .ForMember(dest => dest.Commands, opt => opt.Ignore());
             
        }
    }
}