<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Presentation.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Inicio</title>
    <link href="resource/css/bootstrap.min.css" rel="stylesheet" />
</head>

<body>
        <div>
            <h1><a class="nav-link disabled" href="#">FARMACÉUTICA</a></h1>
            
        </div>

        <main>
            <section>
                <nav class="navbar navbar-expand-lg bg-light">
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
                            Aqui va el contenido
                        </div>
                    </div>
                </div>
            </section>
        </main>
</body>
</html>
