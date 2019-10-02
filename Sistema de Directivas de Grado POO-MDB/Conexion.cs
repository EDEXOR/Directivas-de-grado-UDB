using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Directivas_de_Grado_POO_MDB
{
    class Conexion
    {
        public static SqlConnection conectar()
        {
            SqlConnection cn = new SqlConnection("Data Source=DIEGO-PC\\SQLEXPRESS;Initial Catalog=db_directiva;User ID=sa;Password=123456");
            cn.Open();
            return cn;
        }
    }
}
