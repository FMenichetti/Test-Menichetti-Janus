<%@ Page Title="" EnableEventValidation="false" Language="C#" MasterPageFile="~/MiMaster.Master" AutoEventWireup="true" CodeBehind="Administrador.aspx.cs" Inherits="Stock.Administrador" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


     <asp:GridView runat="server" id="Dgv" AutoGenerateColumns="false" class="table">
        <Columns>

            <asp:BoundField HeaderText="Id" DataField="Id" />

            <asp:BoundField HeaderText="Nombre" DataField="Nombre" />

            <asp:TemplateField HeaderText="Descripcion">
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

            <asp:TemplateField HeaderText="Seleccion">
            <ItemTemplate>
                <asp:Button runat="server" Text="Editar" OnClick="Unnamed_Click" />
            </ItemTemplate>
        </asp:TemplateField>

        </Columns>
    </asp:GridView>

</asp:Content>
