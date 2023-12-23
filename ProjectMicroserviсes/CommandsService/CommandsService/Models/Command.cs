using System;
using System.ComponentModel.DataAnnotations;
namespace CommandsService.Models
{
    public class Command
    {
        [Key]
        [Required]
        public int Id { get; set; } 
    
        [Required]
        public string ProcedureName { get; set; } // Назва процедури.

        [Required]
        public string EquipmentUsed { get; set; } // Використане обладнання для процедури.

        [Required]
        public string ProcedureType { get; set; } // Тип процедури.

        [Required]
        public string ProcedureDescription { get; set; } // Опис процедури.

        [Required]
        public int PlatformId { get; set; } // Посилання на ідентифікатор платформи в таблиці Platform.

        public Platform Platform { get; set; } // Посилання на об'єкт платформи.
        [Required]
        public string PatientName { get; set; } // Ім'я пацієнта, на якому була виконана процедура.
        [Required]
         public DateTime ProcedureDate { get; set; } // Дата виконання процедури.
    
    }
}