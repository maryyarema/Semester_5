using System;
using System.Linq;
using Microsoft.AspNetCore.Authorization.Infrastructure;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PlatformService.Models;

namespace PlatformService.Data
{
    public static class PredDb
    {
        public static void PrepPopulation(IApplicationBuilder app, bool isProd)
        {
            using(var serviceScope = app.ApplicationServices.CreateScope())
            {
                SeedData(serviceScope.ServiceProvider.GetService<AppDbContext>(), isProd);

            }
        }


        private static void SeedData (AppDbContext context, bool isProd) 
        {
            if(isProd)
            {
                Console.WriteLine("--> Attempting to apply migrations...");
                try{
                context.Database.Migrate();
                }
                catch(Exception ex)
                {
                    Console.WriteLine($"--> Could not run migration: {ex.Message}");
                }
            }


            if(!context.Platforms.Any())
            {
                Console.WriteLine("--> Sending data");

                context.Platforms.AddRange(
                    new Platform()
                       {
                        PlatformName = "HealthHub",
                        Manufacturer = "HealthCorp Inc",
                        MedicalProcedure = "Radiology Imaging",
                        DeviceUsed = "Imaging devices",
                        StandardsCompliance = "Healthcare regulations",
                        TechnicalRequirements = "High-resolution imaging capability"
                       },
                       new Platform()
                        {
                            PlatformName = "MindCare",
                            Manufacturer = "PsychTech Innovations",
                            MedicalProcedure = "Psychiatric evaluations",
                            DeviceUsed = "Monitoring and assessment tools",
                            StandardsCompliance = "Privacy and mental health laws",
                            TechnicalRequirements = "Secure data transmission and analysis"
                        }
                );
                context.SaveChanges();


            }
            else
            {
                Console.WriteLine("--> We already have data");
            }

        
        }

    }
}