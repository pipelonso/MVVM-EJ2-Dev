<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="MVVMClass1.View.Inicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="Bootstrap/Content/bootstrap.min.css" rel="stylesheet" />
    <link href="css/Inicio.css" rel="stylesheet" />
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="position: sticky; top : 0px; z-index : 99999; ">
            <div class="p-2 bg-dark navbar">
                <h1 class="text-center text-white nav-item">MVVM</h1>
                <div class="nav-item">
                    <p class="text-center text-white">Ejercicios</p>
                    <asp:Button ID="btnGotoAgenda" runat="server" Text="Ir a Agenda" CssClass="botones" OnClick="btnGotoAgenda_Click" />                    
                </div>
            </div>
            <div  id="progressbar" style="height: 1px; background-image: url('../Imagenes/MVVMBacks/ProgresBar.svg'); background-size: cover;"></div>
        </div>

        <div style="height: 60px; background-image: url('../Imagenes/MVVMBacks/bg_title.svg'); background-size: cover;" class="p-2">
            <h3 class="text-center text-white">Modelo vista VistaModelo</h3>
        </div>
        <div class="container-fluid navbar nav-justified">
            <div class="nav-item col-sm-12 col-md-7 col-lg-7 p-2 mx-1 text-white" style="background-image: url('../Imagenes/MVVMBacks/bg_title.svg'); background-size: cover;">
                <div class="text-white p-2 bg-dark">
                    <p>MVVM Es una arquitectura de software dedicada a mejorar la organización de proyectos en desarrollo de aplicaciones de telefono, para proyectos de AXML, MAUI o Web .NET Core entre algunos, pero se puede adaptar a cualquier proyecto de igual forma aunque no cumpla con todo al pie de la letra.</p>
                </div>
                <hr />
                <div class="text-white p-2 bg-dark">

                    <p>MVVM Se basa en la separación de la presentación de interfaces, de la logica de aplicación y la logica de negocios con el control de datos, esto ayuda a tener un control independiente de la interfaz y de control de datos por parte del servidor y conexión con el cliente de manera mas simple y reutilizable. Para hacer esto MVVM se divide en tres partes:</p>
                    <hr />
                    <ul>
                        <li>
                            <h4 style="background-image: url('../Imagenes/MVVMBacks/bg_title.svg'); background-size: cover;" class="p-2 borderlesanim">Vista</h4>
                            <p>
                                Aqui se aloja todo lo referente a interfaces y logica de interfaces, por ejemplo aqui se pueden guardar para desarrollo web con ASP .NET Framework archivos de Webforms, hojas de estilo, y archivos javascript de control de interfaces.
                            </p>
                        </li>
                        <li>
                            <h4 style="background-image: url('../Imagenes/MVVMBacks/bg_title.svg'); background-size: cover;" class="p-2 borderlesanim">VistaModelo</h4>
                            <p>
                                Este es el intermediario entre el Modelo y la Vista, este se usara para el traspaso y edición de datos brindando las clases y tratamiento de datos necesario para editar valores en la vista o preparar los valores para la vista.
                            </p>
                        </li>
                        <li>
                            <h4 style="background-image: url('../Imagenes/MVVMBacks/bg_title.svg'); background-size: cover;" class="p-2 borderlesanim">Modelo</h4>
                            <p>Este se encarga de la logica de negocio y el control de datos.</p>
                        </li>
                    </ul>

                </div>



            </div>
            <div class="nav-item col-sm-12 col-md-4 col-lg-4 my-2 justify-content-center mx-2 h-100" style="background-color: rgb(26,26,26);">
                <img src="../Imagenes/Info/MVVMEx.svg" alt="Alternate Text" style="height: 600px;" />
            </div>

        </div>

        <div class="p-2 bg-dark">

            <div class="botones p-2 my-2 text-center">
                <a href="https://github.com/pipelonso/MVVM_EJ2_Base" class="text-decoration-none" >Puedes visitar el repositorio de github de esta base desde aqui</a>
            </div>

            <div class="botones p-2 my-2 text-center">
                <a class="text-decoration-none " href="https://github.com/pipelonso/MVVM-EJ2-Dev">Puedes obtener la versión desarrollada desde aqui si presentas algun problema en tu desarrollo puedes usarla para basarte en su contenido</a>
            </div>

            <div class="botones my-2 text-center">                
                <a class="text-decoration-none " href="https://drive.google.com/drive/folders/1W_D6T73qaD4Rci6JUMLz68GJ0ZCSVEVe?usp=drive_link">Puedes acceder a los proyectos desde Google Drive con este enlace</a>
            </div>

        </div>


    </form>
    <script src="Bootstrap/Scripts/bootstrap.min.js"></script>
    <script src="js/Inicio.js"></script>
</body>
</html>
