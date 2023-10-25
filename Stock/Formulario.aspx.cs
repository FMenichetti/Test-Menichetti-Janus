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


        public Boolean modificar = false;
        int id;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                id = 0;
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
            if ((Convert.ToString(Session["Id"]) != "") && !IsPostBack)
            {
                modificar = true;
                Producto producto = new Producto();
                NegocioProducto productoNegocio = new NegocioProducto();
                id = Convert.ToInt32(Session["Id"].ToString());
                producto = ((List<Producto>)productoNegocio.listarProducto()).Find(x => x.Id == id);
                txt_nombre.Text = producto.Nombre;
                //ddl_Tipo.ClearSelection();
                ddl_Tipo.SelectedValue = producto.oTipo.Id.ToString();
                txt_precio.Text = Convert.ToString(producto.Precio); ;
                Txt_cantidad.Text = Convert.ToString(producto.oStock.Cantidad);

            }


        }



        protected void btnNuevo_Click(object sender, EventArgs e)
        {
            Producto aux = new Producto();
            NegocioProducto negocio = new NegocioProducto();

            aux.Nombre = txt_nombre.Text;
            aux.oTipo = new Tipo();
            aux.oTipo.Id = int.Parse(ddl_Tipo.SelectedValue);
            aux.Precio = Convert.ToDecimal(txt_precio.Text);
            aux.oStock = new Dominio.Stock();
            aux.oStock.Cantidad = Convert.ToInt32(Txt_cantidad.Text);

            try
            {
            negocio.cargarProducto(aux);

            }
            catch (Exception ex )
            {
                Session.Add("Error", ex.ToString());
                Response.Redirect("Excepcion.aspx", false);
            }

            Response.Redirect("Administrador.aspx", false);
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            NegocioProducto negocio = new NegocioProducto();
            Producto producto = new Producto();
            id = Convert.ToInt32(Session["Id"].ToString());
            producto = ((List<Producto>)negocio.listarProducto()).Find(x => x.Id == id);

            producto.Id = id;
            producto.oTipo = new Tipo();
            producto.oTipo.Id = int.Parse(ddl_Tipo.SelectedValue);
            producto.Nombre = txt_nombre.Text;
            producto.Precio = Convert.ToDecimal(txt_precio.Text);
            producto.oStock = new Dominio.Stock();
            producto.oStock.Cantidad = int.Parse(Txt_cantidad.Text);

            try
            {

            negocio.modificarProducto(producto);
            }
            catch (Exception ex)
            {

                Session.Add("Error", ex.ToString());
                Response.Redirect("Excepcion.aspx", false);
            }
            //Session.Clear();
            Response.Redirect("Administrador.aspx", false);
        }
    }
}