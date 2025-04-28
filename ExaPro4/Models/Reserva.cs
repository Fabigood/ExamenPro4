using System.ComponentModel.DataAnnotations;

namespace ExaPro4.Models
{
    public class Reserva
    {
        public int Id { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime FechaEntrada { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime FechaSalida { get; set; }

        [Required]
        [Range(0, Double.MaxValue)]
        public int ValorPagar { get; set; }

        [Required]
        public int ClienteId { get; set; } 

        [Required] 
        public Cliente Cliente { get; set; }
    }
}
