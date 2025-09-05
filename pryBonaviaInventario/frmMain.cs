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
            clsConexionBD clsConexionBD = new clsConexionBD();

            clsConexionBD.ConectarBD();

            clsConexionBD.cargarCategorias(cmbCategoriasAgregar);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            
            
            Int32 codigo = Convert.ToInt32(txtAgregarCodigo.Text);
            Int32 categoria = cmbCategoriasAgregar.SelectedIndex;
            String nombre = txtAgregarNombre.Text;
            String observaciones = txtAgregarDescripcion.Text;

            clsConexionBD clsConexionBD = new clsConexionBD();


            clsConexionBD.ConectarBD();

            clsConexionBD.agregarProducto(codigo, categoria, nombre, observaciones);

        }
    }
}
