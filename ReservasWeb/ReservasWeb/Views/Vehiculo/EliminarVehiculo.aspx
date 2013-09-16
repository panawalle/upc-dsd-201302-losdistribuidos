<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<ReservasWeb.Models.Vehiculo>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	UPC - Los Distribuidos
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Eliminar Vehiculo</h2>

    <h3>Seguro que desea eliminar este vehículo?</h3>
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
        
    </fieldset>
    <% using (Html.BeginForm()) { %>
        <p>
		    <input type="submit" value="Eliminar" /> |
		    <%: Html.ActionLink("Regresar al Listado", "Index") %>
        </p>
    <% } %>

</asp:Content>

