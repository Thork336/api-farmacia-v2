<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="WFUsers.aspx.cs" Inherits="Presentation.WFUsers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <%--Id--%>
    <asp:Label ID="LblId" runat="server" Text=""></asp:Label><br />
    <%--Correo--%>
    <asp:Label ID="Label1" runat="server" Text="Ingrese el correo"></asp:Label>
    <asp:TextBox ID="TBMail" runat="server" TextMode="Email"></asp:TextBox><br />
    <%--Contraseña--%>
    <asp:Label ID="Label2" runat="server" Text="Ingrese la contraseña"></asp:Label>
    <asp:TextBox ID="TBContrasena" runat="server"
        TextMode="Password"></asp:TextBox><br />
    <%--Estados--%>
    <asp:Label ID="Label3" runat="server" Text="Estado"></asp:Label>
    <asp:DropDownList ID="DDLState" runat="server">
        <asp:ListItem Value="0">Seleccione</asp:ListItem>
        <asp:ListItem Value="Activo">Activo</asp:ListItem>
        <asp:ListItem Value="Inactivo">Inactivo</asp:ListItem>
    </asp:DropDownList><br />
    <%--Botones--%>
    <asp:Button ID="BtnSave" runat="server" Text="Guardar" OnClick="BtnSave_Click" />
    <asp:Button ID="BtnUpdate" runat="server" Text="Actualizar"
        OnClick="BtnUpdate_Click" />
    <%--Mensaje--%>
    <asp:Label ID="LblMsj" runat="server" Text=""></asp:Label><br />
    <%--Tabla--%>
    <asp:GridView ID="GVUsers" runat="server" AutoGenerateColumns="False"
        OnSelectedIndexChanged="GVUsers_SelectedIndexChanged">
        <Columns>
            <asp:BoundField DataField="id_us" HeaderText="Id" />
            <asp:BoundField DataField="correo_us" HeaderText="Correo" />
            <asp:BoundField DataField="contrasena_us" HeaderText="Contraseña" />
            <asp:BoundField DataField="salt_us" HeaderText="Salt" />
            <asp:BoundField DataField="estado_us" HeaderText="Estado" />
            <asp:CommandField ShowSelectButton="True" />
        </Columns>
    </asp:GridView>
</asp:Content>
