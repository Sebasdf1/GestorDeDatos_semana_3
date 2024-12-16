namespace GestorDeDatos
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTituloPrincipal = new System.Windows.Forms.Label();
            this.btnAsignacionAutoresTitulos = new System.Windows.Forms.Button();
            this.btnGestionDescuentos = new System.Windows.Forms.Button();
            this.btnProgramacionRegalias = new System.Windows.Forms.Button();
            this.btnGestionAutores = new System.Windows.Forms.Button();
            this.btnGestionTrabajos = new System.Windows.Forms.Button();
            this.btnGestionInfoEditorial = new System.Windows.Forms.Button();
            this.btnGestionTitulos = new System.Windows.Forms.Button();
            this.btnGestionEmpleados = new System.Windows.Forms.Button();
            this.btnGestionPublicadores = new System.Windows.Forms.Button();
            this.btnGestionVentas = new System.Windows.Forms.Button();
            this.btnGestionTiendas = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblTituloPrincipal
            // 
            this.lblTituloPrincipal.AutoSize = true;
            this.lblTituloPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblTituloPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTituloPrincipal.Font = new System.Drawing.Font("Perpetua Titling MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloPrincipal.Location = new System.Drawing.Point(243, 22);
            this.lblTituloPrincipal.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTituloPrincipal.Name = "lblTituloPrincipal";
            this.lblTituloPrincipal.Size = new System.Drawing.Size(489, 34);
            this.lblTituloPrincipal.TabIndex = 0;
            this.lblTituloPrincipal.Text = "El Gestor de Datos Principal";
            this.lblTituloPrincipal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAsignacionAutoresTitulos
            // 
            this.btnAsignacionAutoresTitulos.BackColor = System.Drawing.Color.Silver;
            this.btnAsignacionAutoresTitulos.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignacionAutoresTitulos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAsignacionAutoresTitulos.Image = global::GestorDeDatos.Properties.Resources.asignacion;
            this.btnAsignacionAutoresTitulos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAsignacionAutoresTitulos.Location = new System.Drawing.Point(395, 456);
            this.btnAsignacionAutoresTitulos.Name = "btnAsignacionAutoresTitulos";
            this.btnAsignacionAutoresTitulos.Size = new System.Drawing.Size(223, 87);
            this.btnAsignacionAutoresTitulos.TabIndex = 11;
            this.btnAsignacionAutoresTitulos.Text = "Asignación de Autores a Títulos";
            this.btnAsignacionAutoresTitulos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAsignacionAutoresTitulos.UseVisualStyleBackColor = false;
            this.btnAsignacionAutoresTitulos.Click += new System.EventHandler(this.btnAsignacionAutoresTitulos_Click);
            // 
            // btnGestionDescuentos
            // 
            this.btnGestionDescuentos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnGestionDescuentos.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionDescuentos.ForeColor = System.Drawing.Color.Navy;
            this.btnGestionDescuentos.Image = global::GestorDeDatos.Properties.Resources.gestion_de_desc;
            this.btnGestionDescuentos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionDescuentos.Location = new System.Drawing.Point(284, 93);
            this.btnGestionDescuentos.Name = "btnGestionDescuentos";
            this.btnGestionDescuentos.Size = new System.Drawing.Size(178, 83);
            this.btnGestionDescuentos.TabIndex = 10;
            this.btnGestionDescuentos.Text = "Gestión de Descuentos";
            this.btnGestionDescuentos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGestionDescuentos.UseVisualStyleBackColor = false;
            this.btnGestionDescuentos.Click += new System.EventHandler(this.btnGestionDescuentos_Click);
            // 
            // btnProgramacionRegalias
            // 
            this.btnProgramacionRegalias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnProgramacionRegalias.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnProgramacionRegalias.Image = global::GestorDeDatos.Properties.Resources.regalias;
            this.btnProgramacionRegalias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProgramacionRegalias.Location = new System.Drawing.Point(780, 349);
            this.btnProgramacionRegalias.Name = "btnProgramacionRegalias";
            this.btnProgramacionRegalias.Size = new System.Drawing.Size(204, 88);
            this.btnProgramacionRegalias.TabIndex = 9;
            this.btnProgramacionRegalias.Text = "Programación de Regalías";
            this.btnProgramacionRegalias.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProgramacionRegalias.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProgramacionRegalias.UseVisualStyleBackColor = false;
            this.btnProgramacionRegalias.Click += new System.EventHandler(this.btnProgramacionRegalias_Click);
            // 
            // btnGestionAutores
            // 
            this.btnGestionAutores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnGestionAutores.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionAutores.Image = global::GestorDeDatos.Properties.Resources.gestor_de_autores;
            this.btnGestionAutores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionAutores.Location = new System.Drawing.Point(169, 456);
            this.btnGestionAutores.Name = "btnGestionAutores";
            this.btnGestionAutores.Size = new System.Drawing.Size(178, 87);
            this.btnGestionAutores.TabIndex = 8;
            this.btnGestionAutores.Text = "Gestión de Autores";
            this.btnGestionAutores.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGestionAutores.UseVisualStyleBackColor = false;
            this.btnGestionAutores.Click += new System.EventHandler(this.btnGestionAutores_Click);
            // 
            // btnGestionTrabajos
            // 
            this.btnGestionTrabajos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnGestionTrabajos.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionTrabajos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnGestionTrabajos.Image = global::GestorDeDatos.Properties.Resources.gestion_de_trabajo;
            this.btnGestionTrabajos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionTrabajos.Location = new System.Drawing.Point(655, 456);
            this.btnGestionTrabajos.Name = "btnGestionTrabajos";
            this.btnGestionTrabajos.Size = new System.Drawing.Size(182, 87);
            this.btnGestionTrabajos.TabIndex = 7;
            this.btnGestionTrabajos.Text = "Gestión de Trabajos";
            this.btnGestionTrabajos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGestionTrabajos.UseVisualStyleBackColor = false;
            this.btnGestionTrabajos.Click += new System.EventHandler(this.btnGestionTrabajos_Click);
            // 
            // btnGestionInfoEditorial
            // 
            this.btnGestionInfoEditorial.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnGestionInfoEditorial.ForeColor = System.Drawing.Color.Yellow;
            this.btnGestionInfoEditorial.Image = global::GestorDeDatos.Properties.Resources.gestor_de_editorial;
            this.btnGestionInfoEditorial.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionInfoEditorial.Location = new System.Drawing.Point(780, 224);
            this.btnGestionInfoEditorial.Name = "btnGestionInfoEditorial";
            this.btnGestionInfoEditorial.Size = new System.Drawing.Size(195, 86);
            this.btnGestionInfoEditorial.TabIndex = 6;
            this.btnGestionInfoEditorial.Text = "Gestión de Información Editorial";
            this.btnGestionInfoEditorial.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGestionInfoEditorial.UseVisualStyleBackColor = false;
            this.btnGestionInfoEditorial.Click += new System.EventHandler(this.btnGestionInfoEditorial_Click);
            // 
            // btnGestionTitulos
            // 
            this.btnGestionTitulos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnGestionTitulos.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionTitulos.ForeColor = System.Drawing.Color.DarkRed;
            this.btnGestionTitulos.Image = global::GestorDeDatos.Properties.Resources.gestor_titulos;
            this.btnGestionTitulos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionTitulos.Location = new System.Drawing.Point(780, 96);
            this.btnGestionTitulos.Name = "btnGestionTitulos";
            this.btnGestionTitulos.Size = new System.Drawing.Size(177, 83);
            this.btnGestionTitulos.TabIndex = 5;
            this.btnGestionTitulos.Text = "Gestión de Títulos";
            this.btnGestionTitulos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGestionTitulos.UseVisualStyleBackColor = false;
            this.btnGestionTitulos.Click += new System.EventHandler(this.btnGestionTitulos_Click);
            // 
            // btnGestionEmpleados
            // 
            this.btnGestionEmpleados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnGestionEmpleados.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionEmpleados.ForeColor = System.Drawing.Color.Teal;
            this.btnGestionEmpleados.Image = global::GestorDeDatos.Properties.Resources.gestion_de_emple;
            this.btnGestionEmpleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionEmpleados.Location = new System.Drawing.Point(523, 93);
            this.btnGestionEmpleados.Name = "btnGestionEmpleados";
            this.btnGestionEmpleados.Size = new System.Drawing.Size(187, 86);
            this.btnGestionEmpleados.TabIndex = 4;
            this.btnGestionEmpleados.Text = "Gestión de Empleados";
            this.btnGestionEmpleados.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGestionEmpleados.UseVisualStyleBackColor = false;
            this.btnGestionEmpleados.Click += new System.EventHandler(this.btnGestionEmpleados_Click);
            // 
            // btnGestionPublicadores
            // 
            this.btnGestionPublicadores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnGestionPublicadores.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionPublicadores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnGestionPublicadores.Image = global::GestorDeDatos.Properties.Resources.gestion_de_publi;
            this.btnGestionPublicadores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionPublicadores.Location = new System.Drawing.Point(30, 349);
            this.btnGestionPublicadores.Name = "btnGestionPublicadores";
            this.btnGestionPublicadores.Size = new System.Drawing.Size(189, 85);
            this.btnGestionPublicadores.TabIndex = 3;
            this.btnGestionPublicadores.Text = "Gestión de Publicadores";
            this.btnGestionPublicadores.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGestionPublicadores.UseVisualStyleBackColor = false;
            this.btnGestionPublicadores.Click += new System.EventHandler(this.btnGestionPublicadores_Click);
            // 
            // btnGestionVentas
            // 
            this.btnGestionVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnGestionVentas.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionVentas.ForeColor = System.Drawing.Color.Green;
            this.btnGestionVentas.Image = global::GestorDeDatos.Properties.Resources.gestion_de_ventas;
            this.btnGestionVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionVentas.Location = new System.Drawing.Point(48, 223);
            this.btnGestionVentas.Name = "btnGestionVentas";
            this.btnGestionVentas.Size = new System.Drawing.Size(171, 86);
            this.btnGestionVentas.TabIndex = 2;
            this.btnGestionVentas.Text = "Gestión de Ventas";
            this.btnGestionVentas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGestionVentas.UseVisualStyleBackColor = false;
            this.btnGestionVentas.Click += new System.EventHandler(this.btnGestionVentas_Click);
            // 
            // btnGestionTiendas
            // 
            this.btnGestionTiendas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnGestionTiendas.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionTiendas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnGestionTiendas.Image = global::GestorDeDatos.Properties.Resources.gestion_de_tienda;
            this.btnGestionTiendas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionTiendas.Location = new System.Drawing.Point(48, 93);
            this.btnGestionTiendas.Name = "btnGestionTiendas";
            this.btnGestionTiendas.Size = new System.Drawing.Size(171, 83);
            this.btnGestionTiendas.TabIndex = 1;
            this.btnGestionTiendas.Text = "Gestión de Tiendas";
            this.btnGestionTiendas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGestionTiendas.UseVisualStyleBackColor = false;
            this.btnGestionTiendas.Click += new System.EventHandler(this.btnGestionTiendas_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.BackgroundImage = global::GestorDeDatos.Properties.Resources.gestion_fondo_medio;
            this.panel1.Location = new System.Drawing.Point(381, 208);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(237, 229);
            this.panel1.TabIndex = 12;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BackgroundImage = global::GestorDeDatos.Properties.Resources.fondo_3_el;
            this.ClientSize = new System.Drawing.Size(1007, 591);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAsignacionAutoresTitulos);
            this.Controls.Add(this.btnGestionDescuentos);
            this.Controls.Add(this.btnProgramacionRegalias);
            this.Controls.Add(this.btnGestionAutores);
            this.Controls.Add(this.btnGestionTrabajos);
            this.Controls.Add(this.btnGestionInfoEditorial);
            this.Controls.Add(this.btnGestionTitulos);
            this.Controls.Add(this.btnGestionEmpleados);
            this.Controls.Add(this.btnGestionPublicadores);
            this.Controls.Add(this.btnGestionVentas);
            this.Controls.Add(this.btnGestionTiendas);
            this.Controls.Add(this.lblTituloPrincipal);
            this.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "FrmPrincipal";
            this.Text = "Gestor de Datos Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGestionTiendas;
        private System.Windows.Forms.Button btnGestionVentas;
        private System.Windows.Forms.Button btnGestionPublicadores;
        private System.Windows.Forms.Button btnGestionEmpleados;
        private System.Windows.Forms.Button btnGestionTitulos;
        private System.Windows.Forms.Button btnGestionInfoEditorial;
        private System.Windows.Forms.Button btnGestionTrabajos;
        private System.Windows.Forms.Button btnGestionAutores;
        private System.Windows.Forms.Button btnProgramacionRegalias;
        private System.Windows.Forms.Button btnGestionDescuentos;
        private System.Windows.Forms.Button btnAsignacionAutoresTitulos;
        private System.Windows.Forms.Label lblTituloPrincipal;
        private System.Windows.Forms.Panel panel1;
    }
}

