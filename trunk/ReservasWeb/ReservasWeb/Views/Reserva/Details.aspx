<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<ReservasWeb.Models.Reserva>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Details
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Detalles</h2>

    <fieldset>
        <legend>Campos de Reserva: </legend>
        
        <div class="display-label"><b>Código :</b></div>
        <div class="display-field"><%: Model.codigo %></div>
        
        <div class="display-label"><b>Nro. Reserva :</b></div>
        <div class="display-field"><%: Model.nroreserva %></div>
        
        <div class="display-label"><b>Fecha :</b></div>
        <div class="display-field"><%: String.Format("{0:d}", Model.fecha) %></div>
        
        <div class="display-label"><b>Asesor :</b></div>
        <div class="display-field"><%: Model.asesor.codigo %> - <%: Model.asesor.nombre %></div>
        
        <div class="display-label"><b>Placa - Cliente :</b></div>
        <div class="display-field"><%: Model.vehiculo.placa %> - <%: Model.vehiculo.cliente.nombrecliente %> <%: Model.vehiculo.cliente.apellidopaterno %></div>

        <div class="display-label"><b>Marca - Modelo - Color :</b></div>
        <div class="display-field"><%: Model.vehiculo.modelo.marca.descripcion%> - <%: Model.vehiculo.modelo.descripcion%> <%: Model.vehiculo.color.descripcion %></div>
        
    </fieldset>
    <p>
        <%: Html.ActionLink("Volver a Listado", "Index") %>
    </p>

</asp:Content>

