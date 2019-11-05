<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="PFAseguramientoCS.Inicio" %>

<!DOCTYPE html>

<head runat="server">
    <!--- Basic Page Needs
   ================================================== -->
    <meta charset="utf-8" />
    <meta name="description" content="" />
    <meta name="author" content="" />

    <!-- Mobile Specific Metas
   ================================================== -->
    <meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1" />

    <!-- CSS
    ================================================== -->
    <link rel="stylesheet" href="css/default.css" />
    <link rel="stylesheet" href="css/layout.css" />
    <link rel="stylesheet" href="css/media-queries.css" />

    <!-- Script
   ================================================== -->
    <script src="js/modernizr.js"></script>

    <!-- Favicons
	================================================== -->
    <link rel="shortcut icon" href="favicon.png" />
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />

    <title>Inatec Solution</title>

</head>
<body>


    <form id="form1" runat="server">
        <div>




            <header id="" class="row">
                <div style="margin-left: 50px">
                    <a href="Index.aspx">
                        <img src="images/logo.png" />
                    </a>
                </div>
                <nav id="nav-wrap">
                    <a class="menu-btn" href="#nav-wrap" title="Show navigation">Show navigation</a>
                    <a class="menu-btn" href="#" title="Hide navigation">Hide navigation</a>
                    <ul id="nav" class="nav">
                        <li class="current"><a class="smoothscroll" href="Index.aspx">Inicio</a></li>
                        <%--<li><a class="smoothscroll" href="#about">Sobre Nosotros</a></li>
                        <li><a class="smoothscroll" href="#location">Contactanos</a></li>--%>
                    </ul>
                </nav>

            </header>

            <br />
            <br />

            <section style="margin-left: 50px" id="">
                <div class="contacts">
                    <div class="row contact-details">
                        <div class="columns">
                            <h3>Encriptar/Descencriptar.</h3>
                            <p>
                                <asp:TextBox Width="400px" ID="TxtIngresar" runat="server"></asp:TextBox>

                                <footer>
                                    <div class="">
                                        <div class="">
                                            <ul style="margin-left:-550px" class="copyright">
                                                <li><asp:RadioButton GroupName="RButton1" ID="Rb_Encriptar" runat="server" Text="" /></li>
                                                <li>Encriptar</li>                                                
                                            </ul>
                                        </div>
                                    </div>
                                </footer>

                                <footer>
                                    <div class="">
                                        <div class="">
                                            <ul style="margin-left:-525px" class="copyright">
                                                <li><asp:RadioButton GroupName="RButton1" ID="Rb_Desencriptar" runat="server" Text=""/></li>
                                                <li>Desencriptar</li>                                                
                                            </ul>
                                        </div>
                                    </div>
                                </footer>
                                
                                
                                <asp:Button Width="400px" OnClick="Desencriptar_Click" ID="Desencriptar" runat="server" Text="Procesar" />
                                <asp:TextBox Width="400px" ID="TxtSalida" runat="server"></asp:TextBox>
                            </p>
                        </div>
                    </div>
                </div>
            </section>

            <footer>
                <div class="row">
                    <div class="twelve columns">
                        <ul class="copyright">
                            <li>&copy; Copyright 2019 INATEC SOLUTION</li>
                            <li>Diseño <a title="Styleshout" href="Index.aspx">Inatec Solution</a></li>
                        </ul>
                    </div>
                </div>
                <div id="go-top"><a class="smoothscroll" title="Back to Top" href="#intro"><i class="icon-up-open"></i></a></div>
            </footer>

            <script src="http://ajax.googleapis.com/ajax/libs/jquery/1.10.2/jquery.min.js"></script>
            <script>window.jQuery || document.write('<script src="js/jquery-1.10.2.min.js"><\/script>')</script>
            <script type="text/javascript" src="js/jquery-migrate-1.2.1.min.js"></script>

            <script src="http://maps.google.com/maps/api/js?sensor=true" type="text/javascript"></script>
            <script src="js/gmaps.js"></script>
            <script src="js/waypoints.js"></script>
            <script src="js/jquery.countdown.js"></script>
            <script src="js/jquery.placeholder.js"></script>
            <script src="js/backstretch.js"></script>
            <script src="js/init.js"></script>

        </div>
    </form>
</body>
</html>

