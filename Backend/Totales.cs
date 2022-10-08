using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Backend
{
    public class Totales
    {
        public DataTable dt { get; set; } = new DataTable() { TableName = "TNProCargados" };

        public Totales()
        {
            dt.Columns.Add("Tipo de producto");
            dt.Columns.Add("Totales");
            dt.Rows.Add("Alimenticios");
            dt.Rows.Add("Bebidas");
            dt.Rows.Add("Limpieza");
        }
    }
}
