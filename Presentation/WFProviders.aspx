<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="WFProviders.aspx.cs" Inherits="Presentation.WFProviders" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">&nbsp;<br/>

    <asp:TextBox ID="TBCodigo" runat="server"></asp:TextBox><br/>

    <asp:Label ID="Label5" runat="server" Text="">Id De Proveedor</asp:Label><br/>
    <asp:Label ID="TBIdProvider" runat="server" Text=""></asp:Label><br/>
    <%--<asp:TextBox ID="TBIdProvider" runat="server"></asp:TextBox><br/>--%>

    <asp:Label ID="Label2" runat="server" Text="">Ingrese El Nit Del Proveedor</asp:Label><br/>
    <asp:TextBox ID="TBNitProvider" runat="server"></asp:TextBox><br/>

    <asp:Label ID="Label3" runat="server" Text="">Ingrese El Nombre Del Proveedor</asp:Label><br/>
    <asp:TextBox ID="TBNomProvider" runat="server"></asp:TextBox><br/>

    <asp:Label ID="Label4" runat="server" Text="">Ingrese La Ciudad Del Proveedor</asp:Label><br/>
    <asp:TextBox ID="TBCityProvider" runat="server"></asp:TextBox><br/>

    <asp:Button ID="BtnGuardar" runat="server" CssClass="btn btn-success" Text="Guardar" OnClick="BtnGuardar_Click" />
    <asp:Button ID="BtnActualizar" runat="server" CssClass="btn btn-info" Text="Actualizar" OnClick="BtnActualizar_Click" /><br/>
    <asp:Label ID="LblMensaje" runat="server" Text=""></asp:Label><br/>

    <asp:Label ID="Label1" runat="server" Text="">Lista De Proveedores</asp:Label><br/>
    <asp:GridView ID="GVProviders" runat="server" CssClass="table table-hover table-primary" OnSelectedIndexChanged="GVProviders_SelectedIndexChanged" DataKeyNames="id_provider" OnRowDeleting="GVProviders_RowDeleting">
        <Columns>
            <asp:CommandField ShowSelectButton="True" />
            <asp:CommandField ShowDeleteButton="True" />
        </Columns>
    </asp:GridView><br/>
</asp:Content>
