using MySql.Data.MySqlClient;
namespace AppFacturacion
{
    public class Cliente
    {
        public int id { get; set; }
        public string rfc { get; set; }
        public string nombre { get; set; }
        public string apellidoPaterno { get; set; }
        public string apellidoMaterno { get; set; }

        public string nombreCompleto()
        {
            return nombre + " " + apellidoPaterno + " " + apellidoMaterno;
        }


        public void Guardar()
        {
            var con = ConexionDb.ObtenerConexion();
            string sql = "";
            if (this.id > 0)
            {
                //Consulta de manipulacion de datos para un UPDATE
                sql = "update cliente set nombre=@nombre,apellido_paterno=@apellido_paterno,apellido_materno=@apellido_materno,rfc=@rfc where id=@id";
            }
            else
            {
                //Consulta de manipulacion de datos para un INSERT
                sql = "insert into cliente (rfc,nombre,apellido_paterno,apellido_materno) values(@rfc,@nombre,@apellido_paterno,@apellido_materno)";
            }

            using (MySqlCommand cmd = new MySqlCommand(sql, con))

            {
                cmd.Parameters.AddWithValue("@rfc", this.rfc);
                cmd.Parameters.AddWithValue("@nombre", this.nombre);
                cmd.Parameters.AddWithValue("@apellido_paterno", this.apellidoPaterno);
                cmd.Parameters.AddWithValue("@apellido_materno", this.apellidoMaterno);
                if (this.id > 0)
                {
                    cmd.Parameters.AddWithValue("@id", this.id);
                }
                cmd.Prepare();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
