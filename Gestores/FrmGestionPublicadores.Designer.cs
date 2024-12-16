namespace GestorDeDatos.Gestores
{
    partial class FrmGestionPublicadores
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
            this.lblTituloPublicadores = new System.Windows.Forms.Label();
            this.gbxDatosPublicador = new System.Windows.Forms.GroupBox();
            this.lblPubID = new System.Windows.Forms.Label();
            this.lblPubName = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.txtPubID = new System.Windows.Forms.TextBox();
            this.txtPubName = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gbxresultado = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gbxDatosPublicador.SuspendLayout();
            this.gbxresultado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloPublicadores
            // 
            this.lblTituloPublicadores.AutoSize = true;
            this.lblTituloPublicadores.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloPublicadores.Location = new System.Drawing.Point(302, 9);
            this.lblTituloPublicadores.Name = "lblTituloPublicadores";
            this.lblTituloPublicadores.Size = new System.Drawing.Size(298, 36);
            this.lblTituloPublicadores.TabIndex = 0;
            this.lblTituloPublicadores.Text = "Gestión de Publicadores";
            // 
            // gbxDatosPublicador
            // 
            this.gbxDatosPublicador.Controls.Add(this.txtCountry);
            this.gbxDatosPublicador.Controls.Add(this.txtState);
            this.gbxDatosPublicador.Controls.Add(this.txtCity);
            this.gbxDatosPublicador.Controls.Add(this.txtPubName);
            this.gbxDatosPublicador.Controls.Add(this.txtPubID);
            this.gbxDatosPublicador.Controls.Add(this.lblCountry);
            this.gbxDatosPublicador.Controls.Add(this.lblState);
            this.gbxDatosPublicador.Controls.Add(this.lblCity);
            this.gbxDatosPublicador.Controls.Add(this.lblPubName);
            this.gbxDatosPublicador.Controls.Add(this.lblPubID);
            this.gbxDatosPublicador.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxDatosPublicador.Location = new System.Drawing.Point(56, 81);
            this.gbxDatosPublicador.Name = "gbxDatosPublicador";
            this.gbxDatosPublicador.Size = new System.Drawing.Size(447, 300);
            this.gbxDatosPublicador.TabIndex = 1;
            this.gbxDatosPublicador.TabStop = false;
            this.gbxDatosPublicador.Text = "Datos del Publicador";
            // 
            // lblPubID
            // 
            this.lblPubID.AutoSize = true;
            this.lblPubID.Location = new System.Drawing.Point(64, 51);
            this.lblPubID.Name = "lblPubID";
            this.lblPubID.Size = new System.Drawing.Size(129, 22);
            this.lblPubID.TabIndex = 0;
            this.lblPubID.Text = "ID de Publicador:";
            // 
            // lblPubName
            // 
            this.lblPubName.AutoSize = true;
            this.lblPubName.Location = new System.Drawing.Point(20, 102);
            this.lblPubName.Name = "lblPubName";
            this.lblPubName.Size = new System.Drawing.Size(173, 22);
            this.lblPubName.TabIndex = 1;
            this.lblPubName.Text = "Nombre del Publicador:";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(129, 151);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(64, 22);
            this.lblCity.TabIndex = 2;
            this.lblCity.Text = "Ciudad:";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(129, 202);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(60, 22);
            this.lblState.TabIndex = 3;
            this.lblState.Text = "Estado:";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(148, 254);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(41, 22);
            this.lblCountry.TabIndex = 4;
            this.lblCountry.Text = "País:";
            // 
            // txtPubID
            // 
            this.txtPubID.Location = new System.Drawing.Point(209, 48);
            this.txtPubID.Name = "txtPubID";
            this.txtPubID.Size = new System.Drawing.Size(183, 29);
            this.txtPubID.TabIndex = 5;
            // 
            // txtPubName
            // 
            this.txtPubName.Location = new System.Drawing.Point(209, 99);
            this.txtPubName.Name = "txtPubName";
            this.txtPubName.Size = new System.Drawing.Size(183, 29);
            this.txtPubName.TabIndex = 6;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(209, 148);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(183, 29);
            this.txtCity.TabIndex = 7;
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(209, 199);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(187, 29);
            this.txtState.TabIndex = 8;
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(209, 251);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(189, 29);
            this.txtCountry.TabIndex = 9;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(80, 405);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(80, 37);
            this.btnNuevo.TabIndex = 2;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(189, 405);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(78, 35);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(283, 406);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(92, 35);
            this.btnActualizar.TabIndex = 4;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(413, 406);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(74, 35);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(522, 405);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(78, 34);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // gbxresultado
            // 
            this.gbxresultado.Controls.Add(this.dataGridView1);
            this.gbxresultado.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxresultado.Location = new System.Drawing.Point(538, 81);
            this.gbxresultado.Name = "gbxresultado";
            this.gbxresultado.Size = new System.Drawing.Size(237, 299);
            this.gbxresultado.TabIndex = 7;
            this.gbxresultado.TabStop = false;
            this.gbxresultado.Text = "Resultado";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(207, 260);
            this.dataGridView1.TabIndex = 0;
            // 
            // FrmGestionPublicadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 471);
            this.Controls.Add(this.gbxresultado);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.gbxDatosPublicador);
            this.Controls.Add(this.lblTituloPublicadores);
            this.Name = "FrmGestionPublicadores";
            this.Text = "Gestión de Publicadores";
            this.gbxDatosPublicador.ResumeLayout(false);
            this.gbxDatosPublicador.PerformLayout();
            this.gbxresultado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloPublicadores;
        private System.Windows.Forms.GroupBox gbxDatosPublicador;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblPubName;
        private System.Windows.Forms.Label lblPubID;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtPubName;
        private System.Windows.Forms.TextBox txtPubID;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox gbxresultado;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}