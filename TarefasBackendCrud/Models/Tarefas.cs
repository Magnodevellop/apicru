using System;
using System.ComponentModel.DataAnnotations;
namespace TarefasBackendCrud.Models
{
    public class Tarefa
    {
        public static bool Length { get; internal set; }
        public Guid Id { get; set; }
        public Guid UsuraioId { get; set; }

        [Required]
        public string? Nome { get; set; }
        public bool Concluida { get; set; } = false;


    }
}