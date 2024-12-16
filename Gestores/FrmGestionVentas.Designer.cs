namespace GestorDeDatos.Gestores
{
    partial class FrmGestionVentas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTituloVentas = new System.Windows.Forms.Label();
            this.gbxDatosVenta = new System.Windows.Forms.GroupBox();
            this.dtpOrdDate = new System.Windows.Forms.DateTimePicker();
            this.lblStorID = new System.Windows.Forms.Label();
            this.lblOrdNum = new System.Windows.Forms.Label();
            this.lblOrdDate = new System.Windows.Forms.Label();
            this.lblQty = new System.Windows.Forms.Label();
            this.lblPayterms = new System.Windows.Forms.Label();
            this.lblTitleID = new System.Windows.Forms.Label();
            this.txtStorID = new System.Windows.Forms.TextBox();
            this.txtOrdNum = new System.Windows.Forms.TextBox();
            this.txtPayTerms = new System.Windows.Forms.TextBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.txtTitleID = new System.Windows.Forms.TextBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            this.colStorID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOrdNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOrdDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPayterms = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTitleID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbxResultado = new System.Windows.Forms.GroupBox();
            this.gbxDatosVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            this.gbxResultado.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTituloVentas
            // 
            this.lblTituloVentas.AutoSize = true;
            this.lblTituloVentas.Location = new System.Drawing.Point(212, 33);
            this.lblTituloVentas.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblTituloVentas.Name = "lblTituloVentas";
            this.lblTituloVentas.Size = new System.Drawing.Size(234, 29);
            this.lblTituloVentas.TabIndex = 0;
            this.lblTituloVentas.Text = "Gestión de Ventas";
            // 
            // gbxDatosVenta
            // 
            this.gbxDatosVenta.Controls.Add(this.txtTitleID);
            this.gbxDatosVenta.Controls.Add(this.txtQty);
            this.gbxDatosVenta.Controls.Add(this.txtPayTerms);
            this.gbxDatosVenta.Controls.Add(this.txtOrdNum);
            this.gbxDatosVenta.Controls.Add(this.txtStorID);
            this.gbxDatosVenta.Controls.Add(this.lblTitleID);
            this.gbxDatosVenta.Controls.Add(this.lblPayterms);
            this.gbxDatosVenta.Controls.Add(this.lblQty);
            this.gbxDatosVenta.Controls.Add(this.lblOrdDate);
            this.gbxDatosVenta.Controls.Add(this.lblOrdNum);
            this.gbxDatosVenta.Controls.Add(this.lblStorID);
            this.gbxDatosVenta.Controls.Add(this.dtpOrdDate);
            this.gbxDatosVenta.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxDatosVenta.Location = new System.Drawing.Point(72, 94);
            this.gbxDatosVenta.Name = "gbxDatosVenta";
            this.gbxDatosVenta.Size = new System.Drawing.Size(374, 290);
            this.gbxDatosVenta.TabIndex = 1;
            this.gbxDatosVenta.TabStop = false;
            this.gbxDatosVenta.Text = "Datos de la Venta";
            // 
            // dtpOrdDate
            // 
            this.dtpOrdDate.CalendarFont = new System.Drawing.Font("Perpetua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpOrdDate.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dtpOrdDate.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpOrdDate.Location = new System.Drawing.Point(156, 115);
            this.dtpOrdDate.Name = "dtpOrdDate";
            this.dtpOrdDate.Size = new System.Drawing.Size(206, 26);
            this.dtpOrdDate.TabIndex = 0;
            // 
            // lblStorID
            // 
            this.lblStorID.AutoSize = true;
            this.lblStorID.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStorID.Location = new System.Drawing.Point(42, 36);
            this.lblStorID.Name = "lblStorID";
            this.lblStorID.Size = new System.Drawing.Size(101, 22);
            this.lblStorID.TabIndex = 1;
            this.lblStorID.Text = "ID de Tienda:";
            // 
            // lblOrdNum
            // 
            this.lblOrdNum.AutoSize = true;
            this.lblOrdNum.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrdNum.Location = new System.Drawing.Point(0, 74);
            this.lblOrdNum.Name = "lblOrdNum";
            this.lblOrdNum.Size = new System.Drawing.Size(139, 22);
            this.lblOrdNum.TabIndex = 2;
            this.lblOrdNum.Text = "Número de Orden:";
            // 
            // lblOrdDate
            // 
            this.lblOrdDate.AutoSize = true;
            this.lblOrdDate.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrdDate.Location = new System.Drawing.Point(21, 115);
            this.lblOrdDate.Name = "lblOrdDate";
            this.lblOrdDate.Size = new System.Drawing.Size(122, 22);
            this.lblOrdDate.TabIndex = 3;
            this.lblOrdDate.Text = "Fecha de Orden:";
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQty.Location = new System.Drawing.Point(62, 156);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(77, 22);
            this.lblQty.TabIndex = 4;
            this.lblQty.Text = "Cantidad:";
            // 
            // lblPayterms
            // 
            this.lblPayterms.AutoSize = true;
            this.lblPayterms.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayterms.Location = new System.Drawing.Point(4, 194);
            this.lblPayterms.Name = "lblPayterms";
            this.lblPayterms.Size = new System.Drawing.Size(135, 22);
            this.lblPayterms.TabIndex = 5;
            this.lblPayterms.Text = "Términos de Pago:";
            // 
            // lblTitleID
            // 
            this.lblTitleID.AutoSize = true;
            this.lblTitleID.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleID.Location = new System.Drawing.Point(41, 242);
            this.lblTitleID.Name = "lblTitleID";
            this.lblTitleID.Size = new System.Drawing.Size(98, 22);
            this.lblTitleID.TabIndex = 2;
            this.lblTitleID.Text = "ID del Título:";
            // 
            // txtStorID
            // 
            this.txtStorID.Location = new System.Drawing.Point(156, 32);
            this.txtStorID.Name = "txtStorID";
            this.txtStorID.Size = new System.Drawing.Size(206, 25);
            this.txtStorID.TabIndex = 6;
            // 
            // txtOrdNum
            // 
            this.txtOrdNum.Location = new System.Drawing.Point(156, 74);
            this.txtOrdNum.Name = "txtOrdNum";
            this.txtOrdNum.Size = new System.Drawing.Size(206, 25);
            this.txtOrdNum.TabIndex = 7;
            // 
            // txtPayTerms
            // 
            this.txtPayTerms.Location = new System.Drawing.Point(155, 194);
            this.txtPayTerms.Name = "txtPayTerms";
            this.txtPayTerms.Size = new System.Drawing.Size(207, 25);
            this.txtPayTerms.TabIndex = 8;
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(155, 156);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(207, 25);
            this.txtQty.TabIndex = 9;
            // 
            // txtTitleID
            // 
            this.txtTitleID.Location = new System.Drawing.Point(155, 242);
            this.txtTitleID.Name = "txtTitleID";
            this.txtTitleID.Size = new System.Drawing.Size(207, 25);
            this.txtTitleID.TabIndex = 10;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(75, 401);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(93, 40);
            this.btnNuevo.TabIndex = 2;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(185, 400);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(85, 40);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(298, 402);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(108, 37);
            this.btnActualizar.TabIndex = 4;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(449, 403);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(98, 37);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(584, 402);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(96, 38);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // dgvVentas
            // 
            this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colStorID,
            this.colOrdNum,
            this.colOrdDate,
            this.colQty,
            this.colPayterms,
            this.colTitleID});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVentas.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVentas.Location = new System.Drawing.Point(6, 24);
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.Size = new System.Drawing.Size(389, 227);
            this.dgvVentas.TabIndex = 7;
            // 
            // colStorID
            // 
            this.colStorID.HeaderText = "ID de Tienda";
            this.colStorID.Name = "colStorID";
            // 
            // colOrdNum
            // 
            this.colOrdNum.HeaderText = "Número de Orden";
            this.colOrdNum.Name = "colOrdNum";
            // 
            // colOrdDate
            // 
            this.colOrdDate.HeaderText = "Fecha de Orden";
            this.colOrdDate.Name = "colOrdDate";
            // 
            // colQty
            // 
            this.colQty.HeaderText = "Cantidad";
            this.colQty.Name = "colQty";
            // 
            // colPayterms
            // 
            this.colPayterms.HeaderText = "Términos de Pago";
            this.colPayterms.Name = "colPayterms";
            // 
            // colTitleID
            // 
            this.colTitleID.HeaderText = "ID del Título";
            this.colTitleID.Name = "colTitleID";
            // 
            // gbxResultado
            // 
            this.gbxResultado.Controls.Add(this.dgvVentas);
            this.gbxResultado.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxResultado.Location = new System.Drawing.Point(475, 107);
            this.gbxResultado.Name = "gbxResultado";
            this.gbxResultado.Size = new System.Drawing.Size(416, 264);
            this.gbxResultado.TabIndex = 8;
            this.gbxResultado.TabStop = false;
            this.gbxResultado.Text = "Resultado";
            // 
            // FrmGestionVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 486);
            this.Controls.Add(this.gbxResultado);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.gbxDatosVenta);
            this.Controls.Add(this.lblTituloVentas);
            this.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "FrmGestionVentas";
            this.Text = "Gestión de Ventas";
            this.gbxDatosVenta.ResumeLayout(false);
            this.gbxDatosVenta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            this.gbxResultado.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloVentas;
        private System.Windows.Forms.GroupBox gbxDatosVenta;
        private System.Windows.Forms.TextBox txtTitleID;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.TextBox txtPayTerms;
        private System.Windows.Forms.TextBox txtOrdNum;
        private System.Windows.Forms.TextBox txtStorID;
        private System.Windows.Forms.Label lblTitleID;
        private System.Windows.Forms.Label lblPayterms;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.Label lblOrdDate;
        private System.Windows.Forms.Label lblOrdNum;
        private System.Windows.Forms.Label lblStorID;
        private System.Windows.Forms.DateTimePicker dtpOrdDate;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dgvVentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStorID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrdNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrdDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPayterms;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTitleID;
        private System.Windows.Forms.GroupBox gbxResultado;
    }
}