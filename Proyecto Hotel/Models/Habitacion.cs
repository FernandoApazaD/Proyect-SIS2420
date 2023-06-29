using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Hotel.Models
{
    public class Habitacion
    {
        [Key]
        public int NumHabitacion { get; set; }
        [Required]
        public string TipoHabitacion { get; set;}
        [Required]
        public decimal PrecioHabitacion { get; set; }
        [Required]
        public bool EstadoHabitacion { get; set; }

        //Integridad Referencial
        public List<Flete> Fletes { get; set; }
    }
}
