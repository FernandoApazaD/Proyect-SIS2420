namespace Proyecto_Hotel.Vistas
{
    partial class FrmMenuPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nUEVOCLIENTEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gESTIONARUSUSARIOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gESTIONARHABIATACIONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rEPORTESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sALIRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nUEVOCLIENTEToolStripMenuItem,
            this.gESTIONARUSUSARIOToolStripMenuItem,
            this.gESTIONARHABIATACIONToolStripMenuItem,
            this.rEPORTESToolStripMenuItem,
            this.sALIRToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(701, 68);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nUEVOCLIENTEToolStripMenuItem
            // 
            this.nUEVOCLIENTEToolStripMenuItem.Image = global::Proyecto_Hotel.Properties.Resources.clientes;
            this.nUEVOCLIENTEToolStripMenuItem.Name = "nUEVOCLIENTEToolStripMenuItem";
            this.nUEVOCLIENTEToolStripMenuItem.Size = new System.Drawing.Size(161, 64);
            this.nUEVOCLIENTEToolStripMenuItem.Text = "GESTIONAR CLIENTE";
            this.nUEVOCLIENTEToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.nUEVOCLIENTEToolStripMenuItem.Click += new System.EventHandler(this.nUEVOCLIENTEToolStripMenuItem_Click);
            // 
            // gESTIONARUSUSARIOToolStripMenuItem
            // 
            this.gESTIONARUSUSARIOToolStripMenuItem.Image = global::Proyecto_Hotel.Properties.Resources.usuarios;
            this.gESTIONARUSUSARIOToolStripMenuItem.Name = "gESTIONARUSUSARIOToolStripMenuItem";
            this.gESTIONARUSUSARIOToolStripMenuItem.Size = new System.Drawing.Size(176, 64);
            this.gESTIONARUSUSARIOToolStripMenuItem.Text = "GESTIONAR USUSARIO";
            this.gESTIONARUSUSARIOToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.gESTIONARUSUSARIOToolStripMenuItem.Click += new System.EventHandler(this.gESTIONARUSUSARIOToolStripMenuItem_Click);
            // 
            // gESTIONARHABIATACIONToolStripMenuItem
            // 
            this.gESTIONARHABIATACIONToolStripMenuItem.Image = global::Proyecto_Hotel.Properties.Resources.cuarto;
            this.gESTIONARHABIATACIONToolStripMenuItem.Name = "gESTIONARHABIATACIONToolStripMenuItem";
            this.gESTIONARHABIATACIONToolStripMenuItem.Size = new System.Drawing.Size(201, 64);
            this.gESTIONARHABIATACIONToolStripMenuItem.Text = "GESTIONAR HABIATACION";
            this.gESTIONARHABIATACIONToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.gESTIONARHABIATACIONToolStripMenuItem.Click += new System.EventHandler(this.gESTIONARHABIATACIONToolStripMenuItem_Click);
            // 
            // rEPORTESToolStripMenuItem
            // 
            this.rEPORTESToolStripMenuItem.Image = global::Proyecto_Hotel.Properties.Resources.reporte;
            this.rEPORTESToolStripMenuItem.Name = "rEPORTESToolStripMenuItem";
            this.rEPORTESToolStripMenuItem.Size = new System.Drawing.Size(91, 64);
            this.rEPORTESToolStripMenuItem.Text = "REPORTES";
            this.rEPORTESToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.rEPORTESToolStripMenuItem.Click += new System.EventHandler(this.rEPORTESToolStripMenuItem_Click);
            // 
            // sALIRToolStripMenuItem
            // 
            this.sALIRToolStripMenuItem.Image = global::Proyecto_Hotel.Properties.Resources.cerrar_sesion;
            this.sALIRToolStripMenuItem.Name = "sALIRToolStripMenuItem";
            this.sALIRToolStripMenuItem.Size = new System.Drawing.Size(61, 64);
            this.sALIRToolStripMenuItem.Text = "SALIR";
            this.sALIRToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.sALIRToolStripMenuItem.Click += new System.EventHandler(this.sALIRToolStripMenuItem_Click);
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMenuPrincipal";
            this.Text = "Menu Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nUEVOCLIENTEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gESTIONARUSUSARIOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gESTIONARHABIATACIONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rEPORTESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sALIRToolStripMenuItem;
    }
}