using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class D_Productos
    {
        private readonly string connectionString = @"Server=DESKTOP-5RJ08CB;Database=ProductoDB;Trusted_Connection=True;";

        public DataTable ListarProductos(string valor)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_Listar_pr", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@valor", valor ?? string.Empty);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                }
            }
            return dt;
        }
        public int GuardarProducto(string nombreProd, string marca, string nombreMedida, int stock, decimal precio, string nombreCat, string descripcion)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_Guardar_pr", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Nombre_prod", nombreProd);
                    cmd.Parameters.AddWithValue("@Marca", marca);
                    cmd.Parameters.AddWithValue("@Nombre_Me", nombreMedida);
                    cmd.Parameters.AddWithValue("@stock", stock);
                    cmd.Parameters.AddWithValue("@precio", precio);
                    cmd.Parameters.AddWithValue("@Nombre_cat", nombreCat);
                    cmd.Parameters.AddWithValue("@descripcion", descripcion);

                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected;
                }
            }
        }

        public DataTable ListarCategorias()
        {
            DataTable dtCategorias = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_Listar_Categorias", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dtCategorias);
                }
            }
            return dtCategorias;
        }

        public DataTable ListarMedidas()
        {
            DataTable tabla = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand("SELECT Id_Medida, Nombre_Me FROM Medidas", conn))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        adapter.Fill(tabla);
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al listar medidas.", ex);
                }
            }
            return tabla;
        }
    }
}