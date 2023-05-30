using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Presentation
{
    public partial class Logout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session.Abandon();//Destruye todos los objetos almacenados en un objeto Session y libera sus recursos.
            FormsAuthentication.SignOut();//Elimina el ticket de autenticación de formularios del navegador.
            HttpContext.Current.Response.Redirect("Default.aspx");
        }
    }
}