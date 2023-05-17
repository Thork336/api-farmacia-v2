<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="WFSend.aspx.cs" Inherits="Presentation.WFSend" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:TextBox ID="TBCodigo" runat="server"></asp:TextBox><br/>

    <asp:Label ID="Label5" runat="server" Text="">Ingrese El Id de Envio</asp:Label><br/>
    <asp:TextBox ID="TBIdSend" runat="server"></asp:TextBox><br/>

    <asp:Label ID="Label2" runat="server" Text="">Ingrese codigo de envio:</asp:Label><br/>
    <asp:TextBox ID="TBCodeSend" runat="server"></asp:TextBox><br/>

    <asp:Label ID="Label3" runat="server" Text="">Ingrese direccion del envio:</asp:Label><br/>
    <asp:TextBox ID="TBAddresSend" runat="server"></asp:TextBox><br/>

    <asp:Label ID="Label4" runat="server" Text="">Ingrese el telefono del envio:</asp:Label><br/>
    <asp:TextBox ID="TBPhoneSend" runat="server"></asp:TextBox><br/>

    <asp:Button ID="BtnGuardar" runat="server" Text="Guardar" OnClick="save"/>
    <asp:Button ID="BtnActualizar" runat="server" Text="Actualizar" OnClick="update"/><br/>
    <asp:Label ID="LblMensaje" runat="server" Text=""></asp:Label><br/>

    <asp:Label ID="Label1" runat="server" Text="">Lista de envios:</asp:Label><br/>
    <asp:GridView ID="GVSend" runat="server" OnSelectedIndexChanged="GVSend_SelectedIndexChanged">
        <Columns>
            <asp:CommandField ShowSelectButton="True" />
            <asp:CommandField ShowDeleteButton="True" />
        </Columns>
    </asp:GridView><br/>

</asp:Content>
