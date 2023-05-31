<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="WFVehicle.aspx.cs" Inherits="Presentation.WFVehicle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="resource/css/bootstrap.min.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>

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
                            <h2><asp:Label ID="Label1" runat="server" Text="Label">Vehiculos</asp:Label></h2>
                            <asp:Label ID="TBId" runat="server" Visible="false"></asp:Label>
                            <br />
                            <br />
                            <asp:Label ID="Label2" runat="server" Text="Placa del vehiculo"></asp:Label>
                            <br />
                            <asp:TextBox ID="TBPlaca" placeholder="Ej. MRX221" runat="server" CssClass="form-control" aria-label="Sizing example input" aria-describedby="inputGroup-sizing-default"></asp:TextBox>
                            <br />
                            <asp:Label ID="Label3" runat="server" Text="Modelo del vehiculo" ></asp:Label>
                            <br />
                            <asp:TextBox ID="TBModelo" placeholder="Ej. 2023" runat="server" CssClass="form-control" aria-label="Sizing example input" aria-describedby="inputGroup-sizing-default"></asp:TextBox>
                            <br />
                            <asp:Label ID="Label4" runat="server" Text="Tipo de Vehiculo"></asp:Label>
                            <br />
                            <asp:TextBox ID="TBTipo" placeholder="Ej. Carro, Moto" runat="server" CssClass="form-control" aria-label="Sizing example input" aria-describedby="inputGroup-sizing-default"></asp:TextBox>
                            <br />
                            <asp:Label ID="Label5" runat="server" Text="Capacidad de Carga (KG)"></asp:Label>
                            <br />
                            <asp:TextBox ID="TBCapacidad" placeholder="Ej. 500" runat="server" CssClass="form-control" aria-label="Sizing example input" aria-describedby="inputGroup-sizing-default"></asp:TextBox>
                            <br />
                            <asp:Label ID="Label6" runat="server" Text="Conductor encargado"></asp:Label>
                            <br />
                            <asp:DropDownList ID="DDLDriver" runat="server" CssClass="btn btn-secondary dropdown-toggle" data-bs-toggle="dropdown" aria-expanded="false">
                            </asp:DropDownList>
                            <br />
                            <br />
                            <asp:Label ID="LblMsj" runat="server" Text=" "></asp:Label>
                            <br />
                            <asp:Button ID="BtbClear" runat="server" Text="Limpiar casillas" OnClick="BtbClear_Click" CssClass="btn btn-primary"/>
                            <br />
                            <asp:Button ID="BtnSave" runat="server" Text="Crear Vehiculo" OnClick="BtnSave_Click" CssClass="btn btn-primary"/>
                            <br />
                            <asp:Button ID="BtnUpdate" runat="server" Text="Actualizar Vehiculo" OnClick="BtnUpdate_Click" CssClass="btn btn-primary"/>
                            <asp:GridView ID="GVVehicle" runat="server"
                                OnSelectedIndexChanged="GVVehicle_SelectedIndexChanged" DataKeyNames="id_vehiculo_veh"
                                OnRowDeleting="GVVehicle_RowDeleting" CssClass="container text-center">
                                <Columns>
                                    <asp:CommandField ShowSelectButton="True" />
                                    <asp:CommandField ShowDeleteButton="True" />
                                </Columns>

                            </asp:GridView>
                        </div>
                    </div>
                </div>
            </section>
        </main>



    </div>
</asp:Content>
