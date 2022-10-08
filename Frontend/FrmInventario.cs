using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Backend;

namespace Frontend
{
    public partial class FrmInventario : Form
    {
        public Productos productos = new Productos();
        public Totales totales = new Totales();
        Producto producto = new Producto();      

        public FrmInventario()
        {
            InitializeComponent();
            dgvInventario.DataSource = productos.datatable;
            dgvProCargados.DataSource = totales.dt;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!Error())
            {
                producto.CategoriaProducto = cmbCategorias.Text;
                producto.CodigoProducto = txtCodigo.Text;
                producto.NombreProducto = txtNombre.Text;
                producto.PrecioProducto = Convert.ToDecimal(txtPrecio.Text);

                productos.CargarProducto(producto);
                LimpiarPantalla();

            }   
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            //Validacion por si se quiere borrar algo no seleccionado.
            if (dgvInventario.CurrentRow == null)
            {
                MessageBox.Show(this, "Elija que fila quiere borrar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                dgvInventario.Rows.Remove(dgvInventario.CurrentRow);

                productos.GuardarDatos();
            }
        }


        //Metodo que busca errores 
        private bool Error()
        {
            bool bandera = false;

            //Validacion por si el usuario ingresa caracteres en precio.
            for (int i = 0; i < txtPrecio.Text.Length; i++)
            {
                char c = txtPrecio.Text[i];
                if (!Char.IsDigit(c))
                {
                    bandera = true;
                    MessageBox.Show(this, "No se pueden cargar los datos porque no ingreso un valor en el precio del producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
            }
            //Validacion por si el usuario no lleno algun TextBox.
            if (!txtCodigo.Text.Any() || !txtNombre.Text.Any() || !cmbCategorias.Text.Any() || !txtPrecio.Text.Any())
            {
                bandera = true;
                MessageBox.Show(this, "Faltan datos de cargar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return bandera;
        }

        //Metodo para limpiar los TextBox y el ComboBox.
        public void LimpiarPantalla()
        {
            cmbCategorias.SelectedIndex = -1;
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtPrecio.Text = "";
        }
    }
}
