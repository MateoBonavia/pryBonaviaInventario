using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;

//para conexion de ACcess
using System.Data.OleDb;

using System.Windows.Forms;

namespace pryBonaviaInventario
{
    internal class clsConexionBD
    {
        //cadena de conexion
        //sql - string cadenaConexion = "Server=localhost;Database=Ventas2;Trusted_Connection=True;";
        // string cadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source = ..\\..\\..\\db\\GestionInventario.accdb";

        string cadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source = ..\\..\\..\\db\\GestionInventario.accdb";
        //conector
        //SqlConnection coneccionBaseDatos;
        OleDbConnection coneccionBaseDatos;
        //comando
        //SqlCommand comandoBaseDatos;
        OleDbCommand comandoBaseDatos;

        OleDbDataReader lectorDataReader;

        public string nombreBaseDeDatos;

        public void ConectarBD()
        {
            try
            {
                //coneccionBaseDatos = new SqlConnection(cadenaConexion);
                coneccionBaseDatos = new OleDbConnection(cadenaConexion);

                nombreBaseDeDatos = coneccionBaseDatos.Database;

                coneccionBaseDatos.Open();

                // MessageBox.Show("Conectado a " + nombreBaseDeDatos);
            }
            catch (Exception error)
            {
                MessageBox.Show("Tiene un errorcito - " + error.Message);
            }

        }

        public void cargarCategorias(ComboBox cmbCategorias)
        {
            // Creo en memoria el objeto
            comandoBaseDatos = new OleDbCommand();
            // Cargo la conexion a la base
            comandoBaseDatos.Connection = coneccionBaseDatos;

            // Dar indicaciones que quiero hacer en la db
            comandoBaseDatos.CommandType = System.Data.CommandType.Text;
            // sentencia SQL para consultar la base
            comandoBaseDatos.CommandText = "SELECT marca_nombre FROM productos";
            lectorDataReader = comandoBaseDatos.ExecuteReader();

            while (lectorDataReader.Read())
            {
                cmbCategorias.Items.Add(lectorDataReader[0]);
            }
        }

        public void agregarProducto(Int32 cod, String nombre, Int32 categoria, String observaciones)
        {
            // Creo en memoria el objeto
            comandoBaseDatos = new OleDbCommand();
            // Cargo la conexion a la base
            comandoBaseDatos.Connection = coneccionBaseDatos;

            // Dar indicaciones que quiero hacer en la db
            comandoBaseDatos.CommandType = System.Data.CommandType.Text;
            // sentencia SQL para consultar la base
            comandoBaseDatos.CommandText = "INSERT INTO productos (codigo, marca_nombre, categoria_de_producto, observaciones) VALUES (?, ?, ?, ?)";

            comandoBaseDatos.Parameters.AddWithValue("?", cod);
            comandoBaseDatos.Parameters.AddWithValue("?", nombre);
            comandoBaseDatos.Parameters.AddWithValue("?", categoria);
            comandoBaseDatos.Parameters.AddWithValue("?", observaciones);

            comandoBaseDatos.ExecuteNonQuery();
        }

        public void buscarId(Int32 id, TextBox codigo, TextBox nombre, TextBox cat, TextBox desc) {
            // Creo en memoria el objeto
            comandoBaseDatos = new OleDbCommand();
            // Cargo la conexion a la base
            comandoBaseDatos.Connection = coneccionBaseDatos;

            // Dar indicaciones que quiero hacer en la db
            comandoBaseDatos.CommandType = System.Data.CommandType.Text;
            // sentencia SQL para consultar la base
            comandoBaseDatos.CommandText = $"SELECT * FROM productos WHERE id={id}";

            lectorDataReader = comandoBaseDatos.ExecuteReader();

            // MessageBox.Show(lectorDataReader);

            //while (lectorDataReader.Read())
            //{
            //    cmbCategorias.Items.Add(lectorDataReader[0]);
            //}
        }

    }
}
