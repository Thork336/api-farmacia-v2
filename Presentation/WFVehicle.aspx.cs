using Logic.Driver;
using Logic.Vehicle;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
namespace Presentation
{
    public partial class WFVehicle : System.Web.UI.Page
    {
        VehicleLog objVehicle = new VehicleLog();
        DriverService objDriver = new DriverService();
        private string _placa;
        private int _modelo;
        private bool executed = false;
        private string _tipo;
        private string _capacidad;
        private int _id;
        private int _id_driver;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                showVehicle();
                showDriverDDL();
            }
        }
        private void showVehicle()
        {
            DataSet objData = new DataSet();
            objData = objVehicle.showVehicle();
            GVVehicle.DataSource = objData;
            GVVehicle.DataBind();

        }

        private void showDriverDDL()
        {
            DDLDriver.DataSource = objVehicle.showVehicleDDL();
            DDLDriver.DataValueField = "id_cond";
            DDLDriver.DataTextField = "Nombre Conductor";
            DDLDriver.DataBind();
            DDLDriver.Items.Insert(0, "Seleccione");

        }
        protected void BtnSave_Click(object sender, EventArgs e)
        {
            _placa = TBPlaca.Text;
            _modelo = Convert.ToInt32(TBModelo.Text);
            _tipo = TBTipo.Text;
            _capacidad = TBCapacidad.Text;
            _id_driver = Convert.ToInt32(DDLDriver.Text);
            executed = objVehicle.saveVehicle(_placa, _modelo, _tipo, _capacidad, _id_driver);
            if (executed)
            {
                LblMsj.Text = "Se guardó exitosamente";
                Clear();

                showVehicle();
            }
            else
            {
                LblMsj.Text = "Error al guardar";
            }
        }

        protected void BtnUpdate_Click(object sender, EventArgs e)
        {
            _id = Convert.ToInt32(TBId.Text);
            _placa = TBPlaca.Text;
            _modelo = Convert.ToInt32(TBModelo.Text);
            _tipo = TBTipo.Text;
            _capacidad = TBCapacidad.Text;
            _id_driver = Convert.ToInt32(DDLDriver.Text);
            executed = objVehicle.updateVehicle(_id, _placa, _modelo, _tipo, _capacidad, _id_driver);
            if (executed)
            {
                LblMsj.Text = "Se actualizó exitosamente";
                Clear();
                showVehicle();
            }
            else
            {
                LblMsj.Text = "Error al actualizar";
            }
        }

        protected void GVVehicle_SelectedIndexChanged(object sender, EventArgs e)
        {
            TBId.Text = GVVehicle.SelectedRow.Cells[2].Text;
            TBPlaca.Text = GVVehicle.SelectedRow.Cells[3].Text;
            TBModelo.Text = GVVehicle.SelectedRow.Cells[4].Text;
            TBTipo.Text = GVVehicle.SelectedRow.Cells[5].Text;
            TBCapacidad.Text = GVVehicle.SelectedRow.Cells[6].Text;
            DDLDriver.Text = GVVehicle.SelectedRow.Cells[7].Text;
        }

        protected void GVVehicle_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            _id = Convert.ToInt32(GVVehicle.DataKeys[e.RowIndex].Values[0]);
            executed = objVehicle.deleteVehicle(_id);
            if (executed)
            {
                LblMsj.Text = "Se eliminó exitosamente";
                GVVehicle.EditIndex = -1;
                showVehicle();
            }
            else
            {
                LblMsj.Text = "Error al eliminar";
            }
        }

        protected void BtbClear_Click(object sender, EventArgs e)
        {
            TBId.Text = "";
            TBPlaca.Text = "";
            TBModelo.Text = "";
            TBTipo.Text = "";
            TBCapacidad.Text = "";
            DDLDriver.Text = "Seleccione";

            LblMsj.Text = "Limpio";
        }

        private void Clear()
        {
            TBId.Text = "";
            TBPlaca.Text = "";
            TBModelo.Text = "";
            TBTipo.Text = "";
            TBCapacidad.Text = "";
            DDLDriver.Text = "Seleccione";
        }
    }
}