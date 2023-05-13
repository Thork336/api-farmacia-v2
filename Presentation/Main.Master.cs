using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Presentation
{
    public partial class Main : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LBProviders_Click(object sender, EventArgs e)
        {
            Response.Redirect("WFProviders.aspx");
        }

        protected void LBDriver_Click(object sender, EventArgs e)
        {
            Response.Redirect("WFDriver.aspx");
        }
    }
}