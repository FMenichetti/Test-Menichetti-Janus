using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace Stock
{
    public partial class Administrador : System.Web.UI.Page
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

        protected void Unnamed_Click(object sender, EventArgs e)
        {

            // Obtén el botón que desencadenó el evento de clic
            Button btn = (Button)sender;

            // Encuentra la fila que contiene el botón
            GridViewRow row = (GridViewRow)btn.NamingContainer;

            if (row.RowType == DataControlRowType.DataRow)//Verifico que el tipo de dato de la row sea dataRow
            {
                // Accedo al Id de la fila
                string id = row.Cells[0].Text;
                Session.Add("Id", id);
              
            }

            Response.Redirect("Formulario.aspx", false);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Formulario.aspx", false);
        }
    }
}