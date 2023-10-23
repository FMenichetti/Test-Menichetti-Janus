<%@ Page Title="" Language="C#" MasterPageFile="~/MiMaster.Master" AutoEventWireup="true" CodeBehind="Formulario.aspx.cs" Inherits="Stock.Formulario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">



    <div class="mb-3">
        <label for="exampleInputEmail1" class="form-label">Nombre del producto</label>
        <asp:TextBox ID="txt_nombre" runat="server"></asp:TextBox>
    </div>
    <div class="mb-3">
        <asp:Label ID="Label2" runat="server" Text="Selección del tipo de producto"></asp:Label>
        <asp:DropDownList ID="ddl_Tipo" runat="server"></asp:DropDownList>
    </div>
    <div class="mb-3 ">
        <asp:Label ID="Label1" runat="server" Text="Precio"></asp:Label>
        <asp:TextBox ID="txt_precio" runat="server" TextMode="Number"></asp:TextBox>
    </div>

</asp:Content>
