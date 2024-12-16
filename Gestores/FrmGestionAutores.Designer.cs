namespace GestorDeDatos.Gestores
{
    partial class FrmGestionAutores
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
            this.lblTituloAutores = new System.Windows.Forms.Label();
            this.gbxDatosAutor = new System.Windows.Forms.GroupBox();
            this.txtAuLname = new System.Windows.Forms.TextBox();
            this.txtAuID = new System.Windows.Forms.TextBox();
            this.lblAuLname = new System.Windows.Forms.Label();
            this.lblAuID = new System.Windows.Forms.Label();
            this.lblAuFname = new System.Windows.Forms.Label();
            this.txtAuFname = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblState = new System.Windows.Forms.Label();
            this.txtState = new System.Windows.Forms.TextBox();
            this.lblZip = new System.Windows.Forms.Label();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.lblContract = new System.Windows.Forms.Label();
            this.chkContract = new System.Windows.Forms.CheckBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dgvAutores = new System.Windows.Forms.DataGridView();
            this.gbxDatosAutor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutores)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloAutores
            // 
            this.lblTituloAutores.AutoSize = true;
            this.lblTituloAutores.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloAutores.Location = new System.Drawing.Point(289, 9);
            this.lblTituloAutores.Name = "lblTituloAutores";
            this.lblTituloAutores.Size = new System.Drawing.Size(263, 38);
            this.lblTituloAutores.TabIndex = 0;
            this.lblTituloAutores.Text = "Gestión de Autores";
            // 
            // gbxDatosAutor
            // 
            this.gbxDatosAutor.Controls.Add(this.chkContract);
            this.gbxDatosAutor.Controls.Add(this.lblContract);
            this.gbxDatosAutor.Controls.Add(this.txtZip);
            this.gbxDatosAutor.Controls.Add(this.lblZip);
            this.gbxDatosAutor.Controls.Add(this.txtState);
            this.gbxDatosAutor.Controls.Add(this.lblState);
            this.gbxDatosAutor.Controls.Add(this.txtCity);
            this.gbxDatosAutor.Controls.Add(this.lblCity);
            this.gbxDatosAutor.Controls.Add(this.txtAddress);
            this.gbxDatosAutor.Controls.Add(this.lblAddress);
            this.gbxDatosAutor.Controls.Add(this.txtPhone);
            this.gbxDatosAutor.Controls.Add(this.lblPhone);
            this.gbxDatosAutor.Controls.Add(this.txtAuFname);
            this.gbxDatosAutor.Controls.Add(this.lblAuFname);
            this.gbxDatosAutor.Controls.Add(this.txtAuLname);
            this.gbxDatosAutor.Controls.Add(this.txtAuID);
            this.gbxDatosAutor.Controls.Add(this.lblAuLname);
            this.gbxDatosAutor.Controls.Add(this.lblAuID);
            this.gbxDatosAutor.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxDatosAutor.Location = new System.Drawing.Point(19, 66);
            this.gbxDatosAutor.Name = "gbxDatosAutor";
            this.gbxDatosAutor.Size = new System.Drawing.Size(427, 461);
            this.gbxDatosAutor.TabIndex = 1;
            this.gbxDatosAutor.TabStop = false;
            this.gbxDatosAutor.Text = "Datos del Autor";
            // 
            // txtAuLname
            // 
            this.txtAuLname.Location = new System.Drawing.Point(203, 84);
            this.txtAuLname.Name = "txtAuLname";
            this.txtAuLname.Size = new System.Drawing.Size(190, 29);
            this.txtAuLname.TabIndex = 3;
            // 
            // txtAuID
            // 
            this.txtAuID.Location = new System.Drawing.Point(202, 47);
            this.txtAuID.Name = "txtAuID";
            this.txtAuID.Size = new System.Drawing.Size(192, 29);
            this.txtAuID.TabIndex = 2;
            // 
            // lblAuLname
            // 
            this.lblAuLname.AutoSize = true;
            this.lblAuLname.Location = new System.Drawing.Point(51, 86);
            this.lblAuLname.Name = "lblAuLname";
            this.lblAuLname.Size = new System.Drawing.Size(135, 22);
            this.lblAuLname.TabIndex = 1;
            this.lblAuLname.Text = "Apellido del Autor:";
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
            // lblAuFname
            // 
            this.lblAuFname.AutoSize = true;
            this.lblAuFname.Location = new System.Drawing.Point(50, 128);
            this.lblAuFname.Name = "lblAuFname";
            this.lblAuFname.Size = new System.Drawing.Size(136, 22);
            this.lblAuFname.TabIndex = 4;
            this.lblAuFname.Text = "Nombre del Autor:";
            this.lblAuFname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAuFname
            // 
            this.txtAuFname.Location = new System.Drawing.Point(202, 125);
            this.txtAuFname.Name = "txtAuFname";
            this.txtAuFname.Size = new System.Drawing.Size(192, 29);
            this.txtAuFname.TabIndex = 5;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(116, 171);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(70, 22);
            this.lblPhone.TabIndex = 6;
            this.lblPhone.Text = "Teléfono:";
            this.lblPhone.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(203, 168);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(189, 29);
            this.txtPhone.TabIndex = 7;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(108, 215);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(78, 22);
            this.lblAddress.TabIndex = 8;
            this.lblAddress.Text = "Dirección:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(202, 212);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(192, 29);
            this.txtAddress.TabIndex = 9;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(122, 258);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(64, 22);
            this.lblCity.TabIndex = 10;
            this.lblCity.Text = "Ciudad:";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(202, 255);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(192, 29);
            this.txtCity.TabIndex = 11;
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(126, 299);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(60, 22);
            this.lblState.TabIndex = 12;
            this.lblState.Text = "Estado:";
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(202, 296);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(191, 29);
            this.txtState.TabIndex = 13;
            // 
            // lblZip
            // 
            this.lblZip.AutoSize = true;
            this.lblZip.Location = new System.Drawing.Point(78, 345);
            this.lblZip.Name = "lblZip";
            this.lblZip.Size = new System.Drawing.Size(108, 22);
            this.lblZip.TabIndex = 14;
            this.lblZip.Text = "Código Postal:";
            // 
            // txtZip
            // 
            this.txtZip.Location = new System.Drawing.Point(202, 342);
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(190, 29);
            this.txtZip.TabIndex = 15;
            // 
            // lblContract
            // 
            this.lblContract.AutoSize = true;
            this.lblContract.Location = new System.Drawing.Point(108, 394);
            this.lblContract.Name = "lblContract";
            this.lblContract.Size = new System.Drawing.Size(74, 22);
            this.lblContract.TabIndex = 16;
            this.lblContract.Text = "Contrato:";
            // 
            // chkContract
            // 
            this.chkContract.AutoSize = true;
            this.chkContract.Location = new System.Drawing.Point(202, 393);
            this.chkContract.Name = "chkContract";
            this.chkContract.Size = new System.Drawing.Size(125, 26);
            this.chkContract.TabIndex = 17;
            this.chkContract.Text = "Tiene contrato";
            this.chkContract.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(59, 552);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(114, 46);
            this.btnNuevo.TabIndex = 2;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(209, 552);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(114, 46);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(356, 552);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(114, 46);
            this.btnActualizar.TabIndex = 4;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(502, 552);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(114, 46);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(656, 552);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(114, 46);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // dgvAutores
            // 
            this.dgvAutores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAutores.Location = new System.Drawing.Point(472, 77);
            this.dgvAutores.Name = "dgvAutores";
            this.dgvAutores.Size = new System.Drawing.Size(316, 450);
            this.dgvAutores.TabIndex = 7;
            // 
            // FrmGestionAutores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 626);
            this.Controls.Add(this.dgvAutores);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.gbxDatosAutor);
            this.Controls.Add(this.lblTituloAutores);
            this.Name = "FrmGestionAutores";
            this.Text = "Gestión de Autores";
            this.gbxDatosAutor.ResumeLayout(false);
            this.gbxDatosAutor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloAutores;
        private System.Windows.Forms.GroupBox gbxDatosAutor;
        private System.Windows.Forms.TextBox txtAuLname;
        private System.Windows.Forms.TextBox txtAuID;
        private System.Windows.Forms.Label lblAuLname;
        private System.Windows.Forms.Label lblAuID;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtAuFname;
        private System.Windows.Forms.Label lblAuFname;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblZip;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.CheckBox chkContract;
        private System.Windows.Forms.Label lblContract;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dgvAutores;
    }
}