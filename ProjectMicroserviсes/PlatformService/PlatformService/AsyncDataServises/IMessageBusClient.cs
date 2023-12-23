using System;
using PlatformService.Dtos;

namespace PlatformService.AsyncDataServices
{
    public interface IMessageBusClient
    {
        void ManufacturerNewPlatform(PlatformManufacturerDto platformManufacturerDto) {}
    }
}