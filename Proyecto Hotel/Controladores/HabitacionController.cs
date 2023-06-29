using Proyecto_Hotel.Context;
using Proyecto_Hotel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Hotel.Controladores
{
    internal class HabitacionController
    {
        ModelHotel _contex = new ModelHotel();
        public List<Habitacion> GetAll()
        {
            return _contex.Habitacion.ToList();
        }

        //Devuelve solo una habitacion
        public Habitacion Get(int numeroHabitacion)
        {
            return _contex.Habitacion.Find(numeroHabitacion);
        }

        //Buscar
        public List<Habitacion> Search(string numeroHabitacion)
        {
            if (String.IsNullOrEmpty(numeroHabitacion)) return GetAll();
            else
                return _contex.Habitacion.Where(x => x.NumHabitacion.ToString() == numeroHabitacion).ToList();
        }

        //Crear, Actualizar y Eliminar
        public bool Create(Habitacion habitacion)
        {
            _contex.Habitacion.Add(habitacion);  //Agregando a la tabla habiatacion
            return _contex.SaveChanges() > 0;  //Guardando en la base de datos
        }

        public bool Update(Habitacion habitacion)
        {
            _contex.Habitacion.Attach(habitacion);  //Busca a la tabla habitacion
            _contex.Entry(habitacion).State = System.Data.Entity.EntityState.Modified;  //Modifica al cliente en la base de datos
            return _contex.SaveChanges() > 0;  //Guardando en la base de datos
        }

        public bool Delete(Habitacion habitacion)
        {
            _contex.Habitacion.Remove(habitacion);   //Busca y elimina al cliente en la base de datos
            return _contex.SaveChanges() > 0;  //Guardando en la base de datos
        }
    }
}
