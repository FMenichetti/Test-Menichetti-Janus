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

            //Carga de Drop down list con los tipos de productos

            NegocioTipos negocio = new NegocioTipos();
            List<Tipo> lista = negocio.listarTipo();

            ddl_Tipo.DataSource = lista;
            ddl_Tipo.DataTextField = "Descripcion";
            ddl_Tipo.DataValueField = "Id";
            ddl_Tipo.DataBind();
        }
    }
}