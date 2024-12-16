namespace GestorDeDatos.Gestores
{
    partial class FrmProgramacionRegalias
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
            this.lblTituloRegalias = new System.Windows.Forms.Label();
            this.gbxDatosRegalias = new System.Windows.Forms.GroupBox();
            this.txtRoyalty = new System.Windows.Forms.TextBox();
            this.lblRoyalty = new System.Windows.Forms.Label();
            this.txtHirange = new System.Windows.Forms.TextBox();
            this.lblHirange = new System.Windows.Forms.Label();
            this.txtLorange = new System.Windows.Forms.TextBox();
            this.lblLorange = new System.Windows.Forms.Label();
            this.txtTitleID = new System.Windows.Forms.TextBox();
            this.lblTitleID = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dgvRegalias = new System.Windows.Forms.DataGridView();
            this.gbxDatosRegalias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegalias)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloRegalias
            // 
            this.lblTituloRegalias.AutoSize = true;
            this.lblTituloRegalias.Font = new System.Drawing.Font("Perpetua Titling MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloRegalias.Location = new System.Drawing.Point(256, 9);
            this.lblTituloRegalias.Name = "lblTituloRegalias";
            this.lblTituloRegalias.Size = new System.Drawing.Size(455, 32);
            this.lblTituloRegalias.TabIndex = 1;
            this.lblTituloRegalias.Text = "Programación de Regalías";
            // 
            // gbxDatosRegalias
            // 
            this.gbxDatosRegalias.Controls.Add(this.txtRoyalty);
            this.gbxDatosRegalias.Controls.Add(this.lblRoyalty);
            this.gbxDatosRegalias.Controls.Add(this.txtHirange);
            this.gbxDatosRegalias.Controls.Add(this.lblHirange);
            this.gbxDatosRegalias.Controls.Add(this.txtLorange);
            this.gbxDatosRegalias.Controls.Add(this.lblLorange);
            this.gbxDatosRegalias.Controls.Add(this.txtTitleID);
            this.gbxDatosRegalias.Controls.Add(this.lblTitleID);
            this.gbxDatosRegalias.Location = new System.Drawing.Point(45, 97);
            this.gbxDatosRegalias.Name = "gbxDatosRegalias";
            this.gbxDatosRegalias.Size = new System.Drawing.Size(359, 197);
            this.gbxDatosRegalias.TabIndex = 2;
            this.gbxDatosRegalias.TabStop = false;
            this.gbxDatosRegalias.Text = "Datos de Regalías";
            // 
            // txtRoyalty
            // 
            this.txtRoyalty.Location = new System.Drawing.Point(146, 139);
            this.txtRoyalty.Name = "txtRoyalty";
            this.txtRoyalty.Size = new System.Drawing.Size(195, 20);
            this.txtRoyalty.TabIndex = 7;
            // 
            // lblRoyalty
            // 
            this.lblRoyalty.AutoSize = true;
            this.lblRoyalty.Location = new System.Drawing.Point(7, 142);
            this.lblRoyalty.Name = "lblRoyalty";
            this.lblRoyalty.Size = new System.Drawing.Size(117, 13);
            this.lblRoyalty.TabIndex = 6;
            this.lblRoyalty.Text = "Porcentaje de Regalía:";
            // 
            // txtHirange
            // 
            this.txtHirange.Location = new System.Drawing.Point(146, 100);
            this.txtHirange.Name = "txtHirange";
            this.txtHirange.Size = new System.Drawing.Size(195, 20);
            this.txtHirange.TabIndex = 5;
            // 
            // lblHirange
            // 
            this.lblHirange.AutoSize = true;
            this.lblHirange.Location = new System.Drawing.Point(6, 103);
            this.lblHirange.Name = "lblHirange";
            this.lblHirange.Size = new System.Drawing.Size(125, 13);
            this.lblHirange.TabIndex = 4;
            this.lblHirange.Text = "Límite Superior (hirange):";
            // 
            // txtLorange
            // 
            this.txtLorange.Location = new System.Drawing.Point(146, 68);
            this.txtLorange.Name = "txtLorange";
            this.txtLorange.Size = new System.Drawing.Size(195, 20);
            this.txtLorange.TabIndex = 3;
            // 
            // lblLorange
            // 
            this.lblLorange.AutoSize = true;
            this.lblLorange.Location = new System.Drawing.Point(13, 68);
            this.lblLorange.Name = "lblLorange";
            this.lblLorange.Size = new System.Drawing.Size(118, 13);
            this.lblLorange.TabIndex = 2;
            this.lblLorange.Text = "Límite Inferior (lorange):";
            // 
            // txtTitleID
            // 
            this.txtTitleID.Location = new System.Drawing.Point(146, 32);
            this.txtTitleID.Name = "txtTitleID";
            this.txtTitleID.Size = new System.Drawing.Size(195, 20);
            this.txtTitleID.TabIndex = 1;
            // 
            // lblTitleID
            // 
            this.lblTitleID.AutoSize = true;
            this.lblTitleID.Location = new System.Drawing.Point(62, 35);
            this.lblTitleID.Name = "lblTitleID";
            this.lblTitleID.Size = new System.Drawing.Size(69, 13);
            this.lblTitleID.TabIndex = 0;
            this.lblTitleID.Text = "ID del Título:";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(45, 337);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(92, 37);
            this.btnNuevo.TabIndex = 3;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(174, 337);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(92, 37);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(303, 337);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(92, 37);
            this.btnActualizar.TabIndex = 5;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(439, 337);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(92, 37);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(588, 337);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(92, 37);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // dgvRegalias
            // 
            this.dgvRegalias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegalias.Location = new System.Drawing.Point(445, 106);
            this.dgvRegalias.Name = "dgvRegalias";
            this.dgvRegalias.Size = new System.Drawing.Size(322, 187);
            this.dgvRegalias.TabIndex = 8;
            // 
            // FrmProgramacionRegalias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 416);
            this.Controls.Add(this.dgvRegalias);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.gbxDatosRegalias);
            this.Controls.Add(this.lblTituloRegalias);
            this.Name = "FrmProgramacionRegalias";
            this.Text = "Programación de Regalías";
            this.Load += new System.EventHandler(this.FrmProgramacionRegalias_Load);
            this.gbxDatosRegalias.ResumeLayout(false);
            this.gbxDatosRegalias.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegalias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloRegalias;
        private System.Windows.Forms.GroupBox gbxDatosRegalias;
        private System.Windows.Forms.TextBox txtRoyalty;
        private System.Windows.Forms.Label lblRoyalty;
        private System.Windows.Forms.TextBox txtHirange;
        private System.Windows.Forms.Label lblHirange;
        private System.Windows.Forms.TextBox txtLorange;
        private System.Windows.Forms.Label lblLorange;
        private System.Windows.Forms.TextBox txtTitleID;
        private System.Windows.Forms.Label lblTitleID;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dgvRegalias;
    }
}