<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="WFUser.aspx.cs" Inherits="Presentation.WFUser" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="resource/css/bootstrap.min.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <h1><a class="nav-link disabled" href="#">FARMACÉUTICA</a></h1>

    </div>

    <main>
        <section>
            <nav class="navbar navbar-expand-lg bg-primary">
                <div class="container-fluid">

                    <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
                        <span class="navbar-toggler-icon"></span>
                    </button>
                    <div class="collapse navbar-collapse" id="navbarSupportedContent">
                        <ul class="navbar-nav me-auto mb-2 mb-lg-0">
                            <li class="nav-item"><a class="nav-link active" aria-current="page" href="Index.aspx">Inicio</a></li>
                            <li class="nav-item"><a class="nav-link" href="WFUser.aspx">Usuarios</a></li>
                            <li class="nav-item"><a class="nav-link" href="WFVehicle.aspx">Vehiculos</a></li>
                            <li class="nav-item"><a class="nav-link" href="WFDriver.aspx">Conductor</a></li>
                            <li class="nav-item"><a class="nav-link" href="WFUsers.aspx">Usuarios</a></li>
                        </ul>
                    </div>
                </div>
            </nav>
            <div class="container-fluid">
                <div class="row">
                    <div class="col-12">
                        <div>
                            <br />
                            <asp:Label ID="Label1" runat="server" Text="Label">Crear Usuarios</asp:Label>
                            <asp:Label ID="TBId" runat="server" Visible="false"></asp:Label>
                            <br />
                            <br />
                            <asp:TextBox ID="TBEmail" placeholder="Correo electrónico" runat="server" CssClass="form-control" aria-label="Sizing example input" aria-describedby="inputGroup-sizing-default"></asp:TextBox>
                            <br />
                            <asp:TextBox ID="TBPassword" placeholder="Contraseña" runat="server" CssClass="form-control" aria-label="Sizing example input" aria-describedby="inputGroup-sizing-default"></asp:TextBox>
                            <br />
                            <!--<asp:Label ID="TBSalt111" runat="server" Text="Elige el tipo usuario"></asp:Label>-->
                            <asp:TextBox ID="TBSalt" placeholder="Salt" runat="server"></asp:TextBox>
                            <br />

                            <!--<div class="dropdown">
                                <button class="btn btn-secondary dropdown-toggle" type="button" data-bs-toggle="dropdown" aria-expanded="false">
                                    Estado del usuario
                                </button>
                                <ul class="dropdown-menu" id="TBState">
                                    <li><button class="dropdown-item" type="button" value="0">Seleccione</button></li>
                                    <li><button class="dropdown-item" type="button" value="Activo">Activo</button></li>
                                    <li><button class="dropdown-item" type="button" value="Inactivo">Inactivo</button></li>
                                </ul>
                            </div>-->
                            <asp:DropDownList ID="TBState" runat="server" CssClass="btn btn-secondary dropdown-toggle" data-bs-toggle="dropdown" aria-expanded="false">
                                <asp:ListItem Value="0">Seleccione</asp:ListItem>
                                <asp:ListItem Value="Activo">Activo</asp:ListItem>
                                <asp:ListItem Value="Inactivo">Inactivo</asp:ListItem>
                            </asp:DropDownList>

                            <br />
                            <br />
                            <asp:Label ID="LblMsj2" runat="server" Text=" "></asp:Label>
                            <asp:Label ID="LblMsj" runat="server" Text=" "></asp:Label>
                            <br />
                            <asp:Button ID="BtnClear" runat="server" Text="Limpiar Cajas" OnClick="BtnClear_Click" CssClass="btn btn-primary"/>
                            <br />
                            <asp:Button ID="BtnSave" runat="server" Text="Crear Usuario" OnClick="BtnSave_Click" CssClass="btn btn-primary"/>
                            <br />
                            <asp:Button ID="BtnUpdate" runat="server" Text="Actualizar Usuario" OnClick="BtnUpdate_Click" CssClass="btn btn-primary"/>

                            <asp:GridView ID="GVUser" runat="server"
                                OnSelectedIndexChanged="GVUser_SelectedIndexChanged" DataKeyNames="id_us"
                                OnRowDeleting="GVUser_RowDeleting" CssClass="container text-center">
                                <Columns>
                                    <asp:CommandField ShowSelectButton="True" />
                                    <asp:CommandField ShowDeleteButton="True" />
                                </Columns>
                            </asp:GridView>
                        </div>
                    </div>
                </div>
            </div>
        </section>
    </main>

</asp:Content>
