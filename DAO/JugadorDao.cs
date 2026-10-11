using ENTITIES;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAO
{
    public class JugadorDao
    {
        private string connectionString = ConfigurationDB.getJugadoresConnectionString();

        public List<Jugador> getAll()
        {
            try
            {
                List<Jugador> jugadorList = new List<Jugador>();
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT * FROM JUGADORES";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Jugador jugador = new Jugador
                                {
                                    idJugador = Convert.ToInt32(reader["ID_JUGADOR"].ToString()),
                                    nombre = reader["NOMBRE"].ToString(),
                                    apellido = reader["APELLIDO"].ToString(),
                                    numero = Convert.ToInt32(reader["NUMERO"].ToString()),
                                    habilitado = Convert.ToBoolean(reader["HABILITADO"]),
                                };
                                jugadorList.Add(jugador);
                            }
                        }
                    }
                }
                return jugadorList;
            }
            catch
            {
                throw;
            }
        }

        public void altaJugador(Jugador jugador)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "INSERT INTO JUGADORES (NOMBRE, APELLIDO, NUMERO, HABILITADO) VALUES (@nombre, @apellido, @numero, @habilitado)";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@nombre", jugador.nombre);
                        cmd.Parameters.AddWithValue("@apellido", jugador.apellido);
                        cmd.Parameters.AddWithValue("@numero", jugador.numero);
                        cmd.Parameters.AddWithValue("@habilitado", jugador.habilitado);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch
            {
                throw;
            }
        }

        public void modificarJugador(int id, int nuevoNumero, bool habilitado)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "UPDATE JUGADORES SET NUMERO = @numero, HABILITADO = @habilitado WHERE ID_JUGADOR = @id";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@numero", nuevoNumero);
                        cmd.Parameters.AddWithValue("@habilitado", habilitado);
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch
            {
                throw;
            }
        }

        public void eliminarJugador(int id)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "DELETE FROM JUGADORES WHERE ID_JUGADOR = @id";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch
            {
                throw;
            }
        }

    }
}
