using Logic.User;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Presentation
{
    public partial class WFUser : System.Web.UI.Page
    {
        UserLog objUser = new UserLog();
        private string _mail_user;
        private int _password;
        private bool executed = false;
        private string _type_user;
        private int _id;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                showUser();
            }

        }

        private void showUser()
        {
            DataSet objData = new DataSet();
            objData = objUser.showUser();
            GVUser.DataSource = objData;
            GVUser.DataBind();

        }

        protected void GVUser_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            _id = Convert.ToInt32(GVUser.DataKeys[e.RowIndex].Values[0]);
            executed = objUser.deleteUser(_id);
            if (executed)
            {
                LblMsj.Text = "Se eliminó exitosamente";
                GVUser.EditIndex = -1;
                showUser();
            }
            else
            {
                LblMsj.Text = "Error al eliminar";
            }
        }

        protected void GVUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            TBId.Text = GVUser.SelectedRow.Cells[2].Text;
            TBEmail.Text = GVUser.SelectedRow.Cells[3].Text;
            TBPassword.Text = GVUser.SelectedRow.Cells[4].Text;
            TBType.Text = GVUser.SelectedRow.Cells[5].Text;
        }

        protected void BtnSave_Click(object sender, EventArgs e)
        {
            _mail_user = TBEmail.Text;
            _password = Convert.ToInt32(TBPassword.Text);
            _type_user = TBType.Text;
            executed = objUser.saveUser(_mail_user, _password, _type_user);
            if (executed)
            {
                LblMsj.Text = "Se guardó exitosamente";
                showUser();
                Clear();
            }
            else
            {
                LblMsj.Text = "Error al guardar";
            }
        }

        protected void BtnUpdate_Click(object sender, EventArgs e)
        {
            _id = Convert.ToInt32(TBId.Text);
            _mail_user = TBEmail.Text;
            _password = Convert.ToInt32(TBPassword.Text);
            _type_user = TBType.Text;
            executed = objUser.updateUser(_id, _mail_user, _password, _type_user);
            if (executed)
            {
                LblMsj.Text = "Se actualizó exitosamente";
                showUser();
                Clear();
            }
            else
            {
                LblMsj.Text = "Error al actualizar";
            }
        }

        protected void BtnClear_Click(object sender, EventArgs e)
        {
            TBId.Text = "";
            TBEmail.Text = "";
            TBPassword.Text = "";
            TBTypeUser.Text = "";
            LblMsj.Text = "Limpio";
        }

        private void Clear()
        {
            TBId.Text = "";
            TBEmail.Text = "";
            TBPassword.Text = "";
            TBTypeUser.Text = "";
        }
    }
}