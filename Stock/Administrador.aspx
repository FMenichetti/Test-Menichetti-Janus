﻿<%@ Page Title="" EnableEventValidation="false" Language="C#" MasterPageFile="~/MiMaster.Master" AutoEventWireup="true" CodeBehind="Administrador.aspx.cs" Inherits="Stock.Administrador" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <asp:GridView runat="server" ID="Dgv" AutoGenerateColumns="false" class="table">
        <Columns>

            <asp:BoundField HeaderText="Codigo de producto" DataField="Id" />

            <asp:BoundField HeaderText="Nombre" DataField="Nombre" />

            <asp:TemplateField HeaderText="Clasificacion">
                <ItemTemplate>
                    <%# Eval("oTipo.Descripcion") %>
                </ItemTemplate>
            </asp:TemplateField>

            <asp:BoundField HeaderText="Precio" DataField="Precio" />

            <asp:TemplateField HeaderText="Cantidad">
                <ItemTemplate>
                    <%# Eval("oStock.Cantidad") %>
                </ItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField HeaderText="Modificar">
                <ItemTemplate>
                    <asp:Button runat="server" Text="Editar Producto" OnClick="Unnamed_Click" Class="btn btn-outline-dark" />
                </ItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField HeaderText="Eliminar">
                <ItemTemplate>
                    <asp:Button runat="server" ID="btnEliminar" Text="Eliminar" OnClick="btnEliminar_Click" Class="btn btn-outline-dark" />

                </ItemTemplate>
            </asp:TemplateField>

        </Columns>
    </asp:GridView>

    <asp:Button ID="btnNuevo" runat="server" Text="Nuevo Producto" Class="btn btn-primary" OnClick="btnNuevo_Click" />

    <%if (modificar)
        {%>
    <div>

        <asp:Label ID="Label1" runat="server" Text="Confirme eliminación"></asp:Label>
        <asp:Button ID="btnConfirmar" runat="server" Text="Eliminar" Class="btn btn-danger" OnClick="btnConfirmar_Click" />
        <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" Class="btn btn-outline-danger" OnClick="btnCancelar_Click" />
    </div>
    <%}; %>
</asp:Content>


