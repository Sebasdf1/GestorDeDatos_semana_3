namespace GestorDeDatos.Gestores
{
    partial class FrmGestionInfoEditorial
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
            this.lblTituloInfoEditorial = new System.Windows.Forms.Label();
            this.gbxDatosInfoEditorial = new System.Windows.Forms.GroupBox();
            this.txtPrInfo = new System.Windows.Forms.TextBox();
            this.lblPrInfo = new System.Windows.Forms.Label();
            this.txtLogo = new System.Windows.Forms.TextBox();
            this.lblLogo = new System.Windows.Forms.Label();
            this.txtPubID = new System.Windows.Forms.TextBox();
            this.lblPubID = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dgvInfoEditorial = new System.Windows.Forms.DataGridView();
            this.gbxDatosInfoEditorial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfoEditorial)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloInfoEditorial
            // 
            this.lblTituloInfoEditorial.AutoSize = true;
            this.lblTituloInfoEditorial.Font = new System.Drawing.Font("Perpetua Titling MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloInfoEditorial.Location = new System.Drawing.Point(56, 9);
            this.lblTituloInfoEditorial.Name = "lblTituloInfoEditorial";
            this.lblTituloInfoEditorial.Size = new System.Drawing.Size(575, 32);
            this.lblTituloInfoEditorial.TabIndex = 1;
            this.lblTituloInfoEditorial.Text = "Gestión de Información Editorial";
            // 
            // gbxDatosInfoEditorial
            // 
            this.gbxDatosInfoEditorial.Controls.Add(this.txtPrInfo);
            this.gbxDatosInfoEditorial.Controls.Add(this.lblPrInfo);
            this.gbxDatosInfoEditorial.Controls.Add(this.txtLogo);
            this.gbxDatosInfoEditorial.Controls.Add(this.lblLogo);
            this.gbxDatosInfoEditorial.Controls.Add(this.txtPubID);
            this.gbxDatosInfoEditorial.Controls.Add(this.lblPubID);
            this.gbxDatosInfoEditorial.Location = new System.Drawing.Point(12, 87);
            this.gbxDatosInfoEditorial.Name = "gbxDatosInfoEditorial";
            this.gbxDatosInfoEditorial.Size = new System.Drawing.Size(434, 176);
            this.gbxDatosInfoEditorial.TabIndex = 4;
            this.gbxDatosInfoEditorial.TabStop = false;
            this.gbxDatosInfoEditorial.Text = "Datos de la Información Editorial";
            // 
            // txtPrInfo
            // 
            this.txtPrInfo.Location = new System.Drawing.Point(215, 116);
            this.txtPrInfo.Name = "txtPrInfo";
            this.txtPrInfo.Size = new System.Drawing.Size(195, 20);
            this.txtPrInfo.TabIndex = 5;
            // 
            // lblPrInfo
            // 
            this.lblPrInfo.AutoSize = true;
            this.lblPrInfo.Location = new System.Drawing.Point(6, 119);
            this.lblPrInfo.Name = "lblPrInfo";
            this.lblPrInfo.Size = new System.Drawing.Size(203, 13);
            this.lblPrInfo.TabIndex = 4;
            this.lblPrInfo.Text = "Información de Relaciones Públicas (PR):";
            // 
            // txtLogo
            // 
            this.txtLogo.Location = new System.Drawing.Point(215, 82);
            this.txtLogo.Name = "txtLogo";
            this.txtLogo.Size = new System.Drawing.Size(195, 20);
            this.txtLogo.TabIndex = 3;
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Location = new System.Drawing.Point(175, 85);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(34, 13);
            this.lblLogo.TabIndex = 2;
            this.lblLogo.Text = "Logo:";
            // 
            // txtPubID
            // 
            this.txtPubID.Location = new System.Drawing.Point(215, 46);
            this.txtPubID.Name = "txtPubID";
            this.txtPubID.Size = new System.Drawing.Size(195, 20);
            this.txtPubID.TabIndex = 1;
            // 
            // lblPubID
            // 
            this.lblPubID.AutoSize = true;
            this.lblPubID.Location = new System.Drawing.Point(118, 53);
            this.lblPubID.Name = "lblPubID";
            this.lblPubID.Size = new System.Drawing.Size(91, 13);
            this.lblPubID.TabIndex = 0;
            this.lblPubID.Text = "ID del Publicador:";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(40, 293);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(93, 35);
            this.btnNuevo.TabIndex = 5;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(174, 293);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(93, 35);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(297, 293);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(93, 35);
            this.btnActualizar.TabIndex = 7;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(426, 293);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(93, 35);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(552, 293);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(93, 35);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // dgvInfoEditorial
            // 
            this.dgvInfoEditorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInfoEditorial.Location = new System.Drawing.Point(478, 92);
            this.dgvInfoEditorial.Name = "dgvInfoEditorial";
            this.dgvInfoEditorial.Size = new System.Drawing.Size(201, 170);
            this.dgvInfoEditorial.TabIndex = 10;
            // 
            // FrmGestionInfoEditorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 360);
            this.Controls.Add(this.dgvInfoEditorial);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.gbxDatosInfoEditorial);
            this.Controls.Add(this.lblTituloInfoEditorial);
            this.Name = "FrmGestionInfoEditorial";
            this.Text = "Gestión de Información Editorial";
            this.gbxDatosInfoEditorial.ResumeLayout(false);
            this.gbxDatosInfoEditorial.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfoEditorial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloInfoEditorial;
        private System.Windows.Forms.GroupBox gbxDatosInfoEditorial;
        private System.Windows.Forms.TextBox txtPrInfo;
        private System.Windows.Forms.Label lblPrInfo;
        private System.Windows.Forms.TextBox txtLogo;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.TextBox txtPubID;
        private System.Windows.Forms.Label lblPubID;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dgvInfoEditorial;
    }
}