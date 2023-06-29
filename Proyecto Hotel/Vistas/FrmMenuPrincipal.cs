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
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void gESTIONARUSUSARIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGestionarUsuario frmGestionarUsuario = new FrmGestionarUsuario();
            frmGestionarUsuario.MdiParent = this;       //Carga al formulario en la misma pantalla
            frmGestionarUsuario.WindowState = FormWindowState.Maximized;
            frmGestionarUsuario.Show();
        }

        private void nUEVOCLIENTEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGestionarCliente frmGestionarCliente = new FrmGestionarCliente();
            frmGestionarCliente.MdiParent = this;       //Carga al formulario en la misma pantalla
            frmGestionarCliente.WindowState = FormWindowState.Maximized;
            frmGestionarCliente.Show();
        }

        private void gESTIONARHABIATACIONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGestionarHabitacion frmGestionarCliente = new FrmGestionarHabitacion();
            frmGestionarCliente.MdiParent= this;
            frmGestionarCliente.WindowState= FormWindowState.Maximized;
            frmGestionarCliente.Show();
        }

        private void rEPORTESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReportes frmReporte = new FrmReportes();
            frmReporte.MdiParent = this;       //Carga al formulario en la misma pantalla
            frmReporte.WindowState = FormWindowState.Maximized;
            frmReporte.Show();
        }

        private void sALIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
