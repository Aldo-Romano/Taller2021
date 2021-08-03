<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistroClientes.aspx.cs" Inherits="WebPresentacion.RegistroClientes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Registro Clientes</title>

    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet"/>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/js/bootstrap.bundle.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.9.2/dist/umd/popper.min.js""></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/js/bootstrap.min.js"></script>

</head>
<body>
    <form id="form1" runat="server">
         <!--Nav-->
        <div>
            <nav class="navbar navbar-light" style="background-color: #e3f2fd;">
            <a class="navbar-brand" href="#">
            <img src="IMG/icono.png" width="30" height="30" class="d-inline-block align-top" alt=""/>
            Taller2021
            </a>
            <div class="collapse navbar-collapse" id="navbarNavAltMarkup">
            <div class="navbar-nav">
            <a class="nav-item nav-link" href="RegistroClientes.aspx">Registro Clientes</a>
            </div>
           </div>
            </nav>
        </div>

         <!--Formularios-->
        <div class="form-group" style="width:700px; margin-left:400px; margin-top:50px;">
        <asp:Label ID="Label2" runat="server" Text="Nombre:"></asp:Label>
        <asp:TextBox ID="txtNombre" runat="server" class="form-control"></asp:TextBox>
        <asp:Label ID="Label3" runat="server" Text="Apellido paterno:"></asp:Label>
        <asp:TextBox ID="txtApp" runat="server" class="form-control"></asp:TextBox>
        <asp:Label ID="Label4" runat="server" Text="Apellido materno:"></asp:Label>
        <asp:TextBox ID="txtApm" runat="server" class="form-control"></asp:TextBox>
        <asp:Label ID="Label5" runat="server" Text="Celular:"></asp:Label>
        <asp:TextBox ID="txtcelular" runat="server" class="form-control"></asp:TextBox>
        <asp:Label ID="Label6" runat="server" Text="Teléfono de oficina:"></asp:Label>
        <asp:TextBox ID="txtTelOficina" runat="server" class="form-control"></asp:TextBox>
        <asp:Label ID="Label7" runat="server" Text="Correo personal:"></asp:Label>
        <asp:TextBox ID="txtCorreoPer" runat="server" class="form-control"></asp:TextBox>
        <asp:Label ID="Label8" runat="server" Text="Correo corporativo:"></asp:Label>
        <asp:TextBox ID="txtCorreoCorp" runat="server" class="form-control"></asp:TextBox>
        </div>
        <br />
        <div style="margin-left:400px;">
        <asp:Button ID="Button1" runat="server" class="btn btn-primary" Text="Registrar"/>
        <asp:Button ID="Button2" runat="server" class="btn btn-primary" Text="Mostrar clientes"/>
        </div>
    </form>
</body>
</html>
