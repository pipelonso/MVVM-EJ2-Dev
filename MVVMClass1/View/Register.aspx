<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="MVVMClass1.View.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="Bootstrap/Content/bootstrap.min.css" rel="stylesheet" />
    <link href="sweetAlert/Styles/sweetalert.css" rel="stylesheet" />
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="navbar p-2"> 
            <div class="nav-item col-sm-12 col-md-2 col-lg-3 col-12 "></div>
            <div class="nav-item p-2 col-sm-12 col-md-8 col-lg-6 col-12 regbox" id="regbox" style="position: relative;">
                <h1 class="text-center p-2 bg-dark text-white">Registro</h1>
                <asp:Label ID="lblCorreo" runat="server" Text="Correo" CssClass="w-100"></asp:Label>
                <asp:TextBox ID="txtCorreo" runat="server" CssClass="w-100 textboxes"></asp:TextBox>
                <asp:Label ID="lblNombre" runat="server" Text="Nombre" CssClass="w-100"></asp:Label>
                <asp:TextBox ID="txtNombres" runat="server" CssClass="w-100 textboxes"></asp:TextBox>
                <asp:Label ID="lblPass" runat="server" Text="Contraseña" CssClass="w-100"></asp:Label>
                <asp:TextBox ID="txtPass" runat="server" CssClass="w-100 textboxes" TextMode="Password"></asp:TextBox>
                <asp:Label ID="lblPassRP" runat="server" Text="Repetir Contraseña" CssClass="w-100"></asp:Label>
                <asp:TextBox ID="txtPassRP" runat="server" CssClass="w-100 textboxes" TextMode="Password"></asp:TextBox>
                <asp:Label ID="lblImagenUsuario" runat="server" Text="Imagen de usuario" CssClass="w-100"></asp:Label>
                <asp:FileUpload ID="FuImagen" runat="server" CssClass="w-100"/>
                <asp:Button ID="btnRegister" runat="server" Text="REGISTRARSE" CssClass="botones w-100 p-2 my-2" OnClick="btnRegister_Click"/>
            </div>
            <div class="nav-item col-sm-12 col-md-2 col-lg-3 col-12"></div>
        </div>
        <script src="Bootstrap/Scripts/bootstrap.min.js"></script>
        <link href="css/Register.css" rel="stylesheet" />
        <script src="js/Register.js"></script>
        <script src="sweetAlert/Scripts/sweetalert.min.js"></script>
        <script src="js/Alertas.js"></script>
    </form>
</body>
</html>
