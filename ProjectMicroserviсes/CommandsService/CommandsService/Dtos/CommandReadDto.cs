using System;
using CommandsService.Models;

namespace CommandsService.Dtos
{
    public class CommandReadDto
    {
    
        public int Id { get; set; }
        public string ProcedureName { get; set; } // Назва процедури.        
        public string EquipmentUsed { get; set; } // Використане обладнання для процедури.
        public string ProcedureType { get; set; } // Тип процедури.
        public string ProcedureDescription { get; set; } // Опис процедури.
        public int PlatformId { get; set; } // Посилання на ідентифікатор платформи в таблиці Platform.

        public Platform Platform { get; set; } // Посилання на об'єкт платформи.

        public string PatientName { get; set; } // Ім'я пацієнта, на якому була виконана процедура.
        public DateTime ProcedureDate { get; set; } // Дата виконання процедури.
    
    }
}