using Proyecto_Hotel.Models;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Proyecto_Hotel.Context
{
    public partial class ModelHotel : DbContext
    {
        public ModelHotel()
            : base("name=ModelHotel")
        {
        }

        public virtual DbSet<Usuario> Usuario { get; set; }
        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<Habitacion> Habitacion { get; set; }
        public virtual DbSet<Flete> Flete { get; set; }

    }
}
