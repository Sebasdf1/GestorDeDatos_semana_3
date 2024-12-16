namespace GestorDeDatos.Gestores
{
    partial class FrmGestionTiendas
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.gbxDatosTienda = new System.Windows.Forms.GroupBox();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.lblZip = new System.Windows.Forms.Label();
            this.txtState = new System.Windows.Forms.TextBox();
            this.lblState = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtStorAddress = new System.Windows.Forms.TextBox();
            this.lblStorAddress = new System.Windows.Forms.Label();
            this.txtStorName = new System.Windows.Forms.TextBox();
            this.lblStorName = new System.Windows.Forms.Label();
            this.txtStorID = new System.Windows.Forms.TextBox();
            this.lblStorID = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dgvTiendas = new System.Windows.Forms.DataGridView();
            this.gbxDatosTienda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTiendas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Perpetua Titling MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(238, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(322, 32);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Gestión de Tiendas";
            // 
            // gbxDatosTienda
            // 
            this.gbxDatosTienda.Controls.Add(this.txtZip);
            this.gbxDatosTienda.Controls.Add(this.lblZip);
            this.gbxDatosTienda.Controls.Add(this.txtState);
            this.gbxDatosTienda.Controls.Add(this.lblState);
            this.gbxDatosTienda.Controls.Add(this.txtCity);
            this.gbxDatosTienda.Controls.Add(this.lblCity);
            this.gbxDatosTienda.Controls.Add(this.txtStorAddress);
            this.gbxDatosTienda.Controls.Add(this.lblStorAddress);
            this.gbxDatosTienda.Controls.Add(this.txtStorName);
            this.gbxDatosTienda.Controls.Add(this.lblStorName);
            this.gbxDatosTienda.Controls.Add(this.txtStorID);
            this.gbxDatosTienda.Controls.Add(this.lblStorID);
            this.gbxDatosTienda.Location = new System.Drawing.Point(55, 89);
            this.gbxDatosTienda.Name = "gbxDatosTienda";
            this.gbxDatosTienda.Size = new System.Drawing.Size(349, 256);
            this.gbxDatosTienda.TabIndex = 1;
            this.gbxDatosTienda.TabStop = false;
            this.gbxDatosTienda.Text = "Datos de la Tienda";
            // 
            // txtZip
            // 
            this.txtZip.Location = new System.Drawing.Point(130, 201);
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(193, 20);
            this.txtZip.TabIndex = 11;
            // 
            // lblZip
            // 
            this.lblZip.AutoSize = true;
            this.lblZip.Location = new System.Drawing.Point(49, 204);
            this.lblZip.Name = "lblZip";
            this.lblZip.Size = new System.Drawing.Size(75, 13);
            this.lblZip.TabIndex = 10;
            this.lblZip.Text = "Código Postal:";
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(130, 167);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(195, 20);
            this.txtState.TabIndex = 9;
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(81, 171);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(43, 13);
            this.lblState.TabIndex = 8;
            this.lblState.Text = "Estado:";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(130, 135);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(195, 20);
            this.txtCity.TabIndex = 7;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(81, 138);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(43, 13);
            this.lblCity.TabIndex = 6;
            this.lblCity.Text = "Ciudad:";
            // 
            // txtStorAddress
            // 
            this.txtStorAddress.Location = new System.Drawing.Point(130, 100);
            this.txtStorAddress.Name = "txtStorAddress";
            this.txtStorAddress.Size = new System.Drawing.Size(195, 20);
            this.txtStorAddress.TabIndex = 5;
            // 
            // lblStorAddress
            // 
            this.lblStorAddress.AutoSize = true;
            this.lblStorAddress.Location = new System.Drawing.Point(69, 103);
            this.lblStorAddress.Name = "lblStorAddress";
            this.lblStorAddress.Size = new System.Drawing.Size(55, 13);
            this.lblStorAddress.TabIndex = 4;
            this.lblStorAddress.Text = "Dirección:";
            this.lblStorAddress.Click += new System.EventHandler(this.lblStorAddress_Click);
            // 
            // txtStorName
            // 
            this.txtStorName.Location = new System.Drawing.Point(130, 65);
            this.txtStorName.Name = "txtStorName";
            this.txtStorName.Size = new System.Drawing.Size(195, 20);
            this.txtStorName.TabIndex = 3;
            // 
            // lblStorName
            // 
            this.lblStorName.AutoSize = true;
            this.lblStorName.Location = new System.Drawing.Point(15, 68);
            this.lblStorName.Name = "lblStorName";
            this.lblStorName.Size = new System.Drawing.Size(109, 13);
            this.lblStorName.TabIndex = 2;
            this.lblStorName.Text = "Nombre de la Tienda:";
            // 
            // txtStorID
            // 
            this.txtStorID.Location = new System.Drawing.Point(130, 29);
            this.txtStorID.Name = "txtStorID";
            this.txtStorID.Size = new System.Drawing.Size(195, 20);
            this.txtStorID.TabIndex = 1;
            // 
            // lblStorID
            // 
            this.lblStorID.AutoSize = true;
            this.lblStorID.Location = new System.Drawing.Point(52, 32);
            this.lblStorID.Name = "lblStorID";
            this.lblStorID.Size = new System.Drawing.Size(72, 13);
            this.lblStorID.TabIndex = 0;
            this.lblStorID.Text = "ID de Tienda:";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(73, 362);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(68, 38);
            this.btnNuevo.TabIndex = 2;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(157, 364);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(64, 38);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(244, 364);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(68, 38);
            this.btnActualizar.TabIndex = 4;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(340, 364);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(64, 38);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(436, 364);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(71, 36);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // dgvTiendas
            // 
            this.dgvTiendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTiendas.Location = new System.Drawing.Point(436, 89);
            this.dgvTiendas.Name = "dgvTiendas";
            this.dgvTiendas.Size = new System.Drawing.Size(294, 256);
            this.dgvTiendas.TabIndex = 7;
            // 
            // FrmGestionTiendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 450);
            this.Controls.Add(this.dgvTiendas);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.gbxDatosTienda);
            this.Controls.Add(this.lblTitulo);
            this.Name = "FrmGestionTiendas";
            this.Text = "Gestión de Tiendas";
            this.Load += new System.EventHandler(this.FrmGestionTiendas_Load);
            this.gbxDatosTienda.ResumeLayout(false);
            this.gbxDatosTienda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTiendas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox gbxDatosTienda;
        private System.Windows.Forms.Label lblStorID;
        private System.Windows.Forms.Label lblStorAddress;
        private System.Windows.Forms.TextBox txtStorName;
        private System.Windows.Forms.Label lblStorName;
        private System.Windows.Forms.TextBox txtStorID;
        private System.Windows.Forms.TextBox txtStorAddress;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.Label lblZip;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dgvTiendas;
    }
}