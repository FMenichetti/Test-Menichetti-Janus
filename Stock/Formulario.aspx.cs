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
    public partial class Formulario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

            //Carga de Drop down list con los tipos de productos
            NegocioTipos tipoNegocio = new NegocioTipos();
            List<Tipo> lista = tipoNegocio.listarTipo();


            ddl_Tipo.DataSource = lista;
            ddl_Tipo.DataTextField = "Descripcion";
            ddl_Tipo.DataValueField = "Id";
            ddl_Tipo.DataBind();
            }


            //En caso de ingresar por Editar, guardo el ID 
            //Filtro el producto de la lista
            //Auto completo los datos del producto seleccionado
            if (Convert.ToString(Session["Id"]) != "")
            {
                Producto producto = new Producto();
                NegocioProducto productoNegocio = new NegocioProducto();
                int id = Convert.ToInt32(Session["Id"].ToString());
                producto = ((List<Producto>)productoNegocio.listarProducto()).Find(x => x.Id == id);
                txt_nombre.Text = producto.Nombre;
                //ddl_Tipo.ClearSelection();
                ddl_Tipo.SelectedValue = producto.oTipo.Id.ToString();
                txt_precio.Text = Convert.ToString(producto.Precio); ;
                Txt_cantidad.Text = Convert.ToString(producto.oStock.Cantidad);

            }






        }

        protected void btn_aceptar_Click(object sender, EventArgs e)
        {

            Producto aux = new Producto();
            NegocioProducto negocio = new NegocioProducto();

            aux.Nombre = txt_nombre.Text;
            aux.oTipo = new Tipo();
            aux.oTipo.Id = int.Parse(ddl_Tipo.SelectedValue);
            aux.Precio = Convert.ToDecimal(txt_precio.Text);
            aux.oStock = new Dominio.Stock();
            aux.oStock.Cantidad = Convert.ToInt32(Txt_cantidad.Text);

            negocio.cargarProducto(aux);

            Response.Redirect("Administrador.aspx", false);
        }
    }
}