using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class NegocioProducto
    {
        //Metodo de listar Producto
        public List<Producto> listarProducto()
        {
            List<Producto> lista = new List<Producto>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                //Consulta a View creada en DB
                datos.setearConsulta("select * from vw_StockProducto");

                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Producto aux = new Producto();
                    aux.oTipo = new Tipo();
                    aux.oStock = new Stock();

                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Id= (int)datos.Lector["Id"];
                    aux.oTipo.Descripcion = (string)datos.Lector["Desc"];
                    aux.Precio = (decimal)datos.Lector["Precio"];
                    aux.oStock.Cantidad = (int)datos.Lector["Cant"];
                    lista.Add(aux);
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }


        //Metodo de carga de Producto nuevo
        public void cargarProducto(Producto producto)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                //Se utiliza store procedure de DB
                datos.setearProcedimiento("sp_InsertarProducto");
                datos.setearParametro("@idTipoProducto", producto.oTipo.Id);
                datos.setearParametro("@nombre", producto.Nombre);
                datos.setearParametro("@precio", producto.Precio);
               
                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();

            }
        }

        //Metodo de Modificar producto
        public void modificarProducto(Producto producto)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                //Se utiliza store procedure de DB
                datos.setearProcedimiento("sp_ModificarProducto");
                datos.setearParametro("@idTipoProducto", producto.oTipo.Id);
                datos.setearParametro("@nombre", producto.Nombre);
                datos.setearParametro("@precio", producto.Precio);

                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();

            }
        }


        //Metodo de eliminar producto
        public void eliminarProducto(int id)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                //Se utiliza store procedure de DB
                datos.setearProcedimiento("sp_EliminarProducto");
                datos.setearParametro("@Id", id);
                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();

            }
        }

    }
}
