<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistroAutos.aspx.cs" Inherits="WebPresentacion.RegistroAutos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Registro Autos</title>

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
            <a class="nav-item nav-link" href="RegistroAutos.aspx">Registro Autos</a>
            <a class="nav-item nav-link" href="RegistroClientes.aspx">Registro Clientes</a>
            </div>
           </div>
            </nav>
        </div>

         <!--Formularios-->
        <div class="form-group" style="width:700px; margin-left:400px; margin-top:50px;">
        <asp:Label ID="Label2" runat="server" Text="Marca:"></asp:Label>
        <asp:DropDownList ID="dlF_marca" runat="server" style="width:700px; height:35px;"></asp:DropDownList>
        <asp:Label ID="Label3" runat="server" Text="Modelo:"></asp:Label>
        <asp:TextBox ID="txtModelo" runat="server" class="form-control"></asp:TextBox>
        <asp:Label ID="Label4" runat="server" Text="Año:"></asp:Label>
        <asp:TextBox ID="txtAño" runat="server" class="form-control"></asp:TextBox>
        <asp:Label ID="Label5" runat="server" Text="Color:"></asp:Label>
        <asp:TextBox ID="txtcolor" runat="server" class="form-control"></asp:TextBox>
        <asp:Label ID="Label6" runat="server" Text="Placas:"></asp:Label>
        <asp:TextBox ID="txtPlacas" runat="server" class="form-control"></asp:TextBox>
        <asp:Label ID="Label7" runat="server" Text="Dueño"></asp:Label>
        <asp:DropDownList ID="dlDueño" runat="server" style="width:700px; height:35px;"></asp:DropDownList>
        </div>
        <br />
        <div style="margin-left:400px;">
        <asp:Button ID="Button1" runat="server" class="btn btn-primary" Text="Registrar"/>
        <asp:Button ID="Button2" runat="server" class="btn btn-primary" Text="Mostrar dueños"/>
        </div>
    </form>
</body>
</html>
