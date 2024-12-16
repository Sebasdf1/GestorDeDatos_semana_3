namespace GestorDeDatos.Gestores
{
    partial class FrmGestionDescuentos
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
            this.lblTituloDescuentos = new System.Windows.Forms.Label();
            this.gbxDatosDescuento = new System.Windows.Forms.GroupBox();
            this.txtDiscountType = new System.Windows.Forms.TextBox();
            this.lblDiscountType = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.txtHighQty = new System.Windows.Forms.TextBox();
            this.lblHighQty = new System.Windows.Forms.Label();
            this.txtLowQty = new System.Windows.Forms.TextBox();
            this.lblLowQty = new System.Windows.Forms.Label();
            this.txtStorID = new System.Windows.Forms.TextBox();
            this.lblStorID = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.dgvDescuentos = new System.Windows.Forms.DataGridView();
            this.gbxDatosDescuento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDescuentos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloDescuentos
            // 
            this.lblTituloDescuentos.AutoSize = true;
            this.lblTituloDescuentos.Font = new System.Drawing.Font("Perpetua Titling MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloDescuentos.Location = new System.Drawing.Point(210, 9);
            this.lblTituloDescuentos.Name = "lblTituloDescuentos";
            this.lblTituloDescuentos.Size = new System.Drawing.Size(385, 32);
            this.lblTituloDescuentos.TabIndex = 1;
            this.lblTituloDescuentos.Text = "Gestión de Descuentos";
            // 
            // gbxDatosDescuento
            // 
            this.gbxDatosDescuento.Controls.Add(this.txtDiscountType);
            this.gbxDatosDescuento.Controls.Add(this.lblDiscountType);
            this.gbxDatosDescuento.Controls.Add(this.txtDiscount);
            this.gbxDatosDescuento.Controls.Add(this.lblDiscount);
            this.gbxDatosDescuento.Controls.Add(this.txtHighQty);
            this.gbxDatosDescuento.Controls.Add(this.lblHighQty);
            this.gbxDatosDescuento.Controls.Add(this.txtLowQty);
            this.gbxDatosDescuento.Controls.Add(this.lblLowQty);
            this.gbxDatosDescuento.Controls.Add(this.txtStorID);
            this.gbxDatosDescuento.Controls.Add(this.lblStorID);
            this.gbxDatosDescuento.Location = new System.Drawing.Point(47, 89);
            this.gbxDatosDescuento.Name = "gbxDatosDescuento";
            this.gbxDatosDescuento.Size = new System.Drawing.Size(349, 220);
            this.gbxDatosDescuento.TabIndex = 2;
            this.gbxDatosDescuento.TabStop = false;
            this.gbxDatosDescuento.Text = "Datos del Descuento";
            // 
            // txtDiscountType
            // 
            this.txtDiscountType.Location = new System.Drawing.Point(130, 167);
            this.txtDiscountType.Name = "txtDiscountType";
            this.txtDiscountType.Size = new System.Drawing.Size(195, 20);
            this.txtDiscountType.TabIndex = 9;
            // 
            // lblDiscountType
            // 
            this.lblDiscountType.AutoSize = true;
            this.lblDiscountType.Location = new System.Drawing.Point(23, 174);
            this.lblDiscountType.Name = "lblDiscountType";
            this.lblDiscountType.Size = new System.Drawing.Size(101, 13);
            this.lblDiscountType.TabIndex = 8;
            this.lblDiscountType.Text = "Tipo de Descuento:";
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(130, 135);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(195, 20);
            this.txtDiscount.TabIndex = 7;
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Location = new System.Drawing.Point(62, 138);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(62, 13);
            this.lblDiscount.TabIndex = 6;
            this.lblDiscount.Text = "Descuento:";
            // 
            // txtHighQty
            // 
            this.txtHighQty.Location = new System.Drawing.Point(130, 100);
            this.txtHighQty.Name = "txtHighQty";
            this.txtHighQty.Size = new System.Drawing.Size(195, 20);
            this.txtHighQty.TabIndex = 5;
            // 
            // lblHighQty
            // 
            this.lblHighQty.AutoSize = true;
            this.lblHighQty.Location = new System.Drawing.Point(8, 103);
            this.lblHighQty.Name = "lblHighQty";
            this.lblHighQty.Size = new System.Drawing.Size(116, 13);
            this.lblHighQty.TabIndex = 4;
            this.lblHighQty.Text = "Cantidad Alta (highqty):";
            // 
            // txtLowQty
            // 
            this.txtLowQty.Location = new System.Drawing.Point(130, 65);
            this.txtLowQty.Name = "txtLowQty";
            this.txtLowQty.Size = new System.Drawing.Size(195, 20);
            this.txtLowQty.TabIndex = 3;
            // 
            // lblLowQty
            // 
            this.lblLowQty.AutoSize = true;
            this.lblLowQty.Location = new System.Drawing.Point(15, 68);
            this.lblLowQty.Name = "lblLowQty";
            this.lblLowQty.Size = new System.Drawing.Size(115, 13);
            this.lblLowQty.TabIndex = 2;
            this.lblLowQty.Text = "Cantidad Baja (lowqty):";
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
            this.lblStorID.Location = new System.Drawing.Point(41, 32);
            this.lblStorID.Name = "lblStorID";
            this.lblStorID.Size = new System.Drawing.Size(83, 13);
            this.lblStorID.TabIndex = 0;
            this.lblStorID.Text = "ID de la Tienda:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(520, 350);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(71, 36);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(424, 350);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(64, 38);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(328, 350);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(68, 38);
            this.btnActualizar.TabIndex = 9;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(241, 350);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(64, 38);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(157, 348);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(68, 38);
            this.btnNuevo.TabIndex = 7;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // dgvDescuentos
            // 
            this.dgvDescuentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDescuentos.Location = new System.Drawing.Point(429, 93);
            this.dgvDescuentos.Name = "dgvDescuentos";
            this.dgvDescuentos.Size = new System.Drawing.Size(337, 215);
            this.dgvDescuentos.TabIndex = 12;
            // 
            // FrmGestionDescuentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvDescuentos);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.gbxDatosDescuento);
            this.Controls.Add(this.lblTituloDescuentos);
            this.Name = "FrmGestionDescuentos";
            this.Text = "Gestión de Descuentos";
            this.gbxDatosDescuento.ResumeLayout(false);
            this.gbxDatosDescuento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDescuentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloDescuentos;
        private System.Windows.Forms.GroupBox gbxDatosDescuento;
        private System.Windows.Forms.TextBox txtDiscountType;
        private System.Windows.Forms.Label lblDiscountType;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.TextBox txtHighQty;
        private System.Windows.Forms.Label lblHighQty;
        private System.Windows.Forms.TextBox txtLowQty;
        private System.Windows.Forms.Label lblLowQty;
        private System.Windows.Forms.TextBox txtStorID;
        private System.Windows.Forms.Label lblStorID;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.DataGridView dgvDescuentos;
    }
}