using System;
using System.Text.Json;
using AutoMapper;
using CommandsService.Data;
using CommandsService.Dtos;
using CommandsService.ContactInformationProcessing;
using CommandsService.Models;
using Microsoft.Extensions.DependencyInjection;

namespace CommandsService.ContactInformationProcessing
{
    public class ContactInformationProcessor : IContactInformationProcessor
    {
        private readonly IServiceScopeFactory _scopeFactory;
        private readonly IMapper _mapper;

        public ContactInformationProcessor(IServiceScopeFactory scopeFactory, IMapper mapper)
        {
            _scopeFactory = scopeFactory;
            _mapper = mapper;
        }

        public void ProcessContactInformation(string message)
        {
            var contactInformationType = DetermineContactInformation(message);

            switch (contactInformationType)
            {
                case ContactInformationType.PlatformManufacturer:
                    addPlatform(message);
                    break;
                default:
                    break;
            }
        }

        private ContactInformationType DetermineContactInformation(string notifcationMessage)
        {
            Console.WriteLine("--> Determining ContactInformation");

            var contactInformationType = JsonSerializer.Deserialize<GenericContactInformationDto>(notifcationMessage);

            switch (contactInformationType.ContactInformation)
            {
                case "Platform_Manufacturer":
                    Console.WriteLine("--> Platform Manufacturer ContactInformation Detected");
                    return ContactInformationType.PlatformManufacturer;
                default:
                    Console.WriteLine("--> Could not determine the event type");
                    return ContactInformationType.Undetermined;
            }
        }

        private void addPlatform(string platformManufacturerMessage)
        {
            using (var scope = _scopeFactory.CreateScope())
            {
                var repo = scope.ServiceProvider.GetRequiredService<ICommandRepo>();

                var platformManufacturerDto = JsonSerializer.Deserialize<PlatformManufacturerDto>(platformManufacturerMessage);

                try
                {
                    var plat = _mapper.Map<Platform>(platformManufacturerDto);
                    if (!repo.ExternalPlatformExists(plat.HealthPlatformId))
                    {
                        repo.CreatePlatform(plat);
                        repo.SaveChanges();
                        Console.WriteLine("--> Platform added!");
                    }
                    else
                    {
                        Console.WriteLine("--> Platform already exisits...");
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine($"--> Could not add Platform to DB {ex.Message}");
                }
            }
        }

        // public void ProcessContactInformation(string message)
        // {
        //     throw new NotImplementedException();
        // }
    }

    public interface IContactInformationProcessor
    {
        void ProcessContactInformation(string notificationMessage);
    }

    enum ContactInformationType
    {
        PlatformManufacturer,
        Undetermined
    }
}