using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryBonaviaInventario
{
    public partial class frmVentas : Form
    {
        public frmVentas()
        {
            InitializeComponent();
        }

        private void frmVentas_Load(object sender, EventArgs e)
        {
            clsConexionBDSQL clsConexionBD = new clsConexionBDSQL();

            clsConexionBD.ConectarBD();

            //clsConexionBD.cargarMarcas(cmbCategoriasAgregar);
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgregarArticulos frmAgregarArticulos = new frmAgregarArticulos();
            frmAgregarArticulos.ShowDialog();
        }

        private void verToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVerArticulos frmVerArticulos = new frmVerArticulos();
            frmVerArticulos.ShowDialog();
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmModificarArticulo frmModificarArticulo = new frmModificarArticulo();
            frmModificarArticulo.ShowDialog();
        }
    }
}
