<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<ReservasWeb.Models.Oportunidad>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Eliminar SERVICIO
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>ELIMINAR SERVICIO</h2>

    <fieldset>
        <legend>Datos del Servicio</legend>
        
        <div class="display-label">COD. SERVICO</div>
        <div class="display-field"><%: Model.codServicio %></div>
        
        <div class="display-label">NOMBRES SERVICIO</div>
        <div class="display-field"><%: Model.nombreServicio %></div>
        
        <div class="display-label">CANTIDAD SERVICIO</div>
        <div class="display-field"><%: Model.cantidadServicio %></div>
        
        <div class="display-label">PRECIO SERVICIO</div>
        <div class="display-field"><%: Model.precioServicio %></div>
        
        <div class="display-label">ValidateRequest</div>
        <div class="display-field"><%: Model.ValidateRequest %></div>
        
    </fieldset>
    <% using (Html.BeginForm()) { %>
        <p>
		    <input type="submit" value="Eliminar" /> |
		    <%: Html.ActionLink("Regresar al listado", "Index") %>
        </p>
    <% } %>

</asp:Content>

