using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Hotel.Models
{
    public class Flete
    {
        [Key]
        public int IdFlete { get; set; }
        [Required]
        public DateTime FechaEntrada { get; set; }
        [Required]
        public DateTime FechaSalida { get; set; }
        [Required]
        public string Observaciones { get; set; }
        [Required]
        public decimal Costo { get; set; }

        //Clave Foranea
        public Usuario Usuario { get; set; }
        public Cliente Cliente { get; set; }
        public Habitacion Habitacion { get; set; }
    }
}
