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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            clsConexionBDSQL clsConexionBD = new clsConexionBDSQL();

            clsConexionBD.ConectarBD();

            //clsConexionBD.cargarMarcas(cmbCategoriasAgregar);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //clsConexionBD clsConexionBD = new clsConexionBD();

            //clsConexionBD.ConectarBD();

            //Int32 cod = Convert.ToInt32(txtAgregarCodigo.Text);
            //String nombre = txtAgregarNombre.Text;
            //Int32 categoria = cmbCategoriasAgregar.SelectedIndex + 1;
            //String descripcion = txtAgregarDescripcion.Text;

            //clsConexionBD.agregarProducto(cod, nombre, categoria, descripcion);
        }
    }
}
