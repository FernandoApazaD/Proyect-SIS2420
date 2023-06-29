using Proyecto_Hotel.Context;
using Proyecto_Hotel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Hotel.Controladores
{
    internal class UsuarioController
    {
        //CRUD y Login
        ModelHotel _contex = new ModelHotel();

        public bool Login(string usuario, string password)
        {
            var usuarios = _contex.Usuario.Where(x => x.CuentaUsuario == usuario && x.ClaveUsuario == password).SingleOrDefault();
            if (usuarios != null)       return true;
            else                        return false;
        }

        //CRUD
        //Devuelve todos los usuario
        public List<Usuario> GetAll()
        {
            return _contex.Usuario.ToList();
        }

        //Devuelve solo un usuario
        public Usuario Get(string NombreUsuario) 
        {
            return _contex.Usuario.Find(NombreUsuario);
        }

        //Buscar
        public List<Usuario> Search(string parametro)
        {
            if(String.IsNullOrEmpty(parametro))     return GetAll();
            else
                    return _contex.Usuario.Where(x => x.CuentaUsuario.Contains(parametro) ||
                                                 x.NombreUsuario.Contains(parametro)).ToList();
        }

        //Crear, Actualizar y Eliminar
        public bool Create (Usuario usuario) 
        {
            _contex.Usuario.Add(usuario);  //Agregando a la tabla usuario
            return _contex.SaveChanges() > 0;  //Guardando en la base de datos
        }

        public bool Update(Usuario usuario)
        {
            _contex.Usuario.Attach(usuario);  //Busca a la tabla usuario
            _contex.Entry(usuario).State = System.Data.Entity.EntityState.Modified;  //Modifica al usuario en la base de datos
            return _contex.SaveChanges() > 0;  //Guardando en la base de datos
        }

        public bool Delete(Usuario usuario) 
        {
            _contex.Usuario.Remove(usuario);   //Busca y elimina al usuario en la base de datos
            return _contex.SaveChanges() > 0;  //Guardando en la base de datos
        }
    }
}
