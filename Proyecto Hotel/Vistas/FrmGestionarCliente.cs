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
    public partial class FrmGestionarCliente : Form
    {
        public FrmGestionarCliente()
        {
            InitializeComponent();
        }

        ClienteController _clienteController = new ClienteController();
        bool _isNew = true;
        private void FrmGestionarCliente_Load(object sender, EventArgs e)
        {
            //Al cargar la pantalla muestre todos los clientes
            clienteBindingSource.DataSource = _clienteController.GetAll(); 
            //Desabiliota al groupbox
            groupBoxCliente.Enabled = false;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }
        public void Guardar()
        {
            var client = (Cliente)clienteBindingSource.Current;
            if (_isNew) _clienteController.Create(client);
            else _clienteController.Update(client);
            groupBoxCliente.Enabled = false; //desabiita al groupbox
            clienteBindingSource.DataSource = _clienteController.GetAll();  //muestra a todos los usuarios
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //Desabiliota al groupbox
            groupBoxCliente.Enabled = false;
            //vacia los parametros dentro el groupbox
            clienteBindingSource.CancelEdit();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            _isNew = true; //A la variable global lo volvemos true
            groupBoxCliente.Enabled = true; //Habilita al groupbox escribir los datos
            clienteBindingSource.AddNew();  //Borra los datos que habia en el groupbox
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string par = txtBuscar.Text;
            clienteBindingSource.DataSource = _clienteController.Search(par);   //muestra los usuarios que cumplen con el parametro
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //Recuperar los datos del usuario
            var client = (Cliente)clienteBindingSource.Current;
            //Mostrar mensaje
            DialogResult dlr = MessageBox.Show("¿Estas Seguro de Eliminar?", "Hotel", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dlr == DialogResult.OK) _clienteController.Delete(client);   //si es ok elimina cliente
            clienteBindingSource.DataSource = _clienteController.GetAll(); //muestra a todos los clientes
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            _isNew = false; //A la variable global lo volvemos false
            groupBoxCliente.Enabled = true; //Habilita al groupbox escribir los datos
        }
    }
}
