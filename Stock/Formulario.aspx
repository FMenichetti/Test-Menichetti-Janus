<%@ Page Title="" Language="C#" MasterPageFile="~/MiMaster.Master" AutoEventWireup="true" CodeBehind="Formulario.aspx.cs" Inherits="Stock.Formulario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="row">
        <div class="col-5 m-3">


            <div class="mb-3">
                <label for="exampleInputEmail1" class="form-label">Nombre del producto</label>
                <asp:TextBox ID="txt_nombre" Class="form-control" runat="server"></asp:TextBox>
            </div>

            <div class="mb-3">
                <asp:Label ID="Label2" runat="server" Text="Selección del tipo de producto"></asp:Label>
                <asp:DropDownList ID="ddl_Tipo" Class="form-control" runat="server"></asp:DropDownList>
            </div>

            <div class="mb-3 ">
                <asp:Label ID="Label1" runat="server" Text="Precio"></asp:Label>
                <asp:TextBox ID="txt_precio" Class="form-control" runat="server"></asp:TextBox>
                 <asp:RegularExpressionValidator ErrorMessage="***Numeros enteros o decimales con coma solamente***" ControlToValidate="txt_precio" runat="server" ValidationExpression="^$|^(0|\d+(,\d+)?)$" />
            </div>

            <div class="mb-3 ">
                <asp:Label ID="Label3" runat="server" Text="Cantidad"></asp:Label>
                <asp:TextBox ID="Txt_cantidad" Class="form-control" runat="server" TextMode="Number"></asp:TextBox>
            </div>

            <!-- Condicion de botones a mostrar, segun la accion que quiero realizar-->

            <%if (modificar == true)
                { %>

            <asp:Button ID="btnModificar" runat="server" Text="Aceptar modificación" class="btn btn-outline-primary" OnClick="btnModificar_Click" />

            <%}
                else
                { %>
            <asp:Button ID="btnNuevo" runat="server" Text="Crear Producto" class="btn btn-outline-primary" OnClick="btnNuevo_Click" />
            <%} %>
        </div>
    </div>


</asp:Content>
