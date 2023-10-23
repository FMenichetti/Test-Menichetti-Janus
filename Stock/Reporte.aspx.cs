using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using Dominio;

namespace Stock
{
    public partial class Reporte : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                NegocioProducto negocio = new NegocioProducto();
                List<Producto> lista = new List<Producto>();

                Dgv.DataSource = negocio.listarProducto();
                Dgv.DataBind();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            



        }

        
    }
}