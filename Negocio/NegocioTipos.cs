using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class NegocioTipos
    {
        //Metodo Listar tipos
        public List<Tipo> listarTipo()
        {
            List<Tipo> lista = new List<Tipo>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                //Consulta embebida para seleccionar Id y descripcion de los tipos de productos
                datos.setearConsulta("select Id, Descripcion from TipoProducto");

                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Tipo tipo = new Tipo();
                    tipo.Id = (int)datos.Lector["Id"];
                    tipo.Descripcion = (string)datos.Lector["Descripcion"];
                    lista.Add(tipo);
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

    }
}
