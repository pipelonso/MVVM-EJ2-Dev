<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Agenda.aspx.cs" Inherits="MVVMClass1.View.Agenda" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="css/Agenda.css" rel="stylesheet" />
    <link href="Bootstrap/Content/bootstrap.min.css" rel="stylesheet" />
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

        

        <div class="navbar p-2 bg-dark">
            <h3 class="nav-item text-white">Agenda</h3>
            <div class="nav-item text-white navbar" id="UserBox">
                <asp:Label ID="lblUserName" runat="server" Text="---" CssClass="nav-item"></asp:Label>
                <asp:ImageButton ID="UserPic" runat="server" ImageUrl="~/Imagenes/UserPicks/Default.jpg" Height="40px" CssClass="rounded-circle nav-item mx-2" />
            </div>
            <div id="SesionControls">
                <asp:Button ID="btnLogin" runat="server" Text="Iniciar Sesión" CssClass="botones" OnClick="btnLogin_Click" />
                <asp:Button ID="btnRegister" runat="server" Text="Registrarse" CssClass="botones" OnClick="btnRegister_Click" />
            </div>
        </div>

        
        

        <div id="contenido">

            <div id="DeletePanel" style="position: sticky; background-color: rgb(55, 0, 0); z-index: 2999999; top: 0px; border-bottom: double; border-bottom-color: black" class="w-100 p-2 text-white">
                <asp:Label ID="lblDeleteId" runat="server" Text="1" Visible="false"></asp:Label>
                <h2 class="text-center">CONFIRMAR ELIMINACIÓN</h2>
                <p class="text-center">¿Estas seguro de eliminar este registro?</p>
                <div class="navbar">
                    <asp:Button CssClass="nav-item botones col-5" ID="btnCancelDelete" runat="server" Text="Cancelar" />
                    <asp:Button CssClass="nav-item col-5 deletebtn" ID="btnConfirmDelete" runat="server" Text="Eliminar" OnClick="btnConfirmDelete_Click" />
                </div>

            </div>


            <div id="editPanel" style="position: sticky; background-color: rgb(34, 34, 34); z-index : 19999; top:0px; border-bottom : double; border-bottom-color : black" class ="w-100 p-2 text-white">
                <asp:Label ID="lblEditId" runat="server" Text="1" Visible="false" ></asp:Label>
                <h3>Editar</h3>                
                <p>Editar nota de la agenda</p>
                <asp:TextBox ID="txtNotaEdit" runat="server" TextMode="MultiLine" CssClass="w-100 cajas"></asp:TextBox>
                <p>Editar Fecha del Recordatorio / Nota</p>
                <asp:TextBox ID="txtFechaEdit" runat="server" TextMode="DateTimeLocal" CssClass="w-100 cajas"></asp:TextBox>
                <asp:Button ID="btnEditTask" runat="server" Text="Editar Nota" CssClass="w-100 my-2 cajas" OnClick="btnEditTask_Click" />
            </div>


            <div class="p-2" id="">
                <div class="navbar justify-content-start">

                    <div class="col-12 col-sm-12 col-md-2 col-lg-2 align-baseline nav-item moveslow">
                        <div class="navbar justify-content-start bg-secondary rounded-2 p-2" id="btnShowAddTaks">
                            <img src="../Imagenes/UI/plus-circle-fill.svg" alt="+" class="p-2 bg-dark nav-item text-white rounded-2" style="height: 40px;" />
                            <h3 class="nav-item p-2">Agregar</h3>
                        </div>
                    </div>

                    <div id="addPanel" class="nav-item col-12 col-sm-12 col-md-9 col-lg-9 p-2 moveslow ">
                        <div class="p-2 moveslow addbox rounded-3" id="wexpand">
                            <p class="text-white">Agregar una nota a la agenda</p>
                            <asp:TextBox ID="txtNota" runat="server" TextMode="MultiLine" CssClass="w-100 cajas"></asp:TextBox>
                            <p class="text-white">Selecciona la fecha de recordatorio</p>
                            <asp:TextBox ID="txtFecha" runat="server" TextMode="DateTimeLocal" CssClass="w-100 cajas"></asp:TextBox>
                            <asp:Button ID="btnAddTask" runat="server" Text="Añadir Nota" CssClass="w-100 my-2 cajas" OnClick="btnAddTask_Click" />
                        </div>
                    </div>

                    

                    <asp:Repeater ID="RpRecordatorio" runat="server">
                        <ItemTemplate>

                            <div class=" bg-dark text-white rounded-3 my-2 w-100">
                                <div class="navbar">

                                    <div class="nav-item p-2 col-sm-12 col-12 col-md-10 col-lg-10">
                                        <asp:Label ID="lblidRecordatorioRP" runat="server" Text='<%# Eval("IdRecordatorio") %>' Visible="false"></asp:Label>
                                        <div>
                                            <asp:Label ID="lblRecordatorioRP" runat="server" Text='<%# Eval("Recordatorio") %>' Font-Size="22px"></asp:Label>                                            
                                        </div>                                        
                                        <div>
                                            <asp:Label ID="lblFechaRP" runat="server" Text='<%# Eval("Fecha")%>'></asp:Label>
                                            
                                        </div>
                                    </div>
                                    <div class="nav-item navbar align-self-baseline col-12 col-sm-12 col-md-2 col-lg-2 justify-content-end" style="position: relative; top : -16px;">

                                        <asp:LinkButton CssClass="nav-item editb p-2 roundleft" ID="lkbEdit" runat="server" OnClick="lkbEdit_Click">
                                        <div>
                                            <img src="../Imagenes/UI/EditBtn.svg" alt="Pemcil_icon" style="height : 40px;"/>
                                        </div>
                                        </asp:LinkButton>
                                        <asp:LinkButton CssClass="nav-item deleteb p-2 rounderight" ID="lkbDelete" runat="server" OnClick="lkbDelete_Click">
                                        <div>
                                            <img src="../Imagenes/UI/DeleteBtn.svg" alt="Trash_icon" style="height : 40px;"/>
                                        </div>
                                        </asp:LinkButton>
                                    </div>
                                </div>




                            </div>

                        </ItemTemplate>
                    </asp:Repeater>


                </div>

            </div>

        </div>

        <script src="js/Agenda.js"></script>
        <script src="Bootstrap/Scripts/bootstrap.min.js"></script>
    </form>
</body>
</html>
