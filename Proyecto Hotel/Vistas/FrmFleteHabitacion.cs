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
    public partial class FrmFleteHabitacion : Form
    {
        public FrmFleteHabitacion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Recibo frmRecibo = new Recibo();
            frmRecibo.Show();
        }
    }
}
