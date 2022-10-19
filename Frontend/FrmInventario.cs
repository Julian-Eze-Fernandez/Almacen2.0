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
        Producto producto = new Producto();

        int contAlimentos = 0;
        int contBebidas = 0;
        int contLimpieza = 0;

        const string ERROR_PRECIO = "No se pueden cargar los datos porque no ingreso un valor en el precio del producto.";
        const string ERROR_FILA = "Elija que fila quiere borrar.";
        const string ERROR_CODIGO = "ERROR, Codigo Repetido.";
        const string ERROR_DATOS = "Faltan datos de cargar.";

        public FrmInventario()
        {
            InitializeComponent();
            dgvInventario.DataSource = productos.datatable;                      
            dgvProCargados.DataSource = productos.dtTotales;

            if (System.IO.File.Exists(@"D:\Vs2022\Almacen2.0\TotalProductos.xml"))
            {
                contAlimentos = Convert.ToInt32(dgvProCargados.Rows[0].Cells[1].Value);
                contBebidas = Convert.ToInt32(dgvProCargados.Rows[1].Cells[1].Value);
                contLimpieza = Convert.ToInt32(dgvProCargados.Rows[2].Cells[1].Value);
            }
            else 
            {
                contAlimentos = 0;
                contBebidas = 0;
                contLimpieza = 0;
                dgvProCargados.Rows[0].Cells[1].Value = contAlimentos;
                dgvProCargados.Rows[1].Cells[1].Value = contBebidas;
                dgvProCargados.Rows[2].Cells[1].Value = contLimpieza;
            }
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

                productos.contar(ref contAlimentos, ref contBebidas, ref contLimpieza, producto.CategoriaProducto);
                
                dgvProCargados.Rows[0].Cells[1].Value = Convert.ToString(contAlimentos);
                dgvProCargados.Rows[1].Cells[1].Value = Convert.ToString(contBebidas);
                dgvProCargados.Rows[2].Cells[1].Value = Convert.ToString(contLimpieza);
                productos.GuardarDatos();
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            //Validacion por si se quiere borrar algo no seleccionado.
            if (dgvInventario.CurrentRow == null)
            {
                MessageBox.Show(this, ERROR_FILA, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                productos.Descontar(ref contAlimentos, ref contBebidas, ref contLimpieza, dgvInventario.CurrentRow.Cells[0].Value.ToString());

                dgvProCargados.Rows[0].Cells[1].Value = Convert.ToString(contAlimentos);
                dgvProCargados.Rows[1].Cells[1].Value = Convert.ToString(contBebidas);
                dgvProCargados.Rows[2].Cells[1].Value = Convert.ToString(contLimpieza);

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
                    MessageBox.Show(this, ERROR_PRECIO ,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
            }
            //Validacion por si el usuario no lleno algun TextBox.
            if (!txtCodigo.Text.Any() || !txtNombre.Text.Any() || !cmbCategorias.Text.Any() || !txtPrecio.Text.Any())
            {
                bandera = true;
                MessageBox.Show(this, ERROR_DATOS , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //Validacion para que no se repita un codigo.
            for (int i = 0; i < productos.datatable.Rows.Count; i++)
            {
                if (productos.datatable.Rows[i]["Codigo"].ToString() == txtCodigo.Text)
                {
                    bandera = true;
                    MessageBox.Show(this, ERROR_CODIGO , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
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
