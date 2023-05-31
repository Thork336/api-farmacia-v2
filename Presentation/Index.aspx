<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Presentation.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Inicio</title>
    <link href="resource/css/bootstrap.min.css" rel="stylesheet" />
</head>

<body>
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
                            <li class="nav-item"><a class="nav-link" href="WFUsers.aspx">Usuarios2</a></li>
                        </ul>
                    </div>
                </div>
            </nav>
            <div class="container-fluid">
                <div class="row">
                    <div class="col-12">
                        <div id="carouselExampleIndicators" class="carousel slide" data-bs-ride="true">
                            <div class="carousel-indicators">
                                <button type="button" data-bs-target="#carouselExampleIndicators" data-bs-slide-to="0" class="active" aria-current="true" aria-label="Slide 1"></button>
                                <button type="button" data-bs-target="#carouselExampleIndicators" data-bs-slide-to="1" aria-label="Slide 2"></button>
                                <button type="button" data-bs-target="#carouselExampleIndicators" data-bs-slide-to="2" aria-label="Slide 3"></button>
                            </div>
                            <div class="carousel-inner">
                                <div class="carousel-item active">
                                    <img src="resource/image/8d13db43aefc568f8305afe804b72bc0.jpeg" class="d-block w-100" alt=""/>
                                </div>
                                <div class="carousel-item">
                                    <img src="resource/image/8d13db43aefc568f8305afe804b72bc0.jpeg" class="d-block w-100" alt=""/>
                                </div>
                                <div class="carousel-item">
                                    <img src="resource/image/8d13db43aefc568f8305afe804b72bc0.jpeg" class="d-block w-100" alt=""/>
                                </div>
                            </div>
                            <button class="carousel-control-prev" type="button" data-bs-target="#carouselExampleIndicators" data-bs-slide="prev">
                                <span class="carousel-control-prev-icon" aria-hidden="true"></span>
                                <span class="visually-hidden">Previous</span>
                            </button>
                            <button class="carousel-control-next" type="button" data-bs-target="#carouselExampleIndicators" data-bs-slide="next">
                                <span class="carousel-control-next-icon" aria-hidden="true"></span>
                                <span class="visually-hidden">Next</span>
                            </button>
                        </div>
                    </div>
                </div>
            </div>
        </section>
    </main>
</body>
</html>
