<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WFUser.aspx.cs" Inherits="Presentation.WFUser" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <header>
        <div>
            <ul>
                <a href="WFUser.aspx">Usuarios</a>
                <a href="WFVehicle.aspx">Vehiculos</a>
            </ul>
        </div>
    </header>
    <form id="form1" runat="server">
        <div>
            <br />
            <asp:Label ID="Label1" runat="server" Text="Label">Crear Usuarios</asp:Label>
            <asp:Label ID="TBId" runat="server" Visible="false"></asp:Label>
            <br />
            <br />
            <asp:TextBox ID="TBEmail" placeholder="Correo electrónico" runat="server"></asp:TextBox>
            <br />
            <asp:TextBox ID="TBPassword" placeholder="Contraseña" runat="server"></asp:TextBox>
            <br />
            <!--<asp:Label ID="TBSalt111" runat="server" Text="Elige el tipo usuario"></asp:Label>-->
            <asp:TextBox ID="TBSalt" placeholder="Salt" runat="server"></asp:TextBox>
            <br />
            <asp:DropDownList ID="TBState" runat="server">
                <asp:ListItem>Activo</asp:ListItem>
                <asp:ListItem>Inactivo</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <asp:Label ID="LblMsj" runat="server" Text=" "></asp:Label>
            <br />
            <asp:Button ID="BtnClear" runat="server" Text="Limpiar Cajas" OnClick="BtnClear_Click"/>
            <br />
            <asp:Button ID="BtnSave" runat="server" Text="Crear Usuario" OnClick="BtnSave_Click" />
            <br />
            <asp:Button ID="BtnUpdate" runat="server" Text="Actualizar Usuario" OnClick="BtnUpdate_Click" />

            <asp:GridView ID="GVUser" runat="server"
                OnSelectedIndexChanged="GVUser_SelectedIndexChanged" DataKeyNames="id_us"
                OnRowDeleting="GVUser_RowDeleting">
                <Columns>
                    <asp:CommandField ShowSelectButton="True" />
                    <asp:CommandField ShowDeleteButton="True" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
