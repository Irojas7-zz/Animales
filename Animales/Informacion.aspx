<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Informacion.aspx.cs" Inherits="Informacion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <!-- The above 3 meta tags *must* come first in the head; any other head content must come *after* these tags -->
    <title>Informacion</title>

    <!-- Bootstrap -->
    <link href="css/bootstrap.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="row">
            <div class="panel panel-default">
                <div class="panel-heading">
                    <div class="jumbotron">
                        <img src="http://res.cloudinary.com/spotlio/image/upload/ilafnc55bhqfasvbxq4x.jpg" alt="zoo" />
                    </div>
                </div>
            </div>

            <div class="panel panel-default col-sm-10 col-sm-offset-1">
                <div class="panel-heading">
                    <%--<img src="http://static.elobservador.com.uy/adjuntos/184/imagenes/000/316/0000316354.jpg" alt="animal" />--%>
                    <h2>PORTADA</h2>
                </div>
                <div class="panel-body">
                    <div class="col-md-4">
                        <%--<img src="http://ichef-1.bbci.co.uk/news/ws/624/amz/worldservice/live/assets/images/2015/08/02/150802155216_leon1_624x351_alamy_nocredit.jpg" alt="animaltwo" />--%>
                        <h2>IMAGEN ANIMAL</h2>
                    </div>
                    <div class="col-md-8">
                        <asp:DropDownList ID="ddlColor" runat="server">
                            <asp:ListItem Text="[Color]"></asp:ListItem>
                        </asp:DropDownList>
                        <br />
                        <asp:DropDownList ID="ddlTipo" runat="server">
                            <asp:ListItem Text="[Tipo]"></asp:ListItem>
                        </asp:DropDownList>
                        <br />
                        <asp:DropDownList ID="ddlGenero" runat="server">
                            <asp:ListItem Text="[Genero]"></asp:ListItem>
                        </asp:DropDownList>
                        <br />
                        <asp:TextBox runat="server" ID="txtNombre"></asp:TextBox>
                        <br />
                        <asp:TextBox runat="server" ID="txtExist"></asp:TextBox>
                        <br />
                        <asp:TextBox runat="server" ID="txtPeso"></asp:TextBox>
                        <br />
                        <asp:TextBox runat="server" ID="txtEdad"></asp:TextBox>
                    </div>
                </div>
                <div class="panel-footer">
                    <div class="col-sm-12">
                        <h2>VIDEO </h2>
                        <a href="#" id="lnkEditar">Editar </a>
                        <a href="#" id="lnkBorrar">Borrar </a>
                    </div>
                </div>
            </div>
        </div>
    </form>
    <script src="js/jquery-2.1.4.js"></script>
    <script src="js/bootstrap.js"></script>
</body>
</html>
