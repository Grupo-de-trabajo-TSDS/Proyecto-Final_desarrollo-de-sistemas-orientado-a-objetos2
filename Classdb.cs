using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clubd
{
    using MySql.Data.MySqlClient;

   
        /// <summary>
        /// Clase base para cualquier repositorio MySQL.
        /// Contiene la cadena de conexión y utilidades comunes.
        /// </summary>
        public class UsuarioRepo(string servidor,
                                string baseDatos,
                                string usuario,
                                string clave,
                                uint puerto = 3306) : IDisposable
        {
                private readonly string _connectionString =
                    $"server={servidor};port={puerto};database={baseDatos};uid={usuario};pwd={clave};";

       
        /// Devuelve una conexión abierta.
        /// El using queda a cargo del que llame.
        /// </summary>
                protected MySqlConnection GetOpenConnection()
                    {
                    var conn = new MySqlConnection(_connectionString);
                    conn.Open();
                    return conn;
                    }

        public ResultadoBusquedaPersona BuscarPersonaPorDni(string dni)
        {
            var resultado = new ResultadoBusquedaPersona { Existe = false, EsSocio = false };

            using (var conexion = GetOpenConnection())
            {
                //conexion.Open();
                var query = "SELECT socio FROM Persona WHERE dni = @dni";

                using (var comando = new MySqlCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@dni", dni);

                    using (var reader = comando.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            resultado.Existe = true;
                            resultado.EsSocio = reader.GetBoolean("socio");
                        }
                    }
                }
            }

            return resultado;
        }

        public bool InsertarPersona(person Persona)
        {
            using (var conexion = GetOpenConnection())
            {
                //conexion.Open();
                string query = @"INSERT INTO Persona 
            (dni, apellido, nombre, fechanac, fechainscrip, direccion, email, telefono, conturgencia, fichamed, socio, estado) 
            VALUES 
            (@dni, @apellido, @nombre, @fechanac, @fechainscrip, @direccion, @email, @telefono, @conturgencia, @fichamed, @socio, @estado)";

                using (var comando = new MySqlCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@dni", Persona.Dni);
                    comando.Parameters.AddWithValue("@apellido", Persona.Apellido);
                    comando.Parameters.AddWithValue("@nombre", Persona.Nombre);
                    comando.Parameters.AddWithValue("@fechanac", Persona.Fechanac);
                    comando.Parameters.AddWithValue("@fechainscrip", Persona.Fechainscrip);
                    comando.Parameters.AddWithValue("@direccion", Persona.Direccion);
                    comando.Parameters.AddWithValue("@email", Persona.Email);
                    comando.Parameters.AddWithValue("@telefono", Persona.Telefono);
                    comando.Parameters.AddWithValue("@conturgencia", Persona.Conturgencia);
                    comando.Parameters.AddWithValue("@fichamed", Persona.Fichamed);
                    comando.Parameters.AddWithValue("@socio", Persona.Socio ? 1 : 0);
                    comando.Parameters.AddWithValue("@estado", Persona.Estado);

                    int filasAfectadas = comando.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
            }
        }


        #region Implementación de IDisposable (opcional)
        public void Dispose()
            {
                // Si más adelante tu clase mantiene algún recurso, límpialo aquí
            }
            #endregion
        }
   

   
}
