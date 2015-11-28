using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tico.Animales.DatAnimales
{
    public class DatAnimal : DatAbstracta
    {
        public DatAnimal() { }

        public DataTable Obtener() {
            SqlCommand comm = new SqlCommand("sp_Obtener_Animales", conn);
            comm.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(comm);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable Obtener(int Id) {
            SqlCommand comm = new SqlCommand("sp_Obtener_Animal", conn);
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.Add(new SqlParameter() { SqlDbType = SqlDbType.Int,ParameterName="@Id",Value=Id });
            SqlDataAdapter da = new SqlDataAdapter(comm);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
