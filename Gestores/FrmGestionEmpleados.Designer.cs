namespace GestorDeDatos.Gestores
{
    partial class FrmGestionEmpleados
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
            this.lblTituloEmpleados = new System.Windows.Forms.Label();
            this.gbxDatosEmpleado = new System.Windows.Forms.GroupBox();
            this.txtJobLvl = new System.Windows.Forms.TextBox();
            this.lblJobLvl = new System.Windows.Forms.Label();
            this.txtJobID = new System.Windows.Forms.TextBox();
            this.lblJobID = new System.Windows.Forms.Label();
            this.txtLname = new System.Windows.Forms.TextBox();
            this.lblLname = new System.Windows.Forms.Label();
            this.txtMinit = new System.Windows.Forms.TextBox();
            this.lblMinit = new System.Windows.Forms.Label();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.lblFname = new System.Windows.Forms.Label();
            this.txtEmpID = new System.Windows.Forms.TextBox();
            this.lblEmpID = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.lblHireDate = new System.Windows.Forms.Label();
            this.dtpHireDate = new System.Windows.Forms.DateTimePicker();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.gbxDatosEmpleado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloEmpleados
            // 
            this.lblTituloEmpleados.AutoSize = true;
            this.lblTituloEmpleados.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloEmpleados.Location = new System.Drawing.Point(285, 9);
            this.lblTituloEmpleados.Name = "lblTituloEmpleados";
            this.lblTituloEmpleados.Size = new System.Drawing.Size(303, 38);
            this.lblTituloEmpleados.TabIndex = 4;
            this.lblTituloEmpleados.Text = "Gestión de Empleados";
            // 
            // gbxDatosEmpleado
            // 
            this.gbxDatosEmpleado.Controls.Add(this.dtpHireDate);
            this.gbxDatosEmpleado.Controls.Add(this.lblHireDate);
            this.gbxDatosEmpleado.Controls.Add(this.txtJobLvl);
            this.gbxDatosEmpleado.Controls.Add(this.lblJobLvl);
            this.gbxDatosEmpleado.Controls.Add(this.txtJobID);
            this.gbxDatosEmpleado.Controls.Add(this.lblJobID);
            this.gbxDatosEmpleado.Controls.Add(this.txtLname);
            this.gbxDatosEmpleado.Controls.Add(this.lblLname);
            this.gbxDatosEmpleado.Controls.Add(this.txtMinit);
            this.gbxDatosEmpleado.Controls.Add(this.lblMinit);
            this.gbxDatosEmpleado.Controls.Add(this.txtFname);
            this.gbxDatosEmpleado.Controls.Add(this.lblFname);
            this.gbxDatosEmpleado.Controls.Add(this.txtEmpID);
            this.gbxDatosEmpleado.Controls.Add(this.lblEmpID);
            this.gbxDatosEmpleado.Location = new System.Drawing.Point(63, 80);
            this.gbxDatosEmpleado.Name = "gbxDatosEmpleado";
            this.gbxDatosEmpleado.Size = new System.Drawing.Size(402, 280);
            this.gbxDatosEmpleado.TabIndex = 5;
            this.gbxDatosEmpleado.TabStop = false;
            this.gbxDatosEmpleado.Text = "Datos del Empleado";
            // 
            // txtJobLvl
            // 
            this.txtJobLvl.Location = new System.Drawing.Point(178, 204);
            this.txtJobLvl.Name = "txtJobLvl";
            this.txtJobLvl.Size = new System.Drawing.Size(193, 20);
            this.txtJobLvl.TabIndex = 11;
            // 
            // lblJobLvl
            // 
            this.lblJobLvl.AutoSize = true;
            this.lblJobLvl.Location = new System.Drawing.Point(82, 207);
            this.lblJobLvl.Name = "lblJobLvl";
            this.lblJobLvl.Size = new System.Drawing.Size(90, 13);
            this.lblJobLvl.TabIndex = 10;
            this.lblJobLvl.Text = "Nivel del Trabajo:";
            // 
            // txtJobID
            // 
            this.txtJobID.Location = new System.Drawing.Point(178, 170);
            this.txtJobID.Name = "txtJobID";
            this.txtJobID.Size = new System.Drawing.Size(195, 20);
            this.txtJobID.TabIndex = 9;
            // 
            // lblJobID
            // 
            this.lblJobID.AutoSize = true;
            this.lblJobID.Location = new System.Drawing.Point(95, 173);
            this.lblJobID.Name = "lblJobID";
            this.lblJobID.Size = new System.Drawing.Size(77, 13);
            this.lblJobID.TabIndex = 8;
            this.lblJobID.Text = "ID del Trabajo:";
            // 
            // txtLname
            // 
            this.txtLname.Location = new System.Drawing.Point(178, 138);
            this.txtLname.Name = "txtLname";
            this.txtLname.Size = new System.Drawing.Size(195, 20);
            this.txtLname.TabIndex = 7;
            // 
            // lblLname
            // 
            this.lblLname.AutoSize = true;
            this.lblLname.Location = new System.Drawing.Point(129, 141);
            this.lblLname.Name = "lblLname";
            this.lblLname.Size = new System.Drawing.Size(47, 13);
            this.lblLname.TabIndex = 6;
            this.lblLname.Text = "Apellido:";
            // 
            // txtMinit
            // 
            this.txtMinit.Location = new System.Drawing.Point(178, 103);
            this.txtMinit.Name = "txtMinit";
            this.txtMinit.Size = new System.Drawing.Size(195, 20);
            this.txtMinit.TabIndex = 5;
            // 
            // lblMinit
            // 
            this.lblMinit.AutoSize = true;
            this.lblMinit.Location = new System.Drawing.Point(32, 106);
            this.lblMinit.Name = "lblMinit";
            this.lblMinit.Size = new System.Drawing.Size(140, 13);
            this.lblMinit.TabIndex = 4;
            this.lblMinit.Text = "Inicial del Segundo Nombre:";
            // 
            // txtFname
            // 
            this.txtFname.Location = new System.Drawing.Point(178, 68);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(195, 20);
            this.txtFname.TabIndex = 3;
            // 
            // lblFname
            // 
            this.lblFname.AutoSize = true;
            this.lblFname.Location = new System.Drawing.Point(125, 71);
            this.lblFname.Name = "lblFname";
            this.lblFname.Size = new System.Drawing.Size(47, 13);
            this.lblFname.TabIndex = 2;
            this.lblFname.Text = "Nombre:";
            // 
            // txtEmpID
            // 
            this.txtEmpID.Location = new System.Drawing.Point(178, 32);
            this.txtEmpID.Name = "txtEmpID";
            this.txtEmpID.Size = new System.Drawing.Size(195, 20);
            this.txtEmpID.TabIndex = 1;
            // 
            // lblEmpID
            // 
            this.lblEmpID.AutoSize = true;
            this.lblEmpID.Location = new System.Drawing.Point(84, 35);
            this.lblEmpID.Name = "lblEmpID";
            this.lblEmpID.Size = new System.Drawing.Size(88, 13);
            this.lblEmpID.TabIndex = 0;
            this.lblEmpID.Text = "ID del Empleado:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(497, 384);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(71, 36);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(401, 384);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(64, 38);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(305, 384);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(68, 38);
            this.btnActualizar.TabIndex = 9;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(218, 384);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(64, 38);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(134, 382);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(68, 38);
            this.btnNuevo.TabIndex = 7;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // lblHireDate
            // 
            this.lblHireDate.AutoSize = true;
            this.lblHireDate.Location = new System.Drawing.Point(54, 245);
            this.lblHireDate.Name = "lblHireDate";
            this.lblHireDate.Size = new System.Drawing.Size(118, 13);
            this.lblHireDate.TabIndex = 12;
            this.lblHireDate.Text = "Fecha de Contratación:";
            this.lblHireDate.Click += new System.EventHandler(this.lblHireDate_Click);
            // 
            // dtpHireDate
            // 
            this.dtpHireDate.Location = new System.Drawing.Point(178, 239);
            this.dtpHireDate.Name = "dtpHireDate";
            this.dtpHireDate.Size = new System.Drawing.Size(193, 20);
            this.dtpHireDate.TabIndex = 12;
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Location = new System.Drawing.Point(504, 88);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.Size = new System.Drawing.Size(277, 271);
            this.dgvEmpleados.TabIndex = 12;
            // 
            // FrmGestionEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvEmpleados);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.gbxDatosEmpleado);
            this.Controls.Add(this.lblTituloEmpleados);
            this.Name = "FrmGestionEmpleados";
            this.Text = "Gestión de Empleados";
            this.gbxDatosEmpleado.ResumeLayout(false);
            this.gbxDatosEmpleado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloEmpleados;
        private System.Windows.Forms.GroupBox gbxDatosEmpleado;
        private System.Windows.Forms.TextBox txtJobLvl;
        private System.Windows.Forms.Label lblJobLvl;
        private System.Windows.Forms.TextBox txtJobID;
        private System.Windows.Forms.Label lblJobID;
        private System.Windows.Forms.TextBox txtLname;
        private System.Windows.Forms.Label lblLname;
        private System.Windows.Forms.TextBox txtMinit;
        private System.Windows.Forms.Label lblMinit;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.Label lblFname;
        private System.Windows.Forms.TextBox txtEmpID;
        private System.Windows.Forms.Label lblEmpID;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Label lblHireDate;
        private System.Windows.Forms.DateTimePicker dtpHireDate;
        private System.Windows.Forms.DataGridView dgvEmpleados;
    }
}