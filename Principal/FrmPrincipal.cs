using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestorDeDatos.Gestores;

namespace GestorDeDatos
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnGestionTiendas_Click(object sender, EventArgs e)
        {
            FrmGestionTiendas frmTiendas = new FrmGestionTiendas(); // Crea una instancia del formulario
            frmTiendas.ShowDialog(); // Muestra el formulario como ventana modal
        }

        private void btnGestionVentas_Click(object sender, EventArgs e)
        {
            FrmGestionVentas frmVentas = new FrmGestionVentas(); // Crea una instancia del formulario de ventas
            frmVentas.ShowDialog(); // Muestra el formulario de forma modal

        }

        private void btnGestionPublicadores_Click(object sender, EventArgs e)
        {
            FrmGestionPublicadores frmPublicadores = new FrmGestionPublicadores();
            frmPublicadores.ShowDialog();

        }

        private void btnGestionAutores_Click(object sender, EventArgs e)
        {
            FrmGestionAutores frmAutores = new FrmGestionAutores();
            frmAutores.ShowDialog();

        }

        private void btnAsignacionAutoresTitulos_Click(object sender, EventArgs e)
        {
            FrmAsignacionAutoresTitulos frmAsignacion = new FrmAsignacionAutoresTitulos();
            frmAsignacion.ShowDialog();

        }

        private void btnGestionTrabajos_Click(object sender, EventArgs e)
        {
            FrmGestionTrabajos frmTrabajos = new FrmGestionTrabajos();
            frmTrabajos.ShowDialog();

        }

        private void btnProgramacionRegalias_Click(object sender, EventArgs e)
        {
            FrmProgramacionRegalias frmRegalias = new FrmProgramacionRegalias();
            frmRegalias.ShowDialog();

        }

        private void btnGestionInfoEditorial_Click(object sender, EventArgs e)
        {
            FrmGestionInfoEditorial frmInfoEditorial = new FrmGestionInfoEditorial();
            frmInfoEditorial.ShowDialog();

        }

        private void btnGestionTitulos_Click(object sender, EventArgs e)
        {
            dgvTitulos frmTitulos = new dgvTitulos();
            frmTitulos.ShowDialog();

        }

        private void btnGestionEmpleados_Click(object sender, EventArgs e)
        {
            FrmGestionEmpleados frmEmpleados = new FrmGestionEmpleados();
            frmEmpleados.ShowDialog();

        }

        private void btnGestionDescuentos_Click(object sender, EventArgs e)
        {
            FrmGestionDescuentos frmDescuentos = new FrmGestionDescuentos();
            frmDescuentos.ShowDialog();

        }
    }
}
