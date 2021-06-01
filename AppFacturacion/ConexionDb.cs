using MySql.Data.MySqlClient;


namespace AppFacturacion
{
    public class ConexionDb
    {
        public static MySqlConnection ObtenerConexion()
        {
            string cs = @"server=localhost;userid=root;password=123456;database=db_facturacion";

            MySqlConnection con = new MySqlConnection(cs);
            con.Open();
            return con;
        
        }

        
    }
}
