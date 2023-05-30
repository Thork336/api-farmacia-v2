<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="WFDriver.aspx.cs" Inherits="Presentation.WFDriver" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server"><br/>

    <asp:Label ID="Label10" runat="server" Text="">ID</asp:Label><br/>
    <asp:Label ID="TBId" runat="server" Text=""></asp:Label><br/>
    <%--<asp:TextBox ID="TBId" runat="server"></asp:TextBox><br/>--%>

    <asp:Label ID="Label2" runat="server" Text="">Ingrese La Identificacion Del Conductor</asp:Label><br/>
    <asp:TextBox ID="TBIdentiConductor" runat="server"></asp:TextBox><br/>

    <asp:Label ID="Label3" runat="server" Text="">Ingrese El Numero De Licencia Del Conductor</asp:Label><br/>
    <asp:TextBox ID="TBNumLicenciaConductor" runat="server"></asp:TextBox><br/>

    <asp:Label ID="Label4" runat="server" Text="">Ingrese Nombre Del Conductor</asp:Label><br/>
    <asp:TextBox ID="TBNomConductor" runat="server"></asp:TextBox><br/>

    <asp:Label ID="Label5" runat="server" Text="">Ingrese Apellido Del Conductor</asp:Label><br/>
    <asp:TextBox ID="TBApellidoConductor" runat="server"></asp:TextBox><br/>

    <asp:Label ID="Label6" runat="server" Text="">Ingrese Telefono Del Conductor</asp:Label><br/>
    <asp:TextBox ID="TBTelefonoConductor" runat="server"></asp:TextBox><br/>

    <asp:Label ID="Label7" runat="server" Text="">Ingrese La Edad Del Conductor</asp:Label><br/>
    <asp:TextBox ID="TBEdadConductor" runat="server"></asp:TextBox><br/>

    <asp:Label ID="Label8" runat="server" Text="">Ingrese el Genero Del Conductor</asp:Label><br/>
    <asp:TextBox ID="TBGeneroConductor" runat="server"></asp:TextBox><br/>

    <asp:Label ID="Label9" runat="server" Text="">Ingrese El Tipo De Licencia</asp:Label><br/>
    <asp:TextBox ID="TBTipoLicencia" runat="server"></asp:TextBox><br/>

    <asp:Button ID="BtnGuardar" runat="server" CssClass="btn btn-success" Text="Guardar" OnClick="BtnGuardar_Click" />
    <asp:Button ID="BtnActualizar" runat="server" CssClass="btn btn-info" Text="Actualizar" OnClick="BtnActualizar_Click" /><br/>
    <asp:Label ID="LblMensaje" runat="server" Text=""></asp:Label><br/>

    <asp:Label ID="Label1" runat="server" Text="">Lista De Conductores</asp:Label><br/>
    <asp:GridView ID="GVDriver" runat="server" CssClass="table table-hover table-primary" OnSelectedIndexChanged="GVDriver_SelectedIndexChanged" DataKeyNames="id_cond" OnRowDeleting="GVDriver_RowDeleting" style="margin-right: 0px">
        <Columns>
            <asp:CommandField ShowSelectButton="True" />
            <asp:CommandField ShowDeleteButton="True" />
        </Columns>
    </asp:GridView><br/>
</asp:Content>
