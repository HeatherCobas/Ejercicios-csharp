using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaDatos
{
    public class RolDAL
    {
        private readonly Conexion conexion = new Conexion();

        public List<Rol> ObtenerRoles()
        {
            List<Rol> listaRoles = new List<Rol>();

            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("ObtenerRoles", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    listaRoles.Add(new Rol
                    {
                        IdRol = Convert.ToInt32(dr["Id_Rol"]),
                        NombreRol = dr["NombreRol"].ToString()
                    });
                }
            }

            return listaRoles;
        }

        public Rol ObtenerRolPorUsuario(int idUsuario)
        {
            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("ObtenerRolPorUsuario", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    return new Rol
                    {
                        IdRol = Convert.ToInt32(reader["IdRol"]),
                        NombreRol = reader["NombreRol"].ToString()
                    };
                }
                else
                {
                    return null;
                }
            }
        }
    }
}