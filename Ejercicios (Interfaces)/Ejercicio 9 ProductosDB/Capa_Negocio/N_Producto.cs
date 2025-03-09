using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace Capa_Negocio
{
    public class N_Producto
    {
            private D_Productos datos = new D_Productos();

            public DataTable ListarProductos(string valor)
            {
                return datos.ListarProductos(valor);
            }

            public DataTable ListarCategorias()
            {
                return datos.ListarCategorias();
            }


            public void GuardarProducto(string Nombre_Prod, string marca, string Nombre_Me, int stock, decimal precio, string Nombre_cat, string descripcion)
            {
                if (string.IsNullOrWhiteSpace(Nombre_Prod))
                {
                    throw new ArgumentException("El nombre del producto no puede estar vacío.");
                }
                if (precio <= 0)
                {
                    throw new ArgumentException("El precio debe ser mayor a cero.");
                }
                if (stock < 0)
                {
                    throw new ArgumentException("El stock no puede ser negativo.");
                }

                datos.GuardarProducto(Nombre_Prod, marca, Nombre_Me, stock, precio, Nombre_cat, descripcion);
            }

            public DataTable ListarMedidas()
            {
                return datos.ListarMedidas();
            }
    }

}