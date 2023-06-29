using Proyecto_Hotel.Controladores;
using Proyecto_Hotel.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Hotel.Vistas
{
    public partial class FrmGestionarUsuario : Form
    {
        public FrmGestionarUsuario()
        {
            InitializeComponent();
        }

        UsuarioController _usuarioController = new UsuarioController();
        bool _isNew = true;  //variable para verificar si el usuario es nuevo o se modifico un usuario
        private void FrmGestionarUsuario_Load(object sender, EventArgs e)
        {
            //Al cargar la pantalla muestre todos los usuarios
            usuarioBindingSource.DataSource = _usuarioController.GetAll();
            //Desabiliota al groupbox
            groupBoxUsuario.Enabled = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //Desabiliota al groupbox
            groupBoxUsuario.Enabled = false;
            //vacia los parametros dentro el groupbox
            usuarioBindingSource.CancelEdit();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        public void Guardar() 
        {
            var user = (Usuario)usuarioBindingSource.Current;
            if (_isNew) _usuarioController.Create(user);
            else        _usuarioController.Update(user);
            groupBoxUsuario.Enabled = false; //desabiita al groupbox
            usuarioBindingSource.DataSource = _usuarioController.GetAll();  //muestra a todos los usuarios
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            _isNew = true; //A la variable global lo volvemos true
            groupBoxUsuario.Enabled = true; //Habilita al groupbox escribir los datos
            usuarioBindingSource.AddNew();  //Borra los datos que habia en el groupbox

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //Recuperar los datos del usuario
            var user = (Usuario)usuarioBindingSource.Current;
            //Mostrar mensaje
            DialogResult dlr = MessageBox.Show("¿Estas Seguro de Eliminar?", "Hotel", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(dlr == DialogResult.OK)      _usuarioController.Delete(user);   //si es ok elimina usuario
            usuarioBindingSource.DataSource = _usuarioController.GetAll(); //muestra a todos los usuarios
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            _isNew = false; //A la variable global lo volvemos false
            groupBoxUsuario.Enabled = true; //Habilita al groupbox escribir los datos

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string par = txtBuscar.Text;
            usuarioBindingSource.DataSource = _usuarioController.Search(par);   //muestra los usuarios que cumplen con el parametro
        }

    }
}
