<%@ Page Title="" Language="C#" MasterPageFile="~/MiMaster.Master" AutoEventWireup="true" CodeBehind="Excepcion.aspx.cs" Inherits="Stock.Excepcion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <!-- Manejo de excepciones de ejecucion de acciones-->

     <br />
    <h4> Su pagina ha presentado un error.. </h4>
    <br />
    <asp:Label Text = ".." ID="lblError"  runat="server" />
    

</asp:Content>
