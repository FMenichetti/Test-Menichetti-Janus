using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Stock
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonReporte_Click(object sender, EventArgs e)
        {
            Response.Redirect("Reporte.aspx", false);
        }

        protected void ButtonAdmin_Click(object sender, EventArgs e)
        {
            Response.Redirect("Administrador.aspx", false);
        }
    }
}