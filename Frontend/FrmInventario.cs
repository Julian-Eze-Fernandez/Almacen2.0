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

        public FrmInventario()
        {
            InitializeComponent();
            dgvInventario.DataSource = productos.datatable;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();

            producto.CategoriaProducto = cmbCategorias.Text;
            producto.CodigoProducto = txtCodigo.Text;
            producto.NombreProducto = txtNombre.Text;
            producto.PrecioProducto = Convert.ToDecimal(txtPrecio.Text);

            productos.CargarProducto(producto);
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {

        }

    }
}
