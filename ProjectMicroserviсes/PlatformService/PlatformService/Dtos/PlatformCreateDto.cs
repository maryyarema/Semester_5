using System.ComponentModel.DataAnnotations;

namespace PlatformService.Dtos
{
    public class PlatformCreateDto
    {
        

        [Required]
        public string PlatformName { get; set; }

        [Required]
        public string Manufacturer { get; set; }
        [Required]

        public string MedicalProcedure { get; set; }
        [Required]

        public string DeviceUsed { get; set; }
        [Required]

        public string StandardsCompliance { get; set; }
        
        [Required]
        public string TechnicalRequirements { get; set; }
    }
}