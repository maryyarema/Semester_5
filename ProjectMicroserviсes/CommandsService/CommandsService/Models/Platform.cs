using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;



namespace CommandsService.Models
{
    public class Platform
    {
        
    [Key]
    [Required]
    public int Id { get; set; }

    // [ForeignKey("HealthPlatform")]
    [Required]
    public int HealthPlatformId { get; set; }

    [Required]
    public string PlatformName { get; set; }

    public ICollection<Command> Commands {get; set; } = new List<Command>();
    
    }
}