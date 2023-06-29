using Proyecto_Hotel.Context;
using Proyecto_Hotel.Controladores;
using Proyecto_Hotel.Vistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Hotel
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            //Crear las clases a la base de datos
            //ModelHotel db = new ModelHotel();
            //db.Usuario.ToList();
            //db.Cliente.ToList();
            //db.Habitacion.ToList();
            //db.Flete.ToList();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string password = txtPassword.Text;
            UsuarioController usuarioController = new UsuarioController();
            bool islogin = usuarioController.Login(usuario, password);
            if (islogin) 
            {
                FrmMenuPrincipal frmMenuPrincipal = new FrmMenuPrincipal();
                frmMenuPrincipal.Show();
            }
            else
            {
                MessageBox.Show("Usuario o Password Incorrectos...","Hotel", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtUsuario.Text = "";
            txtPassword.Text = "";
        }
    }
}
