<%@ Page Title="" Language="C#" MasterPageFile="~/MiMaster.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Stock.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

        <!-- Header-->
        <header class="py-3">
            <div class="container px-lg-3">
                <div class="p-2 p-lg-3 bg-light rounded-3 text-center">
                    <div class="m-4 m-lg-5">
                        <h1 class="display-5 fw-bold">Store app!</h1>
                        <p class="fs-4">Estas en la web de manejo de stock del almacen.</p>

                    </div>
                </div>
            </div>
        </header>
        <!-- Page Content-->
        <section class="pt-4">
            <div class="container px-lg-5 ">
                <!-- Page Features-->
                <div class="row gx-lg-5">

                    <div class="col-lg-6 col-xxl-4 mb-5 ">
                        <div class="card btn btn-outline-secondary ">
                            <div class="card-body text-center p-4 p-lg-5 pt-0 pt-lg-0 " style="height:200px">
                                <h2 class="fs-4 fw-bold mt-3 ">Reporte</h2>
                                <p class="mb-0">Aqui encontraras el reporte de los productos existentes en el almacen, junto con su stock actual, precio y descripción.</p>
                                <asp:Button ID="ButtonReporte" runat="server" onclick="ButtonReporte_Click" class="btn btn-outline-dark m-3" Text="Ver reporte >>>" />
                                </div>
                        </div>
                    </div>

                    <div class="col-lg-6 col-xxl-4 mb-5 ">
                        <div class="card btn btn-outline-secondary">
                            <div class="card-body text-center p-4 p-lg-5 pt-0 pt-lg-0 " style="height:200px">
                                <h2 class="fs-4 fw-bold mt-3 ">Administrador</h2>
                                <p class="mb-0">Aquí podras ingresar nuevos productos, modificar el stock y eliminar los productos obsoletos</p>
                                <asp:Button ID="ButtonAdmin" runat="server" onclick="ButtonAdmin_Click" Text="Ingresar >>>" class="btn btn-outline-dark m-3"/>
                            </div>
                        </div>
                    </div>

                </div>
            </div>
        </section>
        <!-- Footer-->
        <footer class="py-5 bg-dark">
            <div class="container">
                <p class="m-0 text-center text-white">Copyright &copy; Your Website 2023</p>
            </div>
        </footer>
        <!-- Bootstrap core JS-->
        <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.2.3/dist/js/bootstrap.bundle.min.js"></script>
        <!-- Core theme JS-->
        <script src="js/scripts.js"></script>
  

</asp:Content>
