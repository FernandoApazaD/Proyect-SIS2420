using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Hotel.Models
{
    public class Usuario
    {
        [Key]
        //public int IdUsuario { get; set; }
        public string CuentaUsuario { get; set; }
        [Required]
        public string ClaveUsuario { get; set; }
        [Required]
        public string NombreUsuario { get; set; }
        [Required]
        public string RolUsuario { get; set; }
        [Required]
        public bool EstadoUsuario { get; set; }

        //Integridad Referencial
        public List<Flete> Fletes { get; set; }
    }
}
