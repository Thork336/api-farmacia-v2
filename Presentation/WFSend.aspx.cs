using Logic.Send;
using System;
using System.Data;
using System.Web.UI.WebControls;

namespace Presentation
{
    public partial class WFSend : System.Web.UI.Page
    {
        SendService service = new SendService();
        private int id_send;
        private int codeShipping;
        private string address;
        private string phone;
        private int id_driver;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                list();
            }
        }

        private void list()
        {
            DataSet data = new DataSet();
            data = service.list();
            GVSend.DataSource = data;
            GVSend.DataBind();
        }

        protected void save(object sender, EventArgs e)
        {   
            bool executed = false;
            codeShipping = Convert.ToInt32(TBCodeSend.Text);
            address = TBAddresSend.Text;
            phone = TBPhoneSend.Text;
            id_driver = 0;
            executed = service.insert(codeShipping, address, phone, id_driver);

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

        protected void update(object sender, EventArgs e)
        {
            bool executed = false;
            id_driver = Convert.ToInt32(TBIdSend.Text);
            codeShipping = Convert.ToInt32(TBCodeSend.Text);
            address = TBAddresSend.Text;
            phone = TBPhoneSend.Text;
            id_driver = 0;
            executed = service.update(id_send, codeShipping, address, phone, id_driver);

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

        private void limpiarCajas()
        {
            TBCodeSend.Text = "";
            TBAddresSend.Text = "";
            TBPhoneSend.Text = "";
        }

        protected void GVSend_SelectedIndexChanged(object sender, EventArgs e)
        {
            TBCodeSend.Text = GVSend.SelectedRow.Cells[2].Text;
            TBAddresSend.Text = GVSend.SelectedRow.Cells[3].Text;
            TBPhoneSend.Text = GVSend.SelectedRow.Cells[4].Text;
        }

        protected void GVSend_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            id_send = Convert.ToInt32(GVSend.DataKeys[e.RowIndex].Values[0]);
            service.delete(id_send);
        }
    }
}