using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Backend
{
    public class Productos
    {
        public DataTable datatable { get; set; } = new DataTable() { TableName = "TNProductos" };
        public DataTable dtTotales { get; set; } = new DataTable() { TableName = "TNProCargados" };

        public Productos()
        {
            //Creamos las columnas del nuestro DataGridView.
            datatable.Columns.Add("Categoria");
            datatable.Columns.Add("Codigo");
            datatable.Columns.Add("Nombre");
            datatable.Columns.Add("Precio");

            //Creamos las columnas del nuestro DataGridView ProductosCargados.
            dtTotales.Columns.Add("Tipo de producto");
            dtTotales.Columns.Add("Totales");

            Leer_dtTotales();
            Leer_DataTable();

        }

        //Metodo para cargar datos a la tabla.
        public void CargarProducto(Producto producto)
        {
            datatable.Rows.Add();
            int i = datatable.Rows.Count - 1;

            datatable.Rows[i]["Categoria"] = producto.CategoriaProducto;
            datatable.Rows[i]["Codigo"] = producto.CodigoProducto;
            datatable.Rows[i]["Nombre"] = producto.NombreProducto;
            datatable.Rows[i]["Precio"] = producto.PrecioProducto;
        }

        //Metodo que lee los datos del DataGridView.
        public void Leer_DataTable()
        {
            if (System.IO.File.Exists(@"D:\Vs2022\Almacen2.0\DatosProductos.xml"))
            {
                datatable.ReadXml(@"D:\Vs2022\Almacen2.0\DatosProductos.xml");
            }
        }

        //Metodo que lee los datos del DataGridView ProductosCargados.
        public void Leer_dtTotales()
        {
            //Si existen datos los leemos.
            if (System.IO.File.Exists(@"D:\Vs2022\Almacen2.0\TotalProductos.xml"))
            {
                dtTotales.ReadXml(@"D:\Vs2022\Almacen2.0\TotalProductos.xml");
            }
            else
            {
                //Sino lo añadimos.
                dtTotales.Rows.Add("Alimenticios");
                dtTotales.Rows.Add("Bebidas");
                dtTotales.Rows.Add("Limpieza");
            }
        }

        //Metodo que guarda los datos de los DataGridView en un Xml.
        public void GuardarDatos()
        {
            datatable.WriteXml(@"D:\Vs2022\Almacen2.0\DatosProductos.xml");
            dtTotales.WriteXml(@"D:\Vs2022\Almacen2.0\TotalProductos.xml");
        }

        //Metodo que cuenta los productos segun categoria.
        public void contar(ref int contaralimentos, ref int contarbebidas, ref int contarlimpieza, string categoria)
        {
            if (categoria == "Alimentos")
            {
                contaralimentos++;
            }
            else if (categoria == "Bebidas")
            {
                contarbebidas++;
            }
            else if (categoria == "Limpieza")
            {
                contarlimpieza++;
            }
        }

        //Metodo que resta los productos segun categoria.
        public void Descontar(ref int contarAlimentos, ref int contarBebidas, ref int contarLimpieza, string categoria)
        {
            if (categoria == "Alimentos")
            {
                contarAlimentos--;
            }
            else if (categoria == "Bebidas")
            {
                contarBebidas--;
            }
            else if (categoria == "Limpieza")
            {
                contarLimpieza--;
            }
        }
    }
}
