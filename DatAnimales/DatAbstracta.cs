using Kadmiel.BusKadmiel.UtilityKadmiel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tico.Animales.DatAnimales
{
    public class DatAbstracta
    {
        public SqlConnection conn;
        public DatAbstracta() {
            conn = new SqlConnection(UtiCrypto.DesEncriptar("poubbDovFVgmY7x1hBEfUshzh8KWs1EQCt2epwRk5aQatiYfz/5i4T7sTFTsQOWsBVscFbUrZsF71IWD6pFlKSg8ktNOgKfezFqVM9yI="));

            ///Establecer la conexion desde la web config con el ConfigurationManager y agregamos la referencia desde datAnimales, pestañas ensamblado, elegir system.configuration y depues resolver            //conn = new SqlConnection();
            //conn.ConnectionString = ConfigurationManager.ConnectionStrings["NombreConexion"].ToString();
        }
    }
}
