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
        public Boolean modificar;  //Esta variable se usa del lado FE como condicional
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Session.Clear();
                modificar = false;
            }

            try
            {
                NegocioProducto negocio = new NegocioProducto();
                List<Producto> lista = new List<Producto>();

                Dgv.DataSource = negocio.listarProducto();
                Dgv.DataBind();
            }
            catch (Exception ex)
            {
                Session.Add("Error", ex.ToString());
                Response.Redirect("Excepcion.aspx", false);
            }
        }

        protected void Unnamed_Click(object sender, EventArgs e) //Click de cualquieras de los botones de Edicion
        {

            // Obténgo el botón que de click
            Button btn = (Button)sender;

            // Encuentro la fila que contiene el botón
            GridViewRow row = (GridViewRow)btn.NamingContainer;

            if (row.RowType == DataControlRowType.DataRow)//Verifico que el tipo de dato de la row sea dataRow
            {
                // Accedo al Id de la fila
                string id = row.Cells[0].Text;
                Session.Add("Id", id);
              
            }

            Response.Redirect("Formulario.aspx", false);
        }

        
        protected void btnNuevo_Click(object sender, EventArgs e)  // btn de nuevo producto
        {
            Response.Redirect("Formulario.aspx", false);
        }

        protected void btnEliminar_Click(object sender, EventArgs e)   // btn eliminar producto
        {
            // Obténgo el botón que de click
            Button btn = (Button)sender;

            // Encuentro la fila que contiene el botón
            GridViewRow row = (GridViewRow)btn.NamingContainer;

            if (row.RowType == DataControlRowType.DataRow)//Verifico que el tipo de dato de la row sea dataRow
            {
                // Accedo al Id de la fila
                string id = row.Cells[0].Text;
                Session.Add("Id", id);
                modificar = true;

            }
        }

        protected void btnConfirmar_Click(object sender, EventArgs e)  // confirmacion de eliminacion
        {
            int id = int.Parse(Session["Id"].ToString());
            NegocioProducto negocio = new NegocioProducto();

            try
            {
                negocio.eliminarProducto(id);
                modificar = false;
                Response.Redirect("Administrador.aspx", false);
            }
            catch (Exception ex )
            {

                Session.Add("Error", ex.ToString());
                Response.Redirect("Excepcion.aspx", false);
            }
            
        }

        protected void btnCancelar_Click(object sender, EventArgs e)   // btn cancelo eliminacion
        {
            modificar = false;
            Response.Redirect("Administrador.aspx", false);
        }
    }
}