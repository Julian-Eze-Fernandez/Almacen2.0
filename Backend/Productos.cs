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

        public Productos()
        {
            datatable.Columns.Add("Categoria");
            datatable.Columns.Add("Codigo");
            datatable.Columns.Add("Nombre");
            datatable.Columns.Add("Precio");

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

            GuardarDatos();

        }

        //Metodo que lee los datos del Data Grid View.
        public void Leer_DataTable()
        {
            if (System.IO.File.Exists(@"D:\Vs2022\Almacen2.0\DatosProductos.xml"))
            {
                datatable.ReadXml(@"D:\Vs2022\Almacen2.0\DatosProductos.xml");
            }
        }

        public void GuardarDatos()
        {
            datatable.WriteXml(@"D:\Vs2022\Almacen2.0\DatosProductos.xml");
        }
    }
}
