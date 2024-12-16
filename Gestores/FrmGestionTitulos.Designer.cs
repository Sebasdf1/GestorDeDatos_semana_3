namespace GestorDeDatos.Gestores
{
    partial class dgvTitulos
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
            this.lblTituloTitulos = new System.Windows.Forms.Label();
            this.gbxDatosTitulo = new System.Windows.Forms.GroupBox();
            this.txtAdvance = new System.Windows.Forms.TextBox();
            this.lblAdvance = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPubID = new System.Windows.Forms.TextBox();
            this.lblPubID = new System.Windows.Forms.Label();
            this.txtType = new System.Windows.Forms.TextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtTitleID = new System.Windows.Forms.TextBox();
            this.lblTitleID = new System.Windows.Forms.Label();
            this.lblRoyalty = new System.Windows.Forms.Label();
            this.lblYtdSales = new System.Windows.Forms.Label();
            this.lblNotes = new System.Windows.Forms.Label();
            this.lblPubdate = new System.Windows.Forms.Label();
            this.txtRoyalty = new System.Windows.Forms.TextBox();
            this.txtYtdSales = new System.Windows.Forms.TextBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.dtpPubdate = new System.Windows.Forms.TextBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gbxDatosTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloTitulos
            // 
            this.lblTituloTitulos.AutoSize = true;
            this.lblTituloTitulos.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloTitulos.Location = new System.Drawing.Point(256, 9);
            this.lblTituloTitulos.Name = "lblTituloTitulos";
            this.lblTituloTitulos.Size = new System.Drawing.Size(252, 38);
            this.lblTituloTitulos.TabIndex = 3;
            this.lblTituloTitulos.Text = "Gestión de Títulos";
            // 
            // gbxDatosTitulo
            // 
            this.gbxDatosTitulo.Controls.Add(this.dtpPubdate);
            this.gbxDatosTitulo.Controls.Add(this.txtNotes);
            this.gbxDatosTitulo.Controls.Add(this.txtYtdSales);
            this.gbxDatosTitulo.Controls.Add(this.txtRoyalty);
            this.gbxDatosTitulo.Controls.Add(this.lblPubdate);
            this.gbxDatosTitulo.Controls.Add(this.lblNotes);
            this.gbxDatosTitulo.Controls.Add(this.lblYtdSales);
            this.gbxDatosTitulo.Controls.Add(this.lblRoyalty);
            this.gbxDatosTitulo.Controls.Add(this.txtAdvance);
            this.gbxDatosTitulo.Controls.Add(this.lblAdvance);
            this.gbxDatosTitulo.Controls.Add(this.txtPrice);
            this.gbxDatosTitulo.Controls.Add(this.lblPrice);
            this.gbxDatosTitulo.Controls.Add(this.txtPubID);
            this.gbxDatosTitulo.Controls.Add(this.lblPubID);
            this.gbxDatosTitulo.Controls.Add(this.txtType);
            this.gbxDatosTitulo.Controls.Add(this.lblType);
            this.gbxDatosTitulo.Controls.Add(this.txtTitle);
            this.gbxDatosTitulo.Controls.Add(this.lblTitle);
            this.gbxDatosTitulo.Controls.Add(this.txtTitleID);
            this.gbxDatosTitulo.Controls.Add(this.lblTitleID);
            this.gbxDatosTitulo.Location = new System.Drawing.Point(29, 67);
            this.gbxDatosTitulo.Name = "gbxDatosTitulo";
            this.gbxDatosTitulo.Size = new System.Drawing.Size(384, 371);
            this.gbxDatosTitulo.TabIndex = 4;
            this.gbxDatosTitulo.TabStop = false;
            this.gbxDatosTitulo.Text = "Datos del Título";
            // 
            // txtAdvance
            // 
            this.txtAdvance.Location = new System.Drawing.Point(130, 201);
            this.txtAdvance.Name = "txtAdvance";
            this.txtAdvance.Size = new System.Drawing.Size(195, 20);
            this.txtAdvance.TabIndex = 11;
            // 
            // lblAdvance
            // 
            this.lblAdvance.AutoSize = true;
            this.lblAdvance.Location = new System.Drawing.Point(19, 201);
            this.lblAdvance.Name = "lblAdvance";
            this.lblAdvance.Size = new System.Drawing.Size(100, 13);
            this.lblAdvance.TabIndex = 10;
            this.lblAdvance.Text = "Anticipo (Advance):";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(130, 167);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(195, 20);
            this.txtPrice.TabIndex = 9;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(76, 170);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(40, 13);
            this.lblPrice.TabIndex = 8;
            this.lblPrice.Text = "Precio:";
            // 
            // txtPubID
            // 
            this.txtPubID.Location = new System.Drawing.Point(130, 135);
            this.txtPubID.Name = "txtPubID";
            this.txtPubID.Size = new System.Drawing.Size(195, 20);
            this.txtPubID.TabIndex = 7;
            this.txtPubID.TextChanged += new System.EventHandler(this.txtPubID_TextChanged);
            // 
            // lblPubID
            // 
            this.lblPubID.AutoSize = true;
            this.lblPubID.Location = new System.Drawing.Point(30, 138);
            this.lblPubID.Name = "lblPubID";
            this.lblPubID.Size = new System.Drawing.Size(91, 13);
            this.lblPubID.TabIndex = 6;
            this.lblPubID.Text = "ID del Publicador:";
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(130, 100);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(195, 20);
            this.txtType.TabIndex = 5;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(88, 103);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(31, 13);
            this.lblType.TabIndex = 4;
            this.lblType.Text = "Tipo:";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(130, 65);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(195, 20);
            this.txtTitle.TabIndex = 3;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(81, 68);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(38, 13);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Título:";
            // 
            // txtTitleID
            // 
            this.txtTitleID.Location = new System.Drawing.Point(130, 29);
            this.txtTitleID.Name = "txtTitleID";
            this.txtTitleID.Size = new System.Drawing.Size(195, 20);
            this.txtTitleID.TabIndex = 1;
            // 
            // lblTitleID
            // 
            this.lblTitleID.AutoSize = true;
            this.lblTitleID.Location = new System.Drawing.Point(52, 32);
            this.lblTitleID.Name = "lblTitleID";
            this.lblTitleID.Size = new System.Drawing.Size(69, 13);
            this.lblTitleID.TabIndex = 0;
            this.lblTitleID.Text = "ID del Título:";
            // 
            // lblRoyalty
            // 
            this.lblRoyalty.AutoSize = true;
            this.lblRoyalty.Location = new System.Drawing.Point(24, 235);
            this.lblRoyalty.Name = "lblRoyalty";
            this.lblRoyalty.Size = new System.Drawing.Size(92, 13);
            this.lblRoyalty.TabIndex = 12;
            this.lblRoyalty.Text = "Regalía (Royalty):";
            // 
            // lblYtdSales
            // 
            this.lblYtdSales.AutoSize = true;
            this.lblYtdSales.Location = new System.Drawing.Point(-45, 265);
            this.lblYtdSales.Name = "lblYtdSales";
            this.lblYtdSales.Size = new System.Drawing.Size(164, 13);
            this.lblYtdSales.TabIndex = 13;
            this.lblYtdSales.Text = "Ventas Acumuladas (YTD Sales):";
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(81, 297);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(38, 13);
            this.lblNotes.TabIndex = 14;
            this.lblNotes.Text = "Notas:";
            // 
            // lblPubdate
            // 
            this.lblPubdate.AutoSize = true;
            this.lblPubdate.Location = new System.Drawing.Point(3, 331);
            this.lblPubdate.Name = "lblPubdate";
            this.lblPubdate.Size = new System.Drawing.Size(113, 13);
            this.lblPubdate.TabIndex = 15;
            this.lblPubdate.Text = "Fecha de Publicación:";
            // 
            // txtRoyalty
            // 
            this.txtRoyalty.Location = new System.Drawing.Point(130, 232);
            this.txtRoyalty.Name = "txtRoyalty";
            this.txtRoyalty.Size = new System.Drawing.Size(195, 20);
            this.txtRoyalty.TabIndex = 16;
            // 
            // txtYtdSales
            // 
            this.txtYtdSales.Location = new System.Drawing.Point(130, 262);
            this.txtYtdSales.Name = "txtYtdSales";
            this.txtYtdSales.Size = new System.Drawing.Size(195, 20);
            this.txtYtdSales.TabIndex = 17;
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(130, 294);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(195, 20);
            this.txtNotes.TabIndex = 18;
            // 
            // dtpPubdate
            // 
            this.dtpPubdate.Location = new System.Drawing.Point(130, 328);
            this.dtpPubdate.Name = "dtpPubdate";
            this.dtpPubdate.Size = new System.Drawing.Size(195, 20);
            this.dtpPubdate.TabIndex = 12;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(30, 484);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(105, 48);
            this.btnNuevo.TabIndex = 5;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(169, 484);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(105, 48);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(308, 484);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(105, 48);
            this.btnActualizar.TabIndex = 7;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(431, 484);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(105, 48);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(560, 484);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(105, 48);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(456, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(282, 365);
            this.dataGridView1.TabIndex = 10;
            // 
            // dgvTitulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 577);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.gbxDatosTitulo);
            this.Controls.Add(this.lblTituloTitulos);
            this.Name = "dgvTitulos";
            this.Text = "Gestión de Títulos";
            this.gbxDatosTitulo.ResumeLayout(false);
            this.gbxDatosTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloTitulos;
        private System.Windows.Forms.GroupBox gbxDatosTitulo;
        private System.Windows.Forms.TextBox txtAdvance;
        private System.Windows.Forms.Label lblAdvance;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPubID;
        private System.Windows.Forms.Label lblPubID;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtTitleID;
        private System.Windows.Forms.Label lblTitleID;
        private System.Windows.Forms.TextBox dtpPubdate;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.TextBox txtYtdSales;
        private System.Windows.Forms.TextBox txtRoyalty;
        private System.Windows.Forms.Label lblPubdate;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.Label lblYtdSales;
        private System.Windows.Forms.Label lblRoyalty;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}