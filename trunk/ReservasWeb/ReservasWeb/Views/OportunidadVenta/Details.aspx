<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<ReservasWeb.Models.OportunidadVenta>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Detalle del Servicio
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>DETALLE DEL SERVICIO</h2>

    <fieldset>
        <legend>Datos del Servicio</legend>
        
        <div class="display-label">COD SERVICIO</div>
        <div class="display-field"><%: Model.codServicio %></div>
        
        <div class="display-label">NOMBRE SERVICIO</div>
        <div class="display-field"><%: Model.nombreServicio %></div>
        
        <div class="display-label">CANTIDAD SERVICIO</div>
        <div class="display-field"><%: Model.cantidadServicio %></div>
        
        <div class="display-label">PRECIO SERVICIO</div>
        <div class="display-field"><%: Model.precioServicio %></div>
        
    </fieldset>
    <p>
        <%: Html.ActionLink("Editar Servicio", "Edit", new { /* id=Model.PrimaryKey */ }) %> |
        <%: Html.ActionLink("Regresar al listado", "Index") %>
    </p>

</asp:Content>

