namespace GestorDeDatos.Gestores
{
    partial class FrmAsignacionAutoresTitulos
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
            this.lblTituloAsignacion = new System.Windows.Forms.Label();
            this.gbxDatosAsignacion = new System.Windows.Forms.GroupBox();
            this.txtRoyaltyPer = new System.Windows.Forms.TextBox();
            this.lblRoyaltyPer = new System.Windows.Forms.Label();
            this.txtAuOrd = new System.Windows.Forms.TextBox();
            this.lblAuOrd = new System.Windows.Forms.Label();
            this.txtTitleID = new System.Windows.Forms.TextBox();
            this.txtAuID = new System.Windows.Forms.TextBox();
            this.lblTitleID = new System.Windows.Forms.Label();
            this.lblAuID = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dgvAsignaciones = new System.Windows.Forms.DataGridView();
            this.gbxDatosAsignacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsignaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloAsignacion
            // 
            this.lblTituloAsignacion.AutoSize = true;
            this.lblTituloAsignacion.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloAsignacion.Location = new System.Drawing.Point(175, 9);
            this.lblTituloAsignacion.Name = "lblTituloAsignacion";
            this.lblTituloAsignacion.Size = new System.Drawing.Size(429, 38);
            this.lblTituloAsignacion.TabIndex = 1;
            this.lblTituloAsignacion.Text = "Asignación de Autores a Títulos";
            // 
            // gbxDatosAsignacion
            // 
            this.gbxDatosAsignacion.Controls.Add(this.txtRoyaltyPer);
            this.gbxDatosAsignacion.Controls.Add(this.lblRoyaltyPer);
            this.gbxDatosAsignacion.Controls.Add(this.txtAuOrd);
            this.gbxDatosAsignacion.Controls.Add(this.lblAuOrd);
            this.gbxDatosAsignacion.Controls.Add(this.txtTitleID);
            this.gbxDatosAsignacion.Controls.Add(this.txtAuID);
            this.gbxDatosAsignacion.Controls.Add(this.lblTitleID);
            this.gbxDatosAsignacion.Controls.Add(this.lblAuID);
            this.gbxDatosAsignacion.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxDatosAsignacion.Location = new System.Drawing.Point(30, 50);
            this.gbxDatosAsignacion.Name = "gbxDatosAsignacion";
            this.gbxDatosAsignacion.Size = new System.Drawing.Size(427, 235);
            this.gbxDatosAsignacion.TabIndex = 2;
            this.gbxDatosAsignacion.TabStop = false;
            this.gbxDatosAsignacion.Text = "Datos de la Asignación";
            // 
            // txtRoyaltyPer
            // 
            this.txtRoyaltyPer.Location = new System.Drawing.Point(203, 168);
            this.txtRoyaltyPer.Name = "txtRoyaltyPer";
            this.txtRoyaltyPer.Size = new System.Drawing.Size(189, 29);
            this.txtRoyaltyPer.TabIndex = 7;
            // 
            // lblRoyaltyPer
            // 
            this.lblRoyaltyPer.AutoSize = true;
            this.lblRoyaltyPer.Location = new System.Drawing.Point(21, 171);
            this.lblRoyaltyPer.Name = "lblRoyaltyPer";
            this.lblRoyaltyPer.Size = new System.Drawing.Size(165, 22);
            this.lblRoyaltyPer.TabIndex = 6;
            this.lblRoyaltyPer.Text = "Porcentaje de Regalías:";
            // 
            // txtAuOrd
            // 
            this.txtAuOrd.Location = new System.Drawing.Point(202, 125);
            this.txtAuOrd.Name = "txtAuOrd";
            this.txtAuOrd.Size = new System.Drawing.Size(192, 29);
            this.txtAuOrd.TabIndex = 5;
            // 
            // lblAuOrd
            // 
            this.lblAuOrd.AutoSize = true;
            this.lblAuOrd.Location = new System.Drawing.Point(50, 128);
            this.lblAuOrd.Name = "lblAuOrd";
            this.lblAuOrd.Size = new System.Drawing.Size(123, 22);
            this.lblAuOrd.TabIndex = 4;
            this.lblAuOrd.Text = "Orden del Autor:";
            this.lblAuOrd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTitleID
            // 
            this.txtTitleID.Location = new System.Drawing.Point(203, 84);
            this.txtTitleID.Name = "txtTitleID";
            this.txtTitleID.Size = new System.Drawing.Size(190, 29);
            this.txtTitleID.TabIndex = 3;
            // 
            // txtAuID
            // 
            this.txtAuID.Location = new System.Drawing.Point(202, 47);
            this.txtAuID.Name = "txtAuID";
            this.txtAuID.Size = new System.Drawing.Size(192, 29);
            this.txtAuID.TabIndex = 2;
            // 
            // lblTitleID
            // 
            this.lblTitleID.AutoSize = true;
            this.lblTitleID.Location = new System.Drawing.Point(51, 86);
            this.lblTitleID.Name = "lblTitleID";
            this.lblTitleID.Size = new System.Drawing.Size(98, 22);
            this.lblTitleID.TabIndex = 1;
            this.lblTitleID.Text = "ID del Título:";
            // 
            // lblAuID
            // 
            this.lblAuID.AutoSize = true;
            this.lblAuID.Location = new System.Drawing.Point(90, 50);
            this.lblAuID.Name = "lblAuID";
            this.lblAuID.Size = new System.Drawing.Size(96, 22);
            this.lblAuID.TabIndex = 0;
            this.lblAuID.Text = "ID del Autor:";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(104, 359);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(98, 43);
            this.btnNuevo.TabIndex = 3;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(228, 359);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(98, 43);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(355, 359);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(98, 43);
            this.btnActualizar.TabIndex = 5;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(479, 359);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(98, 43);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(607, 359);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(98, 43);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // dgvAsignaciones
            // 
            this.dgvAsignaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsignaciones.Location = new System.Drawing.Point(492, 62);
            this.dgvAsignaciones.Name = "dgvAsignaciones";
            this.dgvAsignaciones.Size = new System.Drawing.Size(296, 246);
            this.dgvAsignaciones.TabIndex = 8;
            // 
            // FrmAsignacionAutoresTitulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 444);
            this.Controls.Add(this.dgvAsignaciones);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.gbxDatosAsignacion);
            this.Controls.Add(this.lblTituloAsignacion);
            this.Name = "FrmAsignacionAutoresTitulos";
            this.Text = "Asignación de Autores a Títulos";
            this.gbxDatosAsignacion.ResumeLayout(false);
            this.gbxDatosAsignacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsignaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloAsignacion;
        private System.Windows.Forms.GroupBox gbxDatosAsignacion;
        private System.Windows.Forms.TextBox txtRoyaltyPer;
        private System.Windows.Forms.Label lblRoyaltyPer;
        private System.Windows.Forms.TextBox txtAuOrd;
        private System.Windows.Forms.Label lblAuOrd;
        private System.Windows.Forms.TextBox txtTitleID;
        private System.Windows.Forms.TextBox txtAuID;
        private System.Windows.Forms.Label lblTitleID;
        private System.Windows.Forms.Label lblAuID;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dgvAsignaciones;
    }
}