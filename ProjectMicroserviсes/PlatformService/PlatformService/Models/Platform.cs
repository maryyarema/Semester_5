using System.ComponentModel.DataAnnotations;

namespace PlatformService.Models
{
    public class Platform
    {
        [Key]
        [Required]
        public int Id {get; set;}

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