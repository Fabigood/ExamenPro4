using System.ComponentModel.DataAnnotations;

namespace ExaPro4.Models
{
    public class Cliente
    {
        
        public int Id { get; set; }
        [Required(ErrorMessage = "El nombre es obligatorio.")]
        [StringLength(50, ErrorMessage = "El nombre no puede exceder los 50 caracteres.")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El apellido es obligatorio.")]
        [Range(18, 100, ErrorMessage = "La edad debe ser entre 18 y 100 años.")]
        //se hace desde 18 pq solo en esa edad es habil para hacer reservas
        public string Edad { get; set; }
        [Required(ErrorMessage = "El saldo es obligatorio.")]
        [Range(0.0, Double.MaxValue, ErrorMessage = "El saldo debe ser positivo.")]
        public decimal Saldo { get; set; }
        [Required]

        public Boolean EsVip { get; set; }


        [Required]
        [DataType(DataType.Date)]
        public DateTime FechaRegistro { get; set; }
    }
}
