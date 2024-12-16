namespace GestorDeDatos.Gestores
{
    partial class FrmGestionTrabajos
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
            this.lblTituloTrabajos = new System.Windows.Forms.Label();
            this.gbxDatosTrabajo = new System.Windows.Forms.GroupBox();
            this.lblMaxLvl = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtMinLvl = new System.Windows.Forms.TextBox();
            this.lblMinLvl = new System.Windows.Forms.Label();
            this.txtJobDesc = new System.Windows.Forms.TextBox();
            this.lblJobDesc = new System.Windows.Forms.Label();
            this.txtJobID = new System.Windows.Forms.TextBox();
            this.lblJobID = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dgvTrabajos = new System.Windows.Forms.DataGridView();
            this.gbxDatosTrabajo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrabajos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloTrabajos
            // 
            this.lblTituloTrabajos.AutoSize = true;
            this.lblTituloTrabajos.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloTrabajos.Location = new System.Drawing.Point(255, 9);
            this.lblTituloTrabajos.Name = "lblTituloTrabajos";
            this.lblTituloTrabajos.Size = new System.Drawing.Size(272, 38);
            this.lblTituloTrabajos.TabIndex = 2;
            this.lblTituloTrabajos.Text = "Gestión de Trabajos";
            // 
            // gbxDatosTrabajo
            // 
            this.gbxDatosTrabajo.Controls.Add(this.lblMaxLvl);
            this.gbxDatosTrabajo.Controls.Add(this.lblCity);
            this.gbxDatosTrabajo.Controls.Add(this.txtMinLvl);
            this.gbxDatosTrabajo.Controls.Add(this.lblMinLvl);
            this.gbxDatosTrabajo.Controls.Add(this.txtJobDesc);
            this.gbxDatosTrabajo.Controls.Add(this.lblJobDesc);
            this.gbxDatosTrabajo.Controls.Add(this.txtJobID);
            this.gbxDatosTrabajo.Controls.Add(this.lblJobID);
            this.gbxDatosTrabajo.Location = new System.Drawing.Point(60, 106);
            this.gbxDatosTrabajo.Name = "gbxDatosTrabajo";
            this.gbxDatosTrabajo.Size = new System.Drawing.Size(349, 188);
            this.gbxDatosTrabajo.TabIndex = 3;
            this.gbxDatosTrabajo.TabStop = false;
            this.gbxDatosTrabajo.Text = "Datos del Trabajo";
            // 
            // lblMaxLvl
            // 
            this.lblMaxLvl.Location = new System.Drawing.Point(130, 135);
            this.lblMaxLvl.Name = "lblMaxLvl";
            this.lblMaxLvl.Size = new System.Drawing.Size(195, 20);
            this.lblMaxLvl.TabIndex = 7;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(51, 142);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(73, 13);
            this.lblCity.TabIndex = 6;
            this.lblCity.Text = "Nivel Máximo:";
            // 
            // txtMinLvl
            // 
            this.txtMinLvl.Location = new System.Drawing.Point(130, 100);
            this.txtMinLvl.Name = "txtMinLvl";
            this.txtMinLvl.Size = new System.Drawing.Size(195, 20);
            this.txtMinLvl.TabIndex = 5;
            // 
            // lblMinLvl
            // 
            this.lblMinLvl.AutoSize = true;
            this.lblMinLvl.Location = new System.Drawing.Point(52, 107);
            this.lblMinLvl.Name = "lblMinLvl";
            this.lblMinLvl.Size = new System.Drawing.Size(72, 13);
            this.lblMinLvl.TabIndex = 4;
            this.lblMinLvl.Text = "Nivel Mínimo:";
            // 
            // txtJobDesc
            // 
            this.txtJobDesc.Location = new System.Drawing.Point(130, 65);
            this.txtJobDesc.Name = "txtJobDesc";
            this.txtJobDesc.Size = new System.Drawing.Size(195, 20);
            this.txtJobDesc.TabIndex = 3;
            // 
            // lblJobDesc
            // 
            this.lblJobDesc.AutoSize = true;
            this.lblJobDesc.Location = new System.Drawing.Point(2, 68);
            this.lblJobDesc.Name = "lblJobDesc";
            this.lblJobDesc.Size = new System.Drawing.Size(122, 13);
            this.lblJobDesc.TabIndex = 2;
            this.lblJobDesc.Text = "Descripción del Trabajo:";
            // 
            // txtJobID
            // 
            this.txtJobID.Location = new System.Drawing.Point(130, 29);
            this.txtJobID.Name = "txtJobID";
            this.txtJobID.Size = new System.Drawing.Size(195, 20);
            this.txtJobID.TabIndex = 1;
            // 
            // lblJobID
            // 
            this.lblJobID.AutoSize = true;
            this.lblJobID.Location = new System.Drawing.Point(47, 36);
            this.lblJobID.Name = "lblJobID";
            this.lblJobID.Size = new System.Drawing.Size(77, 13);
            this.lblJobID.TabIndex = 0;
            this.lblJobID.Text = "ID del Trabajo:";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(41, 341);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(90, 44);
            this.btnNuevo.TabIndex = 4;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(162, 341);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(90, 44);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(283, 341);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(90, 44);
            this.btnActualizar.TabIndex = 6;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(417, 341);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(90, 44);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(559, 341);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 44);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // dgvTrabajos
            // 
            this.dgvTrabajos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrabajos.Location = new System.Drawing.Point(474, 108);
            this.dgvTrabajos.Name = "dgvTrabajos";
            this.dgvTrabajos.Size = new System.Drawing.Size(300, 185);
            this.dgvTrabajos.TabIndex = 9;
            // 
            // FrmGestionTrabajos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvTrabajos);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.gbxDatosTrabajo);
            this.Controls.Add(this.lblTituloTrabajos);
            this.Name = "FrmGestionTrabajos";
            this.Text = "Gestión de Trabajos";
            this.gbxDatosTrabajo.ResumeLayout(false);
            this.gbxDatosTrabajo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrabajos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloTrabajos;
        private System.Windows.Forms.GroupBox gbxDatosTrabajo;
        private System.Windows.Forms.TextBox lblMaxLvl;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtMinLvl;
        private System.Windows.Forms.Label lblMinLvl;
        private System.Windows.Forms.TextBox txtJobDesc;
        private System.Windows.Forms.Label lblJobDesc;
        private System.Windows.Forms.TextBox txtJobID;
        private System.Windows.Forms.Label lblJobID;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dgvTrabajos;
    }
}