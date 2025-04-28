namespace ExaPro4.Models
{
    public class PlanRecompensas
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public DateTime FechaInicio { get; set; }

        public int PuntosAcumulados { get; set; }


        public TipoRecompensaEnum TipoRecompensa { get; set; }


        public int ClienteId { get; set; }

        public Cliente Cliente { get; set; }
         }
    }
