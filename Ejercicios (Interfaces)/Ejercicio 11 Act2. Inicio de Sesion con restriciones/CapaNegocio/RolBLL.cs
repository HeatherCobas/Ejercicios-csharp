using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class RolBLL
    {
        private RolDAL rolDAL = new RolDAL();
        private readonly Conexion conexion = new Conexion();


        public List<Rol> ObtenerRoles()
        {
            return rolDAL.ObtenerRoles();
        }

        public Rol ObtenerRolPorUsuario(int idUsuario)
        {
            Rol rol = null;

            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                try
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("ObtenerRolPorUsuario", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                rol = new Rol
                                {
                                    IdRol = Convert.ToInt32(reader["Id_Rol"]),
                                    NombreRol = reader["NombreRol"].ToString()
                                };
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al obtener el rol del usuario: " + ex.Message);
                }
            }

            return rol;
        }
    }
}