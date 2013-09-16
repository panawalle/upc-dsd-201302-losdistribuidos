<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<ReservasWeb.Models.Vehiculo>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	UPC - Los Distribuidos
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Detalle de Vehículo</h2>

    <fieldset>
        <legend>Campos</legend>
        
        <div class="display-label">placa</div>
        <div class="display-field"><%: Model.placa %></div>
        
        <div class="display-label">vin</div>
        <div class="display-field"><%: Model.vin %></div>
        
        <div class="display-label">anio</div>
        <div class="display-field"><%: Model.anio %></div>
        
        <div class="display-label">motor</div>
        <div class="display-field"><%: Model.motor %></div>
        
        <div class="display-label">contacto</div>
        <div class="display-field"><%: Model.contacto %></div>
        
        <div class="display-label">usuario</div>
        <div class="display-field"><%: Model.usuario %></div>
        
        <div class="display-label">fecha</div>
        <div class="display-field"><%: Model.fecha %></div>

        <div class="display-label">Color</div>
        <div class="display-field"><%: Model.color.descripcion %></div>

        <div class="display-label">Modelo</div>
        <div class="display-field"><%: Model.modelo.descripcion %></div>

        <div class="display-label">Cliente</div>
        <div class="display-field"><%: Model.cliente.apellidocliente %>, <%: Model.cliente.nombrecliente %></div>
        
    </fieldset>
    <p>
        <%: Html.ActionLink("Editar", "Edit", new { placa=Model.placa }) %> |
        <%: Html.ActionLink("Regresar al Listado", "Index") %>
    </p>

</asp:Content>

