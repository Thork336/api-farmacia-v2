using Logic.Providers;
using System;
using System.Data;

namespace Presentation
{
    public partial class WFProviders : System.Web.UI.Page
    {
        ProvidersService objPro = new ProvidersService();
        private int nit_provider;
        private string name_provider;
        private string city_provider;
        private int id_provider;
        private bool executed = false;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                TBCodigo.Visible = false;
                list();
            }
        }

        private void list()
        {
            DataSet objData = new DataSet();
            objData = objPro.list();
            GVProviders.DataSource = objData;
            GVProviders.DataBind();
        }

        protected void BtnGuardar_Click(object sender, EventArgs e)
        {
            id_provider = Convert.ToInt32(TBIdProvider.Text);
            nit_provider = Convert.ToInt32(TBNitProvider.Text);
            name_provider = TBNomProvider.Text;
            city_provider = TBCityProvider.Text;

            executed = objPro.insert(nit_provider, name_provider, city_provider);
            if (executed)
            {
                LblMensaje.Text = "Registro Exitoso";
                limpiarCajas();
                list();
            }
            else
            {
                LblMensaje.Text = "Error Al Guardar";
            }
        }

        protected void BtnActualizar_Click(object sender, EventArgs e)
        {
            id_provider = Convert.ToInt32(TBIdProvider.Text);
            nit_provider = Convert.ToInt32(TBNitProvider.Text);
            name_provider = TBNomProvider.Text;
            city_provider = TBCityProvider.Text;

            executed = objPro.update(id_provider, nit_provider, name_provider, city_provider);
            if (executed)
            {
                LblMensaje.Text = "Actualizacion Exitosa";
                BtnGuardar.Enabled = true;
                limpiarCajas();
                list();
            }
            else
            {
                LblMensaje.Text = "Error Al Actualizar";
            }
        }

        protected void GVProviders_SelectedIndexChanged(object sender, EventArgs e)
        {
            TBIdProvider.Text = GVProviders.SelectedRow.Cells[2].Text;
            TBNitProvider.Text = GVProviders.SelectedRow.Cells[3].Text;
            TBNomProvider.Text = GVProviders.SelectedRow.Cells[4].Text;
            TBCityProvider.Text = GVProviders.SelectedRow.Cells[5].Text;

            BtnGuardar.Enabled = false;
        }

        private void limpiarCajas()
        {
            TBIdProvider.Text = "";
            TBNitProvider.Text = "";
            TBNomProvider.Text = "";
            TBCityProvider.Text = "";
        }

        protected void GVProviders_RowDeleting(object sender, System.Web.UI.WebControls.GridViewDeleteEventArgs e)
        {
            id_provider = Convert.ToInt32(GVProviders.DataKeys[e.RowIndex].Values[0]);
            executed = objPro.delete(id_provider);

            if (executed)
            {
                LblMensaje.Text = "El Proveedor Se Elimino Exitosamente";
                list();
            }
            else
            {
                LblMensaje.Text = "Error Al Eliminar";
            }
        }
    }
}