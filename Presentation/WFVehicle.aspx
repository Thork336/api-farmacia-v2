<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WFVehicle.aspx.cs" Inherits="Presentation.WFVehicle" %>

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
            <asp:Label ID="Label1" runat="server" Text="Label">Vehiculos</asp:Label>
            <asp:Label ID="TBId" runat="server" Visible="false"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Placa del vehiculo"></asp:Label>
            <br />
            <asp:TextBox ID="TBPlaca" placeholder="Ej. MRX221" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label3" runat="server" Text="Modelo del vehiculo"></asp:Label>
            <br />
            <asp:TextBox ID="TBModelo" placeholder="Ej. 2023" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label4" runat="server" Text="Tipo de Vehiculo"></asp:Label>
            <br />
            <asp:TextBox ID="TBTipo" placeholder="Ej. Carro, Moto" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label5" runat="server" Text="Capacidad de Carga (KG)"></asp:Label>
            <br />
            <asp:TextBox ID="TBCapacidad" placeholder="Ej. 500" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label6" runat="server" Text="ID Conductor encargado"></asp:Label>
            <br />
            <asp:DropDownList ID="DropDownList1" runat="server">

            </asp:DropDownList>
            <br />
            <asp:TextBox ID="TBId_cond" placeholder="Ej. 1,2,3" runat="server"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Label ID="LblMsj" runat="server" Text=" "></asp:Label>
            <br />
            <asp:Button ID="BtbClear" runat="server" Text="Limpiar casillas" OnClick="BtbClear_Click" />
            <br />
            <asp:Button ID="BtnSave" runat="server" Text="Crear Vehiculo" OnClick="BtnSave_Click" />
            <br />
            <asp:Button ID="BtnUpdate" runat="server" Text="Actualizar Vehiculo" OnClick="BtnUpdate_Click" />
            <asp:GridView ID="GVVehicle" runat="server"
                OnSelectedIndexChanged="GVVehicle_SelectedIndexChanged" DataKeyNames="id_vehiculo_veh"
                OnRowDeleting="GVVehicle_RowDeleting">
                <Columns>
                    <asp:CommandField ShowSelectButton="True" />
                    <asp:CommandField ShowDeleteButton="True" />
                </Columns>
                
            </asp:GridView>
        </div>
    </form>
</body>
</html>
