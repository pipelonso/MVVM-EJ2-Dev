<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="MVVMClass1.View.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="css/Login.css" rel="stylesheet" />
    <link href="Bootstrap/Content/bootstrap.min.css" rel="stylesheet" />
    <link href="sweetAlert/Styles/sweetalert.css" rel="stylesheet" />
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <div class="navbar p-2"> 
            <div class="nav-item col-sm-12 col-md-2 col-lg-3 col-12 "></div>
            <div class="nav-item p-2 col-sm-12 col-md-8 col-lg-6 col-12 regbox" id="loginbox" style="position: relative;">
                <h1 class="text-center p-2 bg-dark text-white">Registro</h1>
                <asp:Label ID="lblCorreo" runat="server" Text="Correo" CssClass="w-100"></asp:Label>
                <asp:TextBox ID="txtCorreo" runat="server" CssClass="w-100 textboxes"></asp:TextBox>
                <asp:Label ID="lblPass" runat="server" Text="Contraseña" CssClass="w-100"></asp:Label>
                <asp:TextBox ID="txtPass" runat="server" CssClass="w-100 textboxes" TextMode="Password"></asp:TextBox>                
                <asp:Button ID="btnLogin" runat="server" Text="INICIAR SESIÓN" CssClass="botones w-100 p-2 my-2" OnClick="btnLogin_Click"/>
            </div>
            <div class="nav-item col-sm-12 col-md-2 col-lg-3 col-12"></div>

        </div>
        </div>
        <script src="Bootstrap/Scripts/bootstrap.min.js"></script>
        <script src="js/Login.js"></script>
        <script src="js/Alertas.js"></script>
        <script src="sweetAlert/Scripts/sweetalert.min.js"></script>
    </form>
</body>
</html>
