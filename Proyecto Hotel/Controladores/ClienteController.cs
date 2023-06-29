using Proyecto_Hotel.Context;
using Proyecto_Hotel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Hotel.Controladores
{
    internal class ClienteController
    {
        
        ModelHotel _contex = new ModelHotel();
        //CRUD
        //Devuelve todos los Clientes
        public List<Cliente> GetAll()
        {
            return _contex.Cliente.ToList();
        }

        //Devuelve solo un cliente
        public Cliente Get(int IdCliente)
        {
            return _contex.Cliente.Find(IdCliente);
        }

        //Buscar
        public List<Cliente> Search(string parametro)
        {
            if (String.IsNullOrEmpty(parametro)) return GetAll();
            else
                return _contex.Cliente.Where(x => x.IdCliente.ToString() == parametro ||
                                             x.NombreCliente.Contains(parametro)).ToList();
        }

        //Crear, Actualizar y Eliminar
        public bool Create(Cliente cliente)
        {
            _contex.Cliente.Add(cliente);  //Agregando a la tabla cliente
            return _contex.SaveChanges() > 0;  //Guardando en la base de datos
        }

        public bool Update(Cliente cliente)
        {
            _contex.Cliente.Attach(cliente);  //Busca a la tabla cliente
            _contex.Entry(cliente).State = System.Data.Entity.EntityState.Modified;  //Modifica al cliente en la base de datos
            return _contex.SaveChanges() > 0;  //Guardando en la base de datos
        }

        public bool Delete(Cliente cliente)
        {
            _contex.Cliente.Remove(cliente);   //Busca y elimina al cliente en la base de datos
            return _contex.SaveChanges() > 0;  //Guardando en la base de datos
        }
    }
    
}
