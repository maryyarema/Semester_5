using System;
using System.ComponentModel.DataAnnotations;

namespace CommandsService.Dtos
{
    public class CommandCreateDto
    {

    
        [Required]
        public string ProcedureName { get; set; } // Назва процедури.

        [Required]
        public string EquipmentUsed { get; set; } // Використане обладнання для процедури.

        [Required]
        public string ProcedureType { get; set; } // Тип процедури.

        [Required]
        public string ProcedureDescription { get; set; } // Опис процедури.

        [Required]
        public string PatientName { get; set; } // Ім'я пацієнта, на якому була виконана процедура.
        [Required]
        public DateTime ProcedureDate { get; set; } // Дата виконання процедури.
    }
}