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
    public partial class FrmGestionarHabitacion : Form
    {
        public FrmGestionarHabitacion()
        {
            InitializeComponent();
        }
        HabitacionController _habitacionController = new HabitacionController();
        bool _isNew = true;
        private void FrmGestionarHabitacion_Load(object sender, EventArgs e)
        {
            habitacionBindingSource.DataSource = _habitacionController.GetAll();
            groupBoxHabitacion.Enabled = false;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }
        public void Guardar()
        {
            var room = (Habitacion)habitacionBindingSource.Current;
            if (_isNew) _habitacionController.Create(room);
            else _habitacionController.Update(room);
            groupBoxHabitacion.Enabled = false; //desabiita al groupbox
            habitacionBindingSource.DataSource = _habitacionController.GetAll();  //muestra todas las habitaciones
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //Desabiliota al groupbox
            groupBoxHabitacion.Enabled = false;
            //vacia los parametros dentro el groupbox
            habitacionBindingSource.CancelEdit();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            _isNew = true; //A la variable global lo volvemos true
            groupBoxHabitacion.Enabled = true; //Habilita al groupbox escribir los datos
            habitacionBindingSource.AddNew();  //Borra los datos que habia en el groupbo
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string par = txtBuscar.Text;
            habitacionBindingSource.DataSource = _habitacionController.Search(par);   //muestra los usuarios que cumplen con el parametro
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //Recuperar los datos del usuario
            var room = (Habitacion)habitacionBindingSource.Current;
            //Mostrar mensaje
            DialogResult dlr = MessageBox.Show("¿Estas Seguro de Eliminar?", "Hotel", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dlr == DialogResult.OK) _habitacionController.Delete(room);   //si es ok elimina habitacion
            habitacionBindingSource.DataSource = _habitacionController.GetAll(); //muestra todas las habitaciones
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            _isNew = false; //A la variable global lo volvemos false
            groupBoxHabitacion.Enabled = true; //Habilita al groupbox escribir los datos
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmFleteHabitacion frmFleteHabitacion = new FrmFleteHabitacion();
            frmFleteHabitacion.Show();
        }
    }
}
