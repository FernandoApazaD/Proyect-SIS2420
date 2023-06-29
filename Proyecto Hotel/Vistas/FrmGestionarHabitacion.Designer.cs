namespace Proyecto_Hotel.Vistas
{
    partial class FrmGestionarHabitacion
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label estadoHabitacionLabel;
            System.Windows.Forms.Label numHabitacionLabel;
            System.Windows.Forms.Label precioHabitacionLabel;
            System.Windows.Forms.Label tipoHabitacionLabel;
            this.groupBoxHabitacion = new System.Windows.Forms.GroupBox();
            this.estadoHabitacionCheckBox = new System.Windows.Forms.CheckBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.numHabitacionTextBox = new System.Windows.Forms.TextBox();
            this.precioHabitacionTextBox = new System.Windows.Forms.TextBox();
            this.tipoHabitacionComboBox = new System.Windows.Forms.ComboBox();
            this.habitacionDataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.habitacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            estadoHabitacionLabel = new System.Windows.Forms.Label();
            numHabitacionLabel = new System.Windows.Forms.Label();
            precioHabitacionLabel = new System.Windows.Forms.Label();
            tipoHabitacionLabel = new System.Windows.Forms.Label();
            this.groupBoxHabitacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.habitacionDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.habitacionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // estadoHabitacionLabel
            // 
            estadoHabitacionLabel.AutoSize = true;
            estadoHabitacionLabel.Location = new System.Drawing.Point(29, 96);
            estadoHabitacionLabel.Name = "estadoHabitacionLabel";
            estadoHabitacionLabel.Size = new System.Drawing.Size(121, 16);
            estadoHabitacionLabel.TabIndex = 0;
            estadoHabitacionLabel.Text = "Estado Habitacion:";
            // 
            // numHabitacionLabel
            // 
            numHabitacionLabel.AutoSize = true;
            numHabitacionLabel.Location = new System.Drawing.Point(29, 51);
            numHabitacionLabel.Name = "numHabitacionLabel";
            numHabitacionLabel.Size = new System.Drawing.Size(106, 16);
            numHabitacionLabel.TabIndex = 2;
            numHabitacionLabel.Text = "Num Habitacion:";
            // 
            // precioHabitacionLabel
            // 
            precioHabitacionLabel.AutoSize = true;
            precioHabitacionLabel.Location = new System.Drawing.Point(33, 180);
            precioHabitacionLabel.Name = "precioHabitacionLabel";
            precioHabitacionLabel.Size = new System.Drawing.Size(117, 16);
            precioHabitacionLabel.TabIndex = 4;
            precioHabitacionLabel.Text = "Precio Habitacion:";
            // 
            // tipoHabitacionLabel
            // 
            tipoHabitacionLabel.AutoSize = true;
            tipoHabitacionLabel.Location = new System.Drawing.Point(29, 138);
            tipoHabitacionLabel.Name = "tipoHabitacionLabel";
            tipoHabitacionLabel.Size = new System.Drawing.Size(106, 16);
            tipoHabitacionLabel.TabIndex = 6;
            tipoHabitacionLabel.Text = "Tipo Habitacion:";
            // 
            // groupBoxHabitacion
            // 
            this.groupBoxHabitacion.Controls.Add(this.estadoHabitacionCheckBox);
            this.groupBoxHabitacion.Controls.Add(this.btnCancelar);
            this.groupBoxHabitacion.Controls.Add(this.btnGuardar);
            this.groupBoxHabitacion.Controls.Add(estadoHabitacionLabel);
            this.groupBoxHabitacion.Controls.Add(numHabitacionLabel);
            this.groupBoxHabitacion.Controls.Add(this.numHabitacionTextBox);
            this.groupBoxHabitacion.Controls.Add(precioHabitacionLabel);
            this.groupBoxHabitacion.Controls.Add(this.precioHabitacionTextBox);
            this.groupBoxHabitacion.Controls.Add(tipoHabitacionLabel);
            this.groupBoxHabitacion.Controls.Add(this.tipoHabitacionComboBox);
            this.groupBoxHabitacion.Location = new System.Drawing.Point(12, 70);
            this.groupBoxHabitacion.Name = "groupBoxHabitacion";
            this.groupBoxHabitacion.Size = new System.Drawing.Size(399, 344);
            this.groupBoxHabitacion.TabIndex = 0;
            this.groupBoxHabitacion.TabStop = false;
            this.groupBoxHabitacion.Text = "HABIATCION";
            // 
            // estadoHabitacionCheckBox
            // 
            this.estadoHabitacionCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.habitacionBindingSource, "EstadoHabitacion", true));
            this.estadoHabitacionCheckBox.Location = new System.Drawing.Point(165, 96);
            this.estadoHabitacionCheckBox.Name = "estadoHabitacionCheckBox";
            this.estadoHabitacionCheckBox.Size = new System.Drawing.Size(104, 24);
            this.estadoHabitacionCheckBox.TabIndex = 16;
            this.estadoHabitacionCheckBox.Text = "Ocupado";
            this.estadoHabitacionCheckBox.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(172, 276);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(109, 40);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(49, 276);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(99, 40);
            this.btnGuardar.TabIndex = 14;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // numHabitacionTextBox
            // 
            this.numHabitacionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.habitacionBindingSource, "NumHabitacion", true));
            this.numHabitacionTextBox.Location = new System.Drawing.Point(156, 48);
            this.numHabitacionTextBox.Name = "numHabitacionTextBox";
            this.numHabitacionTextBox.Size = new System.Drawing.Size(121, 22);
            this.numHabitacionTextBox.TabIndex = 3;
            // 
            // precioHabitacionTextBox
            // 
            this.precioHabitacionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.habitacionBindingSource, "PrecioHabitacion", true));
            this.precioHabitacionTextBox.Location = new System.Drawing.Point(160, 177);
            this.precioHabitacionTextBox.Name = "precioHabitacionTextBox";
            this.precioHabitacionTextBox.Size = new System.Drawing.Size(121, 22);
            this.precioHabitacionTextBox.TabIndex = 5;
            // 
            // tipoHabitacionComboBox
            // 
            this.tipoHabitacionComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.habitacionBindingSource, "TipoHabitacion", true));
            this.tipoHabitacionComboBox.FormattingEnabled = true;
            this.tipoHabitacionComboBox.Items.AddRange(new object[] {
            "Individual",
            "Doble",
            "Familiar"});
            this.tipoHabitacionComboBox.Location = new System.Drawing.Point(156, 135);
            this.tipoHabitacionComboBox.Name = "tipoHabitacionComboBox";
            this.tipoHabitacionComboBox.Size = new System.Drawing.Size(121, 24);
            this.tipoHabitacionComboBox.TabIndex = 7;
            // 
            // habitacionDataGridView1
            // 
            this.habitacionDataGridView1.AutoGenerateColumns = false;
            this.habitacionDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.habitacionDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewCheckBoxColumn2});
            this.habitacionDataGridView1.DataSource = this.habitacionBindingSource;
            this.habitacionDataGridView1.Location = new System.Drawing.Point(380, 70);
            this.habitacionDataGridView1.Name = "habitacionDataGridView1";
            this.habitacionDataGridView1.RowHeadersWidth = 51;
            this.habitacionDataGridView1.RowTemplate.Height = 24;
            this.habitacionDataGridView1.Size = new System.Drawing.Size(718, 369);
            this.habitacionDataGridView1.TabIndex = 2;
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(1010, 24);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(86, 29);
            this.btnEditar.TabIndex = 27;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(881, 23);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(111, 29);
            this.btnEliminar.TabIndex = 26;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.Location = new System.Drawing.Point(292, 27);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(60, 20);
            this.lblBuscar.TabIndex = 25;
            this.lblBuscar.Text = "Buscar:";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevo.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(782, 21);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(93, 31);
            this.btnNuevo.TabIndex = 24;
            this.btnNuevo.Text = "NUEVO";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscar.Location = new System.Drawing.Point(358, 27);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(297, 22);
            this.txtBuscar.TabIndex = 23;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(668, 23);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(93, 31);
            this.btnBuscar.TabIndex = 22;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(48, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 40);
            this.button1.TabIndex = 17;
            this.button1.Text = "VER HABITACIONES";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "NumHabitacion";
            this.dataGridViewTextBoxColumn4.HeaderText = "NumHabitacion";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "TipoHabitacion";
            this.dataGridViewTextBoxColumn5.HeaderText = "TipoHabitacion";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "PrecioHabitacion";
            this.dataGridViewTextBoxColumn6.HeaderText = "PrecioHabitacion";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.DataPropertyName = "EstadoHabitacion";
            this.dataGridViewCheckBoxColumn2.HeaderText = "EstadoHabitacion";
            this.dataGridViewCheckBoxColumn2.MinimumWidth = 6;
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            this.dataGridViewCheckBoxColumn2.Width = 125;
            // 
            // habitacionBindingSource
            // 
            this.habitacionBindingSource.DataSource = typeof(Proyecto_Hotel.Models.Habitacion);
            // 
            // FrmGestionarHabitacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 491);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.habitacionDataGridView1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.groupBoxHabitacion);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Name = "FrmGestionarHabitacion";
            this.Text = "FrmGestionarHabitacion";
            this.Load += new System.EventHandler(this.FrmGestionarHabitacion_Load);
            this.groupBoxHabitacion.ResumeLayout(false);
            this.groupBoxHabitacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.habitacionDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.habitacionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxHabitacion;
        private System.Windows.Forms.BindingSource habitacionBindingSource;
        private System.Windows.Forms.DataGridView habitacionDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.TextBox numHabitacionTextBox;
        private System.Windows.Forms.TextBox precioHabitacionTextBox;
        private System.Windows.Forms.ComboBox tipoHabitacionComboBox;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.CheckBox estadoHabitacionCheckBox;
        private System.Windows.Forms.Button button1;
    }
}