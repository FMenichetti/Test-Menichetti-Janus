﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Stock
{
    public partial class Excepcion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            lblError.Text = Session["Error"].ToString();  // cargo en lbl error guardado en  session

        }
    }
}