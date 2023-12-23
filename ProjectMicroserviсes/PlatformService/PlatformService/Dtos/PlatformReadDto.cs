namespace PlatformService.Dtos
{
    public class PlatformReadDto
    {
        
        public int Id {get; set;}

        public string PlatformName { get; set; }

        public string Manufacturer { get; set; }

        public string MedicalProcedure { get; set; }

        public string DeviceUsed { get; set; }

        public string StandardsCompliance { get; set; }

        public string TechnicalRequirements { get; set; }
    }
}