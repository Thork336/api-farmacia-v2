using Logic.Driver;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Presentation
{

    public partial class WFDriver : System.Web.UI.Page
    {
        DriverService objDriver = new DriverService();
        private int id_cond;
        private int cedula_cond;
        private string numLicencia_cond;
        private string nombre_cond;
        private string apellido_cond;
        private string telefono_cond;
        private int edad_cond;
        private string genero_cond;
        private string tipoLicencia_cond;
        private bool executed;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                list();
            }
        }

        private void list()
        {
            DataSet objData = new DataSet();
            objData = objDriver.list();
            GVDriver.DataSource = objData;
            GVDriver.DataBind();
        }

        protected void BtnGuardar_Click(object sender, EventArgs e)
        {
            cedula_cond = Convert.ToInt32(TBIdentiConductor.Text);
            numLicencia_cond = TBNumLicenciaConductor.Text;
            nombre_cond = TBNomConductor.Text;
            apellido_cond = TBApellidoConductor.Text;
            telefono_cond = TBTelefonoConductor.Text;
            edad_cond = Convert.ToInt32(TBEdadConductor.Text);
            genero_cond = TBGeneroConductor.Text;
            tipoLicencia_cond = TBTipoLicencia.Text;

            executed = objDriver.insert(cedula_cond, numLicencia_cond,
             nombre_cond, apellido_cond, telefono_cond, edad_cond, genero_cond,
             tipoLicencia_cond);
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
            cedula_cond = Convert.ToInt32(TBIdentiConductor.Text);
            numLicencia_cond = TBNumLicenciaConductor.Text;
            nombre_cond = TBNomConductor.Text;
            apellido_cond = TBApellidoConductor.Text;
            telefono_cond = TBTelefonoConductor.Text;
            edad_cond = Convert.ToInt32(TBEdadConductor.Text);
            genero_cond = TBGeneroConductor.Text;
            tipoLicencia_cond = TBTipoLicencia.Text;

            executed = objDriver.update(id_cond, cedula_cond, numLicencia_cond,
             nombre_cond, apellido_cond, telefono_cond, edad_cond, genero_cond,
             tipoLicencia_cond);
            if (executed)
            {
                LblMensaje.Text = "Actualizacion Exitosa";
                limpiarCajas();
                list();
            }
            else
            {
                LblMensaje.Text = "Error Al Actualizar";
            }
        }

        protected void GVDriver_SelectedIndexChanged(object sender, EventArgs e)
        {
            TBId.Text = GVDriver.SelectedRow.Cells[2].Text;
            TBIdentiConductor.Text = GVDriver.SelectedRow.Cells[3].Text;
            TBNumLicenciaConductor.Text = GVDriver.SelectedRow.Cells[4].Text;
            TBNomConductor.Text = GVDriver.SelectedRow.Cells[5].Text;
            TBApellidoConductor.Text = GVDriver.SelectedRow.Cells[6].Text;
            TBTelefonoConductor.Text = GVDriver.SelectedRow.Cells[7].Text;
            TBEdadConductor.Text = GVDriver.SelectedRow.Cells[8].Text;
            TBGeneroConductor.Text = GVDriver.SelectedRow.Cells[9].Text;
            TBTipoLicencia.Text = GVDriver.SelectedRow.Cells[10].Text;
        }

        private void limpiarCajas()
        {
            TBIdentiConductor.Text = "";
            TBNumLicenciaConductor.Text = "";
            TBNomConductor.Text = "";
            TBApellidoConductor.Text = "";
            TBTelefonoConductor.Text = "";
            TBEdadConductor.Text = "";
            TBGeneroConductor.Text = "";
            TBTipoLicencia.Text = "";
        }

        protected void GVDriver_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            id_cond = Convert.ToInt32(GVDriver.DataKeys[e.RowIndex].Values[0]);
            executed = objDriver.delete(id_cond);

            if (executed)
            {
                LblMensaje.Text = "El Conductor Se Elimino Exitosamente";
                list();
            }
            else
            {
                LblMensaje.Text = "Error Al Eliminar";
            }
        }
    }
}